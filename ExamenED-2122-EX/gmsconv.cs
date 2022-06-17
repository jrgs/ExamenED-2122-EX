using System;

namespace gsmconv
{
    public class gms
    {
        private int g; // grados
        private int m; // minutos
        private double s; // segundos
        private int maxg;  // valor límite para los grados

        public gms(int max)
        {
            G = M = 0;
            S = 0.0;
            this.maxg = max;
        }

        public int G
        {
            get => g;
            set
            {
                if (value >= -maxg && value <= maxg) g = value;
                else throw new ArgumentOutOfRangeException("Grados no válidos");
            }
        }
        public int M
        {
            get => m;
            set
            {
                if (value >= 0 && value <= 60) m = value;
                else throw new ArgumentOutOfRangeException("Minutos no válidos");
            }
        }
        public double S
        {
            get => s;
            set
            {
                if (value >= 0 && value <= 60) s = value;
                else throw new ArgumentOutOfRangeException("Segundos no válidos");
            }
        }
    }

    public class coord
    {
        public gms lon = new gms(180); // longitud
        public gms lat = new gms(90); // latitud

        public coord(double glong, double glat)
        {
            // primero pasamos la longitud de grados a GMS
            lon.G = (int)glong;
            // ahora calculamos los minutos, hay que eliminar el signo
            glong = Math.Abs((glong - lon.G)*60.0);
            lon.M = (int)(glong);
            // por último los segundos
            lon.S = (glong - lon.M)*60.0;
 
            // Ahora hacemos lo mismo con la latitud
            lat.G = (int)glat;
            // ahora calculamos los minutos, hay que eliminar el signo
            glat = Math.Abs((glat - lat.G)*60.0);
            lat.M = (int)(glat);
            // por último los segundos
            lat.S = (glat - lat.M)*60.0;
        }
    }
}
