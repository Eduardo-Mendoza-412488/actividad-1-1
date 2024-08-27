using Problema_1._1_ProgII.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._1_ProgII.Clases
{
    internal class Pilas : ColeccionAbstracta
    {
        public Pilas(int size) : base(size)
        {
        }

        public override object Extraer()
        {
            //object? e = null;
            //if (!EstaVacía())
            //
            //    e = array[next];
            //    array[next] = null;
            //    next--;
            //}
            //return e;
            object? e = null;
            if (!EstaVacía())
            {
                e = array[next];
                array[next] = null;
                next--;
            }
            return e; 
        }

        public override string ToString()
        {
            string aux = "";
            foreach (object item in array)
            {
                if(item != null)
                {
                    aux += item.ToString() + " - ";
                }
            }
            return aux;

        }

        public int Longitud()
        { 
            int x;
            x = array.Length;

            return x;
        }
    }
}
