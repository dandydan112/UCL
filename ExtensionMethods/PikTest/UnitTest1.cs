using ExtensionMethods;
namespace PikTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Shift_ReturnsOriginalString_WhenAmountIsZero()
        {
            // Arrange
            string original = "This is my life";
            int amount = 0;

            // Act
            string shifted = original.Shift(amount);

            // Assert
            Assert.AreEqual("This is my life", shifted);
        }

        [TestMethod]
        public void Shift_ShiftsStringRight_WhenAmountIsPositive()
        {
            // Arrange
            string original = "This is my life";
            int amount = 1;

            // Act
            string shifted = original.Shift(amount);
            // Assert
            Assert.AreEqual("eThis is my lif", shifted);
        }

        [TestMethod]
        public void Shift_ShiftsStringLeft_WhenAmountIsNegative()
        {
            // Arrange
            string original = "This is my life";
            int amount = -1;

            // Act
            string shifted = original.Shift(amount);
            // Assert
            Assert.AreEqual("his is my lifeT", shifted);
        }

        [TestMethod]
        public void Shift_ShiftsStringLeft_WhenAmountIsPositiveAndWhitespaceIsTakenIntoAccount()
        {
            // Arrange
            string original = "This is my life";
            int amount = 5;

            // Act
            string shifted = original.Shift(amount);

            // Assert
            Assert.AreEqual(" lifeThis is my", shifted);
        }

        [TestMethod]
        public void Shift_ReturnOriginalString_WhenShiftingAmountEqualToStringLenth()
        {
            // Arrange
            string original = "This is my life";
            int amount = original.Length;

            // Act
            string shifted = original.Shift(amount);

            // Assert
            Assert.AreEqual("This is my life", shifted);
        }

        [TestMethod]
        public void Shift_ShiftStringCorrectlyLeft_WhenAmountIsGreaterThanStringLength()
        {
            // Arrange
            string original = "This is my life";
            int amount = 16;

            // Act
            string shifted = original.Shift(amount);

            // Assert
            Assert.AreEqual("eThis is my lif", shifted);
        }

        [TestMethod]
        public void Shift_ShiftStringCorrectlyRight_WhenAmountIsNegativeAndGreaterThanStringLength()
        {
            // Arrange
            string original = "This is my life";
            int amount = -16;

            // Act
            string shifted = original.Shift(amount);

            // Assert
            Assert.AreEqual("his is my lifeT", shifted);
        }

        [TestMethod]
        public void Shift_ReturnsEmptyString_WhenInputIsNull()
        {
            // Arrange
            string original = null;
            int amount = 3;

            // Act
            string shifted = original.Shift(amount);

            // Assert
            Assert.AreEqual("", shifted);
        }

        [TestMethod]

        public void PIKKEMAND()
        {
            //Arrange
            DateTime birth = new DateTime(2003, 3, 1);
            DateTime reference = new DateTime(2023, 3, 5);

            //Act
            int age = birth.Age(reference);

            //Assert
            Assert.AreEqual(20, age);
        }


        [TestMethod]

        public void PIKKEMAND2()
        {
            //Arrange
            DateTime birth = new DateTime(2023, 3, 1);
            DateTime reference = new DateTime(2003, 3, 5);

            //Act
            int age = birth.Age(reference);

            //Assert
            Assert.AreEqual(0, age);
        }


    }
}