using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora {
    public partial class ucCalculadora : UserControl {
        private double acumulador = 0.0;
        private string operador = "+";
        private bool limpia = false;

        public ucCalculadora() {
            InitializeComponent();
        }

        private void btnDigitoClick(object sender, EventArgs e) {
            PonDigito((sender as Button).Text);
        }
        private void btnOperadoresClick(object sender, EventArgs e) {
            Calcular((sender as Button).Text);
        }

        private void PonDigito(string digito) {
            if (Pantalla.Text == "0" || limpia) {
                Pantalla.Text = digito;
                limpia = false;
            } else
                Pantalla.Text += digito;
        }
        private void Calcular(string operador) {
            Calcular();
            this.operador = operador;
        }

        private void Calcular() {
            switch (operador) {
                case "+":
                    acumulador += Convert.ToDouble(Pantalla.Text);
                    break;
                case "-":
                    acumulador -= Convert.ToDouble(Pantalla.Text);
                    break;
                case "*":
                    acumulador *= Convert.ToDouble(Pantalla.Text);
                    break;
                case "/":
                    acumulador /= Convert.ToDouble(Pantalla.Text);
                    break;
                case "=":
                    acumulador = Convert.ToDouble(Pantalla.Text);
                    break;
            }
            Pantalla.Text = acumulador.ToString();
            limpia = true;
        }

        private void btnNueva_Click(object sender, EventArgs e) {
            acumulador = 0.0;
            operador = "+";
            limpia = false;
            Pantalla.Text = "0";
        }

        private void btnComa_Click(object sender, EventArgs e) {
            if (limpia) {
                limpia = false;
                Pantalla.Text = "0,";
            } else
                if (Pantalla.Text.IndexOf(",") == -1)
                    Pantalla.Text += ",";
        }

        private void btnMasMenos_Click(object sender, EventArgs e) {
            Pantalla.Text = Convert.ToString(-1 * Convert.ToDouble(Pantalla.Text));
            if (limpia) acumulador = -acumulador;
        }

        private void btnRetroceso_Click(object sender, EventArgs e) {
            if (limpia && Pantalla.Text.Length == 1) {
                limpia = false;
                Pantalla.Text = "0";
            } else
                Pantalla.Text = Pantalla.Text.Remove(Pantalla.Text.Length - 1, 1);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e) {
            (Parent as Form).Close();
        }

        private void ucCalculadora_KeyPress(object sender, KeyPressEventArgs e) {
            if ('0' <= e.KeyChar && e.KeyChar <= '9') {
                PonDigito(e.KeyChar.ToString());
            } else if (e.KeyChar == 8)
                btnRetroceso_Click(null, null);
            else if (e.KeyChar == ',' || e.KeyChar == '.')
                btnComa_Click(null, null);
            else if ("+-*/=".IndexOf(e.KeyChar) >= 0)
                Calcular(e.KeyChar.ToString());
        }
    }
}
