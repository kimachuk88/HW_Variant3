using System;
using System.IO;
using System.Windows.Forms;
using HW_Variant3;
using NUnit.Framework;


namespace UnitTestProject1
{
    [TestFixture]
    public class Verify
    {
        
        [Test]
        public void TestMethod2()
        {
            
            Buttons buttons = new Buttons();
            buttons.OpenFile();
            int actualItemsInList = 0;
            actualItemsInList += buttons.TestfoodProcessors.Count;
            actualItemsInList += buttons.TestVacuumCleaners.Count;
            actualItemsInList += buttons.TestWashingMashines.Count;
            Assert.AreEqual(actualItemsInList, 7);
            
            
        }
    }
}
