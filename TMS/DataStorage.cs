/* -- this is a FILEHEADER COMMENT --
	NAME	:	DataStorage.cs
	PURPOSE :	This file is to access and retrieve the information from the database.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    /// 
    /// \class DataStorage
    ///
    /// \brief The purpose of this class is to model the access and get the information from the data storage.
    /// This class has two data member to store the storage information(ID, Name).
    /// Also, it will set up the backup system to helping the administrator for how to backup.
    ///
    /// Within the class definition :
    /// - class data members (attributes)
    ///	int StorageID : It will contain the radius size of circle
    ///	string StorageName : It will contain the side length size of square
    ///
    /// - methods
    ///	DataStorage(void) : default constructor
    ///	~DataStorage(void) : destructor
    ///
    ///	int GetStorageId(void)					    : accessor to get a "StorageID" data member
    ///	string GetStorageName(void)				    : accessor to get a "StorageName" data member
    ///		  
    ///	void SetStorage(int id, string name)	    : mutator to set a Storage(ID and Name) data member
    ///	void SetStorageId(int id)		            : mutator to set a "StorageID" data member
    ///	void SetStorageName(string name)		    : mutator to set a "StorageName" data member
    ///	
    /// void SetBackup()                            : mutator to set up the backup system
    /// void StartBackup()                          : mutator to start the backup system
    /// void SetBillingInfo(object o)               : mutator to set up billing information
    /// 
    /// string GetCarrier(int id)                   : method to get a carrier information from the external database
    /// string GetContractMarket(int id)            : method to get a contract market information from the external database
    ///
    ///
    /// \author <i>Younchul Cho</i>
    ///
    public class DataStorage
    {
        ///
        /// <b>Properties</b>
        /// 
        private int StorageID { get; set; }
        private string StorageName { get; set; }


        ///
        /// <b>Method GetStorageId()</b>
        /// \brief <i>GetStorageId()</i> This method get the storage id and returning
        /// \details <b>Details</b>
        /// The purpose of this function is returning the ID of storage from the data member that belongs to DataStorage class
        /// 
        /// \param N/A
        /// \return Returns the integer type for the ID of a storage
        /// 
        public int GetStorageId()
        {
            return StorageID;
        }


        ///
        /// <b>Method GetStorageName()</b>
        /// \brief <i>GetStorageName()</i> This method get the storage name and returning
        /// \details <b>Details</b>
        /// The purpose of this function is returning the name of storage from the data member that belongs to DataStorage class
        /// 
        /// \param N/A
        /// \return Returns the string type for the name of a storage
        /// 
        public string GetStorageName()
        {
            return StorageName;
        }


        ///
        /// <b>Method SetStorage()</b>
        /// \brief <i>SetStorage()</i> This method set the storage id and name
        /// \details <b>Details</b>
        /// The purpose of this function is set the name and ID of storage to the data member that belongs to DataStorage class
        /// 
        /// \param id  - <b>int</b> - representation of the new id number of storage
        /// \param name  - <b>string</b> - representation of the new name of storage
        /// \return N/A - no return value
        /// 
        public void SetStorage(int id, string name)
        {
            SetStorageId(id);
            SetStorageName(name);
        }


        ///
        /// <b>Method SetStorageId()</b>
        /// \brief <i>SetStorageId()</i> This method set the storage id
        /// \details <b>Details</b>
        /// The purpose of this function is set the ID of storage to the data member that belongs to DataStorage class
        /// 
        /// \param id  - <b>int</b> - representation of the new id number of storage
        /// \return N/A - no return value
        /// 
        public void SetStorageId(int id)
        {
            StorageID = id;
        }


        ///
        /// <b>Method SetStorageName()</b>
        /// \brief <i>SetStorageName()</i> This method set the storage name
        /// \details <b>Details</b>
        /// The purpose of this function is set the name of storage to the data member that belongs to DataStorage class
        /// 
        /// \param name  - <b>string</b> - representation of the new name of storage
        /// \return N/A - no return value
        /// 
        public void SetStorageName(string name)
        {
            StorageName = name;
        }


        ///
        /// <b>Method SetBackup()</b>
        /// \brief <i>SetBackup()</i> This method set up the backup system for running
        /// \details <b>Details</b>
        /// The purpose of this function is set up the backup system to store every information to the external database
        /// 
        /// \param N/A
        /// \return N/A - no return value
        /// 
        public void SetBackup()
        {

        }


        ///
        /// <b>Method StartBackup()</b>
        /// \brief <i>StartBackup()</i> This method initiates the backup system
        /// \details <b>Details</b>
        /// The purpose of this function is to start the backup into the external database or file
        /// 
        /// \param N/A
        /// \return N/A - no return value
        /// 
        public void StartBackup()
        {

        }


        ///
        /// <b>Method SetBillingInfo()</b>
        /// \brief <i>SetBillingInfo()</i> This method set up the billing information
        /// \details <b>Details</b>
        /// The purpose of this function is to set the information into the billing information
        /// 
        /// \param o  - <b>object</b> - The object which triggered with thread as a worker
        /// \return N/A - no return value
        /// 
        public void SetBillingInfo(object o)
        {

        }


        ///
        /// <b>Method GetContractMarket()</b>
        /// \brief <i>GetContractMarket()</i> This method get the contract market(customer) name
        /// \details <b>Details</b>
        /// The purpose of this function is get the contract market information from the external database
        /// 
        /// \param id  - <b>int</b> - representation of id that wants to know for contract market
        /// \return Returns the string type of name which indicate the id of the contract market
        /// 
        public string GetContractMarket(int id)
        {
            string name = "";

            return name;
        }



        ///
        /// <b>Method GetCarrier()</b>
        /// \brief <i>GetCarrier()</i> This method get the carrier(driver) name
        /// \details <b>Details</b>
        /// The purpose of this function is get the carrier information from the external database
        /// 
        /// \param id  - <b>int</b> - representation of id that wants to know for carrier
        /// \return Returns the string type of name which indicate the id of the carrier
        ///
        public string GetCarrier(int id)
        {
            string name = "";

            return name;
        }
    }
}
