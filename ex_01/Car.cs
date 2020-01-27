using System;
using System.Collections.Generic;
using System.Text;

namespace ex_01
{
    class Car : Vehicle
    {
        
        public string Model { get; set; }
        public string Color { get; set; }

        
        public string NIV { get; set; }
        public double EngineSize { get; set; }

        public Car()
        {

        }

        public string Display() => $"\t{Brand} \t{Model} \t{Year} \t{Color} \tEngine : {EngineSize}";
        
     

    }
}
