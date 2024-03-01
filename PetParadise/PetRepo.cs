using System;
using System.Collections.Generic;
using System.Text;

namespace PetParadise
{
    public class PetRepo
    {
        private List<Pet> pets = new List<Pet>();

        public PetRepo()
        {
            // Load all pet data from database via SQL statements and populate pet repository

            // IMPLEMENT THIS!
        }

        public int Add(Pet pet)
        {
            // Add new pet to database and to repository
            // Return the database id of the pet

            int result = -1;

            // IMPLEMENT THIS!

            return result;
        }
        public List<Pet> GetAll()
        {
            // Retrieve all pets from database

            List<Pet> result = new List<Pet>();

            // IMPLEMENT THIS!

            return result;
        }
        public Pet GetById(int id)
        {
            // Get pet by id from database

            Pet result = null;

            // IMPLEMENT THIS!

            return result;
        }
        public void Update(Pet pet)
        {
            // Update existing pet on database

            // IMPLEMENT THIS!
        }
        public void Remove(Pet pet)
        {
            // Delete existing pet in database

            // IMPLEMENT THIS!
        }
    }
}
