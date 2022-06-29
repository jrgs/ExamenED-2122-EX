namespace gsmconv
{
    using System;
    // Agustin Perez APC 1DAW 2122
    /// <summary>
    /// Defines the <see cref="GradosMinSeg" />.
    /// </summary>
    public class GradosMinSeg
    {
        /// <summary>
        /// Defines the grados.
        /// </summary>
        private int grados;// grados

        /// <summary>
        /// Defines the minutos.
        /// </summary>
        private int minutos;// minutos

        /// <summary>
        /// Defines the segundos.
        /// </summary>
        private double segundos;// segundos
        
        /// <summary>
        /// Defines the gradosMax.
        /// </summary>
        private int gradosMax;// valor límite para los grados

        /// <summary>
        /// Gets or sets the Grados.
        /// </summary>
        public int Grados
        {
            get => grados;
            set
            {
                if (value >= -gradosMax && value <= gradosMax)
                    grados = value;
                else
                    throw new ArgumentOutOfRangeException("Grados no válidos");
            }
        }

        /// <summary>
        /// Gets or sets the Minutos.
        /// </summary>
        public int Minutos
        {
            get => minutos;
            set
            {
                if (value >= 0 && value <= 60)
                    minutos = value;
                else
                    throw new ArgumentOutOfRangeException("Minutos no válidos");
            }
        }

        /// <summary>
        /// Gets or sets the Segundos.
        /// </summary>
        public double Segundos
        {
            get => segundos;
            set
            {
                if (value >= 0 && value <= 60)
                    segundos = value;
                else
                    throw new ArgumentOutOfRangeException("Segundos no válidos");
            }
        }

        /// <summary>
        /// Gets or sets the GradosMax.
        /// </summary>
        public int GradosMax
        {
            get => gradosMax;
            set
            {
                gradosMax = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GradosMinSeg"/> class.
        /// </summary>
        /// <param name="max">The max<see cref="int"/>.</param>
        public GradosMinSeg(int max)
        {
            Grados = Minutos = 0;
            Segundos = 0.0;
            this.gradosMax = max;
        }
    }

    /// <summary>
    /// Defines the <see cref="Coordenadas" />.
    /// </summary>
    public class Coordenadas
    {
        /// <summary>
        /// Defines the longitudMax.
        /// </summary>
        internal const int longitudMax = 180;

        /// <summary>
        /// Defines the latitudMax.
        /// </summary>
        internal const int latitudMax = 90;

        /// <summary>
        /// Defines the longitud.
        /// </summary>
        public GradosMinSeg longitud = new GradosMinSeg(longitudMax);// longitud

        /// <summary>
        /// Defines the latitud.
        /// </summary>
        public GradosMinSeg latitud = new GradosMinSeg(latitudMax);// latitud

        /// <summary>
        /// Initializes a new instance of the <see cref="Coordenadas"/> class.
        /// </summary>
        /// <param name="gradosLongitud">The gradosLongitud<see cref="double"/>.</param>
        /// <param name="gradosLatitud">The gradosLatitud<see cref="double"/>.</param>
        public Coordenadas(double gradosLongitud, double gradosLatitud)
        {
            // primero pasamos la longitud de grados a GMS
            longitud.Grados = (int)(gradosLongitud);

            // ahora calculamos los minutos, hay que eliminar el signo
            gradosLongitud = Math.Abs((gradosLongitud - longitud.Grados) * 60.0);

            // los minutos
            longitud.Minutos = (int)(gradosLongitud);

            // por último los segundos
            longitud.Segundos = Math.Abs((gradosLongitud - longitud.Minutos) * 60.0);

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
