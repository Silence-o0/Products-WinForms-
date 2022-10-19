using System.Data;
using System.Collections;
using System.DirectoryServices.ActiveDirectory;

namespace Products
{
    public partial class Form1 : Form
    {
        class Product
        {
<<<<<<< HEAD
            internal string name;
            internal string countryOfOrigin;
            internal double productPrice;
            internal string description;
            internal string packingDate;
=======
            string name;
            string countryOfOrigin;
            double productPrice;
            string description;
            string packingDate;
>>>>>>> a706cd5927d963bdc0ce873b399fa5d789588263
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
            int foodQuantity;
            string expirationDate;
            string unitOfMeasure;
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
            int pageQuantity;
            string publishingHouse;
            string authors;
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

            table.Columns.Add("Íàçâà", typeof(string));
            table.Columns.Add("Êðà¿íà ïîõîäæåííÿ", typeof(string));
            table.Columns.Add("Âàðò³ñòü", typeof(double));
            table.Columns.Add("Îïèñ", typeof(string));
            table.Columns.Add("Äàòà âèãîòîâëåííÿ", typeof(string));
            table.Columns.Add("Ê³ëüê³ñòü", typeof(int));
            table.Columns.Add("Òåðì³í ïðèäàòíîñò³", typeof(string));
            table.Columns.Add("Îäèíèöÿ âèì³ðó", typeof(string));
            table.Columns.Add("Ê³ëüê³ñòü ñòîð³íîê", typeof(int));
            table.Columns.Add("Âèäàâíèöòâî", typeof(string));
            table.Columns.Add("Àâòîðè", typeof(string));

<<<<<<< HEAD
            productList.Add(new Food(5, "10.05.2023", "200 ����", "�������� 'Ocean'", "����", 140.80, "�������� ����� 'Ocean'", "6.01.2022"));
            productList.Add(new Book(45, "ABCBook", "����� ��������", "������������� �#", "������", 99.40, "����� ������������� ����� C# � ����", "16.09.2021"));
            productList.Add(new Food(20, "12.07.2023", "350 ����","������� ����� '��������'", "������", 69.20, "������� ����� '��������'", "29.08.2022"));
            productList.Add(new Food(11, "8.02.2023", "1 ���", "������ '�������'", "������", 48.10, "������ ������������� '�������'", "29.09.2022"));
            productList.Add(new Book(158, "FirstBook", "Jane Smith", "Psychology", "USA", 255, "����� 'Psyhology' ���������� �����", "2.11.2020"));
            productList.Add(new Product("����� ������", "������", 26.30, "������ ����� 5 �� � ��������", "10.08.2022"));
            productList.Add(new Product("����� ��� ��������", "�����", 240.80, "����� ��� �������� Samsung ������� �������", "23.04.2021"));

            displayListAtDataGrid();
=======
            table.Rows.Add("Êîíñåðâà 'Ocean'", "Äàí³ÿ", 140.80, "Êîíñåðâà ðèáíà 'Ocean'", "6.01.2022", 5, "10.05.2023", "200 ãðàì", null,
                null, null);
            table.Rows.Add("Ïðîãðàìóâàííÿ Ñ#", "Óêðà¿íà", 99.40, "Êíèãà ïðîãðàìóâàííÿ ìîâîþ C# ç íóëÿ", "16.09.2021", 
                null, null, null, 45, "ABCBook", "Ïåòðî Ïåòðåíêî");
            table.Rows.Add("Òîìàòíà ïàñòà 'Ïîì³äîðêà'", "Óêðà¿íà", 69.20, "Òîìàòíà ïàñòà 'Ïîì³äîðêà'", "29.08.2022", 20, 
                "12.07.2023", "350 ãðàì", null, null, null);
            table.Rows.Add("Ìîëîêî 'Ðÿáóøêà'", "Óêðà¿íà", 48.10, "Ìîëîêî ïàñòåðèçîâàíå 'Ðÿáóøêà'", "29.09.2022", 11, "8.02.2023", 
                "1 ë³òð", null, null, null);
            table.Rows.Add("Psychology", "USA", 255, "Êíèãà 'Psyhology' àíãë³éñüêîþ ìîâîþ", "2.11.2020", null, null, null, 
                158, "FirstBook", "Jane Smith");
>>>>>>> a706cd5927d963bdc0ce873b399fa5d789588263

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
            textBoxÑountryOfOrigin.Visible = false;

            labelAddProductPrice.Visible = false;
            textBoxProductPrice.Visible = false;

