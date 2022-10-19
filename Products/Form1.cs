using System.Data;
using System.Collections;
using System.DirectoryServices.ActiveDirectory;

namespace Products
{
    public partial class Form1 : Form
    {
        class Product
        {
            internal string name;
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
        List<dynamic> productList = new List<dynamic>();  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly= true;

            table.Columns.Add("����� ������", typeof(string));
            table.Columns.Add("����� ����������", typeof(string));
            table.Columns.Add("�������", typeof(double));
            table.Columns.Add("����", typeof(string));
            table.Columns.Add("���� �����������", typeof(string));
            table.Columns.Add("ʳ������", typeof(int));
            table.Columns.Add("����", typeof(string));
            table.Columns.Add("����� ����������", typeof(string));
            table.Columns.Add("ʳ������ �������", typeof(int));
            table.Columns.Add("�����������", typeof(string));
            table.Columns.Add("������", typeof(string));

            productList.Add(new Food(5, "10.05.2023", "200 ����", "�������� 'Ocean'", "����", 140.80, "�������� ����� 'Ocean'", "6.01.2022"));
            productList.Add(new Book(45, "ABCBook", "����� ��������", "������������� �#", "������", 99.40, "����� ������������� ����� C# � ����", "16.09.2021"));
            productList.Add(new Food(20, "12.07.2023", "350 ����","������� ����� '��������'", "������", 69.20, "������� ����� '��������'", "29.08.2022"));
            productList.Add(new Food(11, "8.02.2023", "1 ���", "������ '�������'", "������", 48.10, "������ ������������� '�������'", "29.09.2022"));
            productList.Add(new Book(158, "FirstBook", "Jane Smith", "Psychology", "USA", 255, "����� 'Psyhology' ���������� �����", "2.11.2020"));
            productList.Add(new Product("����� ������", "������", 26.30, "������ ����� 5 �� � ��������", "10.08.2022"));
            productList.Add(new Product("����� ��� ��������", "�����", 240.80, "����� ��� �������� Samsung ������� �������", "23.04.2021"));

            displayListAtDataGrid();

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
        private void addProducts_AdditionalElementVisibilityOFF()       //������� ����� ��������� ����������
        {
            labelAdd_Food_Page_Quantity.Visible = false;
            textBox_Food_Page_Quantity.Visible = false;

            labelAdd_ExpDate_PublishingHouse.Visible = false;
            textBox_ExpDate_PublishingHouse.Visible = false;

            labelAdd_Measure_Authors.Visible = false;
            textBox_Measure_Authors.Visible = false;
        }
        private void addProducts_AllElementVisibilityOFF()
        {
            addProducts_AdditionalElementVisibilityOFF();

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
        private void addProducts_MainElementVisibilityON()    //������ ����� ����� ��������
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

            buttonFinishAdding.Visible = true;
        }
        private void addProducts_AllElementVisibilityON()
        {
            addProducts_MainElementVisibilityON();

            labelAdd_Food_Page_Quantity.Visible = true;
            textBox_Food_Page_Quantity.Visible = true;

            labelAdd_ExpDate_PublishingHouse.Visible = true;
            textBox_ExpDate_PublishingHouse.Visible = true;

            labelAdd_Measure_Authors.Visible = true;
            textBox_Measure_Authors.Visible = true;
        }
        private void toolStripButtonAddAnotherProduct_Click(object sender, EventArgs e)
        {
            buttonFinishAdding.Text = "������ �����";

            addProducts_AdditionalElementVisibilityOFF();    //����� ��������� ���������� �������
            addProducts_MainElementVisibilityON();       // ����� ����� ������ ��������
        }

        private void toolStripButtonAddFood_Click(object sender, EventArgs e)
        {
            labelAdd_Food_Page_Quantity.Text = "ʳ�-���:";

            labelAdd_ExpDate_PublishingHouse.Text = "����� ����������:";

            labelAdd_Measure_Authors.Text = "����:";

            buttonFinishAdding.Text = "������ �������";
            addProducts_AllElementVisibilityON();
        }

