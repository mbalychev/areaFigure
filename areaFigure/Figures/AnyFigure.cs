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

    /// <summary>
    /// проверка евляетс ли прямоугольным
    /// </summary>
    /// <returns></returns> <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public bool IsRightAngled()
    {
        if (Triangle is not null)
        {

            double a = Math.Pow(Triangle.BaseLength, 2);
            double b = Math.Pow(Triangle.Height, 2);
            double c = Math.Pow(Triangle.Hypotenuse, 2);
            return Math.Abs(a + b - c) < 0.0001;

        }

        throw new Exception("фигура не является треугольником");
    }
}