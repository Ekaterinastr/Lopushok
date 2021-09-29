namespace Lopushok
{
    partial class AddChangeProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label articleNumberLabel;
            System.Windows.Forms.Label productTypeIDLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label productionPersonCountLabel;
            System.Windows.Forms.Label productionWorkshopNumberLabel;
            System.Windows.Forms.Label minCostForAgentLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.articleNumberTextBox = new System.Windows.Forms.TextBox();
            this.productionPersonCountTextBox = new System.Windows.Forms.TextBox();
            this.productionWorkshopNumberTextBox = new System.Windows.Forms.TextBox();
            this.minCostForAgentTextBox = new System.Windows.Forms.TextBox();
            this.typeOfProdCmb = new System.Windows.Forms.ComboBox();
            this.productTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionRTb = new System.Windows.Forms.RichTextBox();
            this.imagePic = new System.Windows.Forms.PictureBox();
            this.wayImageTb = new System.Windows.Forms.TextBox();
            this.attachBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            iDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            articleNumberLabel = new System.Windows.Forms.Label();
            productTypeIDLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            productionPersonCountLabel = new System.Windows.Forms.Label();
            productionWorkshopNumberLabel = new System.Windows.Forms.Label();
            minCostForAgentLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Location = new System.Drawing.Point(-2, 427);
            this.panel1.Size = new System.Drawing.Size(667, 48);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(669, 63);
            // 
            // nameFormLb
            // 
            this.nameFormLb.Size = new System.Drawing.Size(218, 45);
            this.nameFormLb.Text = "Добавление продукции";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iDLabel.Location = new System.Drawing.Point(4, 68);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(108, 29);
            iDLabel.TabIndex = 3;
            iDLabel.Text = "Идентификатор:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(219, 115);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(67, 29);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Название:";
            // 
            // articleNumberLabel
            // 
            articleNumberLabel.AutoSize = true;
            articleNumberLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            articleNumberLabel.Location = new System.Drawing.Point(48, 115);
            articleNumberLabel.Name = "articleNumberLabel";
            articleNumberLabel.Size = new System.Drawing.Size(64, 29);
            articleNumberLabel.TabIndex = 6;
            articleNumberLabel.Text = "Артикул:";
            // 
            // productTypeIDLabel
            // 
            productTypeIDLabel.AutoSize = true;
            productTypeIDLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productTypeIDLabel.Location = new System.Drawing.Point(14, 157);
            productTypeIDLabel.Name = "productTypeIDLabel";
            productTypeIDLabel.Size = new System.Drawing.Size(96, 29);
            productTypeIDLabel.TabIndex = 8;
            productTypeIDLabel.Text = "Тип продукции:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            imageLabel.Location = new System.Drawing.Point(19, 252);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(45, 29);
            imageLabel.TabIndex = 10;
            imageLabel.Text = "Фото:";
            // 
            // productionPersonCountLabel
            // 
            productionPersonCountLabel.AutoSize = true;
            productionPersonCountLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productionPersonCountLabel.Location = new System.Drawing.Point(361, 157);
            productionPersonCountLabel.Name = "productionPersonCountLabel";
            productionPersonCountLabel.Size = new System.Drawing.Size(186, 29);
            productionPersonCountLabel.TabIndex = 12;
            productionPersonCountLabel.Text = "Кол-ство чел. для производств.:";
            // 
            // productionWorkshopNumberLabel
            // 
            productionWorkshopNumberLabel.AutoSize = true;
            productionWorkshopNumberLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productionWorkshopNumberLabel.Location = new System.Drawing.Point(399, 205);
            productionWorkshopNumberLabel.Name = "productionWorkshopNumberLabel";
            productionWorkshopNumberLabel.Size = new System.Drawing.Size(148, 29);
            productionWorkshopNumberLabel.TabIndex = 14;
            productionWorkshopNumberLabel.Text = "Номер производст. цеха:";
            // 
            // minCostForAgentLabel
            // 
            minCostForAgentLabel.AutoSize = true;
            minCostForAgentLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            minCostForAgentLabel.Location = new System.Drawing.Point(19, 203);
            minCostForAgentLabel.Name = "minCostForAgentLabel";
            minCostForAgentLabel.Size = new System.Drawing.Size(148, 29);
            minCostForAgentLabel.TabIndex = 16;
            minCostForAgentLabel.Text = "Миним. цена для агента:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            descriptionLabel.Location = new System.Drawing.Point(305, 252);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(68, 29);
            descriptionLabel.TabIndex = 18;
            descriptionLabel.Text = "Описание:";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Lopushok.Product);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ID", true));
            this.iDTextBox.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iDTextBox.Location = new System.Drawing.Point(118, 66);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(100, 33);
            this.iDTextBox.TabIndex = 4;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(287, 113);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(366, 33);
            this.titleTextBox.TabIndex = 5;
            // 
            // articleNumberTextBox
            // 
            this.articleNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ArticleNumber", true));
            this.articleNumberTextBox.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.articleNumberTextBox.Location = new System.Drawing.Point(118, 113);
            this.articleNumberTextBox.Name = "articleNumberTextBox";
            this.articleNumberTextBox.Size = new System.Drawing.Size(100, 33);
            this.articleNumberTextBox.TabIndex = 7;
            // 
            // productionPersonCountTextBox
            // 
            this.productionPersonCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductionPersonCount", true));
            this.productionPersonCountTextBox.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionPersonCountTextBox.Location = new System.Drawing.Point(553, 157);
            this.productionPersonCountTextBox.Name = "productionPersonCountTextBox";
            this.productionPersonCountTextBox.Size = new System.Drawing.Size(100, 33);
            this.productionPersonCountTextBox.TabIndex = 13;
            // 
            // productionWorkshopNumberTextBox
            // 
            this.productionWorkshopNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductionWorkshopNumber", true));
            this.productionWorkshopNumberTextBox.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productionWorkshopNumberTextBox.Location = new System.Drawing.Point(553, 203);
            this.productionWorkshopNumberTextBox.Name = "productionWorkshopNumberTextBox";
            this.productionWorkshopNumberTextBox.Size = new System.Drawing.Size(100, 33);
            this.productionWorkshopNumberTextBox.TabIndex = 15;
            // 
            // minCostForAgentTextBox
            // 
            this.minCostForAgentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "MinCostForAgent", true));
            this.minCostForAgentTextBox.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minCostForAgentTextBox.Location = new System.Drawing.Point(173, 199);
            this.minCostForAgentTextBox.Name = "minCostForAgentTextBox";
            this.minCostForAgentTextBox.Size = new System.Drawing.Size(173, 33);
            this.minCostForAgentTextBox.TabIndex = 17;
            this.minCostForAgentTextBox.TextChanged += new System.EventHandler(this.MinCostForAgentTextBox_TextChanged);
            // 
            // typeOfProdCmb
            // 
            this.typeOfProdCmb.DataSource = this.productTypeBindingSource;
            this.typeOfProdCmb.DisplayMember = "Title";
            this.typeOfProdCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfProdCmb.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeOfProdCmb.FormattingEnabled = true;
            this.typeOfProdCmb.Location = new System.Drawing.Point(118, 157);
            this.typeOfProdCmb.Name = "typeOfProdCmb";
            this.typeOfProdCmb.Size = new System.Drawing.Size(228, 31);
            this.typeOfProdCmb.TabIndex = 19;
            this.typeOfProdCmb.ValueMember = "ID";
            // 
            // productTypeBindingSource
            // 
            this.productTypeBindingSource.DataSource = typeof(Lopushok.ProductType);
            // 
            // descriptionRTb
            // 
            this.descriptionRTb.Location = new System.Drawing.Point(379, 252);
            this.descriptionRTb.Name = "descriptionRTb";
            this.descriptionRTb.Size = new System.Drawing.Size(274, 152);
            this.descriptionRTb.TabIndex = 20;
            this.descriptionRTb.Text = "";
            // 
            // imagePic
            // 
            this.imagePic.Location = new System.Drawing.Point(72, 252);
            this.imagePic.Name = "imagePic";
            this.imagePic.Size = new System.Drawing.Size(130, 99);
            this.imagePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePic.TabIndex = 21;
            this.imagePic.TabStop = false;
            // 
            // wayImageTb
            // 
            this.wayImageTb.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wayImageTb.Location = new System.Drawing.Point(72, 357);
            this.wayImageTb.Name = "wayImageTb";
            this.wayImageTb.Size = new System.Drawing.Size(130, 30);
            this.wayImageTb.TabIndex = 22;
            // 
            // attachBtn
            // 
            this.attachBtn.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.attachBtn.Location = new System.Drawing.Point(72, 393);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.Size = new System.Drawing.Size(130, 28);
            this.attachBtn.TabIndex = 23;
            this.attachBtn.Text = "Прикрепить";
            this.attachBtn.UseVisualStyleBackColor = true;
            this.attachBtn.Click += new System.EventHandler(this.AttachBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.Location = new System.Drawing.Point(525, 12);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(130, 28);
            this.SaveBtn.TabIndex = 24;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backBtn.Location = new System.Drawing.Point(11, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(130, 28);
            this.backBtn.TabIndex = 25;
            this.backBtn.Text = "Отмена";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(246, 427);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(62, 47);
            this.comboBox1.TabIndex = 24;
            // 
            // AddChangeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(665, 475);
            this.Controls.Add(this.attachBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.wayImageTb);
            this.Controls.Add(this.imagePic);
            this.Controls.Add(this.descriptionRTb);
            this.Controls.Add(this.typeOfProdCmb);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(minCostForAgentLabel);
            this.Controls.Add(this.minCostForAgentTextBox);
            this.Controls.Add(productionWorkshopNumberLabel);
            this.Controls.Add(this.productionWorkshopNumberTextBox);
            this.Controls.Add(productionPersonCountLabel);
            this.Controls.Add(this.productionPersonCountTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(productTypeIDLabel);
            this.Controls.Add(articleNumberLabel);
            this.Controls.Add(this.articleNumberTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Name = "AddChangeProduct";
            this.Text = "AddChangeProduct";
            this.Load += new System.EventHandler(this.AddChangeProduct_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.iDTextBox, 0);
            this.Controls.SetChildIndex(iDLabel, 0);
            this.Controls.SetChildIndex(this.titleTextBox, 0);
            this.Controls.SetChildIndex(titleLabel, 0);
            this.Controls.SetChildIndex(this.articleNumberTextBox, 0);
            this.Controls.SetChildIndex(articleNumberLabel, 0);
            this.Controls.SetChildIndex(productTypeIDLabel, 0);
            this.Controls.SetChildIndex(imageLabel, 0);
            this.Controls.SetChildIndex(this.productionPersonCountTextBox, 0);
            this.Controls.SetChildIndex(productionPersonCountLabel, 0);
            this.Controls.SetChildIndex(this.productionWorkshopNumberTextBox, 0);
            this.Controls.SetChildIndex(productionWorkshopNumberLabel, 0);
            this.Controls.SetChildIndex(this.minCostForAgentTextBox, 0);
            this.Controls.SetChildIndex(minCostForAgentLabel, 0);
            this.Controls.SetChildIndex(descriptionLabel, 0);
            this.Controls.SetChildIndex(this.typeOfProdCmb, 0);
            this.Controls.SetChildIndex(this.descriptionRTb, 0);
            this.Controls.SetChildIndex(this.imagePic, 0);
            this.Controls.SetChildIndex(this.wayImageTb, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.attachBtn, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox articleNumberTextBox;
        private System.Windows.Forms.TextBox productionPersonCountTextBox;
        private System.Windows.Forms.TextBox productionWorkshopNumberTextBox;
        private System.Windows.Forms.TextBox minCostForAgentTextBox;
        private System.Windows.Forms.ComboBox typeOfProdCmb;
        private System.Windows.Forms.RichTextBox descriptionRTb;
        private System.Windows.Forms.PictureBox imagePic;
        private System.Windows.Forms.TextBox wayImageTb;
        private System.Windows.Forms.Button attachBtn;
        private System.Windows.Forms.BindingSource productTypeBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}