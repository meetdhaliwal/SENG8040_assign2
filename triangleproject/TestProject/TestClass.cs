using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using triangleproject;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    class TestClass
    {
  
        [Test]
        public void Analyze_inputside1as2side2as2andside3as2_expectedoutputEqualsequilateral()
        {
            //Arrange
            int side1 =2;
            int side2 =2;
            int side3 =2;

            bool expectedResult =(side1 == side2 && side2 == side3);

            //Act
            string actualResult = TriangleSolver.Analyze(side1,side2,side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_inputside1as1000side2as1000andside3as1000_expectedoutputEqualsequilateral()
        {
            //Arrange
            int side1 = 1000;
            int side2 = 1000;
            int side3 = 1000;

            bool expectedResult = (side1 == side2 && side2 == side3);

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_inputside1as9side2as7andside3as9_expectedoutputEqualsisoceles()
        {
            //Arrange
            int side1 = 9;
            int side2 = 7;
            int side3 = 9;

            bool expectedResult = (side1 == side2 || side2 == side3 || side1 == side3);

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_inputside1as85side2as95andside3as85_expectedoutputEqualsisoceles()
        {
            //Arrange
            int side1 = 85;
            int side2 = 95;
            int side3 = 85;

            bool expectedResult = (side1 == side2 || side2 == side3 || side1 == side3);

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_inputside1as1side2as2andside3as3_expectedoutputEqualsscalene()
        {
            //Arrange
            int side1 = 1;
            int side2 = 2;
            int side3 = 3;

            bool expectedResult = (side1 != side2 && side2 != side3 && side1 != side3);

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_inputside1as1001side2as1005andside3as1008_expectedoutputEqualsscalene()
        {
            //Arrange
            int side1 = 1001;
            int side2 = 1005;
            int side3 = 1008;

            bool expectedResult = (side1 != side2 && side2 != side3 && side1 != side3);

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_inputside1as1side2as99andside3as89_expectedoutputEqualsnotTriangle()
        {
            //Arrange
            int side1 = 1;
            int side2 = 99;
            int side3 = 89;

            bool expectedResult = (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2);

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Analyze_inputside1as10side2as123andside3as4_expectedoutputEqualsnotTriangle()
        {
            //Arrange
            int side1 = 10;
            int side2 = 123;
            int side3 = 4;

             bool expectedResult = (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2);

            //Act
            string actualResult = TriangleSolver.Analyze(side1, side2, side3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
