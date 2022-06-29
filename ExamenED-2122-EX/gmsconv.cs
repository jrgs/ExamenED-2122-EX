using System;

namespace gsmconv
{
    /// <summary>
    /// Clase que le damos grados minutos y segundos para luego ser convertidos en Coordenadas
    /// </summary>
    public class gms
    {
        private int grados;
        private int minutos;
        private double segundos;
        private int maxGrados;
        public gms(int max)
        {
            Grados = Minutos = 0;
            Segundos = 0.0;
            this.maxGrados = max;
        }

        public int Grados
        {
            get => grados;
            set
            {
                if (value >= -maxGrados && value <= maxGrados) grados = value;
                else throw new ArgumentOutOfRangeException("Grados no válidos");
            }
        }
        public int Minutos
        {
            get => minutos;
            set
            {
                if (value >= 0 && value <= 60) minutos = value;
                else throw new ArgumentOutOfRangeException("Minutos no válidos");
            }
        }
        public double Segundos
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
    /// Clase dedicada para convertir los datos obtenidos de la clas gms en coordenadas
    /// </summary>
    public class coord
    {
        public gms longitud = new gms(180);
        public gms latitud = new gms(90);

        public coord(double gLong, double gLat)
        {
            // primero pasamos la longitud de grados a GMS
            longitud.Grados = (int)gLong;
            // ahora calculamos los minutos, hay que eliminar el signo
            gLong = Math.Abs((gLong - longitud.Grados) * 60.0);
            longitud.Minutos = (int)(gLong);
            // por último los segundos
            longitud.Segundos = (gLong - longitud.Minutos) * 60.0;

            // Ahora hacemos lo mismo con la latitud
            latitud.Grados = (int)gLat;
            // ahora calculamos los minutos, hay que eliminar el signo
            gLat = Math.Abs((gLat - latitud.Grados) * 60.0);
            latitud.Minutos = (int)(gLat);
            // por último los segundos
            latitud.Segundos = (gLat - latitud.Minutos) * 60.0;
        }
    }
}
