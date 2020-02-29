using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO_v02
{
    class Program
    {
        static void Main(string[] args)
        {
            AparmentBuilding aparment = new AparmentBuilding();
            bool seguir = true;
            string entrada = "";

            while (seguir)
            {
                Console.Clear();
                Console.WriteLine("Bienvenidos a el listado de empleados de la empresa ");
                Console.WriteLine("Elija la opcion que desee: ");
                Console.WriteLine("1 Datos apartamento ");
                Console.WriteLine("2 Vender Apartamento ");
                Console.WriteLine("3 Alquilar apartamento");
                Console.WriteLine("4 Buscar Empleado");
                entrada = Console.ReadLine();
                switch (entrada)
                {

                    case "1":
                        Console.Clear();

                        Console.WriteLine("Agregar datos de Apartamento: ");
                        Console.WriteLine("Direccion: ");
                        aparment._Address = Console.ReadLine();
                        Console.WriteLine("Color: ");
                        aparment._Color = Console.ReadLine();
                        Console.WriteLine("Area de construccion: ");
                        aparment._ConstruccionArea = Console.ReadLine();
                        Console.WriteLine("Parqueo: ");
                        aparment._Garage = Console.ReadLine();
                        Console.WriteLine("Habitaciones: ");
                        aparment._Rooms = Console.ReadLine();
                        Console.WriteLine("Baños: ");
                        aparment._BathRooms = Console.ReadLine();
                        aparment.Imprimir();
                      
                        break;

                    case "2":

                        Console.Clear();
                        aparment.Sell();
                        break;

                    case "3":
                        Console.Clear();

                        aparment.Rent();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Adios :(");
                        Console.ReadLine();
                        seguir = false;
                        break;

                    default:
                        Console.WriteLine("Algo anda mal :( elija la opcion correcta :)");
                        Console.ReadLine();
                        break;
                     
                }
                Console.ReadKey();
            }
        }
    }

}