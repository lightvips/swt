using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HNPower;
namespace HaNoiPower
{
    [TestClass]
    public class UnitTest1
    {
         //Black Box 
         //   input = 5
         //   Output (Number of Move disk) = 31

        [TestMethod]
        public void TC1()
        {
            string num = "5";
            var output = 31;
            ThapHN hn = new ThapHN(num);
            Assert.AreEqual(output, hn.NumOfMove);
        }
        //White Box 
        //   input = 5
        //   Output = ADDDDDEEDEEDDEEDEEDDDEEDEEDDEEDEEDDDDEEDEEDDEEDEEDDDEEDEEDDEEDEC

        [TestMethod]
        public void TC2()
        {
            string num = "5";
            var output = "ADDDDDEEDEEDDEEDEEDDDEEDEEDDEEDEEDDDDEEDEEDDEEDEEDDDEEDEEDDEEDEC";
            ThapHN hn = new ThapHN(num);
            Assert.AreEqual(output, hn.NodePath);
        }
    }
}
