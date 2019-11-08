using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    /* -------------------------- RemoteDatabase -------------------------- */
    ///
    /// \brief <i>RemoteDatabase Class</i>
    /// \details <b>Details</b>
    /// class description here
    class RemoteDatabase
    {
        private int ConnectionID;
        private string IpAddress;
        private string PortAddress;

        public string GetIpAddress()
        {
            string myAddress = null;
            return myAddress;
        }

        public string GetIpPort()
        {
            string myIpPort = null;
            return myIpPort;
        }

        public void SetIpAddress(string myIpAddress)
        {
            this.IpAddress = myIpAddress;
        }

        public void SetIpPort(string myPort)
        {
            this.PortAddress = myPort;
        }
    }
}
