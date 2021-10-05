using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class Ventana
    {
        public bool Abierta { get; set; }


        public Ventana()
        {
            this.Abierta = false;
        }
        public void Abrir()
        {
            if (Abierta)
            {
                Console.WriteLine("La ventana ya esta abierta");
            }
            else
            {
                this.Abierta = true;
                Console.WriteLine("La ventana fue abierta");
            }
        }

        public void Cerrar()
        {
            if (!Abierta)
            {
                Console.WriteLine("La ventana ya está cerrada");
            }
            else
            {
                this.Abierta = false;
                Console.WriteLine("La ventana se cerró");
            }
        }

        public void EstaAbierta()
        {
            Console.WriteLine("La ventana está " + (Abierta? "abierta" : "cerrada"));
        }
    }
}
