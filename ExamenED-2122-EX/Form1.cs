using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gsmconv;

namespace ExamenED_2122_EX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            Coordenadas myCoords = new Coordenadas(double.Parse(txtLongitud.Text), double.Parse(txtLatitud.Text));

            txtGradosLong.Text = myCoords.longitud.Grados.ToString();
            txtMinutosLong.Text = myCoords.longitud.Minutos.ToString();
            txtSegundosLong.Text = myCoords.longitud.Segundos.ToString("0.00");

            txtGradosLat.Text = myCoords.latitud.Grados.ToString();
            txtMinutosLat.Text = myCoords.latitud.Minutos.ToString();
            txtSegundosLat.Text = myCoords.latitud.Segundos.ToString("0.00");
        }
    }
}
