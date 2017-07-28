using Microsoft.VisualStudio.TestTools.UnitTesting;
using LightsNPApi.Models;
using Moq;

namespace LightsNPApi.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<TestLights> chk = new Mock<TestLights>();
            chk.Setup(x => x.checkLights()).Returns(true);

            ProcessLights obje = new ProcessLights();
            Assert.AreEqual(obje.insertLights(chk.Object), true);
        }
    }

    [TestClass]
    public class LightsUnitTest
    {
        [TestMethod]
        public void TestGetLights()
        {
            Mock<TestLights> chk = new Mock<TestLights>();
            chk.Setup(x => x.checkLights()).Returns(true);

            ProcessLights obje = new ProcessLights();
            Assert.AreEqual(obje.insertLights(chk.Object), true);
        }

        [TestMethod]
        public void TestGetLight()
        {
            Mock<TestLights> chk = new Mock<TestLights>();
            chk.Setup(x => x.checkLights()).Returns(true);

            ProcessLights obje = new ProcessLights();
            Assert.AreEqual(obje.insertLights(chk.Object), true);
        }
    }

    [TestClass]
    public class OplpcUnitTest
    {
        [TestMethod]
        public void TestOplpcLights()
        {
            Mock<TestLights> chk = new Mock<TestLights>();
            chk.Setup(x => x.checkLights()).Returns(true);

            ProcessLights obje = new ProcessLights();
            Assert.AreEqual(obje.insertLights(chk.Object), true);
        }
        public void TestOplpcsLight()
        {
            Mock<TestLights> chk = new Mock<TestLights>();
            chk.Setup(x => x.checkLights()).Returns(true);

            ProcessLights obje = new ProcessLights();
            Assert.AreEqual(obje.insertLights(chk.Object), true);
        }
    }
}
