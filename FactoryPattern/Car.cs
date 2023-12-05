﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car() { }
        public void Drive()
        {
            Console.WriteLine("Building a new car!");
            Console.WriteLine("Your car has been built! Enjoy!");
        }
        public int NumberOfWheels { get; set; } = 4;
    }
}
