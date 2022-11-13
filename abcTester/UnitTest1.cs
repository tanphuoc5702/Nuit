using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using abcTOR;

namespace abcTester
{
    [TestClass]
    public class UnitTest1
    {
        private abcTion c;
        public TestContext TestContext { get; set; }
        [TestInitialize] // thiết lập khởi tạo dùng chung 
        public void setup()
        {
            c = new abcTion(7, 5);
        }
        [TestMethod] //testcase1
        public void TestAdd()
        {
            int expected, actual;
            //abcTion c = new abcTion(7, 5);
            expected = 12;
            actual = c.Exectute("+");
            Assert.AreEqual(expected, actual);
        }
        //testcase input : a =7 , b = 5
        [TestMethod] //testcase2
        public void TestSub()
        {
            int expected, actual;
            //abcTion c = new abcTion(7, 5);
            expected = 2;
            actual = c.Exectute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //testcase3
        public void TestMul()
        {
            int expected, actual;
            //abcTion c = new abcTion(7, 5);
            expected = 35;
            actual = c.Exectute("*");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //testcase4
        public void TestDiv()
        {
            int expected, actual;
            //abcTion c = new abcTion(7, 5);
            expected = 1;
            actual = c.Exectute("/");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod] //testcase5
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            c = new abcTion(3, 0);
            c.Exectute("/");
        }

        //Lk testdataa vs project 
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestDataa.txt", "TestDataa#txt", DataAccessMethod.Sequential)]
        public void TestWithDataaSourceAdd()
        {
            int a, b, expected, actual;
            a = Int32.Parse(TestContext.DataRow[0].ToString());
            b = Int32.Parse(TestContext.DataRow[1].ToString());
            expected = Int32.Parse(TestContext.DataRow[2].ToString());
            c = new abcTion(a, b);
            actual = c.Exectute("+");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestDataa1.txt", "TestDataa1#txt", DataAccessMethod.Sequential)]
        public void TestWithDataaSourceSub()
        {
            int a, b, expected, actual;
            a = Int32.Parse(TestContext.DataRow[0].ToString());
            b = Int32.Parse(TestContext.DataRow[1].ToString());
            expected = Int32.Parse(TestContext.DataRow[2].ToString());
            c = new abcTion(a, b);
            actual = c.Exectute("-");
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestDataaOperation.txt", "TestDataaOperation#txt", DataAccessMethod.Sequential)]
        public void TestWithOperation()
        {
            int a, b, expected,actual;
            string pheptoan;
            a = Int32.Parse(TestContext.DataRow[0].ToString());
            b = Int32.Parse(TestContext.DataRow[1].ToString());
            pheptoan = TestContext.DataRow[2].ToString();
            pheptoan = pheptoan.Remove(0, 1);
            expected = Int32.Parse(TestContext.DataRow[3].ToString());
            c = new abcTion(a, b);
            actual = c.Exectute(pheptoan);
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\TestDataPower.csv", "TestDataPower#csv",DataAccessMethod.Sequential)]
        public void TestPower()
        {
            double x, expected, actual;
            int n;
            x = Double.Parse(TestContext.DataRow[0].ToString());
            n = Int32.Parse(TestContext.DataRow[1].ToString());
            expected = Double.Parse(TestContext.DataRow[2].ToString());
            actual = abcTion.Power(x, n);
            Assert.AreEqual(expected, actual);
        }

    }

}
