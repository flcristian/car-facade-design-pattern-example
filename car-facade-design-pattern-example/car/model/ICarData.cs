using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_facade_design_pattern_example.car.model
{
    public interface ICarData
    {
        void SaveCar();

        void ChangeColor();

        void ReportMaintenance();

        void ReportModification();
    }
}
