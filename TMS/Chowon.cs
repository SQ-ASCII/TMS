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
    class User
    {
        private string UserID { get; set; }
        private string UserPW { get; set; }
        private string FirtName { get; set; }
        private string LastName { get; set; }
        private DateTime AccessDate { get; set; }

        /// <b>Main function</b>
        /// \brief main method of <i>User Class</i> inherited by Admin, Buyer, Planner class
        /// \details <b>Details</b>
        /// This is the main method of User class that is the basis of the Admin, Buyer and Planner class.
        /// \param N/A
        /// \return void
        public void main()
        {

        }

        /// <b>Method method name()</b>
        /// \brief <i>method name()</i> bried description
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param parameter description
        /// \return description
        public bool CheckUser()
        {
            return true;
        }
    }


    /* -------------------------- Admin -------------------------- */
    ///
    /// \brief <i>Admin Class</i> inherits User class
    /// \details <b>Details</b>
    /// class description here
    class Admin : User
    {
        private string AdminID { get; set; }    /// property description

        /// <b>Method method name()</b>
        /// \brief <i>method name()</i> bried description
        /// \details <b>Details</b>
        /// detailed description
        /// 
        /// \param parameter description
        /// \return description
        public bool UpdateFeeTable()
        {
            return true;
        }

        public bool AddCarrierData()
        {
            return true;
        }

        public bool UpdateCarrierData()
        {
            return true;
        }

        public bool DeleteCarrierData()
        {
            return true;
        }

        public bool BackupData()
        {
            return true;
        }

        public string GetLogFile(int logfileID)
        {
            string data = "data";
            return data;
        }

        public bool ChangeIpAddress(string ip)
        {
            return true;
        }

        public bool ChangeIpPort(string port)
        {
            return true;
        }

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
    class Buyer : User
    {
        private string BuyerID { get; set; }

        public string ExistingCustomer()
        {
            string customer = "customer1";
            return customer;
        }

        public bool SetNewCustomer()
        {
            return true;
        }

        public void SetRelevantCity()
        {

        }

        public void SetCarrier()
        {

        }

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
    class Planner : User
    {
        private string PlannerID { get; set; }

        public void GetReport()
        {

        }
    }
}
