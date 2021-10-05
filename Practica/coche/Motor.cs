using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class Motor
    {
        public bool Encendido { get; set; }

        public Motor()
        {
            this.Encendido = false;
        }

        public void Encender()
        {
            if (Encendido)
            {
                Console.WriteLine("El motor ya estaba encendido");
            }
            else
            {
                Console.WriteLine("El motor encendió");
                this.Encendido = true;
            }
        }

        public void Apagar()
        {
            if (!Encendido)
            {
                Console.WriteLine("El motor ya está apagado");
            }
            else
            {
                Console.WriteLine("El motor se apagó");
                this.Encendido = false;
            }
        }

        public void EstaEncendido()
        {
            Console.WriteLine("El motor está" + (Encendido ? " encendido" : " apagado"));
        }
    }
}
