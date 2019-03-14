namespace DeEscritorio {
    partial class dlgHijo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.txtDemo = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelText1 = new DeEscritorio.LabelText();
            this.labelText2 = new DeEscritorio.LabelText();
            this.labelText3 = new DeEscritorio.LabelText();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(189, 218);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(275, 218);
            // 
            // txtDemo
            // 
            this.txtDemo.Location = new System.Drawing.Point(22, 13);
            this.txtDemo.Name = "txtDemo";
            this.txtDemo.Size = new System.Drawing.Size(100, 20);
            this.txtDemo.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelText1
            // 
            this.labelText1.Caption = "fffff";
            this.labelText1.Location = new System.Drawing.Point(22, 53);
            this.labelText1.Name = "labelText1";
            this.labelText1.Size = new System.Drawing.Size(183, 56);
            this.labelText1.TabIndex = 3;
            // 
            // labelText2
            // 
            this.labelText2.Caption = "Nombre";
            this.labelText2.Location = new System.Drawing.Point(22, 116);
            this.labelText2.Name = "labelText2";
            this.labelText2.Size = new System.Drawing.Size(251, 40);
            this.labelText2.TabIndex = 4;
            // 
            // labelText3
            // 
            this.labelText3.Caption = "Apellidos";
            this.labelText3.Location = new System.Drawing.Point(22, 163);
            this.labelText3.Name = "labelText3";
            this.labelText3.Size = new System.Drawing.Size(251, 40);
            this.labelText3.TabIndex = 5;
            // 
            // dlgHijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 248);
            this.Controls.Add(this.labelText3);
            this.Controls.Add(this.labelText2);
            this.Controls.Add(this.labelText1);
            this.Controls.Add(this.txtDemo);
            this.Name = "dlgHijo";
            this.Text = "dlgHijo";
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.txtDemo, 0);
            this.Controls.SetChildIndex(this.labelText1, 0);
            this.Controls.SetChildIndex(this.labelText2, 0);
            this.Controls.SetChildIndex(this.labelText3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDemo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private LabelText labelText1;
        private LabelText labelText3;
        private LabelText labelText2;
    }
}