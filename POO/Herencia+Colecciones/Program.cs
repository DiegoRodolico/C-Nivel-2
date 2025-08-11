using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Agregas los objetos en las camionetas y asignamos colores...
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
            c1.color = "Rojo";
            c2.color = "Azul";
            c3.color = "Violeta";
            //armamos una lista y agregamos cada objeto creado a la lista (c1,c2,c3)...
            List<Camioneta> listacamioneta = new List<Camioneta>();
            listacamioneta.Add(c1);
            listacamioneta.Add(c2);
            listacamioneta.Add(c3);
            //Console.WriteLine("mostrame la lista de camionetas :" + listacamioneta);
            //lo recorremos con un FOREACH para mostrar toda la lista entera por consola...
            foreach (Camioneta item in listacamioneta)
            {
                Console.WriteLine("Colores : "  + item.color);
            }
            
            
            Console.ReadKey();


        }
    }
}
