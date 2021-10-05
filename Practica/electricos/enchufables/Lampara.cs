using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.electricos
{
    class Lampara : Enchufable
    {
        public bool Brillando { get; set; }

        public Lampara() : base()
        {
            Brillando = false;
        }


        public override void ActivarTodo()
        {
            base.ActivarTodo();
            Brillando = true;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Está " + (Brillando ? "brillando" : "oscuro"));
        }
    }
}
