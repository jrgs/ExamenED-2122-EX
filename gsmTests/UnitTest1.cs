using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using gsmconv;

namespace gsmTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GradosInvalidos()
        {
            double gLong = -195.25;
            double gLat = 35.678;

            gms longitud = new gms(180);
            gms latitud = new gms(90);

            coord myCoords = new coord(gLong, gLat);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MinutosInvalidos()
        {
            double gLong = -152.369;
            double gLat = 95.258;

            gms longitud = new gms(180);
            gms latitud = new gms(90);

            coord myCoords = new coord(gLong, gLat);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SegundosInvalidos()
        {
            double gLong = -120.285;
            double gLat = 99.857;

            gms longitud = new gms(180);
            gms latitud = new gms(90);

            coord myCoords = new coord(gLong, gLat);
        }
    }
}
