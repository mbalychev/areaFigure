namespace areaFigure.Test;

//тестирование площади фигуры
public class TestsAnyFigure
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
        AnyFigure circle = new AnyFigure(radius);

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
        AnyFigure circle = new AnyFigure(radius);

        // Act
        double area = circle.CalculateArea();

        // Assert
        Assert.AreEqual(Math.PI * Math.Pow(radius, 2), area, 0.0001);
    }

    /// <summary>
    /// тестирование с Int переменными
    /// </summary> <summary>
    /// 
    /// </summary>
    [Test]
    public void Triangle_CalculateArea_WithInt()
    {
        // Arrange
        AnyFigure triangle = new AnyFigure(4, 3, 5);

        // Act
        double area = triangle.CalculateArea();

        // Assert
        Assert.AreEqual(6, area, 0.0001);
    }

    /// <summary>
    /// тестирование на прямоугольный тр
    /// </summary>
    [Test]
    public void Triangle_IsRightAngled()
    {
        // Arrange
        AnyFigure triangle = new AnyFigure(3, 4, 5);

        // Act
        bool isRightAngled = triangle.IsRightAngled();

        // Assert
        Assert.IsTrue(isRightAngled);
    }


    /// <summary>
    /// тестирование на НЕ прямоугольный тр
    /// </summary>
    [Test]
    public void Triangle_IsNotRightAngled()
    {
        // Arrange
        AnyFigure triangle = new AnyFigure(3, 4, 6);

        // Act
        bool isRightAngled = triangle.IsRightAngled();

        // Assert
        Assert.IsFalse(isRightAngled);
    }

}