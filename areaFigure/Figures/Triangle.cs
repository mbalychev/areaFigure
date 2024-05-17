// Класс для треугольника
public class Triangle : Figure
{
    public double BaseLength { get; set; }
    public double Height { get; set; }
    public double Hypotenuse { get; set; }
    /// <summary>
    /// создание треугольника
    /// </summary>
    /// <param name="baseLength">базовая длина</param>
    /// <param name="height">высота</param>
    /// <param name="hypotenuse">гипотинуза</param>
    public Triangle(double baseLength, double height, double hypotenuse)
    {
        BaseLength = baseLength;
        Height = height;
        Hypotenuse = hypotenuse;
    }

    /// <summary>
    /// подсчет плозади треугольника
    /// </summary>
    /// <returns></returns> <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override double CalculateArea()
    {
        return 0.5 * BaseLength * Height;
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
        double a = Math.Pow(BaseLength, 2);
        double b = Math.Pow(Height, 2);
        double c = Math.Pow(Hypotenuse, 2);
        return Math.Abs(a + b - c) < 0.0001;
    }
}