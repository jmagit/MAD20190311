using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeEscritorio {
    public partial class LabelText : UserControl {
        public LabelText() {
            InitializeComponent();
        }

        public string Caption {
            get {
                return label1.Text;
            }
            set {
                label1.Text = value;
            }
        }
    }
}
