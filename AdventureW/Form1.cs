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
using AdventureW.AWDataSetTableAdapters;

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

        private void btnDA_Click(object sender, EventArgs e) {
            var ds = new AWDataSet();
            var dta = new ProductTableAdapter();
            dta.Adapter.SelectCommand = new SqlCommand("SELECT ProductID, Name, ProductNumber, MakeFlag, FinishedGoodsFlag, Color, SafetyStockLevel, ReorderPoint, StandardCost, ListPrice, Size, SizeUnitMeasureCode, WeightUnitMeasureCode, Weight, DaysToManufacture, ProductLine, Class, Style, ProductSubcategoryID, ProductModelID, SellStartDate, SellEndDate, DiscontinuedDate, rowguid, ModifiedDate FROM Production.Product where ProductSubcategoryID is not null");
            dta.Fill(ds.Product);
            consola.Text = "";
            foreach(var rslt in ds.Product
                .Where(p => p.ProductSubcategoryID == int.Parse(productCategoryIDLabel1.Text))
                .Take(10)
                .Select(p => new { id = p.ProductID, nombre = p.Name })
                ) {
                consola.Text += $"{rslt.id}\t{rslt.nombre}\n";
            }
            //ds.Product.AddProductRow()
//            var ds = new AWDataSet();
//            var dta = new ProductTableAdapter();
//            var dt = new DataTable();
//            var da = new SqlDataAdapter("SELECT ProductID, Name, ProductNumber, MakeFlag, FinishedGoodsFlag, Color, SafetyStockLevel, ReorderPoint, StandardCost, ListPrice, Size, SizeUnitMeasureCode, WeightUnitMeasureCode, Weight, DaysToManufacture, ProductLine, Class, Style, ProductSubcategoryID, ProductModelID, SellStartDate, SellEndDate, DiscontinuedDate, rowguid, ModifiedDate FROM Production.Product where ProductSubcategoryID is not null",
//                Settings.Default.AWConnectionString
//                );
//            da.Fill(dt);
//            consola.Text = "";
//            foreach(DataRow rslt in dt.Rows
//                //.Where(p => p.ProductSubcategoryID == int.Parse(productCategoryIDLabel1.Text))
//                //.Take(10)
//                //.Select(p => new { id = p.ProductID, nombre = p.Name})
//                ) {
//                    consola.Text += $"{rslt[0]}\t{rslt[1]}\n";
////                    consola.Text += $"{rslt.id}\t{rslt.nombre}\n";
//            }
//            //ds.Product.AddProductRow()
        }

        private void button1_Click(object sender, EventArgs e) {
            var db = new AWEntities();

            var lista = db.Product.Where(p => p.ProductSubcategoryID != null)
                .Take(10).ToList();

            consola.Text = "";
            foreach (var rslt in lista) {
                consola.Text += $"{rslt.ProductID}\t{rslt.Name}\n";
            }
        }
    }
}
