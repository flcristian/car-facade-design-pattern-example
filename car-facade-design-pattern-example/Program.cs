using car_facade_design_pattern_example.car.model;

internal class Program
{
    private static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("D:\\mycode\\csharp\\design-patterns\\car-facade-design-pattern-example\\car-facade-design-pattern-example\\car\\resources\\car.txt");
        String text = sr.ReadToEnd();
        sr.Close();

        ICarData carData = new CarData(text);
        carData.ReportMaintenance();
        carData.ReportModification();
        carData.ChangeColor();
        carData.SaveCar();
        Console.WriteLine(carData);
    }
}