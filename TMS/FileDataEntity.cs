/* -- this is a LogFile COMMENT --
	NAME	:	FileDataEntity.cs
	PURPOSE :	This file is to store the data from or into the file or Database.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    /// 
    /// \class FileDataEntity
    ///
    /// \brief The purpose of this class is to model the storage write into and read from the log file into the file.
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
    ///	FileDataEntity(void)  : default constructor
    ///	
    /// \author <i>Younchul Cho</i>
    ///
    /// 
    class FileDataEntity
    {
        public int ID { get; set; }
        public string Action { get; set; }
        public string PathName { get; set; }
        public string OldPathName { get; set; }
        public DateTime TimeAffected { get; set; }

        public FileDataEntity() { }
    }
}
