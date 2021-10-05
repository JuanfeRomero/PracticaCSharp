using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class Puerta
    {
        public Ventana Ventanas { get; set; }
        public bool Abierta { get; set; }


        public Puerta()
        {
            this.Ventanas = new Ventana();
            this.Abierta = false;
        }
        public void Abrir()
        {
            if (Abierta)
            {
                Console.WriteLine("La puerta ya esta abierta");
            }
            else
            {
                this.Abierta = true;
                Console.WriteLine("La puerta fue abierta");
            }
        }

        public void Cerrar()
        {
            if (!Abierta)
            {
                Console.WriteLine("La puerta ya está cerrada");
            }
            else
            {
                this.Abierta = false;
                Console.WriteLine("La puerta se cerró");
            }
        }

        public void EstaAbierta()
        {
            Console.WriteLine("La puerta está " + (Abierta ? "abierta" : "cerrada"));
            Ventanas.EstaAbierta();
        }
    }
}
