using Disaheim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisaheimTest
{
    [TestClass]
    public class UnitTest5
    {
        Book b1, b2, b3;
        Amulet a1, a2, a3;
        Course c1, c2, c3;
        ValuableRepository repo;

        [TestInitialize]
        public void Init()
        {
            // Arrange

            repo = new ValuableRepository();

            b1 = new Book("1");
            b2 = new Book("2", "Falling in Love with Yourself");
            b3 = new Book("3", "Spirits in the Night", 123.55);
            repo.AddValuable(b1);
            repo.AddValuable(b2);
            repo.AddValuable(b3);


            a1 = new Amulet("11");
            a2 = new Amulet("12", Level.high);
            a3 = new Amulet("13", Level.low, "Capricorn");
            repo.AddValuable(a1);
            repo.AddValuable(a2);
            repo.AddValuable(a3);

            c1 = new Course("Spådomskunst for nybegyndere");
            c2 = new Course("Magi – når videnskaben stopper", 157);
            c3 = new Course("Et indblik i Helleristning", 180);
            repo.AddValuable(c1);
            repo.AddValuable(c2);
            repo.AddValuable(c3);
        }

        [TestMethod]
        public void BookConstructorWithOneParameter()
        {
            // Assert
            Assert.AreEqual("ItemId: 1, Title: , Price: 0", b1.ToString());
        }
        [TestMethod]
        public void BookConstructorWithTwoParameters()
        {
            // Assert
            Assert.AreEqual("ItemId: 2, Title: Falling in Love with Yourself, Price: 0", b2.ToString());
        }
        [TestMethod]
        public void BookConstructorWithThreeParameters()
        {
            // Assert
            Assert.AreEqual("ItemId: 3, Title: Spirits in the Night, Price: 123.55", b3.ToString());
        }

        [TestMethod]
        public void AmuletConstructorWithOneParameter()
        {
            // Assert
            Assert.AreEqual("ItemId: 11, Quality: medium, Design: ", a1.ToString());
        }
        [TestMethod]
        public void AmuletConstructorWithTwoParameters()
        {
            // Assert
            Assert.AreEqual("ItemId: 12, Quality: high, Design: ", a2.ToString());
        }
        [TestMethod]
        public void AmuletConstructorWithThreeParameters()
        {
            // Assert
            Assert.AreEqual("ItemId: 13, Quality: low, Design: Capricorn", a3.ToString());
        }

        [TestMethod]
        public void CourseConstructorWithOneParameter()
        {
            // Assert
            Assert.AreEqual("Name: Spådomskunst for nybegyndere, Duration in Minutes: 0, Value: 0", c1.ToString());
        }
        [TestMethod]
        public void CourseConstructorWithTwoParameters()
        {
            // Act
            Course.CourseHourValue = 1100;

            // Assert
            Assert.AreEqual("Name: Magi – når videnskaben stopper, Duration in Minutes: 157, Value: 3300", c2.ToString());
        }
        [TestMethod]
        public void CourseConstructorWithTwoParameters2()
        {
            // Act
            Course.CourseHourValue = 875;

            // Assert
            Assert.AreEqual("Name: Et indblik i Helleristning, Duration in Minutes: 180, Value: 2625", c3.ToString());
        }
        [TestMethod]
        public void AmuletSetPropertiesWorks()
        {
            // Act
            a3.ItemId = "X";
            a3.Quality = Level.high;
            a3.Design = "Dolphin";

            // Assert
            Assert.AreEqual("ItemId: X, Quality: high, Design: Dolphin", a3.ToString());
        }
        [TestMethod]
        public void BookSetPropertiesWorks()
        {
            // Act
            b3.ItemId = "Y";
            b3.Title = "Smoke on the Water";
            b3.Price = 376.45;

            // Assert
            Assert.AreEqual("ItemId: Y, Title: Smoke on the Water, Price: 376.45", b3.ToString());
        }
        [TestMethod]
        public void CourseSetPropertiesWorks()
        {
            // Act
            c2.Name = "How to Ying-Yang";
            c2.DurationInMinutes = 413;

            // Assert
            Assert.AreEqual("Name: How to Ying-Yang, Duration in Minutes: 413, Value: 6125", c2.ToString());
        }

        [TestMethod]
        public void TestGetValueForBook1()
        {
            // Assert
            Assert.AreEqual(b1.GetValue(), 0.0);
        }
        [TestMethod]
        public void TestGetValueForBook2()
        {
            // Assert
            Assert.AreEqual(b2.GetValue(), 0.0);
        }
        [TestMethod]
        public void TestGetValueForBook3()
        {
            // Assert
            Assert.AreEqual(b3.GetValue(), 123.55);
        }

        [TestMethod]
        public void TestGetValueForAmulet1()
        {
            // Assert
            Assert.AreEqual(20.0, a1.GetValue());
        }
        [TestMethod]
        public void TestGetValueForAmulet2()
        {
            // Assert
            Assert.AreEqual(27.5, a2.GetValue());
        }
        [TestMethod]
        public void TestGetValueForAmulet3()
        {
            // Assert
            Assert.AreEqual(12.5, a3.GetValue());
        }

        [TestMethod]
        public void TestGetValueForCourse1()
        {
            // Assert
            Assert.AreEqual(0.0, c1.GetValue());
        }
        [TestMethod]
        public void TestGetValueForCourse2()
        {
            // Act
            Course.CourseHourValue = 1100;

            // Assert
            Assert.AreEqual(3300.0, c2.GetValue());
        }
        [TestMethod]
        public void TestGetValueForCourse3()
        {
            // Act
            Course.CourseHourValue = 875;

            // Assert
            Assert.AreEqual(2625.0, c3.GetValue());
        }

        [TestMethod]
        public void TestValuableRepositoryCount()
        {
            // Assert
            Assert.AreEqual(9, repo.Count());
        }
        [TestMethod]
        public void TestValuableRepositoryCount2()
        {
            // Act
            Book dummy = new Book("Dummy");
            repo.AddValuable(dummy);

            // Assert
            Assert.AreEqual(10, repo.Count());
        }
        [TestMethod]
        public void TestValuableRepositoryGetValuable()
        {
            // Act
            Book dummy2 = new Book("Dummy 2");
            repo.AddValuable(dummy2);
            Book result = (Book)repo.GetValuable("Dummy 2");

            // Assert
            Assert.AreEqual(dummy2, result);
        }
        [TestMethod]
        public void TestValuableRepositoryGetTotalValue()
        {
            // Act
            Course.CourseHourValue = 875;

            // Assert
            Assert.AreEqual(5433.55, repo.GetTotalValue());
        }
    }


}
