/* -- this is a FILEHEADER COMMENT --
	NAME	:	LocalDatabase.cs
	PURPOSE :	This file is to access and retrieve the information from the Local database.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    /// 
    /// \class LocalDatabase
    ///
    /// \brief The purpose of this class is to model the access and get the information from the Local database.
    /// This class has two data member to store the Local Database information(LocalDbID, DbDirectory).
    ///
    /// Within the class definition :
    /// - class data members (attributes)
    ///	int LocalDbID        : It will contain the Database ID of Local Database
    ///	string DbDirectory   : It will contain the Directory of Local Database
    ///
    /// - methods
    ///	LocalDatabase(void)  : default constructor
    ///	~LocalDatabase(void) : destructor
    ///
    ///	void SetBackupDirectory(string myIpAddress)	    : mutator to set a "DbDirectory" data member
    ///
    /// \author <i>Hyungbum Kim</i>
    ///
    class LocalDatabase
    {
        ///
        /// <b>Properties</b>
        /// 
        private int LocalDbID;
        private string DbDirectory;

        ///
        /// <b>Method SetBackupDirectory()</b>
        /// \brief <i>SetBackupDirectory()</i> This method set the Local Database Backup Directory
        /// \details <b>Details</b>
        /// The purpose of this Method is to set the DbDirectory that belongs to LocalDatabase class
        /// 
        /// \param myBackupDir  - <b>string</b> - representation of the new Backup Directory of Local Database
        /// \return result - result of setting Backup Directory
        /// 
        bool SetBackupDirectory(string myBackupDir)
        {
            bool result = false;
            this.DbDirectory = myBackupDir;
            return result;
        }
    }
}
