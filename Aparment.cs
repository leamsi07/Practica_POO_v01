using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO_v02
{
    interface IAparmentBuilding
    {
        void Imprimir();
        void Sell();
        void Rent();
    }
    public class AparmentBuilding
    {
        //Atributos
        protected string Address;
        protected string Color;
        protected string ConstruccionArea;
        protected string Garage;
        protected string Rooms;
        protected string BathRooms;
        public void Imprimir()
        {
            Console.WriteLine("Caracteristicas: ");
            Console.WriteLine("Direccion " + Address);
            Console.WriteLine("Color " + Color);
            Console.WriteLine("Area de Construccion " + ConstruccionArea);
            Console.WriteLine("Parqueo " + Garage);
            Console.WriteLine("Habitaciones " + Rooms);
            Console.WriteLine(" Baños " + BathRooms);
            Console.ReadLine();
        }
        //Propiedades get/set
        public string _Address { get => Address; set => Address = value; }
        public string _Color { get => Color; set => Color = value; }
        public string _ConstruccionArea { get => ConstruccionArea; set => ConstruccionArea = value; }
        public string _Garage { get => Garage; set => Garage = value; }
        public string _Rooms { get => Rooms; set => Rooms = value; }
        public string _BathRooms { get => BathRooms; set => BathRooms = value; }
    
        //Metodos

      
        public void Sell()
        {
            Console.WriteLine("Apartamento Vendido!");
            Console.WriteLine();
            Console.WriteLine("Caracteristicas: ");
            Console.WriteLine("Direccion " + Address);
            Console.WriteLine("Color " + Color);
            Console.WriteLine("Area de Construccion " + ConstruccionArea);
            Console.WriteLine("Parqueo " + Garage);
            Console.WriteLine("Habitaciones " + Rooms);
            Console.WriteLine(" Baños " + BathRooms);
            Console.ReadLine();
        }
        public void Rent()
        {
            Console.WriteLine("Apartamento Alquilado!");
            Console.WriteLine();
            Console.WriteLine("Caracteristicas: ");
            Console.WriteLine("Direccion " + Address);
            Console.WriteLine("Color " + Color);
            Console.WriteLine("Area de Construccion " + ConstruccionArea);
            Console.WriteLine("Parqueo " + Garage);
            Console.WriteLine("Habitaciones " + Rooms);
            Console.WriteLine(" Baños " + BathRooms);
            Console.ReadLine();
        }
    }
}
