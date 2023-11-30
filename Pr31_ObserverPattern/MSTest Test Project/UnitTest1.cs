using Pr32_ObserverPattern;
namespace MSTest_Test_Project

{
    [TestClass]
    public class UnitTest1
    {
        ConcreteSubject cSubject;
        ConcreteObserver cObserver1, cObserver2, cObserver3;

        [TestInitialize]
        public void Initialize()
        {
            cSubject = new ConcreteSubject();

            cObserver1 = new ConcreteObserver(cSubject);
            cObserver2 = new ConcreteObserver(cSubject);
            cObserver3 = new ConcreteObserver(cSubject);

            cSubject.Attach(cObserver1);
            cSubject.Attach(cObserver2);
            cSubject.Attach(cObserver3);
        }

        [TestMethod]
        public void TestObserverPattern()
        {
            cSubject.State = 1;
            Assert.AreEqual(1, cObserver1.State);
            Assert.AreEqual(1, cObserver2.State);
            Assert.AreEqual(1, cObserver3.State);

            cSubject.State = 25;
            Assert.AreEqual(25, cObserver1.State);
            Assert.AreEqual(25, cObserver2.State);
            Assert.AreEqual(25, cObserver3.State);

            cSubject.Detach(cObserver2);
            cSubject.State = 42;
            Assert.AreEqual(42, cObserver1.State);
            Assert.AreEqual(25, cObserver2.State);
            Assert.AreEqual(42, cObserver3.State);
        }
    }

}