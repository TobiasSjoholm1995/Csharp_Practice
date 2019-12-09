using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject;
using System.Reflection;

namespace UnitTestProject {

    [TestClass]
    public class PrivateMethodTest {

        /// <summary>
        /// Test of private method through reflection
        /// Normally Unit Tests are for the public API and not private methods
        /// </summary>
        [TestMethod]
        public void TestOfPrivateMethod() {
            MyObject o = new MyObject(5);
            MethodInfo methodInfo = typeof(MyObject).GetMethod("myPrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { 4 };
            int returnValue = (int)methodInfo.Invoke(o, parameters);
            Assert.IsTrue(returnValue == 4);
        }
    }
}
