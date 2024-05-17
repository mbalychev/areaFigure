namespace areaFigure.Test;

//тестирование площади треугольника
public class TestsTriangle
{
    [SetUp]
    public void Setup()
    {
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
        Triangle triangle = new Triangle(4, 3, 5);

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
        Triangle triangle = new Triangle(3, 4, 5);

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
        Triangle triangle = new Triangle(3, 4, 6);

        // Act
        bool isRightAngled = triangle.IsRightAngled();

        // Assert
        Assert.IsFalse(isRightAngled);
    }


}