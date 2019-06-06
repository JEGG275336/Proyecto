using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace proyecto
{
    class Adopcion
    {
        private string IdAdopcion;
            public Usuario _usuario;
        public Animales _animal;
        private string NombreAnimal;
        private string Direccion;
        private string Sucursal;

        public void Movimiento(Animales animales, Usuario usuario)
        {
            this._usuario = usuario;
        this._animal = animales;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Nombre de animal:");
            string NombreAnimal;
            NombreAnimal = Console.ReadLine();
            Console.WriteLine("Direccion de Usuario:");
            string Direccion;
            Direccion = Console.ReadLine();
            Console.WriteLine("Sucursal:");
            string Sucursal;
            Sucursal = Console.ReadLine();

            Console.WriteLine("Datos de Movimiento: " + "\n" + "Nombre de animal:" + NombreAnimal + "\n"
                + "Direccion de Usuario:" + Direccion + "\n" + "Sucursal:" + Sucursal);
        }

    }
}