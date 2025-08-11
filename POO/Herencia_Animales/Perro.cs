using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Animales
{
    class Perro : Animal_Domestico
    {
        public override string comunicarse()
        {
            return "guau guau...";
        }
    }
}
