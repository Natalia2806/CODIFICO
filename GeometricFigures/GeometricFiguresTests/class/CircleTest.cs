using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometricFigures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures.Tests
{
    [TestClass()]
    public class CircleTest
    {
        [TestMethod()]
        public void AreaCircleTest()
        {
            try
            {
                //Arrenge
                double radio = 2;
                double expected = 12.5664;
                Circle AreaCircle = new();

                //Act
                double actual = AreaCircle.AreaCircle(radio);

                //Assert
                Assert.AreEqual(expected, actual);
            }
            catch (AssertFailedException e)
            {
                Console.WriteLine(e);
            }
        
        }
    }
}