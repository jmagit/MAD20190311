namespace Calculadora {
    partial class frmCalculadora {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.pnlClose = new System.Windows.Forms.Panel();
            this.ucCalculadora1 = new Calculadora.ucCalculadora();
            this.SuspendLayout();
            // 
            // pnlClose
            // 
            this.pnlClose.BackColor = System.Drawing.Color.Transparent;
            this.pnlClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlClose.Location = new System.Drawing.Point(145, 137);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(28, 38);
            this.pnlClose.TabIndex = 1;
            this.pnlClose.Click += new System.EventHandler(this.pnlClose_Click);
            // 
            // ucCalculadora1
            // 
            this.ucCalculadora1.Location = new System.Drawing.Point(326, 48);
            this.ucCalculadora1.Name = "ucCalculadora1";
            this.ucCalculadora1.Size = new System.Drawing.Size(270, 327);
            this.ucCalculadora1.TabIndex = 0;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 452);
            this.Controls.Add(this.pnlClose);
            this.Controls.Add(this.ucCalculadora1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCalculadora";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private ucCalculadora ucCalculadora1;
        private System.Windows.Forms.Panel pnlClose;
    }
}

