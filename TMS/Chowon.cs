using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    /* -------------------------- User -------------------------- */
    ///
    /// \brief <i>User Class</i> inherited by Admin, Buyer, Planner class
    /// \details <b>Details</b>
    /// This class is the basis of the Admin, Buyer and Planner class.
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
        /// <b>Main function</b>
        /// \brief This is the main method of the <i>User Class</i> inherited by Admin, Buyer, Planner class
        /// \details <b>Details</b>
        /// This is the main method of User class that is the basis of the Admin, Buyer and Planner class.
        /// 
        /// \param N/A
        /// \return void
        /// 
        public void main()
        {

        }

        ///
        /// <b>Method method name()</b>
        /// \brief <i>method name()</i> bried description
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param parameter description
        /// \return description
        /// 
        public bool CheckUser()
        {
            return true;
        }
    }


    /* -------------------------- Admin -------------------------- */
    ///
    /// \brief <i>Admin Class</i> inherits from the User class
    /// \details <b>Details</b>
    /// This class inherits from the User class.
    /// Having additional properties and methods for the management of the database and the network settings,
    /// this class provides functionalities for Admin account of TMS application.
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
        /// \brief <i>AddCarrierData()</i> This method 
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
        /// \brief <i>UpdateCarrierData()</i> This method 
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
        /// \brief <i>DeleteCarrierData()</i> This method 
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
        /// \brief <i>BackupData()</i> This method 
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
        /// \brief <i>GetLogFile()</i> This method 
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
        /// \brief <i>ChangeIpAddress()</i> This method 
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
        /// \brief <i>ChangeIpPort()</i> This method 
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
        /// \brief <i>SetLogDirectory()</i> This method 
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
    /// \brief <i>Buyer Class</i> inherits User class
    /// \details <b>Details</b>
    /// class description here
    /// 
    class Buyer : User
    {
        ///
        /// <b>Properties</b>
        /// 
        private string BuyerID { get; set; }            /// ID of the buyer

        ///
        /// <b>Method ExistingCustomer()</b>
        /// \brief <i>ExistingCustomer()</i> This method 
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
        /// <b>Method AddNewCustomer()</b>
        /// \brief <i>AddNewCustomer()</i> This method adds new customer to the database.
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param N/A
        /// \return bool
        /// 
        public bool AddNewCustomer()
        {
            return true;
        }

        ///
        /// <b>Method SetRelevantCity()</b>
        /// \brief <i>SetRelevantCity()</i> This method 
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
        /// <b>Method SetCarrier()</b>
        /// \brief <i>SetCarrier()</i> This method 
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param N/A
        /// \return void
        /// 
        public void SetCarrier()
        {

        }

        ///
        /// <b>Method SetInvoice()</b>
        /// \brief <i>SetInvoice()</i> This method 
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
    /// \brief <i>Planner Class</i> inherits User class
    /// \details <b>Details</b>
    /// class description here
    /// 
    class Planner : User
    {
        ///
        /// <b>Properties</b>
        /// 
        private string PlannerID { get; set; }      /// ID of the planner

        ///
        /// <b>Method GetReport()</b>
        /// \brief <i>GetReport()</i> This method 
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param N/A
        /// \return void
        /// 
        public void GetReport()
        {

        }
    }
}
