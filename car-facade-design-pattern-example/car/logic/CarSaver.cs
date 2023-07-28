using car_facade_design_pattern_example.car.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_facade_design_pattern_example.car.logic
{
    public class CarSaver : ICarSaver
    {
        public void SaveCar(CarData carData)
        {
            String save = $"{carData.Id}/{carData.Color}/{carData.LastMaintenanceDate}/";
            foreach (CarModification carModification in carData.CarModifications)
            {
                save += $"{carModification.Modification}/{carModification.Date}/";
            }
            StreamWriter sw = new StreamWriter("D:\\mycode\\csharp\\design-patterns\\car-facade-design-pattern-example\\car-facade-design-pattern-example\\car\\resources\\car.txt");
            sw.WriteLine(save);
            sw.Close();
            Console.WriteLine("Car saved successfully!");
        }
    }
}
