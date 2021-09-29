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
    public partial class AddChangeProduct : Lopushok.BasicForm
    {
        public Model1 db { get; set; }
        public Product prod { get; set; }
        List<TypeOfProductComboBox> tcb = new List<TypeOfProductComboBox>();//коллекция для комбобокса
        
        public AddChangeProduct()
        {
            InitializeComponent();
        }
        public class TypeOfProductComboBox
        {
            public int id { get; set; }
            public string typeOfProd { get; set; }
        }
        private void AddChangeProduct_Load(object sender, EventArgs e)
        {
            tcb = db.ProductType.Select(f => new TypeOfProductComboBox { id = f.ID, typeOfProd = f.Title }).ToList();
            typeOfProdCmb.DataSource = tcb;
            typeOfProdCmb.DisplayMember = "typeOfProd";
            typeOfProdCmb.ValueMember = "id";

            if (MainForm.add == true)
            {
                nameFormLb.Text = "Добавление продукции";
                iDTextBox.Visible = false;
            }
            else if(MainForm.add == false)
            {
                nameFormLb.Text = "Изменение продукции";
                iDTextBox.Visible = true;
                iDTextBox.Text = Convert.ToString(prod.ID);
                articleNumberTextBox.Text = prod.ArticleNumber;
                var tp = from p in db.ProductType
                         where p.ID == prod.ProductTypeID
                         select p.Title;
                comboBox1.DataSource = tp.ToList();
                typeOfProdCmb.Text = comboBox1.Text;
                titleTextBox.Text = prod.Title;
                productionPersonCountTextBox.Text = Convert.ToString(prod.ProductionPersonCount);
                productionWorkshopNumberTextBox.Text = Convert.ToString(prod.ProductionWorkshopNumber);
                minCostForAgentTextBox.Text = Convert.ToString(prod.MinCostForAgent);
                descriptionRTb.Text = prod.Description;
                if(prod.Image == null)
                {
                    imagePic.Image = Image.FromFile("products\\фон.png");
                }
                else
                {
                    wayImageTb.Text = prod.Image;
                    imagePic.Image = Image.FromFile(wayImageTb.Text);
                }
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (articleNumberTextBox.Text == "" || titleTextBox.Text == "" || typeOfProdCmb.Text==""|| productionPersonCountTextBox.Text==""
                || productionWorkshopNumberTextBox.Text=="" || minCostForAgentTextBox.Text == "")
            {
                MessageBox.Show("Внимание! Заполните все поля, кроме описания и фото!", "Ошибка сохранения: незаполненные поля",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Math.Round(Convert.ToDecimal(minCostForAgentTextBox.Text), 2);
                    //string.Format($"{0:N2}", Convert.ToInt32(minCostForAgentTextBox.Text));
                }
                catch(Exception)
                {
                    MessageBox.Show("Внимание! Стоимость должна иметь формат десятичного числа с точностью до сотых!",
                        "Ошибка сохранения: неверный формат стоимости!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (Convert.ToDecimal(minCostForAgentTextBox.Text) < 0)
                {
                    MessageBox.Show("Внимание! Стоимость не должна быть отрицательной!", "Ошибка сохранения: отрицательная стоимость!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MainForm.add == true)
                    {

                        Product prod = new Product();
                        prod.ArticleNumber = articleNumberTextBox.Text;
                        prod.ProductTypeID = Convert.ToInt32(typeOfProdCmb.SelectedValue);
                        prod.Title = titleTextBox.Text;
                        prod.ProductionPersonCount = Convert.ToInt32(productionPersonCountTextBox.Text);
                        prod.ProductionWorkshopNumber = Convert.ToInt32(productionWorkshopNumberTextBox.Text);
                        prod.MinCostForAgent = Convert.ToDecimal(minCostForAgentTextBox.Text);
                        prod.Description = descriptionRTb.Text;
                        if (imagePic.Image == null)
                        {
                            prod.Image = null;
                        }
                        else
                        {
                            prod.Image = wayImageTb.Text;
                        }
                        db.Product.Add(prod);
                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("Внимание! Добавленная продукция успешно сохранилась!", "Успешное сохранение!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (MainForm.add == false)
                    {
                        prod.ArticleNumber = articleNumberTextBox.Text;
                        prod.ProductTypeID = Convert.ToInt32(typeOfProdCmb.SelectedValue);
                        prod.Title = titleTextBox.Text;
                        prod.ProductionPersonCount = Convert.ToInt32(productionPersonCountTextBox.Text);
                        prod.ProductionWorkshopNumber = Convert.ToInt32(productionWorkshopNumberTextBox.Text);
                        prod.MinCostForAgent = Convert.ToDecimal(minCostForAgentTextBox.Text);
                        prod.Description = descriptionRTb.Text;
                        if (imagePic.Image == null)
                        {
                            prod.Image = null;
                        }
                        else
                        {
                            prod.Image = wayImageTb.Text;
                        }
                        try
                        {
                            db.SaveChanges();
                            MessageBox.Show("Внимание! Изменения успешно сохранились!", "Успешное сохранение!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

        }
        //public void AddFullTypeOfProductInComboBox()
        //{
        //    var typeOfProd = (from p in db.ProductType
        //                       select p.Title).Distinct();
        //    typeOfProdCmb.DataSource = typeOfProd.ToList();
        //}
        private void AttachBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выберите фотографию продукции";
            ofd.InitialDirectory = @"C:\Users\Пользователь\source\repos\Lopushok\Lopushok\bin\Debug\products";
            ofd.Filter = "Файл jpeg | *.jpeg;";
            DialogResult dr = ofd.ShowDialog();
            if(dr == DialogResult.OK)
            {
                wayImageTb.Text = @"products\" + $"{ofd.SafeFileName}";
                imagePic.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void MinCostForAgentTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
