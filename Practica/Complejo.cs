using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class Complejo
    {
        public float nReal { get; set; }
        public float nImaginario { get; set; }

        public Complejo(float real, float imaginario)
        {
            this.nReal = real;
            this.nImaginario = imaginario;
        }

        public Complejo()
        {
            this.nReal = 0;
            this.nImaginario = 0;
        }

        public Complejo Sumar(Complejo aSumar)
        {
            return new Complejo(nReal + aSumar.nReal, nImaginario + aSumar.nImaginario);
        }

        public Complejo Multiplicar(float multi)
        {
            return new Complejo(nReal * multi, nImaginario * multi);
        }

        public bool EsIgualA(Complejo comparar)
        {
            return this.ToString().Equals(comparar.ToString());
        }

        public void Print()
        {
            Console.WriteLine($"{nReal}+{nImaginario}i");
        }

        public override string ToString()
        {
            return $"{nReal}+{nImaginario}i";
        }
    }

}
