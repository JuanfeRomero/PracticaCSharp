using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class Racional
    {
        public int Numerador { get; set; }
        public int Denominador { get; set; }

        public Racional(int num, int den)
        {
            this.Numerador = num;
            try
            {
                if (den == 0) throw new Exception();
                this.Denominador = den;
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR, El denominador no puede ser cero, se le asignará el valor por defecto 1");
                this.Denominador = 1;
            }
        }

        public Racional()
        {
            this.Numerador = 0;
            this.Denominador = 1;
        }

        public Racional Sumar(Racional aSumar)
        {
            if(this.Denominador == aSumar.Denominador)
            {
                return new Racional(Numerador + aSumar.Numerador, Denominador);
            }
            else
            {
                int nuevoNum = Numerador * aSumar.Denominador + aSumar.Numerador * Denominador;
                int nuevoDen = Denominador * aSumar.Denominador;

                return new Racional(nuevoNum, nuevoDen);
            }
        }

        public Racional Multiplicar(Racional aMultiplicar)
        {
            return new Racional(Numerador * aMultiplicar.Numerador, Denominador * aMultiplicar.Denominador);
        }

        public override string ToString()
        {
            return $"{Numerador}/{Denominador}";
        }
    }
}
