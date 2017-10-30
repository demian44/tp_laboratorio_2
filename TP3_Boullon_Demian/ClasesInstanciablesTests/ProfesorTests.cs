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
                Assert.Fail("No debe ingresar valores inferiores a 1.");
            }
            catch (Exception excepcion)
            {
                Assert.IsInstanceOfType(excepcion, typeof(DniInvalidoException));
            }

        }

        [TestMethod()]
        public void ProfesorNacionalidadYdocumento2()
        {
            try
            {
                Profesor profesor2 = new Profesor(1, "Demian", "Boullon", "90000000", Persona.ENacionalidad.Argentino);
                Assert.Fail("Debe estar ser 900000000 o mayor");
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
                Assert.Fail("No debe permitir el ingreso de letras.");
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