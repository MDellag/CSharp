using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using CorreoException;

namespace TestCorreo
{
    [TestClass]
    public class TestDeCorreo
    {
        [TestMethod]
        public void Test_ListaPaquetesCorreoNotNUll()
        {
            Correo c = new Correo();

            Assert.IsNotNull(c.Paquetes);
        }


        [TestMethod]
        //corregido, googlear mas sobre etiquetas de UnitTest..
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void Test_CargaDosTrackIdIguales()
        {
            Correo c = new Correo();
            Paquete p1 = new Paquete("aaa", "1234");
            Paquete p2 = new Paquete("bbb", "1234");

          //  bool cargo = false;
            
                c += p1;
                c += p2;
            //    cargo = true;          

         //   Assert.IsFalse(cargo);
        }
    }
}
