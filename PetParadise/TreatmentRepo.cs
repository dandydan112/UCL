using System;
using System.Collections.Generic;
using System.Text;

namespace PetParadise
{
    public class TreatmentRepo
    {
        private List<Treatment> treatments = new List<Treatment>();

        public TreatmentRepo()
        {
            // Load all treatment data from database via SQL statements and populate treatment repository

            // IMPLEMENT THIS!
        }

        public int Add(Treatment treatment)
        {
            // Add new treatment to database and to repository
            // Return the database id of the treatment

            int result = -1;

            // IMPLEMENT THIS!

            return result;
        }
        public List<Treatment> GetAll()
        {
            // Retrieve all treatments from database

            List<Treatment> result = new List<Treatment>();

            // IMPLEMENT THIS!

            return result;
        }
        public Treatment GetById(int id)
        {
            // Get treatment by id from database

            Treatment result = null;

            // IMPLEMENT THIS!

            return result;
        }
        public void Update(Treatment treatment)
        {
            // Update existing treatment on database

            // IMPLEMENT THIS!
        }
        public void Remove(Treatment treatment)
        {
            // Delete existing treatment in database

            // IMPLEMENT THIS!
        }

        
    }
}
