using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeEscritorio {
    public partial class frmPrincipal : Form {
        public frmPrincipal() {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            lbResultado.Text = $"Hola {txtTitulo.Text ?? "Mundo"}";
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e) {
           

        }

        private void btnOtro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            var btn = sender as LinkLabel;
            var frm = new Form();
            if (btn.Text == "Dependiente") {
                frm.Owner = this;
            }
            frm.Text = btn.Text;
            frm.Show();
        }

        private void btnCDialog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            var dlg = new dlgHijo();
            dlg.Owner = this;
            if (dlg.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Acepta", "Resultado", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Cancela", "Resultado", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
