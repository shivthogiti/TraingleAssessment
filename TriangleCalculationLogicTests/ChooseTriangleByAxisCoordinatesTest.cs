using System;
using Xunit;
using Moq;
using Calculation.BusinessLogic;


namespace TriangleCalculationLogicTests
{
    public class ChooseTriangleByAxisCoordinatesTest
    {
        Mock<IImageGridDimensions> gridDimensions = new Mock<IImageGridDimensions>();
        CombineAxisCoordinatesForTriangle combineAxisCoordinates = new CombineAxisCoordinatesForTriangle();
        ChooseTriangleByAxisCoordinates chooseTriangleByAxisCoordinates;
        
        [Fact]
        public void LeftXAndAngleXPositiveTest()
        {
            gridDimensions.Setup(x => x.Height).Returns(() => 60);
            gridDimensions.Setup(x => x.Width).Returns(() => 60);
            gridDimensions.Setup(x => x.EachColumnSize).Returns(() => 10);

            combineAxisCoordinates.AddLeftCoordinates(new Coordinates(0, 10));
            combineAxisCoordinates.AddAngleCoordinates(new Coordinates(0, 0));
            combineAxisCoordinates.AddRightCoordinates(new Coordinates(10,0));

            SelectedTriangleColumnAndRow expectedresult = new SelectedTriangleColumnAndRow('A',1);

            chooseTriangleByAxisCoordinates = new ChooseTriangleByAxisCoordinates();
            var result = chooseTriangleByAxisCoordinates.GetTriangle(combineAxisCoordinates, gridDimensions.Object); ;
            Assert.Equal(expectedresult.Row, result.Row);
            Assert.Equal(expectedresult.Column, result.Column);
        }

        [Fact]
        public void LeftXAndAngleXNegativeTest()
        {
            gridDimensions.Setup(x => x.Height).Returns(() => 60);
            gridDimensions.Setup(x => x.Width).Returns(() => 60);
            gridDimensions.Setup(x => x.EachColumnSize).Returns(() => 10);

            combineAxisCoordinates.AddLeftCoordinates(new Coordinates(0, 10));
            combineAxisCoordinates.AddAngleCoordinates(new Coordinates(0, 0));
            combineAxisCoordinates.AddRightCoordinates(new Coordinates(10, 0));

            SelectedTriangleColumnAndRow expectedresult = new SelectedTriangleColumnAndRow('B', 3);

            chooseTriangleByAxisCoordinates = new ChooseTriangleByAxisCoordinates();
            var result = chooseTriangleByAxisCoordinates.GetTriangle(combineAxisCoordinates, gridDimensions.Object); ;
            Assert.NotEqual(expectedresult.Row, result.Row);
            Assert.NotEqual(expectedresult.Column, result.Column);
        }

        [Fact]
        public void RightXAndAngleXPositiveTest()
        {
            gridDimensions.Setup(x => x.Height).Returns(() => 60);
            gridDimensions.Setup(x => x.Width).Returns(() => 60);
            gridDimensions.Setup(x => x.EachColumnSize).Returns(() => 10);

            combineAxisCoordinates.AddLeftCoordinates(new Coordinates(10, 10));
            combineAxisCoordinates.AddAngleCoordinates(new Coordinates(20, 10));
            combineAxisCoordinates.AddRightCoordinates(new Coordinates(20, 0));

            SelectedTriangleColumnAndRow expectedresult = new SelectedTriangleColumnAndRow('A', 4);

            chooseTriangleByAxisCoordinates = new ChooseTriangleByAxisCoordinates();
            var result = chooseTriangleByAxisCoordinates.GetTriangle(combineAxisCoordinates, gridDimensions.Object); ;
            Assert.Equal(expectedresult.Row, result.Row);
            Assert.Equal(expectedresult.Column, result.Column);
        }

        [Fact]
        public void RightXAndAngleXNegativeTest()
        {
            gridDimensions.Setup(x => x.Height).Returns(() => 60);
            gridDimensions.Setup(x => x.Width).Returns(() => 60);
            gridDimensions.Setup(x => x.EachColumnSize).Returns(() => 10);

            combineAxisCoordinates.AddLeftCoordinates(new Coordinates(10, 10));
            combineAxisCoordinates.AddAngleCoordinates(new Coordinates(20, 10));
            combineAxisCoordinates.AddRightCoordinates(new Coordinates(20, 0));

            SelectedTriangleColumnAndRow expectedresult = new SelectedTriangleColumnAndRow('B', 3);

            chooseTriangleByAxisCoordinates = new ChooseTriangleByAxisCoordinates();
            var result = chooseTriangleByAxisCoordinates.GetTriangle(combineAxisCoordinates, gridDimensions.Object); ;
            Assert.NotEqual(expectedresult.Row, result.Row);
            Assert.NotEqual(expectedresult.Column, result.Column);
        }

    }
}
