using System;
using System.Collections.Generic;

namespace ex_01
{
    class Program
    {
        static void Turning(Vehicle v)
        {
            Random rnd = new Random();
            Console.WriteLine($"The {v.GetType().Name} is " + v.Indicate(rnd.Next(0, 100) < 50));
        }

        static void Main(string[] args)
        {
            var boumbo = new Car()
            {
                Brand = "Car",
                Model = "Yellow",
                Year = 1985,
                Color = "Yellow"
            };

            Console.WriteLine(boumbo.Display());

            List<Vehicle> trafic = new List<Vehicle>();

            int nbVehicles = 20;

            for (int i = 0; i < nbVehicles; i++)
            {
                Random rnd = new Random();
                switch ((int)Math.Floor((double)rnd.Next(1, 4)))
                {
                    case 1:
                        trafic.Add(new MotorVehicle());
                        break;
                    case 2:
                        trafic.Add(new Bus());
                        break;
                    case 3:
                        trafic.Add(new Bicycle());
                        break;
                    default:
                        break;
                }

            }

            foreach (Vehicle v in trafic)
            {
                Turning(v);
            }



        }
    }
}
