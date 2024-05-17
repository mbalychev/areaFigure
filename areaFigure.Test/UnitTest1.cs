namespace areaFigure.Test;
// using FigureTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Circle_CalculateArea_WithRadius_ReturnsCorrectArea()
    {
        // Arrange
        Circle circle = new Circle(5);

        // Act
        double area = circle.CalculateArea();

        // Assert
        Assert.AreEqual(Math.PI * 25, area, 0.0001);
    }

    [Test]
    public void Triangle_CalculateArea_WithBaseAndHeight_ReturnsCorrectArea()
    {
        // Arrange
        Triangle triangle = new Triangle(4, 3, 5);

        // Act
        double area = triangle.CalculateArea();

        // Assert
        Assert.AreEqual(6, area, 0.0001);
    }

    [Test]
    public void Triangle_IsRightAngled_WithValidSides_ReturnsTrue()
    {
        // Arrange
        Triangle triangle = new Triangle(3, 4, 5);

        // Act
        bool isRightAngled = triangle.IsRightAngled();

        // Assert
        Assert.IsTrue(isRightAngled);
    }

    [Test]
    public void Triangle_IsRightAngled_WithInvalidSides_ReturnsFalse()
    {
        // Arrange
        Triangle triangle = new Triangle(3, 4, 6);

        // Act
        bool isRightAngled = triangle.IsRightAngled();

        // Assert
        Assert.IsFalse(isRightAngled);
    }
}