using System.Collections.Generic;
using StorageUnitManagementSystem.BL.Classes;
using StorageUnitManagementSystem.DAL;
//Programmer     : Watlinton Moholo
//Student Number : 214030377
namespace StorageUnitManagementSystem.BL
{
    class LUBL
    {
        private LeaseUnitsProviderBase providerBase;
        public LUBL(string Provider)
        {
            //
            //Method Name : LUBL(string Provider)
            //Purpose     : Overloaded constructor; invoke _SetupProviderBase to setup data provider
            //Re-use      : _SetupProviderBase()
            //Input       : string Provider
            //              - The name of the data provider to use
            //Output      : None
            //
            _SetupProviderBase(Provider);
        } // end method

        /// <summary>
        /// This method gets the list of all the business objects from the LeaseUnit datastore.
        /// It returns the list of business objects
        /// </summary>
        public List<LeaseUnits> SelectAll()
        {
            return providerBase.SelectAll();
        } // end method

        /// <summary>
        /// This method gets a single LeaseUnit object from the LeaseUnit datastore.
        /// It returns 0 to indicate the LeaseUnit was loaded from the datastore, or
        /// -1 to indicate that no LeaseUnit was loaded from the datastore.
        /// </summary>
        /// <param name="ID">The LeaseUnit ID of the StorageUnit to load from the datastore.</param>
        /// <param name="LeaseUnit">The LeaseUnit object loaded from the datastore.</param>
        public int SelectLeaseUnit(string ID, ref LeaseUnits LeaseUnit)
        {
            return providerBase.SelectLeaseUnit(ID, ref LeaseUnit);
        } // end method

        /// <summary>
        /// This method inserts a row in the LeaseUnit datastore. 
        /// It returns 0 to indicate the LeaseUnit was inserted into datastore, or
        /// -1 to indicate the LeaseUnit was not inserted because a duplicate was found
        /// </summary>
        /// <param name="LeaseUnit">The LeaseUnit object to add to the LeaseUnit datastore.</param>
        public int Insert(LeaseUnits LeaseUnit)
        {
            return providerBase.Insert(LeaseUnit);
        } // end method

        /// <summary>
        /// This method updates a row in the LeaseUnit datastore.
        /// It returns 0 to indicate the LeaseUnit was found and updated successfully, or
        ///  -1 to indicate the LeaseUnit was not updated because the record was not found
        /// </summary>
        /// <param name="LeaseUnit">The new LeaseUnit data for the row in the LeaseUnit datastore.</param>
        public int Update(LeaseUnits LeaseUnit)
        {
            return providerBase.Update(LeaseUnit);
        } // end method

        public int UpdatePopUp(LeaseUnits LeaseUnit)
        {
            return providerBase.Update(LeaseUnit);
        } // end method

        /// <summary>
        /// This method deletes a row in the LeaseUnit datastore.
        /// It returns 0 to indicate the LeaseUnit was found and deleted successfully, or
        ///  -1 to indicate the LeaseUnit was not deleted because the record was not found
        /// </summary>
        /// <param name="ID">The LeaseUnit ID of the LeaseUnit to delete in the LeaseUnit datastore.</param>
        public int Delete(string ID)
        {
            return providerBase.Delete(ID);
        } // end method

        /// <summary>
        /// This method determines if a given LeaseUnit exists in the LeaseUnit datastore.
        /// It returns true to indicate the LeaseUnit was foundy, or
        ///  false to indicate the LeaseUnit was not found
        /// </summary>
        /// <param name="ID">The LeaseUnit ID of the LeaseUnit to search in the LeaseUnit datastore.</param>
        public bool DoesExist(string ID)
        {
            return providerBase.DoesExist(ID);
        } // end method

        private void _SetupProviderBase(string Provider)
        {
            //
            //Method Name : void _SetupProviderBase()
            //Purpose     : Helper method to select the correct data provider
            //Re-use      : None
            //Input       : string Provider
            //              - The name of the data provider to use
            //Output      : None
            //
            if (Provider == "LeaseUnitsSQLiteProvider")
            {
                providerBase = new LeaseUnitsSQLiteProvider();
            } // end if
        } // end method
    }
}
