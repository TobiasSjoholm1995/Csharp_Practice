using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TestProject;

namespace UnitTestProject {

    [TestClass]
    public class DataDrivenTest {

        /// Data driven test, test same method with different values.
        /// This method will run 3 times, with parameter 1, 2 and 3
        [DataTestMethod]
        [DataRow(1, 1)]  
        [DataRow(2, 2)]
        [DataRow(3, 3)]
        public void IsValueSubset(int value, int expected) {  
            MyObject o = new MyObject(value);

            Assert.AreEqual(expected, o.Value);
        }



        /// Same as above, but dynamic bind to data

        public static IEnumerable<object[]> Data() {
            yield return new object[] { 1, 1 };
            yield return new object[] { 2, 2 };
            yield return new object[] { 3, 3 };
        }

        [DataTestMethod]
        [DynamicData(nameof(Data), DynamicDataSourceType.Method)]
        public void TestAddDynamicDataMethod(int value, int expected) {
            MyObject o = new MyObject(value);

            Assert.AreEqual(expected, o.Value);
        }

    }
}
