/// <summary>
/// класс котор может содержать любую фигуру (треугольник или круг)
/// </summary>
public class AnyFigure : Figure
{
    Object FigureObj { get; set; }

    /// <summary>
    /// создание фигуры
    /// </summary>
    /// <param name="Figure">массив параметров, один параметр для радиуса фигуры</param>
    public AnyFigure(double[] paramsFigure)
    {
        switch (paramsFigure.Length)
        {
            case 1:
                FigureObj = new Circle(paramsFigure[0]);
                break;

            case 3:
                FigureObj = new Triangle(paramsFigure[0], paramsFigure[1], paramsFigure[2]);
                break;

            default: throw new Exception("неверное кол-во параметров или не удалось определить фигуру");
        }
    }


    /// <summary>
    /// определение типа фигуры и возвр ее площади
    /// </summary>
    /// <returns></returns>
    public override double CalculateArea()
    {
        switch (FigureObj)
        {
            case Circle circle:
                return circle.CalculateArea();

            case Triangle triangle:
                return triangle.CalculateArea();

            default:
                throw new Exception("Неизвестная фигура");
        }

        return 0;
    }
}