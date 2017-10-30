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
            Profesor profesor = new Profesor(1, "Demian", "Boullon", "0", Persona.ENacionalidad.Argentino);

        }

        [TestMethod()]
        public void ProfesorTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EqualsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetHashCodeTest()
        {
            Assert.Fail();
        }
    }
}