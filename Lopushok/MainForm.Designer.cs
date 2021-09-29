namespace Lopushok
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.sortCmb = new System.Windows.Forms.ComboBox();
            this.filtrCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageProdPic = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.articleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionPersonCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionWorkshopNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minCostForAgentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listMaterialBtn = new System.Windows.Forms.Button();
            this.deleteProdBtn = new System.Windows.Forms.Button();
            this.changeProdBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProdPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addProductBtn);
            this.panel1.Controls.Add(this.changeProdBtn);
            this.panel1.Controls.Add(this.deleteProdBtn);
            this.panel1.Location = new System.Drawing.Point(-3, 482);
            this.panel1.Size = new System.Drawing.Size(888, 47);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(890, 63);
            // 
            // nameFormLb
            // 
            this.nameFormLb.Size = new System.Drawing.Size(181, 45);
            this.nameFormLb.Text = "Список продукции";
            // 
            // logoPic
            // 
            this.logoPic.Image = global::Lopushok.Properties.Resources.Лопушок;
            // 
            // searchTb
            // 
            this.searchTb.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTb.Location = new System.Drawing.Point(12, 109);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(259, 35);
            this.searchTb.TabIndex = 3;
            this.searchTb.TextChanged += new System.EventHandler(this.SearchTb_TextChanged);
            // 
            // sortCmb
            // 
            this.sortCmb.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortCmb.FormattingEnabled = true;
            this.sortCmb.Items.AddRange(new object[] {
            "Возраст. Наименование",
            "Убыв. Наименование",
            "Возраст. Номер цеха",
            "Убыв. Номер цеха",
            "Возраст. миним. стоимость ",
            "Убыв. миним. стоимость",
            "Исходная таблица"});
            this.sortCmb.Location = new System.Drawing.Point(287, 106);
            this.sortCmb.Name = "sortCmb";
            this.sortCmb.Size = new System.Drawing.Size(233, 37);
            this.sortCmb.TabIndex = 4;
            this.sortCmb.SelectionChangeCommitted += new System.EventHandler(this.SortCmb_SelectionChangeCommitted);
            // 
            // filtrCmb
            // 
            this.filtrCmb.DisplayMember = "ID";
            this.filtrCmb.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filtrCmb.FormattingEnabled = true;
            this.filtrCmb.Location = new System.Drawing.Point(528, 105);
            this.filtrCmb.Name = "filtrCmb";
            this.filtrCmb.Size = new System.Drawing.Size(233, 37);
            this.filtrCmb.TabIndex = 5;
            this.filtrCmb.ValueMember = "ID";
            this.filtrCmb.SelectionChangeCommitted += new System.EventHandler(this.FiltrCmb_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сортировка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Фильтрация:";
            // 
            // imageProdPic
            // 
            this.imageProdPic.Location = new System.Drawing.Point(773, 203);
            this.imageProdPic.Name = "imageProdPic";
            this.imageProdPic.Size = new System.Drawing.Size(100, 120);
            this.imageProdPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageProdPic.TabIndex = 10;
            this.imageProdPic.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(774, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 39);
            this.label4.TabIndex = 11;
            this.label4.Text = "Картинка:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleNumberDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.productTypeIDDataGridViewTextBoxColumn,
            this.productionPersonCountDataGridViewTextBoxColumn,
            this.productionWorkshopNumberDataGridViewTextBoxColumn,
            this.minCostForAgentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 268);
            this.dataGridView1.TabIndex = 12;
            // 
            // articleNumberDataGridViewTextBoxColumn
            // 
            this.articleNumberDataGridViewTextBoxColumn.DataPropertyName = "ArticleNumber";
            this.articleNumberDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.articleNumberDataGridViewTextBoxColumn.Name = "articleNumberDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Название";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // productTypeIDDataGridViewTextBoxColumn
            // 
            this.productTypeIDDataGridViewTextBoxColumn.DataPropertyName = "ProductTypeID";
            this.productTypeIDDataGridViewTextBoxColumn.DataSource = this.productTypeBindingSource;
            this.productTypeIDDataGridViewTextBoxColumn.DisplayMember = "Title";
            this.productTypeIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.productTypeIDDataGridViewTextBoxColumn.HeaderText = "Тип продукции";
            this.productTypeIDDataGridViewTextBoxColumn.Name = "productTypeIDDataGridViewTextBoxColumn";
            this.productTypeIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productTypeIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productTypeIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataSource = typeof(Lopushok.ProductType);
            // 
            // productionPersonCountDataGridViewTextBoxColumn
            // 
            this.productionPersonCountDataGridViewTextBoxColumn.DataPropertyName = "ProductionPersonCount";
            this.productionPersonCountDataGridViewTextBoxColumn.HeaderText = "Кол-ство чел.на произв.";
            this.productionPersonCountDataGridViewTextBoxColumn.Name = "productionPersonCountDataGridViewTextBoxColumn";
            // 
            // productionWorkshopNumberDataGridViewTextBoxColumn
            // 
            this.productionWorkshopNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductionWorkshopNumber";
            this.productionWorkshopNumberDataGridViewTextBoxColumn.HeaderText = "Номер цеха";
            this.productionWorkshopNumberDataGridViewTextBoxColumn.Name = "productionWorkshopNumberDataGridViewTextBoxColumn";
            // 
            // minCostForAgentDataGridViewTextBoxColumn
            // 
            this.minCostForAgentDataGridViewTextBoxColumn.DataPropertyName = "MinCostForAgent";
            this.minCostForAgentDataGridViewTextBoxColumn.HeaderText = "Мин. цена для агентов";
            this.minCostForAgentDataGridViewTextBoxColumn.Name = "minCostForAgentDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Lopushok.Product);
            this.productBindingSource.CurrentChanged += new System.EventHandler(this.ProductBindingSource_CurrentChanged_1);
            // 
            // listMaterialBtn
            // 
            this.listMaterialBtn.Location = new System.Drawing.Point(588, 435);
            this.listMaterialBtn.Name = "listMaterialBtn";
            this.listMaterialBtn.Size = new System.Drawing.Size(174, 41);
            this.listMaterialBtn.TabIndex = 0;
            this.listMaterialBtn.Text = "Список материалов";
            this.listMaterialBtn.UseVisualStyleBackColor = true;
            this.listMaterialBtn.Click += new System.EventHandler(this.ListMaterialBtn_Click);
            // 
            // deleteProdBtn
            // 
            this.deleteProdBtn.Location = new System.Drawing.Point(15, 3);
            this.deleteProdBtn.Name = "deleteProdBtn";
            this.deleteProdBtn.Size = new System.Drawing.Size(174, 41);
            this.deleteProdBtn.TabIndex = 13;
            this.deleteProdBtn.Text = "Удалить продукцию";
            this.deleteProdBtn.UseVisualStyleBackColor = true;
            this.deleteProdBtn.Click += new System.EventHandler(this.DeleteProdBtn_Click);
            // 
            // changeProdBtn
            // 
            this.changeProdBtn.Location = new System.Drawing.Point(356, 3);
            this.changeProdBtn.Name = "changeProdBtn";
            this.changeProdBtn.Size = new System.Drawing.Size(179, 41);
            this.changeProdBtn.TabIndex = 14;
            this.changeProdBtn.Text = "Изменить продукцию";
            this.changeProdBtn.UseVisualStyleBackColor = true;
            this.changeProdBtn.Click += new System.EventHandler(this.ChangeProdBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.Location = new System.Drawing.Point(691, 3);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(185, 41);
            this.addProductBtn.TabIndex = 15;
            this.addProductBtn.Text = "Добавить продукцию";
            this.addProductBtn.UseVisualStyleBackColor = true;
            this.addProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Изменить стоимость на";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listMaterialBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imageProdPic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filtrCmb);
            this.Controls.Add(this.sortCmb);
            this.Controls.Add(this.searchTb);
            this.Margin = new System.Windows.Forms.Padding(6, 27, 6, 27);
            this.Name = "MainForm";
            this.Text = "Список продукуции";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.searchTb, 0);
            this.Controls.SetChildIndex(this.sortCmb, 0);
            this.Controls.SetChildIndex(this.filtrCmb, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.imageProdPic, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.listMaterialBtn, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProdPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.ComboBox sortCmb;
        private System.Windows.Forms.ComboBox filtrCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imageProdPic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Button changeProdBtn;
        private System.Windows.Forms.Button deleteProdBtn;
        private System.Windows.Forms.Button listMaterialBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn productTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionPersonCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionWorkshopNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minCostForAgentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button button1;
    }
}

