using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro p1 = new Perro();
           
            p1.setNombre("Firulais") ;
            p1.setColor("Marron");
            p1.setOrigen("Gonzalez_Catan");
            
            Perro p2 = new Perro();

            p2.setNombre("Ciro");
            p2.setColor("Gris");
            p2.setOrigen("Persia");

            Perro p3 = new Perro();

            p3.setNombre("MateCosido");
            p3.setColor("Verde");
            p3.setOrigen("Uruguay");


            Console.WriteLine("Los perros son los siguientes:\n" +
                "Primer perro\n" +
            p1.getNombre() + "\n" + p1.getColor() + "\n" + p1.getOrigen() +
            "\n" + "\n" + p1.ladrar() + "\n" +

            "Segundo perro\n" +
            p2.getNombre() + "\n" + p2.getColor() + "\n" + p2.getOrigen() +
            "\n" + "\n" +
                "Tercer perro\n" +
            p3.getNombre() + "\n" + p3.getColor() + "\n" + p3.getOrigen()); 

            Console.ReadKey(); 
        }


    }
}
