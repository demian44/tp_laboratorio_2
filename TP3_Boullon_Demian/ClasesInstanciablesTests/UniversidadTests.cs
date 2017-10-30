using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables.Tests
{
    [TestClass()]
    public class UniversidadTests
    {
        [TestMethod()]
        public void UniversidadProfesorNull()
        {
            Universidad universidadInstanciada = new Universidad();
            try
            {
                Profesor profesorNull = null;
                universidadInstanciada += profesorNull;
            }
            catch (Exception excepcion)
            {
                Assert.IsInstanceOfType(excepcion, typeof(NullReferenceException));
            }
        }

        [TestMethod()]
        public void ProfesorRepetido()
        {
            Universidad universidadInstanciada = new Universidad();

            Profesor profesorA = new Profesor(1, "A", "A", "2", Persona.ENacionalidad.Argentino);
            Profesor profesorB = new Profesor(1, "A", "A", "2", Persona.ENacionalidad.Argentino);
            universidadInstanciada += profesorA;
            universidadInstanciada += profesorB;
            if (1 == universidadInstanciada.Instructores.Count())
                Assert.Fail("Sin excepcion para profesor repetido");

        }

        //[TestMethod()]
        //public void GuardarTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void ToStringTest()
        //{
        //    Assert.Fail();
        //}
    }
}