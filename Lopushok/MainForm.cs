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
    public partial class MainForm : Lopushok.BasicForm
    {
        Model1 db = new Model1();
        List<Filtr> filtrList = new List<Filtr>();//коллекция для фильтрации
        public static bool add; 
        //List<MyProduct> prodList = new List<MyProduct>();
        //List<MyProduct> prodList2 = new List<MyProduct>();
        //public static int prodNumber;
        //public static int i;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FullTable();
            //заполнение коллекции
            filtrList = db.ProductType.Select(f => new Filtr { id = f.ID, typeOfProd = f.Title }).ToList();
            //вставка первой строки 
            filtrList.Insert(0, new Filtr { id = 0, typeOfProd = "Все типы" });
            //добавление данных в комбобокс из коллекции
            filtrCmb.DataSource = filtrList;
            filtrCmb.DisplayMember = "typeOfProd";//то, что показывается пользователю
            filtrCmb.ValueMember = "id";//то, с чем мы работаем
            //prodNumber = 20;
            //AddFullProduct();
            //i = 0;
            //AddTwentyRecord();
            //myProductBindingSource.DataSource = prodList;
        }
        public void FullTable()
        {
            productTypeBindingSource.DataSource = db.ProductType.ToList();
            productBindingSource.DataSource = db.Product.ToList();//заполняем данные в таблицу из бд
        }

        private void SortCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (sortCmb.SelectedIndex == 0)
            {
                productBindingSource.DataSource = db.Product.OrderBy(p => p.Title).ToList();
            }
            else if (sortCmb.SelectedIndex == 1)
            {
                productBindingSource.DataSource = db.Product.OrderByDescending(p => p.Title).ToList();
            }
            else if (sortCmb.SelectedIndex == 2)
                productBindingSource.DataSource = db.Product.OrderBy(p => p.ProductionWorkshopNumber).ToList();
            else if(sortCmb.SelectedIndex == 3)
                productBindingSource.DataSource = db.Product.OrderByDescending(p => p.ProductionWorkshopNumber).ToList();
            else if(sortCmb.SelectedIndex == 4)
                productBindingSource.DataSource = db.Product.OrderBy(p => p.MinCostForAgent).ToList();
            else if(sortCmb.SelectedIndex == 5)
                productBindingSource.DataSource = db.Product.OrderByDescending(p => p.MinCostForAgent).ToList();
            else if(sortCmb.SelectedIndex == 6)
            {
                productTypeBindingSource.DataSource = db.ProductType.ToList();
                productBindingSource.DataSource = db.Product.ToList();//заполняем данные в таблицу из бд
            }
               // FullTable();
        }

        private void ProductBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Product prod = (Product)productBindingSource.Current;
            if (prod.Image != "NULL")
            {
                string s = prod.Image;
                string folder = s;
                imageProdPic.Image = Image.FromFile(folder);
            }
            else
            {
                imageProdPic.Image = Image.FromFile("products\\фон.png");
            }
        }

        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
            if(searchTb.Text == "")
            {
                FullTable();
            }
            else
            {
                var search = db.Product.Where(p => p.Title.Contains(searchTb.Text) || p.Description.Contains(searchTb.Text)).ToList();
                productBindingSource.DataSource = search.ToList();
            }
        }

        private void FiltrCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (filtrCmb.SelectedIndex < 0)
                return;
            if(filtrCmb.SelectedIndex == 0)
            {
                FullTable();
            }
            else
            {
                int n = (int)filtrCmb.SelectedValue;
                productBindingSource.DataSource = db.Product.Where(p => p.ProductTypeID == n).ToList();
            }
            
        }
        public class Filtr
        {
            public int id { get; set; }
            public string typeOfProd { get; set; }
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            add = true;
            AddChangeProduct acp = new AddChangeProduct();
            acp.db = db;
            DialogResult dr = acp.ShowDialog();
            if(dr == DialogResult.OK)
            {
                productBindingSource.DataSource = db.Product.ToList();
            }
        }

        private void ChangeProdBtn_Click(object sender, EventArgs e)
        {
            add = false;
            Product prod = (Product)productBindingSource.Current;
            AddChangeProduct acp = new AddChangeProduct();
            acp.db = db;
            acp.prod = prod;
            DialogResult dr = acp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                productBindingSource.DataSource = db.Product.ToList();
            }
        }

        private void DeleteProdBtn_Click(object sender, EventArgs e)
        {
            Product prod = (Product)productBindingSource.Current;
            DialogResult dr = MessageBox.Show($"Вы действительно хотите удалить продукцию - {prod.Title.ToString()}?",
                "Удаление продукции", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                db.Product.Remove(prod);
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Внимание! Продукция успешно удалена!", "Успешное удаление",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                productBindingSource.DataSource = db.Product.ToList();
            }
        }

        private void ProductBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {
            
        }

        private void ListMaterialBtn_Click(object sender, EventArgs e)
        {
            ProductMaterialForm pmf = new ProductMaterialForm();
            pmf.Show();
            Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        //public void AddFullProduct()
        //{
        //    foreach(Product prd in db.Product.ToList())
        //    {
        //        if (prd.ID <= db.Product.Count())
        //        {
        //            MyProduct myprd = new MyProduct();
        //            myprd.articul = prd.ArticleNumber;
        //            myprd.typeProd = prd.ProductType.Title;
        //            myprd.title = prd.Title;
        //            foreach (ProductMaterial mtr in prd.ProductMaterial)
        //            {
        //                myprd.materials += mtr.Material.Title + ", ";
        //                if (mtr.Count.HasValue == true)
        //                {
        //                    myprd.cost += mtr.Count.Value * (double)mtr.Material.Cost;
        //                }
        //            }
        //            myprd.countPerson = (int)prd.ProductionPersonCount;
        //            myprd.numberWorkShop = (int)prd.ProductionWorkshopNumber;
        //            myprd.MinCount = (double)prd.MinCostForAgent;
        //            myprd.Description = prd.Description;
        //            prodList.Add(myprd);
        //        }
        //    }
        //}
        //public void AddTwentyRecord()
        //{
        //    prodNumber = 20;
        //    prodList2.Clear();
        //    foreach (MyProduct prd in prodList)
        //    {
        //        if ( i < prodNumber)
        //        {
        //            MyProduct myprd = new MyProduct();
        //            myprd.articul = prodList[i].articul;
        //            myprd.typeProd = prodList[i].typeProd;
        //            myprd.title = prodList[i].title;
        //            myprd.materials = prodList[i].materials;
        //            myprd.cost = prodList[i].cost;
        //            myprd.countPerson = prodList[i].countPerson;
        //            myprd.numberWorkShop = prodList[i].numberWorkShop;
        //            myprd.MinCount = prodList[i].MinCount;
        //            myprd.Description = prodList[i].Description;
        //            i++;
        //            prodList2.Add(myprd);
        //        }
        //    }
        //    myProductBindingSource.DataSource = prodList2;
        //}
        //public class MyProduct
        //{
        //    public string articul { get; set; }
        //    public string typeProd { get; set; }
        //    public string title { get; set; }
        //    public string materials { get; set; }
        //    public double cost { get; set; }
        //    public Image image { get; set; }
        //    public int countPerson { get; set; }
        //    public int numberWorkShop { get; set; }
        //    public double MinCount { get; set; }
        //    public string Description { get; set; }
        //}

        //private void NextBtn_Click(object sender, EventArgs e)
        //{
        //    int prodCount = db.Product.Count();
        //    if (prodCount > prodNumber)
        //    {
        //        i += 20;
        //        prodNumber += 20;
        //        AddTwentyRecord();
        //    }
        //}

        //private void PreviosBtn_Click(object sender, EventArgs e)
        //{

        //}
    }
}
