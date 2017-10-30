using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{    
 
    public class DniInvalidoException : Exception
    {       
       
        public DniInvalidoException()
            : base()
        {

        }

        public DniInvalidoException(Exception e)
            : base()
        {   
            
        }        

        public DniInvalidoException(string message)
            : base("DNI invalido: " + message)
        {

        }

        public DniInvalidoException(string message, Exception e)
            : base("DNI invalido: " + message)
        {

        }
    }
 
}
