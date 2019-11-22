using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    /* -------------------------- User -------------------------- */
    ///
    /// \class User Class
    ///
    /// \brief <i>User Class</i> inherited by Admin, Buyer, Planner class
    /// \details <b>Details</b>
    /// This class is the basis of the Admin, Buyer and Planner class.
    /// It contains common properties as user ID, password, first and last name,
    /// and the timestamp of the last access of the user.
    /// 
    /// \author Chowon Jung
    ///
    class User
    {
        ///
        /// <b>Properties</b>
        /// 
        private string UserID { get; set; }         /// ID of the user
        private string UserPW { get; set; }         /// password of the user
        private string FirstName { get; set; }      /// first name of the user
        private string LastName { get; set; }       /// last name of the user
        private DateTime AccessDate { get; set; }   /// the last time stamp of the user accessed

        ///
        /// <b>Method CheckUser()</b>
        /// \brief <i>CheckUser()</i> brief description
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param N/A
        /// \return bool
        /// 
        public bool CheckUser()
        {
            return true;
        }
    }


    /* -------------------------- Admin -------------------------- */
    ///
    /// \class Admin : User Class
    ///
    /// \brief <i>Admin Class</i> inherits from the User class
    /// \details <b>Details</b>
    /// This class inherits from the User class.
    /// Having additional properties and methods for the management of the database and the network settings,
    /// this class provides functionalities for Admin account of TMS application.
    /// 
    /// \author Chowon Jung
    ///
    class Admin : User
    {
        ///
        /// <b>Properties</b>
        /// 
        private string AdminID { get; set; }    /// ID of the Admin

        ///
        /// <b>Method UpdateFeeTable()</b>
        /// \brief <i>UpdateFeeTable()</i> This method updates fee table.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param N/A
        /// \return bool
        /// 
        public bool UpdateFeeTable()
        {
            return true;
        }

        ///
        /// <b>Method AddCarrierData()</b>
        /// \brief <i>AddCarrierData()</i> This method adds a carrier data into the database.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param N/A
        /// \return bool
        /// 
        public bool AddCarrierData()
        {
            return true;
        }

        ///
        /// <b>Method UpdateCarrierData()</b>
        /// \brief <i>UpdateCarrierData()</i> This method updates existing carrier data.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param N/A
        /// \return bool
        /// 
        public bool UpdateCarrierData()
        {
            return true;
        }

        ///
        /// <b>Method DeleteCarrierData()</b>
        /// \brief <i>DeleteCarrierData()</i> This method removes an existing carrier data.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param N/A
        /// \return bool
        /// 
        public bool DeleteCarrierData()
        {
            return true;
        }

        ///
        /// <b>Method BackupData()</b>
        /// \brief <i>BackupData()</i> This method process a data backup for the full TMS DB.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param N/A
        /// \return bool
        /// 
        public bool BackupData()
        {
            return true;
        }

        ///
        /// <b>Method GetLogFile()</b>
        /// \brief <i>GetLogFile()</i> This method load and reads requested log file.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param int logfileID : this is the ID of the logfile to be read.
        /// \return string data  : this is the loaded data string from the requested logfile.
        /// 
        public string GetLogFile(int logfileID)
        {
            string data = "data";
            return data;
        }

        ///
        /// <b>Method ChangeIpAddress()</b>
        /// \brief <i>ChangeIpAddress()</i> This method modifies IP address to the newly given address.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param string ip : this is the IP address to be set.
        /// \return bool
        /// 
        public bool ChangeIpAddress(string ip)
        {
            return true;
        }

        ///
        /// <b>Method ChangeIpPort(</b>
        /// \brief <i>ChangeIpPort()</i> This method modifies the port to the newly given port.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param string port : this is the port string to be set.
        /// \return bool
        /// 
        public bool ChangeIpPort(string port)
        {
            return true;
        }

        ///
        /// <b>Method SetLogDirectory()</b>
        /// \brief <i>SetLogDirectory()</i> This method sets the file directory for the log files.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param string dir : this is the directory to be set.
        /// \return bool
        /// 
        public bool SetLogDirectory(string dir)
        {
            return true;
        }
    }


    /* -------------------------- Buyer -------------------------- */
    ///
    /// \class Buyer : User
    ///
    /// \brief <i>Buyer Class</i> inherits User class
    /// \details <b>Details</b>
    /// class description here
    /// 
    /// \author Chowon Jung
    /// 
    class Buyer : User
    {
        ///
        /// <b>Properties</b>
        /// 
        private string BuyerID { get; set; }            /// ID of the buyer

        ///
        /// <b>Method ExistingCustomer()</b>
        /// \brief <i>ExistingCustomer()</i> This method reads existing customers in.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param N/A
        /// \return string customer : ?
        /// 
        public string ExistingCustomer()
        {
            string customer = "customer1";
            return customer;
        }

        ///
        /// <b>Method AcceptNewCustomer()</b>
        /// \brief <i>AcceptNewCustomer()</i> This method accepts new customer to the existing customer list.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param N/A
        /// \return bool
        /// 
        public bool AcceptNewCustomer()
        {
            return true;
        }

        ///
        /// <b>Method SetRelevantCity()</b>
        /// \brief <i>SetRelevantCity()</i> This method sets relevant cities into the order.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param N/A
        /// \return void
        /// 
        public void SetRelevantCity()
        {

        }

        ///
        /// <b>Method SetInvoice()</b>
        /// \brief <i>SetInvoice()</i> This method creates invoice text file of the order.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param N/A
        /// \return objec textfile : this is the invoice textfile.
        /// 
        public object SetInvoice()
        {
            var textfile = new object();
            return textfile;
        }
    }


    /* -------------------------- Planner -------------------------- */
    ///
    /// \class Planner : User
    ///
    /// \brief <i>Planner Class</i> inherits User class
    /// \details <b>Details</b>
    /// class description here
    ///
    /// 
    /// \author Chowon Jung
    ///
    class Planner : User
    {
        ///
        /// <b>Properties</b>
        /// 
        private string PlannerID { get; set; }      /// ID of the planner

        ///
        /// <b>Method GetReport()</b>
        /// \brief <i>GetReport()</i> This method creates a summary report of existing order.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param N/A
        /// \return void
        /// 
        public void GetReport()
        {

        }
        
        
        ///
        /// <b>Method SetCarrier()</b>
        /// \brief <i>SetCarrier()</i> This method allocates carrier to the order.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param N/A
        /// \return void
        /// 
        public void SetCarrier()
        {

        }
    }
}
