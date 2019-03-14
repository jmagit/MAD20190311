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
    public partial class dlgFormulario : Form {
        public dlgFormulario() {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e) {
            if(cmdAceptar())
                DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            if(cmdCancelar())
                DialogResult = DialogResult.Cancel;
        }

        protected virtual bool cmdAceptar() { return true; }
        protected virtual bool cmdCancelar() { return true; }
    }
}
