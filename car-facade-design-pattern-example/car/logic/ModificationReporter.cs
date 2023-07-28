using car_facade_design_pattern_example.car.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_facade_design_pattern_example.car.logic
{
    public class ModificationReporter : IModificationReporter
    {
        public void ReportModification(out CarModification carModification)
        {
            Console.WriteLine("Enter the car modification :");
            carModification = new CarModification(Console.ReadLine(), DateTime.Now.ToString("dd.MM.yyyy"));
            Console.WriteLine("Car modification reported successfully!");
        }
    }
}
