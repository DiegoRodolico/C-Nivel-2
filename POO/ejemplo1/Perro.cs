using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Perro
    {
        //Perro = Nombre, Color, Origen

        private string Nombre;
        private string Color;
        private string Origen;

        //ATRIBUTOS encapsulados y preparados para el llamamiento nooo...

        public void setNombre(string Name)
        {
            Nombre = Name;
        }
        public string getNombre()
        {
            return Nombre;
        }

        public void setColor(string C)
        {
            Color = C;
        }

        public string getColor()
        {
            return Color;
        }

        public void setOrigen(string O)
        {
            Origen = O;
        }

        public string getOrigen()
        {
            return Origen;
        }


        //metodos quiero que ladre
        //despues lo llamo, p1.ladrar es un comportamiento del perro 

        public string ladrar()
        {
            return "Guau, Guau...";
        }
    }
}
