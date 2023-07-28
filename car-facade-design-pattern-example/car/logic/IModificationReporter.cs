using car_facade_design_pattern_example.car.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_facade_design_pattern_example.car.logic
{
    public interface IModificationReporter
    {
        void ReportModification(out CarModification carModification);
    }
}
