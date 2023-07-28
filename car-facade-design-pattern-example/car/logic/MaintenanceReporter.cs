using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_facade_design_pattern_example.car.logic
{
    public class MaintenanceReporter : IMaintenanceReporter
    {
        public void ReportMaintenance(out String lastMaintenanceDate)
        {
            lastMaintenanceDate = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine("Maintenance reported successfully!");
        }
    }
}
