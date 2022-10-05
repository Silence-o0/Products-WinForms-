using System.Data;


namespace Products
{
    public partial class Form1 : Form
    {
        abstract class Product
        {
            internal string name {get; set;}
            internal string countryOfOrigin;
            internal double productPrice;
            internal string description;
            internal string packingDate;
            public Product (string name, string country, double price, string description, string packingDate)
            {
                this.name = name;
                this.countryOfOrigin = country;
                this.productPrice = price;
                this.description = description; 
                this.packingDate = packingDate;
            }

        }

        class Food : Product
        {
            internal int foodQuantity;
            internal string expirationDate;
            internal string unitOfMeasure;
            public Food (int quantity, string expirationDate, string unitOfMeasure, 
                string name, string country, double price, string description, string packingDate) : 
                base(name, country, price, description, packingDate)
            {
                this.foodQuantity = quantity;
                this.expirationDate = expirationDate;
                this.unitOfMeasure = unitOfMeasure;
            }
        }

        class Book : Product
        {
            internal int pageQuantity;
            internal string publishingHouse;
            internal string authors;
            public Book(int pageQuantity, string publishingHouse, string authors,
            string name, string country, double price, string description, string packingDate) :
                base(name, country, price, description, packingDate)
            {
                this.pageQuantity = pageQuantity;
                this.publishingHouse = publishingHouse;
                this.authors = authors;
            }
        }

        DataTable table = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly= true;

            table.Columns.Add("�����", typeof(string));
            table.Columns.Add("����� ����������", typeof(string));
            table.Columns.Add("�������", typeof(double));
            table.Columns.Add("����", typeof(string));
            table.Columns.Add("���� ������������", typeof(string));
            table.Columns.Add("ʳ������", typeof(int));
            table.Columns.Add("����� ����������", typeof(string));
            table.Columns.Add("������� �����", typeof(string));
            table.Columns.Add("ʳ������ �������", typeof(int));
            table.Columns.Add("�����������", typeof(string));
            table.Columns.Add("������", typeof(string));

            table.Rows.Add("�������� 'Ocean'", "����", 140.80, "�������� ����� 'Ocean'", "6.01.2022", 5, "10.05.2023", "200 ����", null,
                null, null);
            table.Rows.Add("������������� �#", "������", 99.40, "����� ������������� ����� C# � ����", "16.09.2021", 
                null, null, null, 45, "ABCBook", "����� ��������");
            table.Rows.Add("������� ����� '��������'", "������", 69.20, "������� ����� '��������'", "29.08.2022", 20, 
                "12.07.2023", "350 ����", null, null, null);
            table.Rows.Add("������ '�������'", "������", 48.10, "������ ������������� '�������'", "29.09.2022", 11, "8.02.2023", 
                "1 ���", null, null, null);
            table.Rows.Add("Psychology", "USA", 255, "����� 'Psyhology' ���������� �����", "2.11.2020", null, null, null, 
                158, "FirstBook", "Jane Smith");

