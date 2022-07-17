namespace calculateSquareFigureTests
{
    public class TestCircle
    {
        [Fact]
        public void IsCircleSquareCorrect()
        {
            Circle circle = new Circle(1);
            Assert.Equal(3.14f, circle.Square());
        }

        [Fact]
        public void IsInputValidCircle()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}