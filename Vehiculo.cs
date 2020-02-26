using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO_v01
{
 class Vehiculo
    {
        string Marca = "Toyota";
        string Modelo="Corrolla";
        public void SetVehiculo( string marca, string modelo)
        {   this.Marca=marca;
            this.Modelo = modelo;
        }
        public void VerVehiculo()
        {   Console.WriteLine("El vehículo es: " + Marca + " "+ Modelo);
            Console.ReadLine();
        }
    }

}
