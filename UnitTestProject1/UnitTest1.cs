using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Senasa.Curso.Biblioteca;

namespace UnitTestProject1 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestMethod1() {
            Assert.IsTrue("aaaaa".MaxLen(10));
            Assert.IsTrue("".MaxLen(10));
            Assert.IsFalse("12345678901".MaxLen(10));
        }
    }
}
