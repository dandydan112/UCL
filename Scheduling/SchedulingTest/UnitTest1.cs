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
            // Arrange - opsæt din test
            var pcb = new PCB("Sjålålå", 1, ProcessStateType.Ready);

            // Act - udfør den handling, du vil teste
            var result = pcb.ToString();

            // Assert - bekræft at resultatet er som forventet
            Assert.AreEqual("Sjålålå(1)", result);
        }
    }
}