using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    /* -------------------------- LocalDatabase -------------------------- */
    ///
    /// \brief <i>LocalDatabase Class</i>
    /// \details <b>Details</b>
    /// class description here
    class LocalDatabase
    {
        private int LocalDbID;
        private string DbDirectory;

        bool SetBackupDirectory(string myBackupDir)
        {
            bool result = false;
            this.DbDirectory = myBackupDir;
            return result;
        }
    }
}
