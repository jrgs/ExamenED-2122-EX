using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gsmconv;

namespace TestCoordenadas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GradosLongitudFueraLimiteArriba()
        {
            double gradosLongitud = 181;
            double gradosLatitud = 90;
            Coordenadas myCoords = new Coordenadas(gradosLongitud, gradosLatitud);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GradosLongitudFueraLimiteAbajo()
        {
            double gradosLongitud = -181;
            double gradosLatitud = -90;
            Coordenadas myCoords = new Coordenadas(gradosLongitud, gradosLatitud);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GradosLatitudFueraLimiteArriba()
        {
            double gradosLongitud = 180;
            double gradosLatitud = 91;
            Coordenadas myCoords = new Coordenadas(gradosLongitud, gradosLatitud);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GradosLatitudFueraLimiteAbajo()
        {
            double gradosLongitud = 180;
            double gradosLatitud = -91;
            Coordenadas myCoords = new Coordenadas(gradosLongitud, gradosLatitud);

        }
        /*
        [TestMethod]
        public void CalculaGradosMinutosSegundos()
        {
            double gradosLongitud = 180;
            double gradosLatitud = -90;
           // double expected = 
            try
            {
                Coordenadas myCoords = new Coordenadas(gradosLongitud, gradosLatitud);
            }
            Assert.AreEqual(expected, actual, 0.001, "");
        
        Estaba probando pero no me da timepo a mas
        }
          */
    }
}

