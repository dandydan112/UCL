using System;
using System.Collections.Generic;
using System.Text;

namespace PetParadise
{
    public class Pet
    {
        public int PetId { get; }
        public string Name { get; set; }
        public PetTypes PetType { get; set; }
        public string Breed { get; set; }
        public DateTime DOB { get; set; }
        public double Weight { get; set; }

        public Pet(int petId)
        {
            PetId = petId;
        }


        public override string ToString()
        {
            return $"{PetId}: {Name}, {PetType}, {Breed}, {DOB}, {Weight}";
        }
    }
}
