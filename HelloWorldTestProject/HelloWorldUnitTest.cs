using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldTestProject
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void helloWorldToConsoleTestMethod()
        {
            // Arrange
            string expectedResult = "Hello World";
            //Act
            string result = Comp123-S2016lesson1.Program.HelloWorldToConsole();

            //Asert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
