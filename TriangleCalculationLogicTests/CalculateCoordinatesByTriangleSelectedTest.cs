using System;
using Xunit;
using Moq;
using Calculation.BusinessLogic;

namespace TriangleCalculationLogicTests
{
    public class CalculateCoordinatesByTriangleSelectedTest
    {
        Mock<IImageGridDimensions> gridDimensions = new Mock<IImageGridDimensions>();
        Mock<ISelectedTriangleColumnAndRow> selectedTriangle = new Mock<ISelectedTriangleColumnAndRow>();
        CalculateCoordinatesByTriangleSelected calculateCoordinatesByTriangleSelected;

        [Fact]
        public void CalculateTriangleCoordinatesPositive()
        {
            gridDimensions.Setup(x => x.Height).Returns(() => 60);
            gridDimensions.Setup(x => x.Width).Returns(() => 60);
            gridDimensions.Setup(x => x.EachColumnSize).Returns(() => 10);
            selectedTriangle.Setup(x => x.Row).Returns(() => 'A');
            selectedTriangle.Setup(x => x.Column).Returns(() => 1);
     
            CombineCoordinates expectedResult = new CombineCoordinates();
            expectedResult.AddCoordinates(new Coordinates(0,10));
            expectedResult.AddCoordinates(new Coordinates(0, 0));
            expectedResult.AddCoordinates(new Coordinates(10, 0));
            calculateCoordinatesByTriangleSelected = new CalculateCoordinatesByTriangleSelected();
            var result = calculateCoordinatesByTriangleSelected.Calculate(selectedTriangle.Object, gridDimensions.Object);
            result.Equals(expectedResult);
            Assert.Equal(result.CoordinatesList.Count, expectedResult.CoordinatesList.Count);
        }

        [Fact]
        public void CalculateTriangleCoordinatesNegative()
        {
            gridDimensions.Setup(x => x.Height).Returns(() => 60);
            gridDimensions.Setup(x => x.Width).Returns(() => 60);
            gridDimensions.Setup(x => x.EachColumnSize).Returns(() => 10);
            selectedTriangle.Setup(x => x.Row).Returns(() => 'A');
            selectedTriangle.Setup(x => x.Column).Returns(() => 2);

            CombineCoordinates expectedResult = new CombineCoordinates();
            expectedResult.AddCoordinates(new Coordinates(0, 10));
            expectedResult.AddCoordinates(new Coordinates(0, 0));
            expectedResult.AddCoordinates(new Coordinates(10, 0));
            calculateCoordinatesByTriangleSelected = new CalculateCoordinatesByTriangleSelected();
            var result = calculateCoordinatesByTriangleSelected.Calculate(selectedTriangle.Object, gridDimensions.Object);
            Assert.NotSame(expectedResult, result);
        }
    }
}
