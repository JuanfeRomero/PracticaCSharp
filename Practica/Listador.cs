using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class Listador
    {
        public List<string> MiLista { get; set; }
        public Stack<string> MiStack { get; set; }

        public void LlenarLista()
        {
            MiLista = new List<string>();
            MiStack = new Stack<string>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese la palabra: " + (i+1));
                string palabra = Console.ReadLine();
                MiLista.Add(palabra);
                MiStack.Push(palabra);
            }
        }


        public void MostrarInvertida()
        {
            Console.WriteLine("Acá esta la Lista invertida:");
            MiLista.Reverse();
            MiLista.ForEach(Console.WriteLine);
            Console.WriteLine("Y acá está el stack");
            foreach (string palabra in MiStack)
            {
                Console.WriteLine(palabra);
            }
        }


    }
}
