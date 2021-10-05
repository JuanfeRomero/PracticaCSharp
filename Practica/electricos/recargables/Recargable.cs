using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.electricos
{
    class Recargable : Electrico, IRecargable
    {
        public bool Cargando { get; set; }

        public Recargable() :base()
        {
            Cargando = false;
        }

        public void Cargar()
        {
            Cargando = true;
        }

        public void Desconectar()
        {
            Cargando = false;
        }

        public override void ActivarTodo()
        {
            base.ActivarTodo();
            Cargar();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Está " + (Cargando ? "cargando" : "desconectado"));
        }
    }
}
