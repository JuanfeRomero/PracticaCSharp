using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.electricos
{
    interface IRecargable
    {
        bool Cargando { get; set; }
        void Cargar();
        void Desconectar();

    }
}
