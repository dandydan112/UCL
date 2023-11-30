//using System.Reflection.Emit;
//using Disaheim;
//using UtilityLib;

//namespace DisaheimTest
//{
//    [TestClass]
//    public class UnitTest1
//    {
//        Book b1, b2, b3;
//        Amulet a1, a2, a3;
//        Course c1, c2, c3;

//        [TestInitialize]
//        public void Init()
//        {
//            b1 = new Book("1");
//            b2 = new Book("2", "Falling in Love with Yourself");
//            b3 = new Book("3", "Spirits in the Night", 123.55);

//            a1 = new Amulet("11");
//            a2 = new Amulet("12", Level.high);
//            a3 = new Amulet("13", Level.low, "Capricorn");

//            c1 = new Course("Spådomskunst for nybegyndere");

//            c2 = new Course("Magi – når videnskaben stopper", 157);

//            c3 = new Course("Et indblik i Helleristning", 180);
//        }

//        [TestMethod]
//        public void BookConstructorWithOneParameter()
//        {
//            Assert.AreEqual("ItemId: 1, Title: , Price: 0", b1.ToString());
//        }
//        [TestMethod]
//        public void BookConstructorWithTwoParameters()
//        {
//            Assert.AreEqual("ItemId: 2, Title: Falling in Love with Yourself, Price: 0", b2.ToString());
//        }
//        [TestMethod]
//        public void BookConstructorWithThreeParameters()
//        {
//            Assert.AreEqual("ItemId: 3, Title: Spirits in the Night, Price: 123.55", b3.ToString());
//        }

//        [TestMethod]
//        public void AmuletConstructorWithOneParameter()
//        {
//            Assert.AreEqual("ItemId: 11, Quality: medium, Design: ", a1.ToString());
//        }
//        [TestMethod]
//        public void AmuletConstructorWithTwoParameters()
//        {
//            Assert.AreEqual("ItemId: 12, Quality: high, Design: ", a2.ToString());
//        }
//        [TestMethod]
//        public void AmuletConstructorWithThreeParameters()
//        {
//            Assert.AreEqual("ItemId: 13, Quality: low, Design: Capricorn", a3.ToString());
//        }
//        //[TestMethod]

//        ////public void MerchandiseConstructorWorkProperly()

//        ////{

//        //    // Arrange

//        //    Merchandise m = new Merchandise("100");

//        //    // Assert

//        //    Assert.AreEqual("ItemId: 100", m.ToString());

//        //}

//        [TestMethod]

//        public void CourseConstructorWithOneParameter()

//        {

//            // Assert

//            Assert.AreEqual("Name: Spådomskunst for nybegyndere, Duration in Minutes: 0", c1.ToString());

//        }

//        [TestMethod]

//        public void CourseConstructorWithTwoParameters1()

//        {

//            // Assert

//            Assert.AreEqual("Name: Magi – når videnskaben stopper, Duration in Minutes: 157", c2.ToString());

//        }

//        [TestMethod]

//        public void CourseConstructorWithTwoParameters2()

//        {

//            // Assert

//            Assert.AreEqual("Name: Et indblik i Helleristning, Duration in Minutes: 180", c3.ToString());

//        }

//        [TestMethod]

//        public void AmuletSetPropertiesWorks()

//        {

//            // Act

//            a3.ItemId = "X";

//            a3.Quality = Level.high;

//            a3.Design = "Dolphin";

//            // Assert

//            Assert.AreEqual("ItemId: X, Quality: high, Design: Dolphin", a3.ToString());

//        }

//        [TestMethod]

//        public void BookSetPropertiesWorks()

//        {

//            // Act

//            b3.ItemId = "Y";

//            b3.Title = "Smoke on the Water";

//            b3.Price = 376.45;

//            // Assert

//            Assert.AreEqual("ItemId: Y, Title: Smoke on the Water, Price: 376.45", b3.ToString());

//        }

//        [TestMethod]

//        public void CourseSetPropertiesWorks()

//        {

//            // Act

//            c2.Name = "How to Ying-Yang";

//            c2.DurationInMinutes = 413;

//            // Assert

//            Assert.AreEqual("Name: How to Ying-Yang, Duration in Minutes: 413", c2.ToString());

//        }



//    }


//}