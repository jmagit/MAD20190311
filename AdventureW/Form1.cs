using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdventureW.Properties;

namespace AdventureW {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void productCategoryBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.productCategoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aWDataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'aWDataSet.ProductCategory' Puede moverla o quitarla según sea necesario.
            this.productCategoryTableAdapter.Fill(this.aWDataSet.ProductCategory);

        }

        private void btnConsultar_Click(object sender, EventArgs e) {
            var conn = new SqlConnection(Settings.Default.AWConnectionString);
            //var tran = conn.BeginTransaction();
            //tran.Rollback();
            var cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ProductSubcategoryID, ProductCategoryID, Name, rowguid, ModifiedDate " +
                    " FROM Production.ProductSubcategory " +
                    " where ProductCategoryID = @IdCategoria";
            cmd.Parameters.Add(
                new SqlParameter("@IdCategoria", productCategoryIDLabel1.Text));
            cmd.Connection.Open();
            var dr = cmd.ExecuteReader();
            consola.Text = "";
            while(dr.Read()) {
                consola.Text += $"{dr[0]}\t{dr[1]}\t{dr[2]}\n";
            }
            dr.Close();
            cmd.Connection.Close();
        }
    }
}
