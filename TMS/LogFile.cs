/* -- this is a LogFile COMMENT --
	NAME	:	LogFile.cs
	PURPOSE :	This file is to create and write the log file into the file or Database.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace TMS
{
    /// 
    /// \class LogFile
    ///
    /// \brief The purpose of this class is to model the create and write the log file into the file.
    /// This class has one data member to indicate the file stream.
    /// Also, it will store the message with a current date
    ///
    /// Within the class definition :
    /// - class data members (attributes)
    ///	FileStream fs : It will indicate the file, which is the specific information to write the log.
    ///	string LogID            : It will contain the LogID of LogFile
    ///	DateTime GenerateDate   : It will contain the Generating Date of LogFile
    ///	string UserID           : It will contain the UserID of LogFile
    /// string ExceptionDescrip : It will contain the LogFile about Exception
    ///
    /// - methods
    /// FileLog(void)                   : default constructor
    ///	void LogClose()                 : method to close the file system
    ///	void LogWrite(string msg)       : method to write the log message with date information in the file
    ///	object GenLogFile()	        : method generating the Log File and returning File Stream 
    ///	object UpdateLogFile()		: method Updating the Log File and returning File Stream 
    ///
    ///	
    /// \author <i>Younchul Cho</i>
    ///
    /// 

    class LogFile
    {
        ///
        /// <b>Properties</b>
        /// 
        private string LogID;
        private DateTime GenerateDate;
        private string UserID;
        private string ExceptionDescript;
        FileStream fs = null;

        private string connectionString = Properties.Settings.Default.ConnectionString;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader rdr;

        ///
        /// <b>Method LogFile()</b>
        /// \brief <i>LogFile()</i> To instantiate a new LogFile object
        /// \details <b>Details</b>
        /// This is a LogFile's default constructor, it will set up the file stream.
        /// The default file name is "LogFile.txt" with append mode.
        /// 
        /// \param N/A
        /// \return As this is a <i>default constructor</i> for the LogFile class, nothing is returned
        /// 
        public LogFile()
        {
            fs = new FileStream("LogFile.txt", FileMode.Append);
            conn = new MySqlConnection(connectionString);
            cmd = new MySqlCommand();
            cmd.Connection = conn;
        }

        ///
        /// <b>Method GenLogFile()</b>
        /// \brief <i>GenLogFile()</i> This method generate the Log File and returning File Stream 
        /// \details <b>Details</b>
        /// The purpose of this Method is generating the Log File using the data member that belongs to LogFile class and returning File Stream
        /// 
        /// \param myLogID   - <b>string</b>   - representation of the new LogID of LogFile
        /// \param myGenDate - <b>DateTime</b> - representation of the Generating Date of LogFile
        /// \param myUserID  - <b>string</b>   - representation of the UserID of LogFile
        /// \param myUserID  - <b>string</b>   - representation of the LogFile about Exception
        /// \return Returns the FileStream type for the new LogFile
        /// 
        public object GenLogFile(string myLogID, DateTime myGenDate,
            string myUserID, string myException)
        {
            FileStream myFile = null;

            return myFile;
        }

        ///
        /// <b>Method UpdateLogFile()</b>
        /// \brief <i>UpdateLogFile()</i> This method Update the Log File and returning File Stream 
        /// \details <b>Details</b>
        /// The purpose of this Method is updating the Log File using the data member that belongs to LogFile class and returning File Stream
        /// 
        /// \param myLogID   - <b>string</b>   - representation of the update LogID of LogFile
        /// \param myGenDate - <b>DateTime</b> - representation of the Generating Date of LogFile
        /// \param myUserID  - <b>string</b>   - representation of the UserID of LogFile
        /// \param myUserID  - <b>string</b>   - representation of the LogFile about Exception
        /// \return Returns the FileStream type for the updated LogFile
        /// 

        public object UpdateLogFile(string myLogID, DateTime myGenDate,
            string myUserID, string myException)
        {
            FileStream myFile = null;

            return myFile;
        }



        ///
        /// <b>Method LogClose()</b>
        /// \brief <i>LogClose()</i> This method close the file system
        /// \details <b>Details</b>
        /// The purpose of this function is closing the file system when the system does not need to write the log.
        /// 
        /// \param N/A
        /// \return N/A - no return value
        /// 
        public void LogClose()
        {
            fs.Close();
        }



        ///
        /// <b>Method LogWrite()</b>
        /// \brief <i>LogWrite()</i> This method writes the log message into the file
        /// \details <b>Details</b>
        /// The purpose of this function is writing the message with the current date into the file
        /// 
        /// \param msg  - <b>string</b> - representation of the message which is want to write into the file
        /// \return N/A - no return value
        /// 
        public void LogWrite(string msg)
        {
            string log = null;
            string timeStamp = null;

            timeStamp = DateTime.Now.ToString("yyyy-mm-dd hh:mm:ss" + " => ");
            log = timeStamp + msg + "\r\n";

            Console.WriteLine(log);
            byte[] sendBuffer = Encoding.ASCII.GetBytes(log); ;
            fs.Write(sendBuffer, 0, sendBuffer.Length);
        }


        ///
        /// <b>Method AddFileData()</b>
        /// \brief <i>AddFileData()</i> This method writes the log message into the Database
        /// \details <b>Details</b>
        /// The purpose of this function is writing the message with the current date into the Database
        /// 
        /// \param fde  - <b>FileDataEntity</b> - representation of the message which is want to write into the Database
        /// \return N/A - no return value
        /// 
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
            catch (Exception ex)
            {
                Logger.Log("Exception: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        ///
        /// <b>Method GetFDEList()</b>
        /// \brief <i>GetFDEList()</i> This method Read the log message from the Database
        /// \details <b>Details</b>
        /// The purpose of this function is read the message with the current date from the Database
        /// 
        /// \param FileDataEntity  - <b>List</b> - representation of the message which is want to read into the Database
        /// \return N/A - no return value
        /// 
        public List<FileDataEntity> GetFDEList()
        {
            string sqlCmd = "SELECT Action,PathName,OldPathName,TimeAffected FROM Data ORDER BY TimeAffected DESC;";
            List<FileDataEntity> fdeList = new List<FileDataEntity>();

            try
            {
                cmd.CommandText = sqlCmd;
                conn.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    FileDataEntity fde = new FileDataEntity();
                    fde.Action = rdr["Action"].ToString();
                    fde.PathName = rdr["PathName"].ToString();
                    fde.OldPathName = rdr["OldPathName"].ToString();
                    fde.TimeAffected = (DateTime)rdr["TimeAffected"];
                    fdeList.Add(fde);
                }

            }
            catch (Exception ex)
            {
                Logger.Log("Exception: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return fdeList;
        }
    }
}
