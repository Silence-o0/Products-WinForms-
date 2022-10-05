using System.Data;


namespace Products
{
    public partial class Form1 : Form
    {
        class Product
        {
            string name;
            string countryOfOrigin;
            double productPrice;
            string description;
            string packingDate;
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
            textBoxÑountryOfOrigin.Visible = false;

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
            textBoxÑountryOfOrigin.Text = String.Empty;
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
            textBoxÑountryOfOrigin.Visible = true;

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
            labelAdd_Food_Page_Quantity.Text = "Ê³ë-ñòü:";

            labelAdd_ExpDate_PublishingHouse.Text = "Òåðì³í ïðèäàòíîñò³:";

            labelAdd_Measure_Authors.Text = "Âàãà:";

            buttonFinishAdding.Text = "Äîäàòè ïðîäóêò";
            addProducts_ElementVisibilityON();
        }

        private void toolStripButtonAddBook_Click(object sender, EventArgs e)
        {
            labelAdd_Food_Page_Quantity.Text = "Ê-ñòü ñòîð³íîê:";

            labelAdd_ExpDate_PublishingHouse.Text = "Âèäàâíèöòâî:";

            labelAdd_Measure_Authors.Text = "Àâòîðè:";

            buttonFinishAdding.Text = "Äîäàòè êíèãó";
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
                DialogResult result = MessageBox.Show("Âè âïåâíåí³, ùî õî÷åòå âèäàëèòè öåé òîâàð?", "Âèäàëåííÿ òîâàðó", buttons);
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
                if (buttonFinishAdding.Text == "Äîäàòè ïðîäóêò")
                {
                    table.Rows.Add(textBoxName.Text, textBoxÑountryOfOrigin.Text, Convert.ToInt32(textBoxProductPrice.Text),
                        textBoxDescription.Text, textBoxPackingDate.Text, Convert.ToInt32(textBox_Food_Page_Quantity.Text),
                        textBox_ExpDate_PublishingHouse.Text, textBox_Measure_Authors.Text, null, null, null);
                }
                else
                {
                    table.Rows.Add(textBoxName.Text, textBoxÑountryOfOrigin.Text,
                    Convert.ToInt32(textBoxProductPrice.Text), textBoxDescription.Text,
                    textBoxPackingDate.Text, null, null, null, Convert.ToInt32(textBox_Food_Page_Quantity.Text),
                    textBox_ExpDate_PublishingHouse.Text, textBox_Measure_Authors.Text);
                }
            }
            catch (Exception ex)
            {
                succesfulAction = false;
                MessageBox.Show("ERROR! Ïåðåâ³ðòå ïðàâèëüí³ñòü ââåäåíèõ äàíèõ.");
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
