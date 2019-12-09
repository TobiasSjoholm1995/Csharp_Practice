using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestProject;

namespace UnitTestProject {
    /// <summary>
    /// This class use the Moq framework.
    /// 
    /// 
    /// Mock to control the execution of an object.
    /// An object under test may have dependencies on other (complex) objects. 
    /// To isolate the behavior of the object you want to replace the other 
    /// objects by mocks that simulate the behavior of the real objects.
    /// </summary>
    [TestClass]
    public class MockUnitTest {

        [TestMethod]
        public void MockSetupTest() {
            Mock<MyObject> o = new Mock<MyObject>(5);
            o.Setup(x => x.NotImplemented()).Returns(true);  //this Moq framework can only setup virtual methods.

            Assert.IsTrue(o.Object.NotImplemented());
        }

    }
}
