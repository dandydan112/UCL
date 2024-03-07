using BonusApp;

namespace BonusAppUnitTest
{

    [TestClass]
    public class UnitTest1
    {
        Order order;

        [TestInitialize]
        public void InitializeTest()
        {
            order = new Order();
            
            order.AddProduct(new Product
            {
                Name = "Mælk",
                Value = 10.0,

                AvailableFrom = new DateTime(2018, 3, 1),

                AvailableTo = new DateTime(2018, 3, 5)
            });
            order.AddProduct(new Product
            {
                Name = "Smør",
                Value = 15.0,

                AvailableFrom = new DateTime(2018, 3, 3),

                AvailableTo = new DateTime(2018, 3, 4)
            });
            order.AddProduct(new Product
            {
                Name = "Pålæg",
                Value = 20.0,

                AvailableFrom = new DateTime(2018, 3, 4),

                AvailableTo = new DateTime(2018, 3, 7)
            });
        }
        [TestMethod]
        public void TenPercent_Test()
        {
            Assert.AreEqual(4.5, Bonuses.TenPercent(45.0));
            Assert.AreEqual(40.0, Bonuses.TenPercent(400.0));
        }
        [TestMethod]
        public void FlatTwoIfAMountMoreThanFive_Test()
        {
            Assert.AreEqual(2.0, Bonuses.FlatTwoIfAmountMoreThanFive(10.0));
            Assert.AreEqual(0.0, Bonuses.FlatTwoIfAmountMoreThanFive(4.0));
        }
        [TestMethod]
        public void GetValueOfProducts_Test()
        {
            Assert.AreEqual(45.0, order.GetValueOfProducts());
        }
        [TestMethod]
        public void GetBonus_Test()
        {
            order.Bonus = Bonuses.TenPercent;
            Assert.AreEqual(4.5, order.GetBonus());

            order.Bonus = Bonuses.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(2.0, order.GetBonus());
        }
        [TestMethod]
        public void GetTotalPrice_Test()
        {
            order.Bonus = Bonuses.TenPercent;
            Assert.AreEqual(40.5, order.GetTotalPrice());

            order.Bonus = Bonuses.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(43.0, order.GetTotalPrice());
        }

        [TestMethod]

        public void GetValueOfProductsByDate_Test()

        {

            Assert.AreEqual(0.0, order.GetValueOfProducts(new DateTime(2018, 2, 28)));

            Assert.AreEqual(10.0, order.GetValueOfProducts(new DateTime(2018, 3, 2)));

            Assert.AreEqual(25.0, order.GetValueOfProducts(new DateTime(2018, 3, 3)));

            Assert.AreEqual(45.0, order.GetValueOfProducts(new DateTime(2018, 3, 4)));

        }

        [TestMethod]

        public void SortByAvailableToTest()

        {

            List<Product> result = order.SortProductOrderByAvailableTo();

            Assert.AreEqual(3, result.Count);

            Assert.AreEqual("Smør", result[0].Name);

            Assert.AreEqual("Mælk", result[1].Name);

            Assert.AreEqual("Pålæg", result[2].Name);
        }

        [TestMethod]

        public void GetTotalPriceByDate_Test()

        {
            Func<double, double> bonus = price => price * 0.20;

            Assert.AreEqual(0.0, order.GetTotalPrice(new DateTime(2018, 2, 28),  bonus ));

            Assert.AreEqual(8.0, order.GetTotalPrice(new DateTime(2018, 3, 2), bonus));

            Assert.AreEqual(20.0, order.GetTotalPrice(new DateTime(2018, 3, 3),  bonus ));

            Assert.AreEqual(36.0, order.GetTotalPrice(new DateTime(2018, 3, 4),  bonus ));

        }

        [TestClass]
        public class OrderTests
        {
            private List<Product> _testProducts = new List<Product>
        {
            new Product { Name = "Product C", Value = 15.0, AvailableFrom = new DateTime(2022, 1, 1), AvailableTo = new DateTime(2022, 12, 31) },
            new Product { Name = "Product A", Value = 25.0, AvailableFrom = new DateTime(2022, 6, 1), AvailableTo = new DateTime(2023, 5, 30) },
            new Product { Name = "Product B", Value = 10.0, AvailableFrom = new DateTime(2021, 1, 1), AvailableTo = new DateTime(2021, 12, 31) }
        };

            [TestMethod]
            public void SortProductOrderBy_SortsByNameAscending()
            {
                // Arrange
                var order = new Order(_testProducts);

                // Act
                var sortedProducts = order.SortProductOrderBy(p => p.Name);

                // Assert
                Assert.AreEqual("Product A", sortedProducts[0].Name);
                Assert.AreEqual("Product B", sortedProducts[1].Name);
                Assert.AreEqual("Product C", sortedProducts[2].Name);
            }

            [TestMethod]
            public void SortProductOrderBy_SortsByValueAscending()
            {
                // Arrange
                var order = new Order(_testProducts);

                // Act
                var sortedProducts = order.SortProductOrderBy(p => p.Value);

                // Assert
                Assert.AreEqual(10.0, sortedProducts[0].Value);
                Assert.AreEqual(15.0, sortedProducts[1].Value);
                Assert.AreEqual(25.0, sortedProducts[2].Value);
            }

            [TestMethod]
            public void SortProductOrderBy_SortsByAvailableFromAscending()
            {
                // Arrange
                var order = new Order(_testProducts);

                // Act
                var sortedProducts = order.SortProductOrderBy(p => p.AvailableFrom);

                // Assert
                Assert.IsTrue(sortedProducts[0].AvailableFrom < sortedProducts[1].AvailableFrom);
                Assert.IsTrue(sortedProducts[1].AvailableFrom < sortedProducts[2].AvailableFrom);
            }

            [TestMethod]
            public void SortProductOrderBy_SortsByAvailableToAscending()
            {
                // Arrange
                var order = new Order(_testProducts);

                // Act
                var sortedProducts = order.SortProductOrderBy(p => p.AvailableTo);

                // Assert
                Assert.IsTrue(sortedProducts[0].AvailableTo < sortedProducts[1].AvailableTo);
                Assert.IsTrue(sortedProducts[1].AvailableTo <= sortedProducts[2].AvailableTo);
            }
        }
    }
}