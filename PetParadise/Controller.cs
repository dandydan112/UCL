using System;
using System.Collections.Generic;
using System.Text;

namespace PetParadise
{
    public class Controller
    {
        private OwnerRepo ownerRepo = new OwnerRepo();
        private PetRepo petRepo = new PetRepo();
        private TreatmentRepo treatmentRepo = new TreatmentRepo();

        public List<Owner> GetAllOwners()
        {
            return ownerRepo.GetAll();
        }
        public Owner GetSpecificOwner(int ownerId)
        {
            return ownerRepo.GetById(ownerId);
        }

        public List<Pet> GetAllPets()
        {
            return petRepo.GetAll();
        }
        public Pet GetSpecificPet(int petId)
        {
            return petRepo.GetById(petId);
        }

        public List<Treatment> GetAllTreatments()
        {
            return treatmentRepo.GetAll();
        }
        public Treatment GetSpecificTreatment(int treatId)
        {
            return treatmentRepo.GetById(treatId);
        }

        public List<string> GetAllPetNamesOwnedByOwner(string firstName, string lastName)
        {
            return DatabaseHelper.GetAllPetNamesOwnedByOwner(firstName, lastName);
        }
        public List<Treatment> GetAllTreatmentsPaidByOwner(string firstName, string lastName)
        {
            return DatabaseHelper.GetAllTreatmentsPaidByOwner(firstName, lastName);
        }
    }
}
