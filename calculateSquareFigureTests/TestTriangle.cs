namespace calculateSquareFigureTests
{
    public class TestTriangle
    {
        [Fact]
        public void IsTriangleSquareCorrect()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.Equal(6.0, triangle.Square());
        }

        [Fact]
        public void IsInputValidTriangle()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 1, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(1, -1, 1));
            Assert.Throws<ArgumentException>(() => new Triangle(2, 8, 2));
        }

        [Fact]
        public void IsRightTriangleCorrect()
        {
            Assert.True(new Triangle(3, 4, 5).IsRightTriangle());
            Assert.False(new Triangle(5, 5, 5).IsRightTriangle());
        }
    }
}
