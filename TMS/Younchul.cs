using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    class Younchul
    {
    }

    

    public class LogFile
    {
        private FileStream fs = null;
        public LogFile()
        {
            fs = new FileStream("ServerLog.txt", FileMode.Append);
        }


        public void LogClose()
        {
            fs.Close();
        }


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
    }
}
