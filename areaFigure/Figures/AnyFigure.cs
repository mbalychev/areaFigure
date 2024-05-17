/// <summary>
/// класс котор может содержать любую фигуру (треугольник или круг)
/// </summary>
public class AnyFigure : Figure
{
    Circle? Circle { get; set; }
    Triangle? Triangle { get; set; }


    /// <summary>
    /// констр для фигуры - круг
    /// </summary>
    /// <param name="radius"></param>
    public AnyFigure(double radius)
    {
        this.Circle = new Circle(radius);
    }


    /// <summary>
    /// констр для фигуры - круг
    /// </summary>
    /// <param name="radius"></param>
    public AnyFigure(double baseLength, double height, double hypotenuse)
    {
        this.Triangle = new Triangle(baseLength, height, hypotenuse);
    }



    /// <summary>
    /// определение типа фигуры и возвр ее площади
    /// </summary>
    /// <returns></returns>
    public override double CalculateArea()
    {
        if (Circle is not null) return Circle.CalculateArea();
        if (Triangle is not null) return Triangle.CalculateArea();

        throw new Exception("неудалось определить тип фигуры");
    }
}