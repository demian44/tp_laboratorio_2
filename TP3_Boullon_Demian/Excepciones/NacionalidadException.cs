using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{

    public class NacionalidadInvalidaException : Exception
    {
        public NacionalidadInvalidaException()
            : base("La nacionalidad no se condice con el DNI") { }

        public NacionalidadInvalidaException(Exception e)
            : base() { }

        public NacionalidadInvalidaException(string message)
            : base("Nacionalidad invalida: " + message) { }

        public NacionalidadInvalidaException(string message, Exception e)
            : base("Nacionalidad invalida: " + message) { }

    }
}
