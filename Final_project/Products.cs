using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project
{
    public partial class Products : Form
    {
        MyDbContext db = new MyDbContext();

        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            
        }

        private void CreateProduct_Click(object sender, EventArgs e)
        {
            db.Products.Add(new Product()
            {
                //Id = 3,
                Price = Convert.ToInt32(productPrice.Text),
                ProductCategory = prodictCategory.Text,
                ProductName = productName.Text
            });
            db.SaveChanges();
            RefreshGrid();
        }
        void RefreshGrid() {
            var product = db.Products.ToList();
            DataGrid1.DataSource = product;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            var product = db.Products.Where(x=>x.ProductName.Contains(textBox9.Text)).ToList();
            DataGrid1.DataSource = product;
        }

        private void DataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGrid1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[3].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[2].Value.ToString();
                textBox6.Text = row.Cells[1].Value.ToString();
                txtuProduct.Text = row.Cells[0].Value.ToString();
            }
        }

        private void change_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtuProduct.Text);
            Product product = db.Products.FirstOrDefault(x=>x.Id == id);
            if (product != null)
            {
                product.ProductName = textBox3.Text;
                product.ProductCategory = textBox1.Text;
                product.Price = Convert.ToInt32(textBox2.Text);
                db.SaveChanges();
                RefreshGrid();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtuProduct.Text);

                db.Products.Remove(db.Products.Find(id));
                db.SaveChanges();
                RefreshGrid();

        }
    }
}
