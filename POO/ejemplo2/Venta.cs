using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    class Venta
    {
        //Segundo lote con las ventas de la eemana. Cada venta tiene:
        //    -Codigo Articulo
        //    - Cantidad
        //    - Codigo Cliente(1 a 10)
        //Este lote corta con Codigo de Cliente cero.

        public int CodigoArticulo { get; set; }
        
        public int Cantidad { get; set; }

        public int CodigoCliente { get; set; }

        //cargas los datos que te piden y en el program haces la movida
    }


 }    

