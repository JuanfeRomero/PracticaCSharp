using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.electricos
{
    class Electrico
    {
        public bool Encendido { get; set; }

        public Electrico()
        {
            Encendido = false;
        }

        public void Encender()
        {
            Encendido = true;
        }

        public void Apagar()
        {
            Encendido = false;
        }

        public virtual void ActivarTodo()
        {
            Encender();
        }

        public virtual void Print()
        {
            Console.WriteLine("El aparato está " + (Encendido  ? "encendido" : "apagado"));
        }
    }
}
