using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AMG22;

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
            Coordenadas myCoords = new Coordenadas(double.Parse(txtLatitud.Text), double.Parse(txtLongitud.Text));

            txtGradosLong.Text = myCoords.longitud.cGrados.ToString();
            txtMinutosLong.Text = myCoords.longitud.cMinutos.ToString();
            txtSegundosLong.Text = myCoords.longitud.cSegundos.ToString("0.00");

            txtGradosLat.Text = myCoords.latitud.cGrados.ToString();
            txtMinutosLat.Text = myCoords.latitud.cMinutos.ToString();
            txtSegundosLat.Text = myCoords.latitud.cSegundos.ToString("0.00");
        }
    }
}
