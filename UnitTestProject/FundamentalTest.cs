using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject;

namespace UnitTestProject {
    /// <summary>
    /// This is the default unit testing framework in Visual Studio, called MSTest
    /// Common unit testing frameworks:  MSTest, xUnit, or NUnit
    /// </summary>
    [TestClass]
    public class FundamentalTest {

        [TestMethod]
        public void IsValueSubset() {
            MyObject o = new MyObject(5);

            Assert.IsFalse(o.IsValueSubset(1, 2, 3));
        }

        [TestMethod]
        public void IsValueSubset2() {
            MyObject o = new MyObject(5);

            Assert.IsTrue(o.IsValueSubset(1, 2, 5));
        }

    }
}
