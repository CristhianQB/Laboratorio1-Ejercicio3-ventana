using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio1_Ejercicio3_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float par1 = float.Parse(txtb1.Text);
            float par2 = float.Parse(txtb2.Text);
            float par3 = float.Parse(txtb3.Text);
            float examen = float.Parse(txtb4.Text);
            float trabajo = float.Parse(txtb5.Text);

            double notafinal = 0.55 * (par1 + par2 + par3) / 3 + 0.30 * examen + 0.15 * trabajo;

            lbl.Text = notafinal.ToString();
        }
    }
}
