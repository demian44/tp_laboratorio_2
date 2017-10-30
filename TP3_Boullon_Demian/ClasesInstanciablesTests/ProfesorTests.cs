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
    public class ProfesorTests
    {
        [TestMethod()]
        public void ProfesorCorrecto()
        {
            try
            {
                Profesor profesor = new Profesor(1, "Demian", "Boullon", "0", Persona.ENacionalidad.Argentino);
            }
            catch (Exception excepcion)
            {
                Assert.IsInstanceOfType(excepcion, typeof(DniInvalidoException));
            }

        }

        [TestMethod()]
        public void ProfesorNacionalidadYdocumento()
        {
            try
            {
                Profesor profesor = new Profesor(1, "Demian", "Boullon", "1", Persona.ENacionalidad.Extranjero);
                Profesor profesor2 = new Profesor(1, "Demian", "Boullon", "89999999", Persona.ENacionalidad.Extranjero);
            }
            catch (Exception excepcion)
            {
                Assert.IsInstanceOfType(excepcion, typeof(NacionalidadInvalidaException));
            }

        }

        [TestMethod()]
        public void ToStringTest()
        {
            try
            {
                Profesor profesor2 = new Profesor(1, "Demian", "Boullon", "899A99999", Persona.ENacionalidad.Argentino);
            }
            catch (Exception excepcion)
            {
                Assert.IsInstanceOfType(excepcion, typeof(DniInvalidoException));
            }
        }

        //[TestMethod()]
        //public void EqualsTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void GetHashCodeTest()
        //{
        //    Assert.Fail();
        //}
    }
}