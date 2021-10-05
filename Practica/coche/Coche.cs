using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class Coche
    {
        public Motor Motor { get; set; }

        public Rueda[] Rueda = new Rueda[4];

        public Puerta[] Puerta = new Puerta[2];

        public Coche()
        {
            this.Motor = new Motor();
            for (int i = 0; i < Rueda.Length; i++)
            {
                Rueda[i] = new Rueda();
            }
            for (int i = 0; i < Puerta.Length; i++)
            {
                Puerta[i] = new Puerta();
            }
        }


        public void print()
        {
            Console.WriteLine("Estado actual del auto:");
            Motor.EstaEncendido();

            for (int i = 0; i < Rueda.Length; i++)
            {
                Console.WriteLine("Rueda: " + (i+1));
                Rueda[i].EstaInflada();
            }

            for (int i = 0; i < Puerta.Length; i++)
            {
                Console.WriteLine("Puerta: " + (i+1));
                Puerta[i].EstaAbierta();
            }
        }

    }
}
