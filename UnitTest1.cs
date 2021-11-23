using Microsoft.VisualStudio.TestTools.UnitTesting;
using P5;
using System;

namespace HypotenuseUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateHypotenuseTest1()
        {
            //Arrange 
            double expectedLength = 5;
            double actualLength;
            double length1 = 3;
            double length2 = 4;
            Hypotenuse nuse = new Hypotenuse(length1, length2);

            //Act 
            actualLength = nuse.CalculateHypotenuse(length1, length2);

            //Assert
            Assert.IsTrue((actualLength == expectedLength), "Length calculated incorrectly.");

        }

        [TestMethod]
        public void CalculateHypotenuseTest2()
        {
            //Arrange 
            double expectedLength = 20.4;
            double actualLength;
            double length1 = 20;
            double length2 = 4;
            Hypotenuse nuse = new Hypotenuse(length1, length2);

            //Act 
            actualLength = nuse.CalculateHypotenuse(length1, length2);

            //Assert
            Assert.IsTrue((actualLength == expectedLength), "Length calculated incorrectly.");

        }

        [TestMethod]
        public void CalculateHypotenuseTest3()
        {
            //Arrange 
            double expectedLength = 8.6;
            double actualLength;
            double length1 = 5;
            double length2 = 7;
            Hypotenuse nuse = new Hypotenuse(length1, length2);

            //Act 
            actualLength = nuse.CalculateHypotenuse(length1, length2);

            //Assert
            Assert.IsTrue((actualLength == expectedLength), "Length calculated incorrectly.");

        }
    }
}
