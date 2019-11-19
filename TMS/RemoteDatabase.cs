/* -- this is a FILEHEADER COMMENT --
	NAME	:	RemoteDatabase.cs
	PURPOSE :	This file is to access and retrieve the information from the Remote database.
*/

using System;
using System.Collections.Generic;
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
    ///	int ConnectionID   : It will contain the ConnectionID of Remote Database
    ///	string IpAddress   : It will contain the IpAddress of Remote Database
    ///	string PortAddress : It will contain the PortAddress of Remote Database
    ///
    /// - methods
    ///	RemoteDatabase(void) : default constructor
    ///	~RemoteDatabase(void) : destructor
    ///
    ///	string GetIpAddress()				        : accessor to get a "IpAddress" data member
    ///	string GetIpPort()				            : accessor to get a "PortAddress" data member
    ///		  
    ///	void SetIpAddress(string myIpAddress)	    : mutator to set a "IpAddress" data member
    ///	void SetIpPort(string myPort)	            : mutator to set a "PortAddress" data member
    ///
    /// \author <i>Hyungbum Kim</i>
    ///
    class RemoteDatabase
    {
        ///
        /// <b>Properties</b>
        /// 
        private int ConnectionID;
        private string IpAddress;
        private string PortAddress;

        ///
        /// <b>Method GetIpAddress()</b>
        /// \brief <i>GetIpAddress()</i> This method get the Remote Database IP Address and returning
        /// \details <b>Details</b>
        /// The purpose of this function is returning the Remote Database IP Address from the data member that belongs to RemoteDatabase class
        /// 
        /// \param N/A
        /// \return Returns the string type for the Remote Database IP Address
        /// 
        public string GetIpAddress()
        {
            string myAddress = null;
            myAddress = this.IpAddress;
            return myAddress;
        }

        ///
        /// <b>Method GetIpPort()</b>
        /// \brief <i>GetIpPort()</i> This method get the Remote Database Port Number and returning
        /// \details <b>Details</b>
        /// The purpose of this function is returning the Remote Database Port Number from the data member that belongs to RemoteDatabase class
        /// 
        /// \param N/A
        /// \return Returns the string type for the Remote Database Port Number
        /// 
        public string GetIpPort()
        {
            string myIpPort = null;
            myIpPort = this.PortAddress;
            return myIpPort;
        }

        ///
        /// <b>Method SetIpAddress()</b>
        /// \brief <i>SetIpAddress()</i> This method set the Remote Database IP Address
        /// \details <b>Details</b>
        /// The purpose of this Method is to set the Remote Database IP Address Number of Remote Database to the data member that belongs to RemoteDatabase class
        /// 
        /// \param myIpAddress  - <b>string</b> - representation of the new IP Address of Remote Database
        /// \return N/A - no return value
        /// 
        public void SetIpAddress(string myIpAddress)
        {
            this.IpAddress = myIpAddress;
        }

        ///
        /// <b>Method SetIpPort()</b>
        /// \brief <i>SetIpPort()</i> This method set the Remote Database Port Number
        /// \details <b>Details</b>
        /// The purpose of this Method is to set the Remote Database Port Number of Remote Database to the data member that belongs to RemoteDatabase class
        /// 
        /// \param myPort  - <b>string</b> - representation of the new Port number of Remote Database
        /// \return N/A - no return value
        /// 
        public void SetIpPort(string myPort)
        {
            this.PortAddress = myPort;
        }
    }
}
