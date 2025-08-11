using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Crear la clase Telefono(recordemos que una clase va en un archivo nuevo; click derecho en el proyecto, agregar, class).
            //2.Agregale los siguientes atributos:
            //-Modelo string.
            //-Marca string.
            //-NumeroTelefonico string.
            //-CodigoOperador int (1, 2 o 3).
            //3.Agregale las propiedades correspondientes.Podés hacer el formato largo o el corto.
            //-Modelo: solo lectura. Es decir, solo get.
            //-Marca: solo lectura.
            //-NumeroTelefonico: lectura y escritura.
            //-CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
            //4.Agregar Constructor que reciba Modelo y Marca.
            //5.Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla el estado del Telefono.
            Telefono t1 = new Telefono("samsung", "24");
            Console.WriteLine("Nombrar primer telefono : " + t1.marca + t1.modelo);
            Console.WriteLine(t1.Llamar());
            Telefono t2 = new Telefono("motorola", "x1");
            Console.WriteLine("Nombrar segundo telefono : " + t2.marca + t2.modelo);
            Console.WriteLine(t2.LLamar("Diego"));
            Telefono t3 = new Telefono("nokia", "1100");
            Console.WriteLine("Nombrar tercer telefono : " + t3.marca + t3.modelo);

            Console.ReadKey();

            //6.Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
            

            //7.Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto

            //8.Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.
        }
    }
}
