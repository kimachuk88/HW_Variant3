using System;
using System.IO;
using System.Windows.Forms;
using HW_Variant3;
using NUnit.Framework;


namespace UnitTestProject1
{
    [TestFixture]
    public class VerifyListLength
    {

        [Test]
        public void TestMethod1()
        {
            Buttons buttons = new Buttons();
            buttons.OpenFile();

            
            Assert.AreEqual(buttons.TestfoodProcessors.Count, 3);
            Assert.AreEqual(buttons.TestVacuumCleaners.Count, 2);
            Assert.AreEqual(buttons.TestWashingMashines.Count, 2);
                     

                 
           
            

        }
    }
}