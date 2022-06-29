using System;

namespace gsmconv
{
    public class gms
    {
        private int grados; 
        private int minutos; 
        private double segundos; 
        private int maximosGrados;  

        public gms(int max)
        {
            Grados = Minutos = 0;
            Segundos = 0.0;
            this.maximosGrados = max;
        }

        public int Grados
        {
            get => grados;
            set
            {
                if (value >= -maximosGrados && value <= maximosGrados) grados = value;
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

    public class coordenada
    {
        public gms longitud = new gms(180); 
        public gms latitud = new gms(90); 

        public CalcularCoordenadas(double gLongitud, double gLatitud)
        {
            // primero pasamos la longitud de grados a GMS
            longitud.Grados = (int)gLongitud;
            // ahora calculamos los minutos, hay que eliminar el signo
            gLongitud = Math.Abs((gLongitud - longitud.Grados)*60.0);
            longitud.Minutos = (int)(gLongitud);
            // por último los segundos
            longitud.Segundos = (gLongitud - longitud.Minutos)*60.0;
 
            // Ahora hacemos lo mismo con la latitud
            latitud.Grados = (int)gLatitud;
            // ahora calculamos los minutos, hay que eliminar el signo
            gLatitud = Math.Abs((gLatitud - latitud.Grados)*60.0);
            latitud.Minutos = (int)(gLatitud);
            // por último los segundos
            latitud.Segundos = (gLatitud - latitud.Minutos)*60.0;
        }
    }
}
