using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Animales
{
    class Aguila : Animal_Salvaje, Volable_puede_volar_
    {
        public string volar()
        {
            return "vuela como un aguila...";
        }
    }
}
