namespace areaFigure.Test;

//тестирование площади круга
public class TestsCircle
{
    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// тестирование с Itn радиусом
    /// </summary> <summary>
    /// 
    /// </summary>
    [Test]
    public void Circle_CalculateArea_Int()
    {
        int radius = 5;
        // Arrange
        Circle circle = new Circle(radius);

        // Act
        double area = circle.CalculateArea();

        // Assert
        Assert.AreEqual(Math.PI * Math.Pow(radius, 2), area, 0.0001);
    }

    /// <summary>
    /// тестирование с использование double значение радиуса
    /// </summary>
    [Test]
    public void Circle_CalculateArea_Double()
    {
        double radius = 5.1;
        // Arrange
        Circle circle = new Circle(radius);

        // Act
        double area = circle.CalculateArea();

        // Assert
        Assert.AreEqual(Math.PI * Math.Pow(radius, 2), area, 0.0001);
    }

}