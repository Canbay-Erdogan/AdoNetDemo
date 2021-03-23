using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        ProductDal _productDal = new ProductDal();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgwProducts.DataSource = _productDal.GetAll2();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = txtName.Text,
                StockAmount = Convert.ToInt32(txtStock.Text),
                UnitPrice = Convert.ToDecimal(txtPrice.Text)
            };
            _productDal.Add(product);
            dgwProducts.DataSource=_productDal.GetAll();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxId.Text = dgwProducts.CurrentRow.Cells[0].Value.ToString();
            tbxNameUp.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxPriceUp.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockUp.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(tbxId.Text),
                Name = tbxNameUp.Text,
                UnitPrice = Convert.ToDecimal(tbxPriceUp.Text),
                StockAmount = Convert.ToInt32(tbxStockUp.Text)
            };
            _productDal.Update(product);
            dgwProducts.DataSource = _productDal.GetAll2();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            dgwProducts.DataSource = _productDal.GetAll();
        }
    }
}
