using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HNPower;
namespace HNPowerTest
{
    [TestClass]
    public class UnitTest1
    {
        /*
        * Test case: 01
        * Input: input = 0
        * Expected result:"Error! Invalid input";
        */
        [TestMethod]
        public void TC1()
        {
            string input = "0";
            var output = "Error! Invalid input";
            ThapHN hn = new ThapHN(input);
            Assert.AreEqual(output, hn.StringOutput);
        }

        /*
      * Test case: 02
      * Input: input is positive integer (> 0)
      * Expected result: num of steps to move disk
      */

        [TestMethod]
        public void TC2()
        {
            string input = "4";
            var output = 15;
            ThapHN hn = new ThapHN(input);
            Assert.AreEqual(output, hn.NumOfMove);
        }
            /*
        * Test case: 03
        * Input: input is negative integer ( < 0)
        * Expected result: "Error! Invalid input";
        */

        [TestMethod]
        public void TC3()
        {
            string input = "-4";
            var output = "Error! Invalid input";
            ThapHN hn = new ThapHN(input);
            Assert.AreEqual(output, hn.StringOutput);
        }

        /*
        * Test case: 04
        * Input: input  = 1 
        * Expected result: num of move  = 1;
        */

        [TestMethod]
        public void TC4()
        {
            string input = "1";
            var output = 1;
            ThapHN hn = new ThapHN(input);
            Assert.AreEqual(output, hn.NumOfMove);
        }
        /*
        * Test case: 05
        * Input: input  = 1 
        * Expected result: Path throght Nodes: ADC;
        */

        [TestMethod]
        public void TC5()
        {
            string input = "1";
            var output = "ADEC";
            ThapHN hn = new ThapHN(input);
            Assert.AreEqual(output, hn.NodePath);
        }

        /*
        * Test case: 06
        * Input: input  < 1  
        * Expected result: Path throght Nodes: ABC;
        */

        [TestMethod]
        public void TC6()
        {
            string input = "-10";
            var output = "ABC";
            ThapHN hn = new ThapHN(input);
            Assert.AreEqual(output, hn.NodePath);
        }

        /*
       * Test case: 07
       * Input: input in (0,1]
       * Expected result: "Error! Invalid input";
       */

        [TestMethod]
        public void TC7()
        {
            string input = "1.5";
            var output = "Error! Invalid input";
            ThapHN hn = new ThapHN(input);
            Assert.AreEqual(output, hn.StringOutput);
        }
        /*
       * Test case: 08
       * Input: input integer in (1,15)
       * Expected result: ;
       */

        [TestMethod]
        public void TC8()
        {
            string input = "14";
            var output = 16383;
            ThapHN hn = new ThapHN(input);
            Assert.AreEqual(output, hn.NumOfMove);
        }

        /*
       * Test case: 09
       * Input: input is character
       * Expected result:"Error! Invalid input" ;
       */

        [TestMethod]
        public void TC9()
        {
            string input = "abc";
            var output = "Error! Invalid input";
            ThapHN hn = new ThapHN(input);
            Assert.AreEqual(output, hn.StringOutput);
        }

        /*
     * Test case: 10
     * Input: input = 15
     * Expected result:"Error! Invalid input" ;
     */

        [TestMethod]
        public void TC10()
        {
            string input = "15";
            var output = "Error! Invalid input";
            ThapHN hn = new ThapHN(input);
            Assert.AreEqual(output, hn.StringOutput);
        }

        /*
    * Test case: 11
    * Input: input > 15
    * Expected result:"Error! Invalid input" ;
    */

        [TestMethod]
        public void TC11()
        {
            string input = "19";
            var output = "Error! Invalid input";
            ThapHN hn = new ThapHN(input);
            Assert.AreEqual(output, hn.StringOutput);
        }

        /* 
         * Test case: 12 - no loop
         * Expected result: "ABC"
         */
        [TestMethod]
        public void TC12()
        {
            string input = "0";
            var output = "ABC";
            ThapHN hn = new ThapHN(input);
            Assert.AreEqual(output, hn.NodePath);
        }

        /* 
         * Test case: 13 - 1 loop
         * Expected result: "ADEC"
         */
        [TestMethod]
        public void TC13()
        {
            string input = "1";
            var output = "ADEC";
            ThapHN hn = new ThapHN(input);
            Assert.AreEqual(output, hn.NodePath);
        }

        /* 
         * Test case: 14 - 2 loops
         * Expected result: "ADDEEDEC"
         */
        [TestMethod]
        public void TC14()
        {
            string input = "2";
            var output = "ADDEEDEC";
            ThapHN hn = new ThapHN(input);
            Assert.AreEqual(output, hn.NodePath);
        }

        /* 
         * Test case: 15 - more loops : 3 loops
         * Expected result: "ADDDEEDEEDDEEDEC"
         */
        [TestMethod]
        public void TC15()
        {
            string input = "3";
            var output = "ADDDEEDEEDDEEDEC";
            ThapHN hn = new ThapHN(input);
            Assert.AreEqual(output, hn.NodePath);
        }
    }
}
