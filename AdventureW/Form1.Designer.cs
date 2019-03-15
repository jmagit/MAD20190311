namespace AdventureW {
    partial class Form1 {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label productCategoryIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label rowguidLabel;
            System.Windows.Forms.Label modifiedDateLabel;
            this.productCategoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.productCategoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.productCategoryIDLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.rowguidTextBox = new System.Windows.Forms.TextBox();
            this.modifiedDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.consola = new System.Windows.Forms.RichTextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnDA = new System.Windows.Forms.Button();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aWDataSet = new AdventureW.AWDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryTableAdapter = new AdventureW.AWDataSetTableAdapters.ProductCategoryTableAdapter();
            this.tableAdapterManager = new AdventureW.AWDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            productCategoryIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            rowguidLabel = new System.Windows.Forms.Label();
            modifiedDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingNavigator)).BeginInit();
            this.productCategoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aWDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // productCategoryBindingNavigator
            // 
            this.productCategoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productCategoryBindingNavigator.BindingSource = this.productCategoryBindingSource;
            this.productCategoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productCategoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productCategoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productCategoryBindingNavigatorSaveItem});
            this.productCategoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productCategoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productCategoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productCategoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productCategoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productCategoryBindingNavigator.Name = "productCategoryBindingNavigator";
            this.productCategoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productCategoryBindingNavigator.Size = new System.Drawing.Size(745, 25);
            this.productCategoryBindingNavigator.TabIndex = 0;
            this.productCategoryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // productCategoryBindingNavigatorSaveItem
            // 
            this.productCategoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productCategoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productCategoryBindingNavigatorSaveItem.Image")));
            this.productCategoryBindingNavigatorSaveItem.Name = "productCategoryBindingNavigatorSaveItem";
            this.productCategoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productCategoryBindingNavigatorSaveItem.Text = "Guardar datos";
            this.productCategoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.productCategoryBindingNavigatorSaveItem_Click);
            // 
            // productCategoryDataGridView
            // 
            this.productCategoryDataGridView.AllowUserToAddRows = false;
            this.productCategoryDataGridView.AllowUserToDeleteRows = false;
            this.productCategoryDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productCategoryDataGridView.AutoGenerateColumns = false;
            this.productCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productCategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.productCategoryDataGridView.DataSource = this.productCategoryBindingSource;
            this.productCategoryDataGridView.Location = new System.Drawing.Point(16, 25);
            this.productCategoryDataGridView.Name = "productCategoryDataGridView";
            this.productCategoryDataGridView.ReadOnly = true;
            this.productCategoryDataGridView.Size = new System.Drawing.Size(717, 131);
            this.productCategoryDataGridView.TabIndex = 1;
            // 
            // productCategoryIDLabel
            // 
            productCategoryIDLabel.AutoSize = true;
            productCategoryIDLabel.Location = new System.Drawing.Point(16, 170);
            productCategoryIDLabel.Name = "productCategoryIDLabel";
            productCategoryIDLabel.Size = new System.Drawing.Size(106, 13);
            productCategoryIDLabel.TabIndex = 2;
            productCategoryIDLabel.Text = "Product Category ID:";
            // 
            // productCategoryIDLabel1
            // 
            this.productCategoryIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCategoryBindingSource, "ProductCategoryID", true));
            this.productCategoryIDLabel1.Location = new System.Drawing.Point(128, 170);
            this.productCategoryIDLabel1.Name = "productCategoryIDLabel1";
            this.productCategoryIDLabel1.Size = new System.Drawing.Size(200, 23);
            this.productCategoryIDLabel1.TabIndex = 3;
            this.productCategoryIDLabel1.Text = "label1";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(16, 199);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCategoryBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(104, 196);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // rowguidLabel
            // 
            rowguidLabel.AutoSize = true;
            rowguidLabel.Location = new System.Drawing.Point(16, 225);
            rowguidLabel.Name = "rowguidLabel";
            rowguidLabel.Size = new System.Drawing.Size(47, 13);
            rowguidLabel.TabIndex = 6;
            rowguidLabel.Text = "rowguid:";
            // 
            // rowguidTextBox
            // 
            this.rowguidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productCategoryBindingSource, "rowguid", true));
            this.rowguidTextBox.Location = new System.Drawing.Point(104, 222);
            this.rowguidTextBox.Name = "rowguidTextBox";
            this.rowguidTextBox.Size = new System.Drawing.Size(200, 20);
            this.rowguidTextBox.TabIndex = 7;
            // 
            // modifiedDateLabel
            // 
            modifiedDateLabel.AutoSize = true;
            modifiedDateLabel.Location = new System.Drawing.Point(16, 252);
            modifiedDateLabel.Name = "modifiedDateLabel";
            modifiedDateLabel.Size = new System.Drawing.Size(76, 13);
            modifiedDateLabel.TabIndex = 8;
            modifiedDateLabel.Text = "Modified Date:";
            // 
            // modifiedDateDateTimePicker
            // 
            this.modifiedDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productCategoryBindingSource, "ModifiedDate", true));
            this.modifiedDateDateTimePicker.Location = new System.Drawing.Point(104, 248);
            this.modifiedDateDateTimePicker.Name = "modifiedDateDateTimePicker";
            this.modifiedDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.modifiedDateDateTimePicker.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.productCategoryBindingSource;
            // 
            // consola
            // 
            this.consola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consola.Location = new System.Drawing.Point(415, 170);
            this.consola.Name = "consola";
            this.consola.Size = new System.Drawing.Size(318, 138);
            this.consola.TabIndex = 10;
            this.consola.Text = "";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(334, 170);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnDA
            // 
            this.btnDA.Location = new System.Drawing.Point(334, 188);
            this.btnDA.Name = "btnDA";
            this.btnDA.Size = new System.Drawing.Size(75, 23);
            this.btnDA.TabIndex = 12;
            this.btnDA.Text = "DA";
            this.btnDA.UseVisualStyleBackColor = true;
            this.btnDA.Click += new System.EventHandler(this.btnDA_Click);
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataMember = "ProductCategory";
            this.productCategoryBindingSource.DataSource = this.aWDataSet;
            // 
            // aWDataSet
            // 
            this.aWDataSet.DataSetName = "AWDataSet";
            this.aWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductCategoryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductCategoryID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "rowguid";
            this.dataGridViewTextBoxColumn3.HeaderText = "rowguid";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ModifiedDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "ModifiedDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // productCategoryTableAdapter
            // 
            this.productCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductCategoryTableAdapter = this.productCategoryTableAdapter;
            this.tableAdapterManager.ProductSubcategoryTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ScrapReasonTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AdventureW.AWDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "EF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDA);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.consola);
            this.Controls.Add(productCategoryIDLabel);
            this.Controls.Add(this.productCategoryIDLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(rowguidLabel);
            this.Controls.Add(this.rowguidTextBox);
            this.Controls.Add(modifiedDateLabel);
            this.Controls.Add(this.modifiedDateDateTimePicker);
            this.Controls.Add(this.productCategoryDataGridView);
            this.Controls.Add(this.productCategoryBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingNavigator)).EndInit();
            this.productCategoryBindingNavigator.ResumeLayout(false);
            this.productCategoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aWDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AWDataSet aWDataSet;
        private System.Windows.Forms.BindingSource productCategoryBindingSource;
        private AWDataSetTableAdapters.ProductCategoryTableAdapter productCategoryTableAdapter;
        private AWDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productCategoryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productCategoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productCategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label productCategoryIDLabel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox rowguidTextBox;
        private System.Windows.Forms.DateTimePicker modifiedDateDateTimePicker;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.RichTextBox consola;
        private System.Windows.Forms.Button btnDA;
        private System.Windows.Forms.Button button1;
    }
}

