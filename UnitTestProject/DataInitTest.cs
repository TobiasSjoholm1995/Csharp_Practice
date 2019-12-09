using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject;


namespace UnitTestProject {

    [TestClass]
    public class DataInitTest {

        private MyObject o;


        // This execute before all tests in the project
        [AssemblyInitialize]
        public static void InitAssembly(TestContext tc) {
            System.Console.WriteLine("This execute as the assembly in init");
        }

        // This execute before all tests in the class
        [ClassInitialize]
        public static void InitClass(TestContext tc) {
            System.Console.WriteLine("This execute as the class in init");
        }

        // This execute before each test in the class
        [TestInitialize]
        public void InitTest() {
            o = new MyObject(6);
        }

        // This execute after each test in the class
        [TestCleanup]
        public void CleanupTest() {
            System.Console.WriteLine("This execute after any test");
        }


        [TestMethod]
        public void Test1() {
            Assert.AreEqual(6, o.Value);
        }


     


    }
}
