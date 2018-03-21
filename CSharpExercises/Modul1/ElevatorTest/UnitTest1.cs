using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modul7;

namespace ElevatorTest
{
    [TestClass]
    public class UnitTest1
    {
        private string name = "Ida";
        private int highestFloor = 10;
        private int lowestFloor = 0;
        private int currentFloor = 8;
        private int usedTime = 2;

        [TestMethod]
        public void GoUpTest()
        {
            var e1 = new Elevator(highestFloor, lowestFloor, currentFloor, name, usedTime);
            e1.GoUp();
            Assert.AreEqual(9, e1.CurrentFloor);

        }

        [TestMethod]
        public void GoToTopFloor()
        {
            var e1 = new Elevator(highestFloor, lowestFloor, currentFloor, name, usedTime);
            for (int i = 0; i < 5; i++)
            {
                e1.GoUp();
            }
          
            Assert.AreEqual(2, e1.CurrentFloor);

        }
    }
}
