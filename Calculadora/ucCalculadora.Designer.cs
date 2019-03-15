namespace Calculadora {
    partial class ucCalculadora {
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCalculadora));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ArchivolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnRetroceso = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnPor = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnEntre = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnComa = new System.Windows.Forms.Button();
            this.btnMasMenos = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(298, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ArchivolStripMenuItem1
            // 
            this.ArchivolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.ArchivolStripMenuItem1.Name = "ArchivolStripMenuItem1";
            this.ArchivolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.ArchivolStripMenuItem1.Text = "&Archivo";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = -1;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2});
            this.menuItem1.Text = "&Archivo";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlF4;
            this.menuItem2.Text = "&Salir";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = -1;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem4});
            this.menuItem3.Text = "&Archivo";
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 0;
            this.menuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlF4;
            this.menuItem4.Text = "&Salir";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnIgual, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNueva, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRetroceso, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMas, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEntre, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnComa, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnMenos, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMasMenos, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPor, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 285);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Pantalla
            // 
            this.Pantalla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pantalla.BackColor = System.Drawing.Color.ForestGreen;
            this.Pantalla.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.ForeColor = System.Drawing.Color.Yellow;
            this.Pantalla.Location = new System.Drawing.Point(13, 36);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.ReadOnly = true;
            this.Pantalla.Size = new System.Drawing.Size(273, 38);
            this.Pantalla.TabIndex = 22;
            this.Pantalla.TabStop = false;
            this.Pantalla.Text = "0";
            this.Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Pantalla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucCalculadora_KeyPress);
            // 
            // btnNueva
            // 
            this.btnNueva.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNueva.BackgroundImage")));
            this.btnNueva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNueva.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.ForeColor = System.Drawing.Color.Red;
            this.btnNueva.Location = new System.Drawing.Point(3, 3);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(62, 51);
            this.btnNueva.TabIndex = 23;
            this.btnNueva.Text = "C";
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnRetroceso
            // 
            this.btnRetroceso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRetroceso.BackgroundImage")));
            this.tableLayoutPanel1.SetColumnSpan(this.btnRetroceso, 2);
            this.btnRetroceso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRetroceso.Font = new System.Drawing.Font("Wingdings", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnRetroceso.ForeColor = System.Drawing.Color.Red;
            this.btnRetroceso.Location = new System.Drawing.Point(71, 3);
            this.btnRetroceso.Name = "btnRetroceso";
            this.btnRetroceso.Size = new System.Drawing.Size(130, 51);
            this.btnRetroceso.TabIndex = 25;
            this.btnRetroceso.Text = "ç";
            this.btnRetroceso.Click += new System.EventHandler(this.btnRetroceso_Click);
            // 
            // btnMas
            // 
            this.btnMas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMas.BackgroundImage")));
            this.btnMas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMas.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMas.ForeColor = System.Drawing.Color.Red;
            this.btnMas.Location = new System.Drawing.Point(207, 3);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(63, 51);
            this.btnMas.TabIndex = 25;
            this.btnMas.Text = "+";
            this.btnMas.Click += new System.EventHandler(this.btnOperadoresClick);
            // 
            // btn7
            // 
            this.btn7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn7.BackgroundImage")));
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn7.Location = new System.Drawing.Point(3, 60);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(62, 51);
            this.btn7.TabIndex = 26;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btnDigitoClick);
            // 
            // btn8
            // 
            this.btn8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn8.BackgroundImage")));
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn8.Location = new System.Drawing.Point(71, 60);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(62, 51);
            this.btn8.TabIndex = 27;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btnDigitoClick);
            // 
            // btn9
            // 
            this.btn9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn9.BackgroundImage")));
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn9.Location = new System.Drawing.Point(139, 60);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(62, 51);
            this.btn9.TabIndex = 28;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btnDigitoClick);
            // 
            // btnMenos
            // 
            this.btnMenos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenos.BackgroundImage")));
            this.btnMenos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMenos.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.ForeColor = System.Drawing.Color.Red;
            this.btnMenos.Location = new System.Drawing.Point(207, 60);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(63, 51);
            this.btnMenos.TabIndex = 29;
            this.btnMenos.Text = "-";
            this.btnMenos.Click += new System.EventHandler(this.btnOperadoresClick);
            // 
            // btn4
            // 
            this.btn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn4.BackgroundImage")));
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn4.Location = new System.Drawing.Point(3, 117);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(62, 51);
            this.btn4.TabIndex = 30;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btnDigitoClick);
            // 
            // btn5
            // 
            this.btn5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn5.BackgroundImage")));
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn5.Location = new System.Drawing.Point(71, 117);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(62, 51);
            this.btn5.TabIndex = 31;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btnDigitoClick);
            // 
            // btn6
            // 
            this.btn6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn6.BackgroundImage")));
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn6.Location = new System.Drawing.Point(139, 117);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(62, 51);
            this.btn6.TabIndex = 32;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btnDigitoClick);
            // 
            // btnPor
            // 
            this.btnPor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPor.BackgroundImage")));
            this.btnPor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPor.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPor.ForeColor = System.Drawing.Color.Red;
            this.btnPor.Location = new System.Drawing.Point(207, 117);
            this.btnPor.Name = "btnPor";
            this.btnPor.Size = new System.Drawing.Size(63, 51);
            this.btnPor.TabIndex = 33;
            this.btnPor.Text = "*";
            this.btnPor.Click += new System.EventHandler(this.btnOperadoresClick);
            // 
            // btn1
            // 
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn1.Location = new System.Drawing.Point(3, 174);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(62, 51);
            this.btn1.TabIndex = 34;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btnDigitoClick);
            // 
            // btn2
            // 
            this.btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2.BackgroundImage")));
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn2.Location = new System.Drawing.Point(71, 174);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(62, 51);
            this.btn2.TabIndex = 35;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btnDigitoClick);
            // 
            // btn3
            // 
            this.btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3.BackgroundImage")));
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn3.Location = new System.Drawing.Point(139, 174);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(62, 51);
            this.btn3.TabIndex = 36;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btnDigitoClick);
            // 
            // btnEntre
            // 
            this.btnEntre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntre.BackgroundImage")));
            this.btnEntre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEntre.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntre.ForeColor = System.Drawing.Color.Red;
            this.btnEntre.Location = new System.Drawing.Point(207, 174);
            this.btnEntre.Name = "btnEntre";
            this.btnEntre.Size = new System.Drawing.Size(63, 51);
            this.btnEntre.TabIndex = 37;
            this.btnEntre.Text = "/";
            this.btnEntre.Click += new System.EventHandler(this.btnOperadoresClick);
            // 
            // btn0
            // 
            this.btn0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn0.BackgroundImage")));
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn0.Location = new System.Drawing.Point(3, 231);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(62, 51);
            this.btn0.TabIndex = 38;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btnDigitoClick);
            // 
            // btnComa
            // 
            this.btnComa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnComa.BackgroundImage")));
            this.btnComa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComa.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComa.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnComa.Location = new System.Drawing.Point(71, 231);
            this.btnComa.Name = "btnComa";
            this.btnComa.Size = new System.Drawing.Size(62, 51);
            this.btnComa.TabIndex = 39;
            this.btnComa.Text = ",";
            this.btnComa.Click += new System.EventHandler(this.btnComa_Click);
            // 
            // btnMasMenos
            // 
            this.btnMasMenos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMasMenos.BackgroundImage")));
            this.btnMasMenos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMasMenos.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasMenos.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnMasMenos.Location = new System.Drawing.Point(139, 231);
            this.btnMasMenos.Name = "btnMasMenos";
            this.btnMasMenos.Size = new System.Drawing.Size(62, 51);
            this.btnMasMenos.TabIndex = 40;
            this.btnMasMenos.Text = "±";
            this.btnMasMenos.Click += new System.EventHandler(this.btnMasMenos_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIgual.BackgroundImage")));
            this.btnIgual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIgual.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.Red;
            this.btnIgual.Location = new System.Drawing.Point(207, 231);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(63, 51);
            this.btnIgual.TabIndex = 41;
            this.btnIgual.Text = "=";
            this.btnIgual.Click += new System.EventHandler(this.btnOperadoresClick);
            // 
            // ucCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ucCalculadora";
            this.Size = new System.Drawing.Size(298, 376);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucCalculadora_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ArchivolStripMenuItem1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected System.Windows.Forms.TextBox Pantalla;
        public System.Windows.Forms.Button btnNueva;
        public System.Windows.Forms.Button btnRetroceso;
        internal System.Windows.Forms.Button btnMas;
        internal System.Windows.Forms.Button btn7;
        internal System.Windows.Forms.Button btn8;
        internal System.Windows.Forms.Button btn9;
        internal System.Windows.Forms.Button btnMenos;
        internal System.Windows.Forms.Button btn4;
        internal System.Windows.Forms.Button btn5;
        internal System.Windows.Forms.Button btn6;
        internal System.Windows.Forms.Button btnPor;
        internal System.Windows.Forms.Button btn1;
        internal System.Windows.Forms.Button btn2;
        internal System.Windows.Forms.Button btn3;
        internal System.Windows.Forms.Button btnEntre;
        internal System.Windows.Forms.Button btn0;
        internal System.Windows.Forms.Button btnComa;
        internal System.Windows.Forms.Button btnMasMenos;
        public System.Windows.Forms.Button btnIgual;
    }
}
