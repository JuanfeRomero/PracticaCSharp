using System;
using System.Collections.Generic;
using System.Text;

namespace Practica.electricos
{
    interface IEnchufable
    {
        bool Enchufado { get; set; }

        void Enchufar();
        void Desenchufar();
    }
}
