using System;
using System.Collections.Generic;
using System.Text;

namespace Practica
{
    class Libro
    {
        public Libro(string titulo, int anioPublicacion)
        {
            Titulo = titulo;
            AnioPublicacion = anioPublicacion;
        }

        public string Titulo { get; set; }
        public int AnioPublicacion { get; set; }

        public int TamanioTitulo()
        {
            return Titulo.Length;
        }

        public override string ToString()
        {
            return $"{Titulo} - {AnioPublicacion}";
        }
    }
}
