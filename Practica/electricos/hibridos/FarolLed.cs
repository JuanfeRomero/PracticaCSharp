using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.electricos
{
    class FarolLed : CargaHibrida
    {
        public bool Colocado { get; set; }

        public FarolLed() : base()
        {
            Colocado = false;
        }

        public void Colocar()
        {
            Colocado = true;
        }
        public void Descolocar()
        {
            Colocado = false;
        }

        public override void ActivarTodo()
        {
            base.ActivarTodo();
            Colocar();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Está " + (Colocado ? "colocado" : "portatil"));
        }
    }
}
