using Calculation.BusinessLogic;
using Moq;
using NUnit.Framework;

namespace TriangleCalculation.BusinessLogic.Tests
{
    public class CalculateCoordinatesByTriangleSelectedTest
    {
       private Mock<ImageGridDimensions> gridDimensions;
        private Mock<SelectedTriangleColumnAndRow> selectedTriangle;

        [Test]
        public void CalculateTest()
        {
            
            Assert.AreEqual("","");
        }
    }
}