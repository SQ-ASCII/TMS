/* -- this is a FILEHEADER COMMENT --
	NAME	:	FileLog.cs
	PURPOSE :	This file is to create and write the log into the file.
*/

using System;
using System.IO;
using System.Text;


namespace TMS
{
    /// 
    /// \class FileLog
    ///
    /// \brief The purpose of this class is to model the create and write the log file into the file.
    /// This class has one data member to indicate the file stream.
    /// Also, it will store the message with a current date
    ///
    /// Within the class definition :
    /// - class data members (attributes)
    ///	FileStream fs : It will indicate the file, which is the specific information to write the log.
    ///
    /// - methods
    /// FileLog(void)                   : default constructor
    ///	void LogClose()                 : method to close the file system
    ///	void LogWrite(string msg)       : method to write the log message with date information in the file
    ///	
    /// \author <i>Younchul Cho</i>
    ///
    public class FileLog
    {
        ///
        /// <b>Properties</b>
        /// 
        FileStream fs = null;


        ///
        /// <b>Method FileLog()</b>
        /// \brief <i>FileLog()</i> To instantiate a new FileLog object
        /// \details <b>Details</b>
        /// This is a FileLog's default constructor, it will set up the file stream.
        /// The default file name is "LogFile.txt" with append mode.
        /// 
        /// \param N/A
        /// \return As this is a <i>default constructor</i> for the FileLog class, nothing is returned
        /// 
        public FileLog()
        {
            fs = new FileStream("LogFile.txt", FileMode.Append);
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
    }
}
