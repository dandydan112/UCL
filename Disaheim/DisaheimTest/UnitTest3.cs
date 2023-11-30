//using Microsoft.VisualStudio.TestTools.UnitTesting;

//using Disaheim;
//using UtilityLib;

//namespace DisaheimTest

//{

//    [TestClass]
//    public class UnitTest3
//    {
//        Book b1, b2, b3;
//        Amulet a1, a2, a3;
//        Course c1, c2, c3;

//        Controller controller;

//        [TestInitialize]
//        public void Init()
//        {
//            // Arrange

//            b1 = new Book("1");
//            b2 = new Book("2", "Falling in Love with Yourself");
//            b3 = new Book("3", "Spirits in the Night", 123.55);

//            a1 = new Amulet("11");
//            a2 = new Amulet("12", Level.high);
//            a3 = new Amulet("13", Level.low, "Capricorn");

//            c1 = new Course("Spådomskunst for nybegyndere");

//            c2 = new Course("Magi – når videnskaben stopper", 157);

//            c3 = new Course("Et indblik i Helleristning", 180);

//            controller = new Controller();

//            controller.AddToList(b1);
//            controller.AddToList(b2);
//            controller.AddToList(b3);

//            controller.AddToList(a1);
//            controller.AddToList(a2);
//            controller.AddToList(a3);

//            controller.AddToList(c1);

//            controller.AddToList(c2);

//            controller.AddToList(c3);
//        }

//        [TestMethod]
//        public void TestBookList()
//        {
//            // Assert
//            Assert.AreEqual(b3, controller.Books[2]);
//        }

//        [TestMethod]
//        public void TestAmuletList()
//        {
//            // Assert
//            Assert.AreEqual(a1, controller.Amulets[0]);
//        }

//        [TestMethod]

//        public void TestCourseList()

//        {

//            // Assert

//            Assert.AreEqual(c1, controller.Courses[0]);

//            Assert.AreEqual(c2, controller.Courses[1]);

//            Assert.AreEqual(c3, controller.Courses[2]);

//        }

//    }


//}