using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DMP2122Examen;

namespace TestCoordenadas
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void PruebaCoordenadasCorrectas()
        {
            Coordenadas prueba = new Coordenadas(-152.369, 35.678);
            int gradosEsperadosLong = -152;
            int minutosEsperadosLong = 22;
            double segundosEsperadosLong = 8.40;
            int gradosEsperadosLat = 35;
            int minutosEsperadosLat = 40;
            double segundosEsperadosLat = 40.80;

            Assert.AreEqual(gradosEsperadosLong, prueba.longitud.Grados, "Los grados de la longitud no son correctos");
            Assert.AreEqual(minutosEsperadosLong, prueba.longitud.Minutos, "Los minutos de la longitud no son correctos");
            Assert.AreEqual(segundosEsperadosLong, prueba.longitud.Segundos, 0.01, "Los segundos de la longitud no son correctos");
            Assert.AreEqual(gradosEsperadosLat, prueba.latitud.Grados, "Los grados de la latitud no son correctos");
            Assert.AreEqual(minutosEsperadosLat, prueba.latitud.Minutos, "Los minutos de la latitud no son correctos");
            Assert.AreEqual(segundosEsperadosLat, prueba.latitud.Segundos, 0.01, "Los segundos de la latitud no son correctos");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), GradosMinutosSegundos.ExcepcionGrados)]
        public void GradosIncorrectos()
        {
            Coordenadas prueba = new Coordenadas(-180.369, 95.678);
        }


        [TestMethod]
        public void GradosTryCatchIncorrectos()
        {
            try
            {
                Coordenadas prueba = new Coordenadas(-180.369, 95.678);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, GradosMinutosSegundos.ExcepcionGrados);
                return;
            }
            Assert.Fail("Error");

        }

        /*
        //a esto no le hagas caso porque no lo he conseguido sacar!!!
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), GradosMinutosSegundos.ExcepcionMinutos)]
        public void MinutosIncorrectos()
        {
            int MinutosEsperados = 0;
            GradosMinutosSegundos prueba = new GradosMinutosSegundos(MinutosEsperados);
        }
        */
    } 
}
