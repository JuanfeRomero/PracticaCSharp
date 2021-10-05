using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.electricos
{
    class CargaHibrida : Electrico, IRecargable, IEnchufable
    {
        public bool Cargando { get; set; }
        public bool Enchufado { get; set; }

        public void Cargar()
        {
            Cargando = true;
        }

        public void Desconectar()
        {
            Cargando = false;
        }

        public void Desenchufar()
        {
            Enchufado = false;
        }

        public void Enchufar()
        {
            Enchufado = true;
        }

        public override void ActivarTodo()
        {
            base.ActivarTodo();
            Cargar();
            Enchufar();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Está " + (Cargando ? "cargando" : "desconectado"));
            Console.WriteLine("Está " + (Enchufado ? "enchufado" : "desenchufado"));
        }
    }
}
