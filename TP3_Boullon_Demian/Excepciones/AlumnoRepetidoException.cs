using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public class AlumnoRepetidoException : Exception
    {
        public AlumnoRepetidoException() : base("Alumno repedito.")
        { }
    }
}
