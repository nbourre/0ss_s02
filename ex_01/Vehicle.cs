using System;
using System.Collections.Generic;
using System.Text;

namespace ex_01
{
    class Vehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        protected double _speed;

        public virtual string Indicate(bool turnLeft)
        {
            return turnLeft ? "Turning Left" : "Turning right";
        }

        public void Accelerate(double speed)
        {
            _speed += speed;
        }

    }

    class MotorVehicle : Vehicle
    {
        
        public double FuelRemaining { get; set; }
        public double TankSize { get; set; }
        public double Mpg => _speed == 0 ? 0 : _speed < 20 ? 50 : _speed < 50 ? 40 : 35;

        public double Refuel ()
        {
            var whatsMissing = TankSize - FuelRemaining;
            FuelRemaining = TankSize;

            return whatsMissing;
        }

        public override string Indicate(bool turnLeft) => turnLeft ? "Flashing LEFT indicator" : "Flashing RIGHT indicator";
    }

    class Bus : MotorVehicle
    {
        public int NbPassengers { get; set; }
        public int Capacity { get; set; }

        public int EmbarkPassenger (int nbPassenger)
        {
            var placesLeft = Capacity - NbPassengers;

            if (placesLeft >= nbPassenger)
            {
                NbPassengers += nbPassenger;
                return Capacity - NbPassengers;
            } else
            {
                throw new OverflowException();
            }
        }
    }

    class Bicycle : Vehicle
    {
        public int NbWheels { get; set; }
        public override string Indicate(bool turnLeft) => turnLeft ? "Raising LEFT arm" : "Raising RIGHT arm";

        public string RingBell() => "Ring!";
    }

    

}
