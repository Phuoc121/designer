using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Myworld03_Factory.Vehicle;

namespace Myworld03_Factory
{

        public class CarFactory : VehicleFactory
        {
            public override void CreateVehicle()
            {
                Vehicle = new Car();
                Vehicle.Features.Add("4 wheels");
                Vehicle.Features.Add("Air conditioning");
                Vehicle.Features.Add("Radio");
            }
        }
    }

