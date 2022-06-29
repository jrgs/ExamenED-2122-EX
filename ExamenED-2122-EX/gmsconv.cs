using System;

namespace gsmconv
{
    public class ConversionGradosMinutosSegundos
    {
        private int grados; // grados
        private int minutos; // minutos
        private double segundos; // segundos
        private int limiteGrados;  // valor límite para los grados

        public ConversionGradosMinutosSegundos(int max)
        {
            Grados = Minutos = 0;
            Segundos = 0.0;
            this.limiteGrados = max;
        }

        public int Grados
        {
            get => grados;
            set
            {
                if (value >= -limiteGrados && value <= limiteGrados)
                {
                    grados = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Grados no válidos");
                }
            }
        }
        public int Minutos
        {
            get => minutos;
            set
            {
                if (value >= 0 && value <= 60)
                {
                    minutos = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Minutos no válidos");
                }
            }
        }
        public double Segundos
        {
            get => segundos;
            set
            {
                if (value >= 0 && value <= 60)
                {
                    segundos = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Segundos no válidos");
                }
            }
        }
    }

    public class Coordenada
    {
        public ConversionGradosMinutosSegundos longitud = new ConversionGradosMinutosSegundos(180); // longitud
        public ConversionGradosMinutosSegundos latitud = new ConversionGradosMinutosSegundos(90); // latitud

        public Coordenada(double gradosLatitud, double gradosLongitud)
        {
            // primero pasamos la longitud de grados a GMS
            longitud.Grados = (int)gradosLongitud;
            // ahora calculamos los minutos, hay que eliminar el signo
            gradosLongitud = Math.Abs((gradosLongitud - longitud.Grados) * 60.0);
            longitud.Minutos = (int)(gradosLongitud);
            // por último los segundos
            longitud.Segundos = (gradosLongitud - longitud.Minutos) * 60.0;
 
            // Ahora hacemos lo mismo con la latitud
            latitud.Grados = (int)gradosLatitud;
            // ahora calculamos los minutos, hay que eliminar el signo
            gradosLatitud = Math.Abs((gradosLatitud - latitud.Grados) * 60.0);
            latitud.Minutos = (int)(gradosLatitud);
            // por último los segundos
            latitud.Segundos = (gradosLatitud - latitud.Minutos) * 60.0;
        }
    }
}
