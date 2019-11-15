using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace TMS
{
    public class DAL
    {
        private string connectionString = Properties.Settings.Default.ConnectionString;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader rdr;

        public DAL()
        {
            conn = new MySqlConnection(connectionString);
            cmd = new MySqlCommand();
            cmd.Connection = conn;
        }

        public void AddFileData(FileDataEntity fde)
        {
            string sqlCmd = "INSERT INTO Data(Action,PathName,OldPathName,TimeAffected)"
                    + "VALUES('"
                    + fde.Action + "','"
                    + fde.PathName + "','"
                    + fde.OldPathName + "','"
                    + fde.TimeAffected.ToString("yyyy-MM-dd HH:mm:ss") + "');";
            try
            {
                cmd.CommandText = sqlCmd;
                conn.Open();
                int result = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Logger.Log("Exception: " + ex.Message);
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public List<FileDataEntity> GetFDEList()
        {
            string sqlCmd = "SELECT Action,PathName,OldPathName,TimeAffected FROM Data ORDER BY TimeAffected DESC;";
            List<FileDataEntity> fdeList = new List<FileDataEntity>();

            try
            {
                cmd.CommandText = sqlCmd;
                conn.Open();
                rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    FileDataEntity fde = new FileDataEntity();
                    fde.Action = rdr["Action"].ToString();
                    fde.PathName = rdr["PathName"].ToString();
                    fde.OldPathName = rdr["OldPathName"].ToString();
                    fde.TimeAffected = (DateTime)rdr["TimeAffected"];
                    fdeList.Add(fde);
                }

            }
            catch(Exception ex)
            {
                Logger.Log("Exception: " + ex.Message);
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return fdeList;
        }
    }
}
