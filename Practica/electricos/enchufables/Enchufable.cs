using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.electricos
{
    class Enchufable : Electrico, IEnchufable
    {
        public bool Enchufado { get; set; }

        public Enchufable() : base()
        {
            Enchufado = false;
        }
        public void Enchufar()
        {
            Enchufado = true;
        }

        public void Desenchufar()
        {
            Enchufado = false;
        }

        public override void ActivarTodo()
        {
            base.ActivarTodo();
            Enchufar();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Está " + (Enchufado ? "enchufado" : "desenchufado"));
        }
    }
}
