using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class Articulo
    {
        //Primer lote con 10 registros de productos, cada producto tiene:
        //    - Codigo Articulo(3 digitos no correlativos)
        //    - Precio
        //    - Codigo de Marca(1 al 10)

        public int CodigoArticulo { get; set; }
        public float Precio { get; set; }

        private int CodigoMarca;
        
        public int codigomarca //este es publico y muestra el CodigoMarca que es privado.
                               //le pones la lectura(get) y la escritura(set)
        {
            get { return CodigoMarca; } //aca lees lo que escribis en el set
            //en este caso retorna el CodigoMarca que a su vez es el private y lo que pide

            set //aca lo que vas a pedir que escriban en el program que, luego, va a ser leido por el get
            {
                //siempre es un value aca 
                if (value > 0 && value < 11)
                    //uso un if, diciendo si el valor es mayor que 0 y menor que 11 entra 
                    CodigoMarca = value;

                else
                    CodigoMarca = - 1;
            }   //sino muestra -1
        }
    }
}
