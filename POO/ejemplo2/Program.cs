using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primer lote con 10 registros de productos, cada producto tiene:
            //    -Codigo Articulo(3 digitos no correlativos)
            //    - Precio
            //    - Codigo de Marca(1 al 10)
            //Segundo lote con las ventas de la eemana. Cada venta tiene:
            //    -Codigo Articulo
            //    - Cantidad
            //    - Codigo Cliente(1 a 10)
            //Este lote corta con Codigo de Cliente cero.

            //* aca hay que guardar 10 articulos con un vector de la clase Articulo antes creada
            
            Articulo[] articulos = new Articulo[10];
            

            for (int x = 0; x < 2; x++)
            {
                articulos[x] = new Articulo();
                Console.WriteLine("Ingrese los datos del Articulo :");
                Console.WriteLine("Codigo del Articulo : ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                //vector de x(for).llamado al atributo, y lo muestro por pantalla
                Console.WriteLine("Precio : ");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Codigo de Marca : ");
                articulos[x].codigomarca = int.Parse(Console.ReadLine());

                Console.ReadKey();

                //terminado primera parte

            }
            //creo la primer venta:
            Venta venta = new Venta();
            //pido la venta
            Console.WriteLine("Ingrese la nueva Venta : ");
            //despues pido el codigo de cliente
            Console.WriteLine("Ingrese Codigo de Cliente : ");
            //aca lo genero 
            venta.CodigoCliente = int.Parse(Console.ReadLine());
            //y digo si el codigo es distinto de cero entra al while a pedir mas datos :
            while (venta.CodigoCliente != 0)
            {
                //pido los otros datos 
                Console.WriteLine("ingrese codigo del articulo : ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese cantidad : ");
                venta.Cantidad = int.Parse(Console.ReadLine());


                //aca sale y pregunta nuevamente si el codigo de cliente es distinto de 0 y entra y asi...

                Console.WriteLine("Ingrese la nueva Venta : ");
                Console.WriteLine("Ingrese Codigo de Cliente : ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());

            }
        }
    }
}
