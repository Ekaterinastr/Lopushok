using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lopushok
{
    public partial class ProductMaterialForm : Form
    {
        Model1 db = new Model1();
        public ProductMaterialForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            Hide();
        }

        private void ProductMaterialForm_Load(object sender, EventArgs e)
        {
            productMaterialBindingSource.DataSource = db.ProductMaterial.ToList();
        }
    }
}
