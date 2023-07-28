﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_facade_design_pattern_example.car.logic
{
    public class ColorChanger : IColorChanger
    {
        public void ChangeColor(out String color)
        {
            Console.WriteLine("Enter the color :");
            color = Console.ReadLine();
            Console.WriteLine("Color changed successfully!");
        }
    }
}
