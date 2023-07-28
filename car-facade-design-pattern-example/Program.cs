using car_facade_design_pattern_example.car.model;

internal class Program
{
    private static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("D:\\mycode\\csharp\\colectii\\car-facade-design-pattern-example\\car-facade-design-pattern-example\\car\\resources\\car.txt");
        String text = sr.ReadToEnd();
        sr.Close();

        CarData carData = new CarData(text);
        Console.WriteLine(carData);
    }
}