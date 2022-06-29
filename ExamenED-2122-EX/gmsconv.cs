using System;

namespace AMG22
{
    /// <summary>
    /// Clase CoordenadasGMS
    /// Se declaran las variables: Grados, Minutos y Segundos
    /// <para>GMS = Grados, Minutos y Segundos </para>
    /// </summary>
    public class CoordenadasGMS
    {
        private int gradosAMG22; // grados
        private int minutos; // minutos
        private double segundos; // segundos
        private int maximosGrados;  // valor límite para los grados
        /// <summary>
        /// se inicializa el constructos a "0"
        /// </summary>
        /// <param name="max"></param>
        public CoordenadasGMS(int max)
        {
            cGrados = cMinutos = 0;
            cSegundos = 0.0;
            this.maximosGrados = max;
        }

        public int cGrados
        {
            get => gradosAMG22;
            set
            {
                if (value >= -maximosGrados && value <= maximosGrados) gradosAMG22 = value;
                else throw new ArgumentOutOfRangeException("Grados no válidos");
            }
        }
        public int cMinutos
        {
            get => minutos;
            set
            {
                if (value >= 0 && value <= 60) minutos = value;
                else throw new ArgumentOutOfRangeException("Minutos no válidos");
            }
        }
        public double cSegundos
        {
            get => segundos;
            set
            {
                if (value >= 0 && value <= 60) segundos = value;
                else throw new ArgumentOutOfRangeException("Segundos no válidos");
            }
        }
    }
    /// <summary>
    /// Clase coordenadas
    /// <remarks>Importante tener en cuenta no superar los limites 180 o -180 </remarks>
    /// </summary>
    public class Coordenadas
    {
        public CoordenadasGMS longitud = new CoordenadasGMS(180); // longitud
        public CoordenadasGMS latitud = new CoordenadasGMS(90); // latitud

        public Coordenadas(double gradosLongitud, double gradosLatitud)
        {
            // primero pasamos la longitud de grados a GMS
            longitud.cGrados = (int)gradosLongitud;
            // ahora calculamos los minutos, hay que eliminar el signo
            gradosLongitud = Math.Abs((gradosLongitud - longitud.cGrados) * 60.0);
            longitud.cMinutos = (int)(gradosLongitud);
            // por último los segundos
            longitud.cSegundos = (gradosLongitud - longitud.cMinutos) * 60.0;

            // Ahora hacemos lo mismo con la latitud
            latitud.cGrados = (int)gradosLatitud;
            // ahora calculamos los minutos, hay que eliminar el signo
            gradosLatitud = Math.Abs((gradosLatitud - latitud.cGrados) * 60.0);
            latitud.cMinutos = (int)(gradosLatitud);
            // por último los segundos
            latitud.cSegundos = (gradosLatitud - latitud.cMinutos) * 60.0;
        }
    }
}
