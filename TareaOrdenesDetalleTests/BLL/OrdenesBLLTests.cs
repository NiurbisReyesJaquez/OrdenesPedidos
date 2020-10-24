using Microsoft.VisualStudio.TestTools.UnitTesting;
using TareaOrdenesDetalle.BLL;
using System;
using System.Collections.Generic;
using System.Text;
using TareaOrdenesDetalle.Models;

namespace TareaOrdenesDetalle.BLL.Tests
{
    [TestClass()]
    public class OrdenesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Ordenes orden = new Ordenes();

            orden.OrdenId = 0;
            orden.Fecha = DateTime.Now;
            orden.SuplidorId = 1;
            orden.OrdenesDetalle = new List<OrdenesDetalle>();
            orden.Monto = 100;

            paso = OrdenesBLL.Guardar(orden);
            Assert.IsTrue(paso);
        }

        [TestMethod()]
        public void ExisteTest()
        {
            bool paso = false;
            Ordenes orden = new Ordenes();

            orden.OrdenId = 1;
            orden.Fecha = DateTime.Now;
            orden.SuplidorId = 1;
            orden.OrdenesDetalle = new List<OrdenesDetalle>();
            orden.Monto = 5;

            paso = OrdenesBLL.Modificar(orden);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}