using System;
using System.IO;
using System.Windows.Forms;
using HW_Variant3;
using NUnit.Framework;


namespace UnitTestProject1
{
    [TestFixture]
    public class PriceViolation
    {
        [Test]
        public void TestMethod3()
        {
            Buttons buttons = new Buttons();
            buttons.OpenFile();

            foreach (var item in buttons.TestfoodProcessors)
            {
                Assert.LessOrEqual(item.Price, 4499);
                Assert.GreaterOrEqual(item.Price, 2999);
            }

            foreach (var item in buttons.TestVacuumCleaners) 
            {
                    Assert.LessOrEqual(item.Price, 6399);
                    Assert.GreaterOrEqual(item.Price, 3544);
            }

            foreach (var item in buttons.TestWashingMashines)
            {
                Assert.LessOrEqual(item.Price, 8999);
                Assert.GreaterOrEqual(item.Price, 7379);
            }
           
        }

    }

}
