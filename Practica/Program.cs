using System;
using Practica.electricos;
using Practica.libreria;
namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Ejercicio 1
            //Console.WriteLine("Testeando Complejo");

            //Complejo complejo = new Complejo();

            //Console.WriteLine("Test toString: " + complejo);

            //Console.WriteLine("Dandoles valores (2 y 3)");
            //complejo.nReal = 2;
            //complejo.nImaginario = 3;

            //Console.WriteLine("Test print(): ");
            //complejo.Print();

            //Console.WriteLine("Sumando 3 y 2");
            //Complejo aSumar = new Complejo(3, 2);

            //Console.WriteLine("Test sumando: " + complejo.Sumar(aSumar));

            //Console.WriteLine("Multiplicando por 5");

            //Console.WriteLine("Test multi: " + complejo.Multiplicar(5));

            //Console.WriteLine("Testeando un complejo igual y uno diferente");
            //Complejo igual = new Complejo(2, 3);
            //Complejo diferente = new Complejo(34, 23);

            //Console.WriteLine("complejo: " + complejo);
            //Console.WriteLine("Igual: " + igual + " Diferente: " + diferente);
            //Console.WriteLine("Igual: " + complejo.EsIgualA(igual));
            //Console.WriteLine("Diferente: " + complejo.EsIgualA(diferente));

            //// Ejercicio 2

            //Console.WriteLine("Testeando Racional: ");
            //Racional racional = new Racional();
            //Console.WriteLine("Constructor vacio: " + racional);
            //racional = new Racional(3, 0);

            //Console.WriteLine("Dandole valor real 3/7");
            //racional = new Racional(3, 7);

            //Console.WriteLine("Testeando sumar: 2/3");
            //Console.WriteLine("Resultado: 3/7 + 2/3 = " + racional.Sumar(new Racional(2, 3)));
            //Console.WriteLine("Testeando sumar: 2/7");
            //Console.WriteLine("Resultado: 3/7 + 2/7 = " + racional.Sumar(new Racional(2, 7)));

            //Console.WriteLine("Testeando multiplicar: 3/7 * 3/2 = " + racional.Multiplicar(new Racional(3, 2)));


            //// Ejercicio 3

            //Console.WriteLine("Testeando Coche, primero todo en false, despues todo en true");
            //Coche coche = new Coche();

            //coche.Motor.Apagar();
            //foreach (Rueda rueda in coche.Rueda)
            //{
            //    rueda.Desinflar();
            //}
            //foreach (Puerta puerta in coche.Puerta)
            //{
            //    puerta.Ventanas.Cerrar();
            //    puerta.Cerrar();
            //}

            //coche.print();

            //coche.Motor.Encender();
            //foreach (Rueda rueda in coche.Rueda)
            //{
            //    rueda.Inflar();
            //}
            //foreach (Puerta puerta in coche.Puerta)
            //{
            //    puerta.Ventanas.Abrir();
            //    puerta.Abrir();
            //}

            //coche.print();

            //// Ejercicio 4

            //Console.WriteLine("Testeando la lista");
            //Listador lista = new Listador();
            //lista.LlenarLista();
            //lista.MostrarInvertida();

            //// Ejercicio 5

            //Console.WriteLine("Testeando libros.");
            //Biblioteca biblioteca = new Biblioteca();
            //biblioteca.LlenarLibros();

            //Console.WriteLine("Buscar cantidad de libros");
            //biblioteca.ContarLibros();
            //biblioteca.VerLibros();

            //Console.WriteLine("Agregar un libro");
            //biblioteca.AgregarLibro();

            //Console.WriteLine("Eliminar un libro con su nombre o parte de el");
            //biblioteca.EliminarLibro();

            //Console.WriteLine("Encontrar libro por su nombre o parte de el");
            //biblioteca.ObtenerLibro();

            //Console.WriteLine("Buscar libro segun cantidad de caracteres en su titulo");
            //biblioteca.ObtenerPorCaracteres();

            //Console.WriteLine("Buscar libro según su año");
            //biblioteca.ObtenerLibroPorAnio();

            // Ejercicio 6

            Console.WriteLine("Testeando electricos");

            Console.WriteLine("Creando Lampara (enchufable)");
            Lampara lampara = new Lampara();
            lampara.Print();

            Console.WriteLine("Encendiendo la lampara");
            lampara.ActivarTodo();
            lampara.Print();

            Console.WriteLine("Creando Linterna (recargable)");
            Linterna linterna = new Linterna();
            linterna.Print();

            Console.WriteLine("Encendiendo la linterna");
            linterna.ActivarTodo();
            linterna.Print();

            Console.WriteLine("Creando Farol Led (hibrido)");
            FarolLed farolLed = new FarolLed();
            farolLed.Print();

            Console.WriteLine("Encendiendo el farol");
            farolLed.ActivarTodo();
            farolLed.Print();

        }
    }
}