            buttonFinishAdding.Visible = false;
        }
        private void ClearAddBoxes()
        {
            textBoxName.Text = String.Empty;
            textBoxDescription.Text = String.Empty;
            textBoxPackingDate.Text = String.Empty;
            textBoxÑountryOfOrigin.Text = String.Empty;
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
            textBoxÑountryOfOrigin.Visible = true;

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
            labelAdd_Food_Page_Quantity.Text = "Ê³ë-ñòü:";

            labelAdd_ExpDate_PublishingHouse.Text = "Òåðì³í ïðèäàòíîñò³:";

            labelAdd_Measure_Authors.Text = "Âàãà:";

<<<<<<< HEAD
            buttonFinishAdding.Text = "������ �������";
            addProducts_AllElementVisibilityON();
=======
            buttonFinishAdding.Text = "Äîäàòè ïðîäóêò";
            addProducts_ElementVisibilityON();
>>>>>>> a706cd5927d963bdc0ce873b399fa5d789588263
        }

        private void toolStripButtonAddBook_Click(object sender, EventArgs e)
        {
            labelAdd_Food_Page_Quantity.Text = "Ê-ñòü ñòîð³íîê:";

            labelAdd_ExpDate_PublishingHouse.Text = "Âèäàâíèöòâî:";

            labelAdd_Measure_Authors.Text = "Àâòîðè:";

<<<<<<< HEAD
            buttonFinishAdding.Text = "������ �����";
            addProducts_AllElementVisibilityON();
=======
            buttonFinishAdding.Text = "Äîäàòè êíèãó";
            addProducts_ElementVisibilityON();
>>>>>>> a706cd5927d963bdc0ce873b399fa5d789588263
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0 && this.dataGridView1.SelectedRows.Count < this.dataGridView1.Rows.Count)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Âè âïåâíåí³, ùî õî÷åòå âèäàëèòè öåé òîâàð?", "Âèäàëåííÿ òîâàðó", buttons);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.RemoveAt(row.Index);
                    }
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

            table.Rows.Add(productList[i].name, productList[i].countryOfOrigin, productList[i].productPrice, productList[i].description, productList[i].packingDate,
        column6, column7, column8, column9, column10, column11);
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
<<<<<<< HEAD
                if (Convert.ToInt32(textBox_Food_Page_Quantity.Text) < 0 || Convert.ToInt32(textBoxProductPrice.Text) <= 0) 
                {
                    MessageBox.Show("ERROR. �������� �� ���� ���� ��'�����.");
                    succesfulAction = false;
=======
                if (buttonFinishAdding.Text == "Äîäàòè ïðîäóêò")
                {
                    table.Rows.Add(textBoxName.Text, textBoxÑountryOfOrigin.Text, Convert.ToInt32(textBoxProductPrice.Text),
                        textBoxDescription.Text, textBoxPackingDate.Text, Convert.ToInt32(textBox_Food_Page_Quantity.Text),
                        textBox_ExpDate_PublishingHouse.Text, textBox_Measure_Authors.Text, null, null, null);
>>>>>>> a706cd5927d963bdc0ce873b399fa5d789588263
                }
                else if (buttonFinishAdding.Text == "������ �����")
                {
<<<<<<< HEAD
                    productList.Add(new Product(textBoxName.Text, textBox�ountryOfOrigin.Text, Convert.ToInt32(textBoxProductPrice.Text),
                        textBoxDescription.Text, textBoxPackingDate.Text));
                }
                else if (buttonFinishAdding.Text == "������ �������")
                {
                    productList.Add(new Food(Convert.ToInt32(null), textBox_ExpDate_PublishingHouse.Text,
                        textBox_Measure_Authors.Text, textBoxName.Text, textBox�ountryOfOrigin.Text, Convert.ToInt32(textBoxProductPrice.Text),
                        textBoxDescription.Text, textBoxPackingDate.Text));
                }
                else if (buttonFinishAdding.Text == "������ �����")
                {
                    productList.Add(new Book(Convert.ToInt32(textBox_Food_Page_Quantity.Text), textBox_ExpDate_PublishingHouse.Text,
                        textBox_Measure_Authors.Text, textBoxName.Text, textBox�ountryOfOrigin.Text, Convert.ToInt32(textBoxProductPrice.Text),
                        textBoxDescription.Text, textBoxPackingDate.Text));
=======
                    table.Rows.Add(textBoxName.Text, textBoxÑountryOfOrigin.Text,
                    Convert.ToInt32(textBoxProductPrice.Text), textBoxDescription.Text,
                    textBoxPackingDate.Text, null, null, null, Convert.ToInt32(textBox_Food_Page_Quantity.Text),
                    textBox_ExpDate_PublishingHouse.Text, textBox_Measure_Authors.Text);
>>>>>>> a706cd5927d963bdc0ce873b399fa5d789588263
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
<<<<<<< HEAD
=======
                MessageBox.Show("ERROR! Ïåðåâ³ðòå ïðàâèëüí³ñòü ââåäåíèõ äàíèõ.");
>>>>>>> a706cd5927d963bdc0ce873b399fa5d789588263
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

    }

        


}
