using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenED_2122_EX;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using gsmconv;

namespace pruebasUnitariasCood
{
    //YAG2122
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void ComprobarGradosLatitudYLongitud()
        {

            double gradosLongitud = -10;
            double gradosLatitud = -10;


            Cordenaadas clase = new Cordenaadas(gradosLongitud, gradosLatitud);


            Assert.AreEqual(gradosLongitud, clase.latitud.Grados, 0.001);
            Assert.AreEqual(gradosLatitud, clase.longitud.Grados, 0.001);
        }
        [TestMethod]
        public void ComprobarMinutos()
        {

            double gradosLongitud = 10.4;
            double gradosLatitud = 10.4;
            double minutos = 24;
            int max;

           

            Cordenaadas clase = new Cordenaadas(gradosLongitud, gradosLatitud);
            


            Assert.AreEqual(minutos, clase.latitud.Minutos, 0.001);
            Assert.AreEqual(minutos, clase.longitud.Minutos, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void LimiteDeLongitudYlatitutd()
        {

            double gradosLongitud = -181;
            double gradosLatitud = -91;
           

            Cordenaadas clase = new Cordenaadas(gradosLongitud, gradosLatitud);

        }
        
        [TestMethod]
        public void ComprobarSegundos()
        {

            double gradosLongitud = 10.44;
            double gradosLatitud = 10.44;
            double segundos = 24.00;
            int max;

           

            Cordenaadas clase = new Cordenaadas(gradosLongitud, gradosLatitud);
            


            Assert.AreEqual(segundos, clase.latitud.Segundos, 0.001);
            Assert.AreEqual(segundos, clase.longitud.Segundos, 0.001);
        }
        [TestMethod]
        public void ComprobarGrados()
        {

            double gradosLongitud = 10.44;
            double gradosLatitud = 10.44;
            double grados = 10;
            int max;



            Cordenaadas clase = new Cordenaadas(gradosLongitud, gradosLatitud);



            Assert.AreEqual(grados, clase.latitud.Grados, 0.001);
            Assert.AreEqual(grados, clase.longitud.Grados, 0.001);
        }


    }
}
