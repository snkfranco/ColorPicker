using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2Panel1.BackColor = Color.FromArgb(TRACK_RED.Value,TRACK_GREEN.Value,TRACK_BLUE.Value);
            LBL_RED.Text = TRACK_RED.Value.ToString();
            LBL_GREEN.Text = TRACK_GREEN.Value.ToString();
            LBL_BLUE.Text = TRACK_BLUE.Value.ToString();

            LBL_RGB.Text = TRACK_RED.Value.ToString()  + "; " + TRACK_GREEN.Value.ToString() + "; " + TRACK_BLUE.Value.ToString();

            string hex = "#" + TRACK_RED.Value.ToString("X2") + TRACK_GREEN.Value.ToString("X2") + TRACK_BLUE.Value.ToString("X2");
            LBL_HEX.Text = hex;

        }

        private void LBL_RGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LBL_RGB.Text);
            MostrarLabelCopiedRGB();
        }

        private void LBL_HEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(LBL_HEX.Text);
            MostrarLabelCopiedHEX();
        }

        private void MostrarLabelCopiedRGB()
        {
            // Exibe a label "Copied!"
            LBL_CopiedRGB.Visible = true;
            LBL_CopiedRGB.Text = "✔️";
            LBL_CopiedRGB.ForeColor = Color.FromArgb(90,175,120) ; // Cor verde para indicar que foi copiado

            // Inicia o temporizador para ocultar a label "Copied!" após 2 segundos
            Timer timer = new Timer();
            timer.Interval = 2000; // 2 segundos
            timer.Tick += (sender, e) =>
            {
                // Oculta a label "Copied!"
                LBL_CopiedRGB.Visible = false;

                // Libera os recursos do temporizador
                timer.Dispose();
            };
            timer.Start();
        }

        private void MostrarLabelCopiedHEX()
        {
            // Exibe a label "Copied!"
            LBL_CopiedHEX.Visible = true;
            LBL_CopiedHEX.Text = "✔️";
            LBL_CopiedHEX.ForeColor = Color.FromArgb(90, 175, 120); // Cor verde para indicar que foi copiado

            // Inicia o temporizador para ocultar a label "Copied!" após 2 segundos
            Timer timer = new Timer();
            timer.Interval = 2000; // 2 segundos
            timer.Tick += (sender, e) =>
            {
                // Oculta a label "Copied!"
                LBL_CopiedHEX.Visible = false;

                // Libera os recursos do temporizador
                timer.Dispose();
            };
            timer.Start();
        }

    }
}
