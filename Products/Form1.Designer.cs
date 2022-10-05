namespace Products
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddFood = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorRight1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAddBook = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorRight2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparatorLeft = new System.Windows.Forms.ToolStripSeparator();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPackingDate = new System.Windows.Forms.TextBox();
            this.textBoxСountryOfOrigin = new System.Windows.Forms.TextBox();
            this.textBox_Food_Page_Quantity = new System.Windows.Forms.TextBox();
            this.buttonFinishAdding = new System.Windows.Forms.Button();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelAddName = new System.Windows.Forms.Label();
            this.textBox_ExpDate_PublishingHouse = new System.Windows.Forms.TextBox();
            this.textBox_Measure_Authors = new System.Windows.Forms.TextBox();
            this.labelAddDescription = new System.Windows.Forms.Label();
            this.labelAddPackingDate = new System.Windows.Forms.Label();
            this.labelAddCountryOfOrigin = new System.Windows.Forms.Label();
            this.labelAddProductPrice = new System.Windows.Forms.Label();
            this.labelAdd_Food_Page_Quantity = new System.Windows.Forms.Label();
            this.labelAdd_ExpDate_PublishingHouse = new System.Windows.Forms.Label();
            this.labelAdd_Measure_Authors = new System.Windows.Forms.Label();
            this.labelAddMain = new System.Windows.Forms.Label();
            this.LabelOfAddHiding = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(40, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1207, 292);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.Info;
            this.toolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddFood,
            this.toolStripSeparatorRight1,
            this.toolStripButtonAddBook,
            this.toolStripSeparatorRight2,
            this.toolStripButtonDelete,
            this.toolStripSeparatorLeft});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(1314, 43);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked_1);
            // 
            // toolStripButtonAddFood
            // 
            this.toolStripButtonAddFood.BackColor = System.Drawing.SystemColors.Info;
            this.toolStripButtonAddFood.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAddFood.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripButtonAddFood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripButtonAddFood.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddFood.Image")));
            this.toolStripButtonAddFood.ImageTransparentColor = System.Drawing.Color.PeachPuff;
            this.toolStripButtonAddFood.Margin = new System.Windows.Forms.Padding(10, 2, 10, 3);
            this.toolStripButtonAddFood.Name = "toolStripButtonAddFood";
            this.toolStripButtonAddFood.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.toolStripButtonAddFood.Size = new System.Drawing.Size(163, 38);
            this.toolStripButtonAddFood.Text = "Додати продукт";
            this.toolStripButtonAddFood.Click += new System.EventHandler(this.toolStripButtonAddFood_Click);
            // 
            // toolStripSeparatorRight1
            // 
            this.toolStripSeparatorRight1.Name = "toolStripSeparatorRight1";
            this.toolStripSeparatorRight1.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripButtonAddBook
            // 
            this.toolStripButtonAddBook.BackColor = System.Drawing.SystemColors.Info;
            this.toolStripButtonAddBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAddBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripButtonAddBook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripButtonAddBook.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddBook.Image")));
            this.toolStripButtonAddBook.ImageTransparentColor = System.Drawing.Color.PeachPuff;
            this.toolStripButtonAddBook.Margin = new System.Windows.Forms.Padding(10, 2, 10, 3);
            this.toolStripButtonAddBook.Name = "toolStripButtonAddBook";
            this.toolStripButtonAddBook.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.toolStripButtonAddBook.Size = new System.Drawing.Size(140, 38);
            this.toolStripButtonAddBook.Text = "Додати книгу";
            this.toolStripButtonAddBook.Click += new System.EventHandler(this.toolStripButtonAddBook_Click);
            // 
            // toolStripSeparatorRight2
            // 
            this.toolStripSeparatorRight2.Name = "toolStripSeparatorRight2";
            this.toolStripSeparatorRight2.Size = new System.Drawing.Size(6, 43);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonDelete.BackColor = System.Drawing.SystemColors.Info;
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripButtonDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.PeachPuff;
            this.toolStripButtonDelete.Margin = new System.Windows.Forms.Padding(10, 2, 10, 3);
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.toolStripButtonDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButtonDelete.Size = new System.Drawing.Size(189, 38);
            this.toolStripButtonDelete.Text = "Видалити зі списку";
            this.toolStripButtonDelete.ToolTipText = "Натисніть на комірку в першому стовпчику, щоб виділити увесь рядок, потім натисні" +
    "ть \"Видалити зі списку\".\r\n\r\n";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripSeparatorLeft
            // 
            this.toolStripSeparatorLeft.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparatorLeft.Name = "toolStripSeparatorLeft";
            this.toolStripSeparatorLeft.Size = new System.Drawing.Size(6, 43);
            // 
            // textBoxName
            // 
            this.textBoxName.AccessibleDescription = "";
            this.textBoxName.Location = new System.Drawing.Point(54, 459);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(211, 31);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.Visible = false;
            // 
            // textBoxPackingDate
            // 
            this.textBoxPackingDate.Location = new System.Drawing.Point(810, 459);
            this.textBoxPackingDate.Name = "textBoxPackingDate";
            this.textBoxPackingDate.Size = new System.Drawing.Size(223, 31);
            this.textBoxPackingDate.TabIndex = 4;
            this.textBoxPackingDate.Visible = false;
            this.textBoxPackingDate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxСountryOfOrigin
            // 
            this.textBoxСountryOfOrigin.Location = new System.Drawing.Point(54, 533);
            this.textBoxСountryOfOrigin.Name = "textBoxСountryOfOrigin";
            this.textBoxСountryOfOrigin.Size = new System.Drawing.Size(156, 31);
            this.textBoxСountryOfOrigin.TabIndex = 5;
            this.textBoxСountryOfOrigin.Visible = false;
            // 
            // textBox_Food_Page_Quantity
            // 
            this.textBox_Food_Page_Quantity.Location = new System.Drawing.Point(425, 533);
            this.textBox_Food_Page_Quantity.Name = "textBox_Food_Page_Quantity";
            this.textBox_Food_Page_Quantity.Size = new System.Drawing.Size(106, 31);
            this.textBox_Food_Page_Quantity.TabIndex = 6;
            this.textBox_Food_Page_Quantity.Visible = false;
            // 
            // buttonFinishAdding
            // 
            this.buttonFinishAdding.BackColor = System.Drawing.SystemColors.Info;
            this.buttonFinishAdding.Location = new System.Drawing.Point(1112, 470);
            this.buttonFinishAdding.Name = "buttonFinishAdding";
            this.buttonFinishAdding.Size = new System.Drawing.Size(112, 73);
            this.buttonFinishAdding.TabIndex = 7;
            this.buttonFinishAdding.Text = "Додати продукт";
            this.buttonFinishAdding.UseVisualStyleBackColor = false;
            this.buttonFinishAdding.Visible = false;
            this.buttonFinishAdding.Click += new System.EventHandler(this.buttonFinishAdding_Click);
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Location = new System.Drawing.Point(264, 533);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(111, 31);
            this.textBoxProductPrice.TabIndex = 8;
            this.textBoxProductPrice.Visible = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(317, 459);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(442, 31);
            this.textBoxDescription.TabIndex = 10;
            this.textBoxDescription.Visible = false;
            // 
            // labelAddName
            // 
            this.labelAddName.AutoSize = true;
            this.labelAddName.Location = new System.Drawing.Point(54, 431);
            this.labelAddName.Name = "labelAddName";
            this.labelAddName.Size = new System.Drawing.Size(127, 25);
            this.labelAddName.TabIndex = 11;
            this.labelAddName.Text = "Назва товару:";
            this.labelAddName.Visible = false;
            this.labelAddName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_ExpDate_PublishingHouse
            // 
            this.textBox_ExpDate_PublishingHouse.Location = new System.Drawing.Point(571, 533);
            this.textBox_ExpDate_PublishingHouse.Name = "textBox_ExpDate_PublishingHouse";
            this.textBox_ExpDate_PublishingHouse.Size = new System.Drawing.Size(188, 31);
            this.textBox_ExpDate_PublishingHouse.TabIndex = 12;
            this.textBox_ExpDate_PublishingHouse.Visible = false;
            // 
            // textBox_Measure_Authors
            // 
            this.textBox_Measure_Authors.Location = new System.Drawing.Point(810, 533);
            this.textBox_Measure_Authors.Name = "textBox_Measure_Authors";
            this.textBox_Measure_Authors.Size = new System.Drawing.Size(223, 31);
            this.textBox_Measure_Authors.TabIndex = 13;
            this.textBox_Measure_Authors.Visible = false;
            // 
            // labelAddDescription
            // 
            this.labelAddDescription.AutoSize = true;
            this.labelAddDescription.Location = new System.Drawing.Point(317, 431);
            this.labelAddDescription.Name = "labelAddDescription";
            this.labelAddDescription.Size = new System.Drawing.Size(58, 25);
            this.labelAddDescription.TabIndex = 14;
            this.labelAddDescription.Text = "Опис:";
            this.labelAddDescription.Visible = false;
            // 
            // labelAddPackingDate
            // 
            this.labelAddPackingDate.AutoSize = true;
            this.labelAddPackingDate.Location = new System.Drawing.Point(810, 431);
            this.labelAddPackingDate.Name = "labelAddPackingDate";
            this.labelAddPackingDate.Size = new System.Drawing.Size(167, 25);
            this.labelAddPackingDate.TabIndex = 15;
            this.labelAddPackingDate.Text = "Дата виробництва:";
            this.labelAddPackingDate.Visible = false;
            // 
            // labelAddCountryOfOrigin
            // 
            this.labelAddCountryOfOrigin.AutoSize = true;
            this.labelAddCountryOfOrigin.Location = new System.Drawing.Point(54, 505);
            this.labelAddCountryOfOrigin.Name = "labelAddCountryOfOrigin";
            this.labelAddCountryOfOrigin.Size = new System.Drawing.Size(175, 25);
            this.labelAddCountryOfOrigin.TabIndex = 16;
            this.labelAddCountryOfOrigin.Text = "Країна походження:";
            this.labelAddCountryOfOrigin.Visible = false;
            // 
            // labelAddProductPrice
            // 
            this.labelAddProductPrice.AutoSize = true;
            this.labelAddProductPrice.Location = new System.Drawing.Point(264, 505);
            this.labelAddProductPrice.Name = "labelAddProductPrice";
            this.labelAddProductPrice.Size = new System.Drawing.Size(81, 25);
            this.labelAddProductPrice.TabIndex = 17;
            this.labelAddProductPrice.Text = "Вартість:";
            this.labelAddProductPrice.Visible = false;
            // 
            // labelAdd_Food_Page_Quantity
            // 
            this.labelAdd_Food_Page_Quantity.AutoSize = true;
            this.labelAdd_Food_Page_Quantity.Location = new System.Drawing.Point(416, 505);
            this.labelAdd_Food_Page_Quantity.Name = "labelAdd_Food_Page_Quantity";
            this.labelAdd_Food_Page_Quantity.Size = new System.Drawing.Size(133, 25);
            this.labelAdd_Food_Page_Quantity.TabIndex = 18;
            this.labelAdd_Food_Page_Quantity.Text = "К-сть сторінок:";
            this.labelAdd_Food_Page_Quantity.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelAdd_Food_Page_Quantity.Visible = false;
            // 
            // labelAdd_ExpDate_PublishingHouse
            // 
            this.labelAdd_ExpDate_PublishingHouse.AutoSize = true;
            this.labelAdd_ExpDate_PublishingHouse.Location = new System.Drawing.Point(571, 505);
            this.labelAdd_ExpDate_PublishingHouse.Name = "labelAdd_ExpDate_PublishingHouse";
            this.labelAdd_ExpDate_PublishingHouse.Size = new System.Drawing.Size(174, 25);
            this.labelAdd_ExpDate_PublishingHouse.TabIndex = 19;
            this.labelAdd_ExpDate_PublishingHouse.Text = "Термін придатності:";
            this.labelAdd_ExpDate_PublishingHouse.Visible = false;
            this.labelAdd_ExpDate_PublishingHouse.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelAdd_Measure_Authors
            // 
            this.labelAdd_Measure_Authors.AutoSize = true;
            this.labelAdd_Measure_Authors.BackColor = System.Drawing.SystemColors.Control;
            this.labelAdd_Measure_Authors.Location = new System.Drawing.Point(810, 505);
            this.labelAdd_Measure_Authors.Name = "labelAdd_Measure_Authors";
            this.labelAdd_Measure_Authors.Size = new System.Drawing.Size(51, 25);
            this.labelAdd_Measure_Authors.TabIndex = 20;
            this.labelAdd_Measure_Authors.Text = "Вага:";
            this.labelAdd_Measure_Authors.Visible = false;
            // 
            // labelAddMain
            // 
            this.labelAddMain.AutoSize = true;
            this.labelAddMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAddMain.Location = new System.Drawing.Point(85, 387);
            this.labelAddMain.Name = "labelAddMain";
            this.labelAddMain.Size = new System.Drawing.Size(290, 25);
            this.labelAddMain.TabIndex = 21;
            this.labelAddMain.Text = "Введіть інформацію про товар:";
            this.labelAddMain.Visible = false;
            this.labelAddMain.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LabelOfAddHiding
            // 
            this.LabelOfAddHiding.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.LabelOfAddHiding.AutoSize = true;
            this.LabelOfAddHiding.DisabledLinkColor = System.Drawing.Color.DarkGray;
            this.LabelOfAddHiding.LinkColor = System.Drawing.Color.DarkGray;
            this.LabelOfAddHiding.Location = new System.Drawing.Point(1033, 387);
            this.LabelOfAddHiding.Name = "LabelOfAddHiding";
            this.LabelOfAddHiding.Size = new System.Drawing.Size(236, 25);
            this.LabelOfAddHiding.TabIndex = 22;
            this.LabelOfAddHiding.TabStop = true;
            this.LabelOfAddHiding.Text = "Приховати панель додання";
            this.LabelOfAddHiding.Visible = false;
            this.LabelOfAddHiding.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 604);
            this.Controls.Add(this.LabelOfAddHiding);
            this.Controls.Add(this.labelAddMain);
            this.Controls.Add(this.labelAdd_Measure_Authors);
            this.Controls.Add(this.labelAdd_ExpDate_PublishingHouse);
            this.Controls.Add(this.labelAdd_Food_Page_Quantity);
            this.Controls.Add(this.labelAddProductPrice);
            this.Controls.Add(this.labelAddCountryOfOrigin);
            this.Controls.Add(this.labelAddPackingDate);
            this.Controls.Add(this.labelAddDescription);
            this.Controls.Add(this.textBox_Measure_Authors);
            this.Controls.Add(this.textBox_ExpDate_PublishingHouse);
            this.Controls.Add(this.labelAddName);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxProductPrice);
            this.Controls.Add(this.buttonFinishAdding);
            this.Controls.Add(this.textBox_Food_Page_Quantity);
            this.Controls.Add(this.textBoxСountryOfOrigin);
            this.Controls.Add(this.textBoxPackingDate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Перелік товарів";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dataGridView1;
        private ToolStrip toolStrip;
        private ToolStripButton toolStripButtonAddFood;
        private ToolStripButton toolStripButtonAddBook;
        private ToolStripSeparator toolStripSeparatorRight2;
        private ToolStripButton toolStripButtonDelete;
        private ToolStripSeparator toolStripSeparatorRight1;
        private ToolStripSeparator toolStripSeparatorLeft;
        private TextBox textBoxName;
        private TextBox textBoxPackingDate;
        private TextBox textBoxСountryOfOrigin;
        private TextBox textBox_Food_Page_Quantity;
        private Button buttonFinishAdding;
        private TextBox textBoxProductPrice;
        private TextBox textBoxDescription;
        private Label labelAddName;
        private TextBox textBox_ExpDate_PublishingHouse;
        private TextBox textBox_Measure_Authors;
        private Label labelAddDescription;
        private Label labelAddPackingDate;
        private Label labelAddCountryOfOrigin;
        private Label labelAddProductPrice;
        private Label labelAdd_Food_Page_Quantity;
        private Label labelAdd_ExpDate_PublishingHouse;
        private Label labelAdd_Measure_Authors;
        private Label labelAddMain;
        private LinkLabel LabelOfAddHiding;
    }
}