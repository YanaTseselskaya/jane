using Figures;
using Figures3D;
using System.Collections.Generic;
using Xunit;

namespace TestFigures
{
    public class FigureTest
    {
        [Fact]
        public void PerimeterTest()
        {
            //Arrange
            List<Point> vertices = new List<Point>()
            {
                new Point(3, 4, "Point 1"),
                new Point(15, 0, "Point 2"),
                new Point(26, 7, "Point 3"),
                new Point(8, -9, "Point 4")
            };
            var polygon = new Polygon(vertices);
            //Act
            double perimeter = polygon.Perimeter(vertices.ToArray());
            //Assert
            Assert.Equal(64, perimeter,0);//63.69909288584753
        }
        [Fact]
        public void VolumeBoxTest()
        {
            //Arrange
            var box = new Box(15);
            //Act
            double ResultVolumeBox = box.Volume();
            //Assert
            Assert.Equal(3375, ResultVolumeBox);
        }
        [Fact]
        public void VolumeCylinderText()
        {
            var cylinder = new Cylinder(10, 5);
            double ResultVolumeCylinder = cylinder.Volume();
            Assert.Equal(1571, ResultVolumeCylinder, 0);
        }
        [Fact]
        public void VolumePyramidText()
        {
            var pyramid = new Pyramid(3, 4, 6);
            double ResultVolumePyramid = pyramid.Volume();
            Assert.Equal(11, ResultVolumePyramid, 0);
        }
        [Fact]
        public void VolumeBallText()
        {
            var ball = new Ball(7, 4);
            double ResultVolumeBall = ball.Volume();
            Assert.Equal(1437, ResultVolumeBall, 0);
        }
    }
}
