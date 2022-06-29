using System;

namespace DMP2122Examen
{
    /// <summary>
    /// Clase que convierte coordenadas en grados, minutos y segundos
    /// </summary>
    /// <remarks>Saltan tres excepciones: cuando los valores de
    /// los grados no son correctos<see cref=">ExcepcionGrados"/> cuando los valores de los minutos no
    /// son correctos<see cref=">ExcepcionMinutos"/> y cuando los valores de los segundos no
    /// son correctos<see cref=">ExcepcionSegundos"/></remarks>
    public class GradosMinutosSegundos
    {
        public const string ExcepcionGrados = "Grados no válidos";
        public const string ExcepcionMinutos = "Minutos no válidos";
        public const string ExcepcionSegundos = "Segundos no válidos";

        private int grados; // grados
        private int minutos; // minutos
        private double segundos; // segundos
        private int maximoGrado;  // valor límite para los grados

        /// <summary>
        /// Inicializamos las variables
        /// </summary>
        /// <param name="maximo">variable que establece el máximo de los valores</param>
        public GradosMinutosSegundos(int maximo)
        {
            Grados = Minutos = 0;
            Segundos = 0.0;
            this.maximoGrado = maximo;
        }

        /// <summary>
        /// Getters y setters de cada variable
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Salta la excepción cuando los valores de los
        /// grados no son correctos</exception>
        public int Grados
        {
            get => grados;
            set
            {
                if (value >= -maximoGrado && value <= maximoGrado) grados = value;
                else throw new ArgumentOutOfRangeException(ExcepcionGrados);
            }
        }
        public int Minutos
        {
            get => minutos;
            set
            {
                if (value >= 0 && value <= 60) minutos = value;
                else throw new ArgumentOutOfRangeException(ExcepcionMinutos);
            }
        }
        public double Segundos
        {
            get => segundos;
            set
            {
                if (value >= 0 && value <= 60) segundos = value;
                else throw new ArgumentOutOfRangeException(ExcepcionSegundos);
            }
        }
    }

    /// <summary>
    /// clase que calcula los grados, minutos y segundos
    /// <para>a raiz de la longitud y la latidud introducidas</para>
    /// </summary>
    public class Coordenadas
    {
        /// <summary>
        /// se crean los objetos longitud y latitud de la clase<see cref=">GradosMinutosSegundos"/>
        /// </summary>
        public GradosMinutosSegundos longitud = new GradosMinutosSegundos(180); // longitud
        public GradosMinutosSegundos latitud = new GradosMinutosSegundos(90); // latitud

        /// <summary>
        /// método que calcula los grados, minutos y segundos
        /// <para>nos devuelve los grados minutos y segundos de la longitud</para>
        /// <para>nos devuleve los grados minutos y segundos de la latitud</para>
        /// </summary>
        /// <param name="glongitud">se introduce la longitud</param>
        /// <param name="glatitud">se introduce la latitud</param>
        public Coordenadas(double glongitud, double glatitud)
        {   
            glongitud = CalcularLongitud(glongitud);    
            glatitud = CalcularLatitud(glatitud);
        }

        /// <summary>
        /// Método que calcula los grados, minutos y segundos a partir de la latitud introducida
        /// </summary>
        /// <param name="glatitud">latitud introducida</param>
        /// <returns>nos devuelve los grados, minutos y segundos de dicha latitud</returns>
        private double CalcularLatitud(double glatitud)
        {
            latitud.Grados = (int)glatitud;
            glatitud = Math.Abs((glatitud - latitud.Grados) * 60.0);
            latitud.Minutos = (int)(glatitud);
            latitud.Segundos = (glatitud - latitud.Minutos) * 60.0;
            return glatitud;
        }

        /// <summary>
        /// Método que calcula los grados, minutos y segundos a partir de la longtitud introducida
        /// </summary>
        /// <param name="glongitud">longitud introducida</param>
        /// <returns>nos devuelve los grados, minutos y segundos de dicha  longitud</returns>
        private double CalcularLongitud(double glongitud)
        {
            longitud.Grados = (int)glongitud;
            glongitud = Math.Abs((glongitud - longitud.Grados) * 60.0);
            longitud.Minutos = (int)(glongitud);
            longitud.Segundos = (glongitud - longitud.Minutos) * 60.0;
            return glongitud;
        }
    }
}
