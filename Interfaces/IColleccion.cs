using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._1_ProgII.Interfaces
{
    public interface IColleccion
    {
        public bool EstaVacía();
        public object Extraer();
        public object Primero();
        public bool Añadir(object elemento);

        public void mostrarElementos();
    }
}
