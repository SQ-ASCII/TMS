using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS
{
    
    class DataStorage
    {
        private int StorageID { get; set; }
        private string StorageName { get; set; }

        public int GetStorageId()
        {
            return StorageID;
        }

        public string GetStorageName()
        {
            return StorageName;
        }

        public void GetStorageId(int id, string name)
        {
            StorageID = id;
            StorageName = name;
        }

        public void InitiateBackup()
        {

        }

        public void StartBackup()
        {

        }

        public void SetBillingInfo(object o)
        {

        }

        public string GetContractMaket()
        {
            string marketName = "";

            return marketName;
        }

        public void SetContractMaket(string name)
        {

        }

        public void SetCarrierSystem(string carrierName)
        {

        }

        public string GetCarrierSystem()
        {
            string carrierName = "";

            return carrierName;
        }
    }
}
