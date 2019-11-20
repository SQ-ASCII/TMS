/* -- this is a FILEHEADER COMMENT --
	NAME	:	Order.cs
	PURPOSE :	This file is to create and manage orders for a buyer and planner.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    /// 
    /// \class Order
    ///
    /// \brief The purpose of this class is to model the access and get the information from the data storage.
    /// This class has two data member to store the storage information(ID, Name).
    /// Also, it will set up the backup system to helping the administrator for how to backup.
    ///
    /// Within the class definition :
    /// - class data members (attributes)
    ///	int OrderID : It represents the ID of an order
	/// double Capacity : It represents the transportation capacity
    /// int Trip : It represents the number of trips on an order
    /// bool Complete : It represents the completed state
    /// string DestStreetAddress : It represents the address of destination
    /// string DestCity : It represents the city of destination
    /// string DestPostalCode : It represents the postal code of destination
    /// string invoiceDate : It represents the date of an invoice
    ///
    /// - methods
    ///	Order(void) : default constructor
    ///	~Order(void) : destructor
    ///
    ///	int GetOrder(void)					    : accessor to get the infomation of an order
    ///	void SetNewOrder(int)				    : mutator to set the information of new order
    ///		  
    ///	void SetTrip(int)	                    : mutator to set the number of trips
    ///	bool CompleteOrder(int)		            : method to set the state of completion
    ///	string GetActivityOrder(void)		    : accessor to get the information on active orders
    ///
    /// \author <i>Charng Gwon Lee</i>
    ///
    public class Order
    {    
        ///
        /// <b>Properties</b>
        /// 
        private int OrderID { get; set; }
        private double Capacity { get; set; }
        private int Trip { get; set; }
        private bool Complete { get; set; }
        private string DestStreetAddress { get; set; }
        private string DestCity { get; set; }
        private string DestPostalCode { get; set; }
        private string invoiceDate { get; set; }

        ///
        /// <b>Method GetOrder()</b>
        /// \brief <i>GetOrder()</i> This method gets the infomation of an order
        /// \details <b>Details</b>
        /// The purpose of this function is to get the detail information about an order
        /// 
        /// \param N/A
        /// \return Returns the integer type for the ID of an order
        /// 
        /// \see Buyer(), Planner()
        /// 
        public int GetOrder(void)
        {
        }

        ///
        /// <b>Method SetNewOrder()</b>
        /// \brief <i>SetNewOrder()</i> This method sets the information of new order
        /// \details <b>Details</b>
        /// The purpose of this function is to set the detail information about new order
        /// 
        /// \param OrderID  - <b>int</b> - representation of the order ID
        /// \return N/A - no return value
        /// 
        /// \see Buyer(), Planner()
        /// 
        public void SetNewOrder(int OrderID)
        {
        }

        ///
        /// <b>Method SetTrip()</b>
        /// \brief <i>SetTrip()</i> This method sets the number of trips
        /// \details <b>Details</b>
        /// The purpose of this function is to set the detail information about trips
        /// 
        /// \param Trip  - <b>int</b> - representation of the number of trip
        /// \return N/A - no return value
        /// 
        /// \see Buyer(), Planner()
        /// 
        public void SetTrip(int Trip)
        {
        }

        ///
        /// <b>Method CompleteOrder()</b>
        /// \brief <i>CompleteOrder()</i> This method sets the state of completion
        /// \details <b>Details</b>
        /// The purpose of this function is to set the state of completion
        /// 
        /// \param OrderID  - <b>int</b> - representation of the order ID
        /// \return Returns the bool type for the state of completion
        /// 
        /// \see Buyer(), Planner()
        /// 
        public bool CompleteOrder(int OrderID)
        {
        }

        ///
        /// <b>Method GetActivityOrder()</b>
        /// \brief <i>GetActivityOrder()</i> This method gets the information on active orders
        /// \details <b>Details</b>
        /// The purpose of this function is to get the detail information about active orders
        /// 
        /// \param N/A
        /// \return Returns the string type for the active orders
        /// 
        /// \see Buyer(), Planner()
        /// 
        public string GetActivityOrder(void)
        {
        }
    }
}
