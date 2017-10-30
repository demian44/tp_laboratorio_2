using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public class SinProfesorException : Exception
    {
        public SinProfesorException()
            : base("No se introdujo ningun profesor")
        {

        }
    }         
}
