using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Animales
{
    class Animal
    {
        public virtual string comunicarse()
        {
            return "ruido, ruido ...";
        }
    }
}