        private void toolStripButtonAddBook_Click(object sender, EventArgs e)
        {
            labelAdd_Food_Page_Quantity.Text = "ʳ�-��� �������:";

            labelAdd_ExpDate_PublishingHouse.Text = "�����������:";

            labelAdd_Measure_Authors.Text = "������:";

            buttonFinishAdding.Text = "������ �����";
            addProducts_AllElementVisibilityON();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 && this.dataGridView1.SelectedRows.Count < this.dataGridView1.Rows.Count)
            {
                DialogResult result = MessageBox.Show("�� �������, �� ������ ��������?", "���������", MessageBoxButtons.YesNo);
                switch (result)
                {
                    case DialogResult.Yes:
                        {

                                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                                {
                                    dataGridView1.Rows.RemoveAt(row.Index);
                                }
                            
                        }
                        break;
                    case DialogResult.No:
                        break;
                }
            }
            else if (this.dataGridView1.SelectedRows.Count == 0)     // ���� ����� �� �������
            {
                MessageBox.Show("������ �����, ���� ������ ��������.");
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
        void AddingElementToList(int i) {
            int? column6, column9;
            string column7, column8, column10, column11;
            try
            {
                column6 = productList[i].foodQuantity;
                column7 = productList[i].expirationDate;
                column8 = productList[i].unitOfMeasure;
            }
            catch (Exception)
            {
                column6 = null;
                column7 = null;
                column8 = null;
            }

            try
            {
                column9 = productList[i].pageQuantity;
                if (productList[i].pageQuantity == 0)
                {
                    column9 = null;
                }
                column10 = productList[i].publishingHouse;
                column11 = productList[i].authors;
            }
            catch (Exception)
            {
                column9 = null;
                column10 = null;
                column11 = null;
            }

            table.Rows.Add(productList[i].name, productList[i].countryOfOrigin, productList[i].productPrice, productList[i].description, 
                productList[i].packingDate, column6, column7, column8, column9, column10, column11);
        }
        private void displayListAtDataGrid()
        {
            for (int i = 0; i < productList.Count; i++)
            {
                AddingElementToList(i);
            }
        }


        public void checkEmptiness(dynamic textInBox)
        {
            if (String.IsNullOrEmpty(textInBox))
            {
                textInBox = null;
            };
        }

        public void checkTextboxesFullness()             // ���� name �� productPrice ����'������ ����� ���� ��������. �� ���� - �� ��������.
        {
            checkEmptiness(textBox�ountryOfOrigin.Text);
            checkEmptiness(textBoxDescription.Text);
            checkEmptiness(textBoxPackingDate.Text);
            checkEmptiness(textBox_ExpDate_PublishingHouse.Text);
            checkEmptiness(textBox_Measure_Authors.Text);

            if (textBox_Food_Page_Quantity.Text==String.Empty)
            {
                textBox_Food_Page_Quantity.Text = "0";
            }
        }

        private void buttonFinishAdding_Click(object sender, EventArgs e)
        {
            bool succesfulAction = true;
            checkTextboxesFullness();
            try
            {
                if (Convert.ToInt32(textBox_Food_Page_Quantity.Text) < 0 || Convert.ToInt32(textBoxProductPrice.Text) <= 0)
                {
                    MessageBox.Show("ERROR. �������� �� ���� ���� ��'�����.");
                    succesfulAction = false;
                }
                else if (buttonFinishAdding.Text == "������ �����")
                {
                    productList.Add(new Product(textBoxName.Text, textBox�ountryOfOrigin.Text, Convert.ToInt32(textBoxProductPrice.Text),
                        textBoxDescription.Text, textBoxPackingDate.Text));
                }
                else if (buttonFinishAdding.Text == "������ �������")
                {
                    productList.Add(new Food(Convert.ToInt32(textBox_Food_Page_Quantity.Text), textBox_ExpDate_PublishingHouse.Text,
                        textBox_Measure_Authors.Text, textBoxName.Text, textBox�ountryOfOrigin.Text, Convert.ToInt32(textBoxProductPrice.Text),
                        textBoxDescription.Text, textBoxPackingDate.Text));
                }
                else if (buttonFinishAdding.Text == "������ �����")
                {
                    productList.Add(new Book(Convert.ToInt32(textBox_Food_Page_Quantity.Text), textBox_ExpDate_PublishingHouse.Text,
                        textBox_Measure_Authors.Text, textBoxName.Text, textBox�ountryOfOrigin.Text, Convert.ToInt32(textBoxProductPrice.Text),
                        textBoxDescription.Text, textBoxPackingDate.Text));
                }
            }
            catch(Exception)
            {
                if (String.IsNullOrEmpty(textBoxName.Text) && String.IsNullOrEmpty(textBoxProductPrice.Text))  // ���� name �� productPrice ����'������ ����� ���� ��������.
                {
                    MessageBox.Show("ERROR! ���� '����� ������' �� '�������' �� ������ ���� ��������.");
                }
                else if (String.IsNullOrEmpty(textBoxName.Text))
                {
                    MessageBox.Show("ERROR! ���� '����� ������' �� ���� ���� �������.");
                }
                else if (String.IsNullOrEmpty(textBoxProductPrice.Text))
                {
                    MessageBox.Show("ERROR! ���� '�������' �� ���� ���� �������.");
                }
                else 
                {
                    MessageBox.Show($"ERROR! ������������ ��� �����. ������� �����, �� � ����� {labelAddProductPrice.Text} �� {labelAdd_Food_Page_Quantity.Text} " +
                        $"�� ���� ������� ������ ��������.") ;
                }
                succesfulAction = false;
            }
            
            if (succesfulAction == true) 
            { 
                addProducts_AllElementVisibilityOFF();
                ClearAddBoxes();
                AddingElementToList(productList.Count-1);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)     // ������� ���������� ����� ��� �������� ���������� 
        {
            addProducts_AllElementVisibilityOFF();
            ClearAddBoxes();
        }

        private void textBox�ountryOfOrigin_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
