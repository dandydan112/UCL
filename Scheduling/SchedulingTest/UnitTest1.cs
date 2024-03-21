using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scheduling; 

namespace SchedulingTests
{
    [TestClass]
    public class PCBTests
    {
        [TestMethod]
        public void ToString_ReturnsCorrectFormat()
        {
            // Arrange - ops�t din test
            var pcb = new PCB("Sj�l�l�", 1, ProcessStateType.Ready);

            // Act - udf�r den handling, du vil teste
            var result = pcb.ToString();

            // Assert - bekr�ft at resultatet er som forventet
            Assert.AreEqual("Sj�l�l�(1)", result);
        }
    }
}