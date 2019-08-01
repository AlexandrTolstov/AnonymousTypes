﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Anonymous Types *****\n");
            var myCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
            Console.WriteLine("My car is a {0} {1}.", myCar.Color, myCar.Make);
            BuildAnonType("BMW", "Black", 90);
            ReflectOverAnonymous(myCar);
        }
        static void BuildAnonType(string make, string color, int currSp)
        {
            var car = new { Make = make, Color = color, Speed = currSp };
            Console.WriteLine("You have a {0} {1} going {2} MPH", car.Color, car.Make, car.Speed);
            Console.WriteLine("ToString() == {0}", car.ToString());
        }
        static void ReflectOverAnonymous(object obj)
        {
            Console.WriteLine("obj is an instance of: {0}", obj.GetType().Name);
            Console.WriteLine("Base class of {0} is {1}", obj.GetType().Name, obj.GetType().BaseType);
            Console.WriteLine("obj.ToString() == {0}", obj.ToString());
            Console.WriteLine("obj.GetHashCode() == {0}", obj.GetHashCode());
            Console.WriteLine();
        }
    }
}
