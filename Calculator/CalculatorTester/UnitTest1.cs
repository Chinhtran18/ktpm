using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Calculation c;
        [TestInitialize] // thiet lap du lieu dung chung cho TC
        public void SetUp()
        {
            c = new Calculation(10, 5);
        }
        [TestMethod]  //TC1: a =10, b = 5, kq= 15

        public void Test_Cong()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 15;
            actual = c.Execute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]  //TC2: a =10, b = 5, kq= 5

        public void Test_Tru()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 5;
            actual = c.Execute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]  //TC3: a =10, b = 5, kq= 50

        public void Test_Nhan()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 50;
            actual = c.Execute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]  //TC4: a =10, b = 5, kq= 2

        public void Test_Chia()
        {
            int expected, actual;
            // Caculation c = new Caculation(a,b);
            expected = 2;
            actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]  //TC5: a =10, b = 0,  kq mong muốn là xuất hiện ngoại lệ DivideByZeroException khi thực hiện phép chia cho 0

        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_ChiaZero()
        {
            c = new Calculation(10, 0);
            c.Execute("/");
        }

        public TestContext TestContext { get; set; }
        
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", 
            @".\Data\DataTestToanTu.csv", "DataTestToanTu#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestToanCong()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            string operation = TestContext.DataRow[2].ToString().Substring(1,1);
            int expected = int.Parse(TestContext.DataRow[3].ToString());

            Calculation c = new Calculation(a, b);
            int actual = c.Execute(operation);
            Assert.AreEqual(expected,actual);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TestData.csv", "TestData#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestToanTu()
        {
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            //string operation = TestContext.DataRow[2].ToString().Remove(0, 1);
            int expected = int.Parse(TestContext.DataRow[2].ToString());

            Calculation c = new Calculation(a, b);
            int actual = c.Execute("/");
            Assert.AreEqual(expected, actual);
        }
    }
}
