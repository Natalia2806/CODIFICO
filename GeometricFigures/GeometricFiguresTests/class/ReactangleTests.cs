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
    public class ReactangleTests
    {
        [TestMethod()]
        public void AreaReactangleTest()
        {
            try
            {
                //Arrenge
                double baseR = 4;
                double high = 9;
                double expected = 36;
                Reactangle AreaRectangle = new();

                //Act
                double actual = AreaRectangle.Rectangle(baseR, high);

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