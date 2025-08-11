using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    class Telefono
    {
        //4.Agregar Constructor que reciba Modelo y Marca.
        public Telefono(string Marca, string Modelo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
        }
        public Telefono()
        {

        }

        //2.Agregale los siguientes atributos:
        //-Modelo string.
        //-Marca string.
        //-NumeroTelefonico string.
        //-CodigoOperador int (1, 2 o 3).

        private string Modelo;
        private string Marca;
        private string NumeroTelefonico;
        private int CodigoOperador;

        //3.Agregale las propiedades correspondientes.Podés hacer el formato largo o el corto.

        //-Modelo: solo lectura. Es decir, solo get.
        public string modelo
        {
            get
            {
                return Modelo;
            }
        }
        //-Marca: solo lectura.
        public string marca
        {
            get
            {
                return Marca;
            }
        }
        //-NumeroTelefonico: lectura y escritura.
        public string numerotelefonico
        {
            get { return NumeroTelefonico; }
            set { numerotelefonico = value; }
        }

        //-CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, caso contrario escribir un cero.
        public int codigooperador
        {
            get { return CodigoOperador; }
            set
            {
                if (CodigoOperador > 0 && CodigoOperador < 4)
                {
                    codigooperador = value;
                }
                else { codigooperador = 0; }
            }
        }

        //6.Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
        public string Llamar()
        {
            return "Realizando llamada...";
        }
        //7.Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string con la leyenda "Llamando a " + contacto
        public string LLamar(string contacto)
        {
            return "Llamando a  " + contacto;
        }
    }
}