            dataGridView1.DataSource = table;
        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void addProducts_ElementVisibilityOFF()
        {
            LabelOfAddHiding.Visible = false;
            labelAddMain.Visible = false;

            labelAddName.Visible = false;
            textBoxName.Visible = false;

            labelAddDescription.Visible = false;
            textBoxDescription.Visible = false;

            labelAddPackingDate.Visible = false;
            textBoxPackingDate.Visible = false;

            labelAddCountryOfOrigin.Visible = false;
            textBox�ountryOfOrigin.Visible = false;

            labelAddProductPrice.Visible = false;
            textBoxProductPrice.Visible = false;

            labelAdd_Food_Page_Quantity.Visible = false;
            textBox_Food_Page_Quantity.Visible = false;

            labelAdd_ExpDate_PublishingHouse.Visible = false;
            textBox_ExpDate_PublishingHouse.Visible = false;

            labelAdd_Measure_Authors.Visible = false;
            textBox_Measure_Authors.Visible = false;

            buttonFinishAdding.Visible = false;
        }
        private void ClearAddBoxes()
        {
            textBoxName.Text = String.Empty;
            textBoxDescription.Text = String.Empty;
            textBoxPackingDate.Text = String.Empty;
            textBox�ountryOfOrigin.Text = String.Empty;
            textBoxProductPrice.Text = String.Empty;
            textBox_Food_Page_Quantity.Text = String.Empty;
            textBox_ExpDate_PublishingHouse.Text = String.Empty;
            textBox_Measure_Authors.Text = String.Empty;
        }
        private void addProducts_ElementVisibilityON()
        {
            LabelOfAddHiding.Visible = true;
            labelAddMain.Visible = true;

            labelAddName.Visible = true;
            textBoxName.Visible = true;

            labelAddDescription.Visible = true;
            textBoxDescription.Visible = true;

            labelAddPackingDate.Visible = true;
            textBoxPackingDate.Visible = true;

            labelAddCountryOfOrigin.Visible = true;
            textBox�ountryOfOrigin.Visible = true;

            labelAddProductPrice.Visible = true;
            textBoxProductPrice.Visible = true;

            labelAdd_Food_Page_Quantity.Visible = true;
            textBox_Food_Page_Quantity.Visible = true;

            labelAdd_ExpDate_PublishingHouse.Visible = true;
            textBox_ExpDate_PublishingHouse.Visible = true;

            labelAdd_Measure_Authors.Visible = true;
            textBox_Measure_Authors.Visible = true;

            buttonFinishAdding.Visible = true;
        }

        private void toolStripButtonAddFood_Click(object sender, EventArgs e)
        {
            labelAdd_Food_Page_Quantity.Text = "ʳ�-���:";

            labelAdd_ExpDate_PublishingHouse.Text = "����� ����������:";

            labelAdd_Measure_Authors.Text = "����:";

            buttonFinishAdding.Text = "������ �������";
            addProducts_ElementVisibilityON();
        }

        private void toolStripButtonAddBook_Click(object sender, EventArgs e)
        {
            labelAdd_Food_Page_Quantity.Text = "�-��� �������:";

            labelAdd_ExpDate_PublishingHouse.Text = "�����������:";

            labelAdd_Measure_Authors.Text = "������:";

            buttonFinishAdding.Text = "������ �����";
            addProducts_ElementVisibilityON();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 && this.dataGridView1.SelectedRows.Count< this.dataGridView1.Rows.Count)
            {
                DataRowView _dataRowView = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("�� �������, �� ������ �������� ��� �����?", "��������� ������", buttons);
                if (result == DialogResult.Yes)
                {
                    _dataRowView.Delete();
                }          
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonFinishAdding_Click(object sender, EventArgs e)
        {
            bool succesfulAction = true;
            try
            {
                if (buttonFinishAdding.Text == "������ �������")
                {
                    table.Rows.Add(textBoxName.Text, textBox�ountryOfOrigin.Text, Convert.ToInt32(textBoxProductPrice.Text),
                        textBoxDescription.Text, textBoxPackingDate.Text, Convert.ToInt32(textBox_Food_Page_Quantity.Text),
                        textBox_ExpDate_PublishingHouse.Text, textBox_Measure_Authors.Text, null, null, null);
                }
                else
                {
                    table.Rows.Add(textBoxName.Text, textBox�ountryOfOrigin.Text,
                    Convert.ToInt32(textBoxProductPrice.Text), textBoxDescription.Text,
                    textBoxPackingDate.Text, null, null, null, Convert.ToInt32(textBox_Food_Page_Quantity.Text),
                    textBox_ExpDate_PublishingHouse.Text, textBox_Measure_Authors.Text);
                }
            }
            catch (Exception ex)
            {
                succesfulAction = false;
                MessageBox.Show("ERROR! �������� ����������� �������� �����.");
            }
            if (succesfulAction == true) 
            { 
                addProducts_ElementVisibilityOFF();
                ClearAddBoxes();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addProducts_ElementVisibilityOFF();
            ClearAddBoxes();
        }
    }

        


}