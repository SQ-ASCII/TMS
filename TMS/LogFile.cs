using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    /* -------------------------- LogFile -------------------------- */
    ///
    /// \brief <i>LogFile Class</i>
    /// \details <b>Details</b>
    /// class description here
    class LogFile
    {
        private string LogID;
        private DateTime GenerateDate;
        private string UserID;
        private string ExceptionDescript;

        public object GenLogFile(string myLogID,DateTime myGenDate,
            string myUserID, string myException)
        {
            FileStream myFile = null;

            return myFile;
        }

        public object UpdateLogFile(string myLogID, DateTime myGenDate,
            string myUserID, string myException)
        {
            FileStream myFile = null;

            return myFile;
        }
    }
}
