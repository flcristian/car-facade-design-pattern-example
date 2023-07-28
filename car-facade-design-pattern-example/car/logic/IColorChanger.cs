using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_facade_design_pattern_example.car.logic
{
    public interface IColorChanger
    {
        void ChangeColor(out String color);
    }
}
