using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO_v01
{
    class MostrarVehiculo
    {
        static void Main(string[] args)
        {
            Vehiculo MyCar = new Vehiculo();
            MyCar.SetVehiculo("Jeep", "Grand Cherokee");
            MyCar.VerVehiculo();
            Console.WriteLine();
            Vehiculo YourCar = new Vehiculo();
            YourCar.SetVehiculo("Jeep", "Grand Cherokee SRT");
            YourCar.VerVehiculo();
            Console.ReadKey();
        }
       
    }
}
