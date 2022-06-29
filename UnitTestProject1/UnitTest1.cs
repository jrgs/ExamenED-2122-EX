using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gsmconv;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double gradosLongitud = 90.0;
            double gradosLatitud = 90.0;
            Coordenada coordenada = new Coordenada(gradosLatitud, gradosLongitud);
           
            //coordenada.longitud = 90;
            Assert.AreEqual(90, coordenada.latitud, "0.001", "Error en cálculo de longitud");


        }
    }
}
