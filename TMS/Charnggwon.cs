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
    /// \brief The Order class has been created to order ... .
    ///
    /// \author <i>Charng Gwon Lee</i>
    ///
    class Order
    {    
         private int OrderID;
         private double Capacity;
         private int Trip;
         private bool Complete;
         private string DestStreetAddress;
         private string DestCity;
         private string DestPostalCode;
         private string invoiceDate;

         /**
         * \brief To get a order ...
         * \details <b>Details</b>
         *
         * This method gets a order ... .
         *
         * \param OrderID  - <b>int</b> - representation of the order ID
         *
         * \return nothing is returned
         *
         * \see Buyer()
         */
         public void getOrder(int OrderID)
         {
         }

         /**
         * \brief To set new order ...
         * \details <b>Details</b>
         *
         * This method sets new order ... .
         *
         * \param nothing
         *
         * \return nothing is returned
         *
         * \see Buyer()
         */
         public void setNewOrder()
         {
         }

         /**
         * \brief To set a trip ...
         * \details <b>Details</b>
         *
         * This method sets the order ... .
         *
         * \param nothing
         *
         * \return nothing is returned
         *
         * \see Buyer()
         */
         public void setTrip()
         {
         }

         /**
         * \brief To complete the order ...
         * \details <b>Details</b>
         *
         * This method completes the order ... .
         *
         * \param nothing
         *
         * \return nothing is returned
         *
         * \see Buyer()
         */
         public void completeOrder(bool Complete)
         {
         }

         /**
         * \brief To get an activity order ...
         * \details <b>Details</b>
         *
         * This method get an activity order ... .
         *
         * \param nothing
         *
         * \return nothing is returned
         *
         * \see Buyer()
         */
         public void getActivityOrder()
         {
         }
 
    }
}
