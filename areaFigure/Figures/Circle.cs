// Класс для круга
public class Circle : Figure
{
    public double Radius { get; set; }

    /// <summary>
    /// создание нового круга
    /// </summary>
    /// <param name="radius">радиус</param> <summary>
    /// 
    /// </summary>
    /// <param name="radius"></param>
    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}