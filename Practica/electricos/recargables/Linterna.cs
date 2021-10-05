using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.electricos
{
    class Linterna : Recargable
    {
        public bool Iluminando { get; set; }

        public Linterna() : base()
        {
            Iluminando = false;
        }

        public override void ActivarTodo()
        {
            base.ActivarTodo();
            Iluminando = true;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Está " + (Iluminando ? "iluminando": "oscuro"));
        }
    }
}
