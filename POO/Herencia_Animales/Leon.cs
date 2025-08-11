using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Animales
{
    class Leon : Animal_Salvaje
    {
        public override string comunicarse()
        {
            return "rugido, rugido...";
        }
    }
}
