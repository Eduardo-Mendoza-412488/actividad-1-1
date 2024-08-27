using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._1_ProgII.Interfaces
{
    public abstract class ColeccionAbstracta : IColleccion
    {
        protected object[] array;
        protected int next;

        public ColeccionAbstracta(int size)
        {
            array = new object[size];
            next = -1;
        }
        public virtual bool Añadir(object? elemento)
        {
            bool añadido = false;

            if (next < array.Length)
            {
                array[++next] = elemento;
                añadido = true;
            }

            return añadido;
        }
        public virtual bool EstaVacía()
        {
            return next == -1;
        }

        public abstract object Extraer();

        public void mostrarElementos()
        {
            Console.WriteLine("Elementos en la coleccion");
            for ( int i = 0; i < next; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public virtual object Primero()
        {
            object? e = null;
            if (!EstaVacía())
            {
                e = array[0];
            }
            return e.ToString();
        }



    }
}
