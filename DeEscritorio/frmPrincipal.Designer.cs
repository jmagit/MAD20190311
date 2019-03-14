namespace DeEscritorio {
    partial class frmPrincipal {
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
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.btnOtro = new System.Windows.Forms.LinkLabel();
            this.btnDependiente = new System.Windows.Forms.LinkLabel();
            this.btnCDialog = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorProvider1.SetError(this.txtTitulo, "dddddd");
            this.txtTitulo.Location = new System.Drawing.Point(13, 13);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(210, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = global::DeEscritorio.Properties.Settings.Default.buttonColorFondo;
            this.btnAceptar.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", global::DeEscritorio.Properties.Settings.Default, "buttonColorLetra", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAceptar.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DeEscritorio.Properties.Settings.Default, "buttonColorFondo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnAceptar.ForeColor = global::DeEscritorio.Properties.Settings.Default.buttonColorLetra;
            this.btnAceptar.Location = new System.Drawing.Point(229, 10);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Pulsar";
            this.toolTip1.SetToolTip(this.btnAceptar, "xxxxx");
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(13, 40);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(60, 13);
            this.lbResultado.TabIndex = 2;
            this.lbResultado.Text = "(pendiente)";
            // 
            // btnOtro
            // 
            this.btnOtro.AutoSize = true;
            this.btnOtro.Location = new System.Drawing.Point(229, 40);
            this.btnOtro.Name = "btnOtro";
            this.btnOtro.Size = new System.Drawing.Size(27, 13);
            this.btnOtro.TabIndex = 3;
            this.btnOtro.TabStop = true;
            this.btnOtro.Text = "Otro";
            this.btnOtro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnOtro_LinkClicked);
            // 
            // btnDependiente
            // 
            this.btnDependiente.AutoSize = true;
            this.btnDependiente.Location = new System.Drawing.Point(229, 64);
            this.btnDependiente.Name = "btnDependiente";
            this.btnDependiente.Size = new System.Drawing.Size(68, 13);
            this.btnDependiente.TabIndex = 4;
            this.btnDependiente.TabStop = true;
            this.btnDependiente.Text = "Dependiente";
            this.btnDependiente.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnOtro_LinkClicked);
            // 
            // btnCDialog
            // 
            this.btnCDialog.AutoSize = true;
            this.btnCDialog.Location = new System.Drawing.Point(229, 86);
            this.btnCDialog.Name = "btnCDialog";
            this.btnCDialog.Size = new System.Drawing.Size(53, 13);
            this.btnCDialog.TabIndex = 5;
            this.btnCDialog.TabStop = true;
            this.btnCDialog.Text = "C.Dialogo";
            this.btnCDialog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCDialog_LinkClicked);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(316, 203);
            this.Controls.Add(this.btnCDialog);
            this.Controls.Add(this.btnDependiente);
            this.Controls.Add(this.btnOtro);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTitulo);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbResultado;
        public System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.LinkLabel btnOtro;
        private System.Windows.Forms.LinkLabel btnDependiente;
        private System.Windows.Forms.LinkLabel btnCDialog;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}