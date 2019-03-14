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
    public partial class dlgHijo : dlgFormulario {
        public dlgHijo() {
            InitializeComponent();
        }
        protected override bool cmdAceptar() {
            if(txtDemo.Text == "")
                this.errorProvider1.SetError(this.txtDemo, "No puede estar en blanco");
            else
                this.errorProvider1.SetError(this.txtDemo, "");
            return txtDemo.Text != "";
        }
    }
}
