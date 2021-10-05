using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class Rueda
    {
        public bool Inflada { get; set; }

        public Rueda()
        {
            this.Inflada = false;
        }
        public void Inflar()
        {
            if (Inflada)
            {
                Console.WriteLine("La rueda ya está inflada");
            }
            else
            {
                this.Inflada = true;
                Console.WriteLine("La rueda fue inflada");
            }
        }

        public void Desinflar()
        {
            if (!Inflada)
            {
                Console.WriteLine("La rueda ya está desinflada");
            }
            else
            {
                this.Inflada = false;
                Console.WriteLine("La rueda fue desinflada");
            }
        }

        public void EstaInflada()
        {
            Console.WriteLine("La rueda está " + (Inflada ? "inflada" : "desinflada"));
        }
    }
}
