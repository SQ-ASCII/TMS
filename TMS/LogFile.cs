/* -- this is a LogFile COMMENT --
	NAME	:	RemoteDatabase.cs
	PURPOSE :	This file is to access and retrieve the information from the Remote database.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    /// 
    /// \class RemoteDatabase
    ///
    /// \brief The purpose of this class is to model the access and get the information from the Remote database.
    /// This class has three data member to store the Remote Database information(ConnectionID, IP,Port).
    ///
    /// Within the class definition :
    /// - class data members (attributes)
    ///	string LogID            : It will contain the LogID of LogFile
    ///	DateTime GenerateDate   : It will contain the Generating Date of LogFile
    ///	string UserID           : It will contain the UserID of LogFile
    /// string ExceptionDescrip : It will contain the LogFile about Exception
    /// 
    /// - methods
    ///	LogFile(void)  : default constructor
    ///	~LogFile(void) : destructor
    ///
    ///	object GenLogFile()	        : method generating the Log File and returning File Stream 
    ///	object UpdateLogFile()		: method Updating the Log File and returning File Stream 
    ///
    /// \author <i>Hyungbum Kim</i>
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
        public object GenLogFile(string myLogID,DateTime myGenDate,
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
    }
}
