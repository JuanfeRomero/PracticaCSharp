using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.libreria
{
    class Biblioteca
    {
        public List<Libro> Libros { get; set; }

        public Biblioteca()
        {
            Libros = new List<Libro>();
        }

        public void LlenarLibros()
        {
            Console.WriteLine("ingrese la cantidad de libros a ingresar");
            int cantidad = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                AgregarLibro();
            }
        }

        public void AgregarLibro()
        {
            Console.WriteLine("Ingrese el titulo del libro");
            string titulo = Console.ReadLine();
            Console.WriteLine("Ingrese el año de publicacion");
            int anioPublicacion = Int32.Parse(Console.ReadLine());

            Libros.Add(new Libro(titulo, anioPublicacion));
        }

        public void ContarLibros()
        {
            Console.WriteLine($"Hay {Libros.Count} libros en el catalogo");
        }

        public void VerLibros()
        {
            if (Libros.Count == 0)
            {
                Console.WriteLine("No hay libros en el catalogo");
            }
            else
            {
                foreach (Libro libro in Libros)
                {
                    Console.WriteLine("********************");
                    Console.WriteLine(libro);
                    Console.WriteLine("********************");
                }
            }

        }

        public void EliminarLibro()
        {
            Console.WriteLine("Ingrese todo o parte del nombre del titulo a borrar");
            string tituloParcial = Console.ReadLine();

            Libros.RemoveAll(libro =>
            {
                if (libro.Titulo.ToLower().Contains(tituloParcial.ToLower()))
                {
                    Console.WriteLine($"Desea eliminar {libro}? (y/n)");
                    return Console.ReadKey().Key == ConsoleKey.Y;
                }
                else
                {
                    return false;
                }
            });
        }

        public void ObtenerLibro()
        {
            Console.WriteLine("Ingrese todo o parte del nombre del titulo a buscar");
            string tituloParcial = Console.ReadLine();

            foreach (Libro libro in Libros.FindAll(libro => libro.Titulo.ToLower().Contains(tituloParcial.ToLower())))
            {
                Console.WriteLine(libro);
            }        
        }

        public void ObtenerPorCaracteres()
        {
            Console.WriteLine("Ingrese la cantidad de caracteres que quiere que el titulo contenga");
            int cantidad = Int32.Parse(Console.ReadLine());
            int encontrado = 0;

            Libros.ForEach(delegate (Libro libro)
            {
                if (libro.Titulo.Length == cantidad)
                {
                    encontrado++;
                    Console.WriteLine(libro);
                }
            });

            if (encontrado == 0) Console.WriteLine("no se ha encontrado un libro con esa cantidad");
        }

        public void ObtenerLibroPorAnio()
        {
            Console.WriteLine("Ingrese el anio del titulo");
            int anio = Int32.Parse(Console.ReadLine());

            foreach (Libro libro in Libros.FindAll(libro => libro.AnioPublicacion == anio))
            {
                Console.WriteLine(libro);
            }
        }
    }
}
