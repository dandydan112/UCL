//using Disaheim;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using UtilityLib;

//namespace DisaheimTest
//{
//    [TestClass]
//    public class UnitTest4
//    {
//        Book b1, b2, b3;
//        Amulet a1, a2, a3;
//        Course c1, c2;

//        CourseRepository courses;
//        BookRepository books;
//        AmuletRepository amulets;

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

//            c1 = new Course("Eufori med røg");
//            c2 = new Course("Nuru Massage using Chia Oil", 157);

//            courses = new CourseRepository();
//            books = new BookRepository();
//            amulets = new AmuletRepository();

//            // Act
//            books.AddBook(b1);
//            books.AddBook(b2);
//            books.AddBook(b3);

//            amulets.AddAmulet(a1);
//            amulets.AddAmulet(a2);
//            amulets.AddAmulet(a3);

//            courses.AddCourse(c1);
//            courses.AddCourse(c2);
//        }

//        [TestMethod]
//        public void TestGetBook()
//        {
//            // Assert
//            Assert.AreEqual(b2, books.GetBook("2"));
//        }
//        [TestMethod]
//        public void TestGetAmulet()
//        {
//            // Assert
//            Assert.AreEqual(a3, amulets.GetAmulet("13"));
//        }
//        [TestMethod]
//        public void TestGetCourse()
//        {
//            // Assert
//            Assert.AreEqual(c1, courses.GetCourse("Eufori med røg"));
//        }
//        [TestMethod]
//        public void TestGetTotalValueForBook()
//        {
//            // Assert
//            Assert.AreEqual(123.55, books.GetTotalValue());
//        }
//        [TestMethod]
//        public void TestGetTotalValueForAmulet()
//        {
//            // Assert
//            Assert.AreEqual(60.0, amulets.GetTotalValue());
//        }
//        [TestMethod]
//        public void TestGetTotalValueForCourse()
//        {
//            // Assert
//            Assert.AreEqual(2625.0, courses.GetTotalValue());
//        }
//    }


//}
