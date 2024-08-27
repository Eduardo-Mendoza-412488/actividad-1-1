using Problema_1._1_ProgII.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1._1_ProgII.Clases
{
    public class Colas : ColeccionAbstracta
    {
        public Colas(int size) : base(size)
        {
        }

        public override object Extraer()
        {
            throw new NotImplementedException();
        }
    }
}
