using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ArchivosExceptions : Exception
    {
        #region Constructores
        /// <summary>
        /// Constructor que recibe la excepcion
        /// </summary>
        /// <param name="innerException">exception</param>
        public ArchivosExceptions(Exception innerException) { }

        /// <summary>
        /// Constructor que recibe un mensaje por param
        /// </summary>
        /// <param name="men">string mensaje a cargar</param>
        public ArchivosExceptions(string men):base(men) { }
        #endregion
    }
}
