using PetParadise;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        Controller controller;
        [TestInitialize]
        public void TestInitialize()
        {
            controller = new Controller();
        }

        [TestMethod]
        public void TestGetAllOwnersCheckCount()
        {
            // Arrange
            List<Owner> owners = controller.GetAllOwners();

            // Assert
            Assert.AreEqual(5, owners.Count);
        }
        [TestMethod]
        public void TestGetAllOwnersCheckItem2()
        {
            // Arrange
            List<Owner> owners = controller.GetAllOwners();

            // Assert
            Assert.AreEqual("3: Liz Frier - T: 555 537 6543 - M: Liz.Frier@somewhere.com", owners[2].ToString());
        }
        [TestMethod]
        public void TestGetSpecificOwner3()
        {
            // Arrange
            Owner owner = controller.GetSpecificOwner(5);

            // Assert
            Assert.AreEqual("5: Hilary Evans - T: 210-634-2345 - M: Hilary.Evans@somewhere.com", owner.ToString());
        }
        [TestMethod]
        public void TestGetAllPetsCheckCount()
        {
            // Arrange
            List<Pet> pets = controller.GetAllPets();

            // Assert
            Assert.AreEqual(8, pets.Count);
        }
        [TestMethod]
        public void TestGetAllPetsCheckItem6()
        {
            // Arrange
            List<Pet> pets = controller.GetAllPets();

            // Assert
            Assert.AreEqual("7: Buster, Dog, Border Collie, 11-12-2008 00:00:00, 25", pets[6].ToString());
        }
        [TestMethod]
        public void TestGetSpecificPet7()
        {
            // Arrange
            Pet pet = controller.GetSpecificPet(7);

            // Assert
            Assert.AreEqual("7: Buster, Dog, Border Collie, 11-12-2008 00:00:00, 25", pet.ToString());
        }
        [TestMethod]
        public void TestGetAllTreatmentsCheckCount()
        {
            // Arrange
            List<Treatment> treatments = controller.GetAllTreatments();

            // Assert
            Assert.AreEqual(9, treatments.Count);
        }
        [TestMethod]
        public void TestGetAllTreatmentsCheckItem2()
        {
            // Arrange
            List<Treatment> treatments = controller.GetAllTreatments();

            // Assert
            Assert.AreEqual("3: Parasites on 13-10-2014 00:00:00 costs 42", treatments[2].ToString());
        }
        [TestMethod]
        public void TestGetSpecificTreatment7()
        {
            // Arrange
            Treatment treatment = controller.GetSpecificTreatment(7);

            // Assert
            Assert.AreEqual("7: Skin lnfection on 03-10-2014 00:00:00 costs 35", treatment.ToString());
        }
        [TestMethod]
        public void TestJoin1Count()
        {
            // Arrange
            List<string> petNames = controller.GetAllPetNamesOwnedByOwner("Marsha", "Downs");

            // Assert
            Assert.AreEqual(2, petNames.Count);
        }
        [TestMethod]
        public void TestJoin1Item1()
        {
            // Arrange
            List<string> petNames = controller.GetAllPetNamesOwnedByOwner("Marsha", "Downs");

            // Assert
            Assert.AreEqual("Fido", petNames[1]);
        }
        [TestMethod]
        public void TestJoin2Count()
        {
            // Arrange
            List<Treatment> treatments = controller.GetAllTreatmentsPaidByOwner("Richard", "James");

            // Assert
            Assert.AreEqual(4, treatments.Count);
        }
        [TestMethod]
        public void TestJoin2Item3()
        {
            // Arrange
            List<Treatment> treatments = controller.GetAllTreatmentsPaidByOwner("Richard", "James");

            // Assert
            Assert.AreEqual("7: Skin lnfection on 03-10-2014 00:00:00 costs 35", treatments[3].ToString());
        }
    }

}