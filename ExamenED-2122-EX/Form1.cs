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
            coord myCoords = new coord(double.Parse(txtLatitud.Text), double.Parse(txtLongitud.Text));

            txtGradosLong.Text = myCoords.lon.G.ToString();
            txtMinutosLong.Text = myCoords.lon.M.ToString();
            txtSegundosLong.Text = myCoords.lon.S.ToString("0.00");

            txtGradosLat.Text = myCoords.lat.G.ToString();
            txtMinutosLat.Text = myCoords.lat.M.ToString();
            txtSegundosLat.Text = myCoords.lat.S.ToString("0.00");
        }
    }
}
