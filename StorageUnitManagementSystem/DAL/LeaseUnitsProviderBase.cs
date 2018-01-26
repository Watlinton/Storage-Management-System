using System.Collections.Generic;
using StorageUnitManagementSystem.BL.Classes;
//Programmer     : Watlinton Moholo
//Student Number : 214030377
namespace StorageUnitManagementSystem.DAL
{   
    public abstract class LeaseUnitsProviderBase
    {
        /// <summary>
        /// This method gets the list of all the business objects from the LeaseUnit datastore.
        /// It returns the list of business objects
        /// </summary>
        public abstract List<LeaseUnits> SelectAll();

        /// <summary>
        /// This method gets a single LeaseUnit object from the LeaseUnit datastore.
        /// It returns 0 to indicate the LeaseUnit was loaded from datastore, or
        /// -1 to indicate that no LeaseUnit was loaded from the datastore (not found).
        /// </summary>
        /// <param name="ID">The ID of the LeaseUnit to load from the datastore.</param>
        /// <param name="LeaseUnit">The LeaseUnit object loaded from the datastore.</param>
        public abstract int SelectLeaseUnit(string ID, ref LeaseUnits LeaseUnit);


        /// <summary>
        /// This method inserts a row in the LeaseUnit datastore. 
        /// It returns 0 to indicate the LeaseUnit was inserted into datastore, or
        /// -1 to indicate the LeaseUnit was not inserted because a duplicate was found
        /// </summary>
        /// <param name="LeaseUnit">The LeaseUnit object to add to the LeaseUnit datastore.</param>
        public abstract int Insert(LeaseUnits LeaseUnits);

        /// <summary>
        /// This method updates a row in the LeaseUnit datastore.
        /// It returns 0 to indicate the LeaseUnit was found and updated successfully, or
        ///  -1 to indicate the LeaseUnit was not updated because the record was not found
        /// </summary>
        /// <param name="LeaseUnit">The new LeaseUnit data for the row in the LeaseUnit datastore.</param>
        public abstract int Update(LeaseUnits LeaseUnits);
        public abstract int UpdatePopUp(LeaseUnits LeaseUnits);
        /// <summary>
        /// This method deletes a row in the LeaseUnit datastore.
        /// It returns 0 to indicate the LeaseUnit was found and deleted successfully, or
        ///  -1 to indicate the LeaseUnit was not deleted because the record was not found
        /// </summary>
        /// <param name="ID">The LeaseUnit ID of the LeaseUnit to delete in the LeaseUnit datastore.</param>
        public abstract int Delete(string ID);

        /// <summary>
        /// This method determines if a given LeaseUnit exists in the LeaseUnit datastore.
        /// It returns true to indicate the LeaseUnit was foundy, or
        ///  false to indicate the LeaseUnit was not found
        /// </summary>
        /// <param name="ID">The LeaseUnit ID of the LeaseUnit to search in the LeaseUnit datastore.</param>
        public abstract bool DoesExist(string ID);
    }
}
