using System;

namespace gsmconv
{
    //YAG2122
    /// <summary>
    /// Esta clase de gradosMintuosSegundos
    /// </summary>
    public class gms
    {
        private int grados; // grados
        private int minutos; // minutos
        private double segundos; // segundos
        private int maximoGrado;  // valor límite para los grados

        /// <summary>
        /// Esto es el constructor
        /// </summary>
        /// <param name="max">Esto es un parametro para saber el maximos</param>
        public gms(int max)
        {
            Grados = Minutos = 0;
            Segundos = 0.0;
            this.maximoGrado = max;
        }
        /// <summary>
        /// Esto te hace es validar si los grados son validos o no y si estan en el limite
        /// <exception cref="ArgumentOutOfRangeException">El grado no es validos</exception>
        /// </summary>
        public int Grados
        {
            get => grados;
            set
            {
                if (value >= -maximoGrado && value <= maximoGrado) grados = value;
                else throw new ArgumentOutOfRangeException("Grados no válidos");
            }
        }
        /// <summary>
        /// Esto lo uqe hace es validar si los minutos estan bien o se pasa del limite
        /// <exception cref="ArgumentOutOfRangeException">El grado no es validos</exception>
        /// </summary>
        public int Minutos
        {
            get => minutos;
            set
            {
                if (value >= 0 && value <= 60) minutos = value;
                else throw new ArgumentOutOfRangeException("Minutos no válidos");
            }
        }
        /// <summary>
        /// Esto lo que hace es si lo segundos son valdos y no se pasan de los minutos
        /// <exception cref="ArgumentOutOfRangeException">El grado no es validos</exception>
        /// </summary>
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

    //YAG2122
    /// <summary>
    /// Esto es una clase de cordenadas
    /// </summary>
    public class Cordenaadas
    {
        /// <summary>
        /// Esto son variables que vienen de otra clase
        /// /// </summary>
        public gms longitud = new gms(180); // longitud
        public gms latitud = new gms(90); // latitud

      
        /// <summary>
        /// Esto es un Construcotr 
        /// </summary>
        /// <param name="gradosLongitud">Este es el parametro de longitud</param>
        /// <param name="gradosLatitud">Este es el parametro de latitud</param>
        public Cordenaadas(double gradosLongitud, double gradosLatitud)
        {
            // primero pasamos la longitud de grados a GMS
            longitud.Grados = (int)gradosLongitud;
            // ahora calculamos los minutos, hay que eliminar el signo
            gradosLongitud = Math.Abs((gradosLongitud - longitud.Grados)*60.0);
            longitud.Minutos =(int)(gradosLongitud);
            // por último los segundos
            longitud.Segundos = (gradosLongitud - longitud.Minutos)*60.0;

            // Ahora hacemos lo mismo con la latitud
            latitud.Grados = (int)gradosLatitud;
            // ahora calculamos los minutos, hay que eliminar el signo
            gradosLatitud = Math.Abs((gradosLatitud - latitud.Grados)*60.0);
            latitud.Minutos = (int)(gradosLatitud);
            // por último los segundos
            latitud.Segundos = (gradosLatitud - latitud.Minutos)*60.0;
        }
    }
}
