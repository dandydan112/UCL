using System;
using System.Collections.Generic;
using System.Text;

namespace PetParadise
{
    public class OwnerRepo
    {
        private List<Owner> owners = new List<Owner>();

        public OwnerRepo()
        {
            // Load all owner data from database via SQL statements and populate owner repository

            // IMPLEMENT THIS!
        }

        public int Add(Owner owner)
        {
            // Add new owner to database and to repository
            // Return the database id of the owner

            int result = -1;

            // IMPLEMENT THIS!

            return result;
        }
        public List<Owner> GetAll()
        {
            // Retrieve all owners from database

            List<Owner> result = null;

            // IMPLEMENT THIS!

            return result;
        }
        public Owner GetById(int id)
        {
            // Get owner by id from database

            Owner result = null;

            // IMPLEMENT THIS!

            return result;
        }
        public void Update(Owner owner)
        {
            // Update existing owner on database

            // IMPLEMENT THIS!
        }
        public void Remove(Owner owner)
        {
            // Delete existing owner in database

            // IMPLEMENT THIS!
        }

    }
}
