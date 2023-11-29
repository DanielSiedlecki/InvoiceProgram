namespace Invoice
{
    public partial class Form1 : Form
    {
        private object listLock = new object();
        private List<Commodity> lstCommodity = new List<Commodity>();
        private List<int> vatList = new List<int> { 23, 10, 30 };
        private List<string> unitList = new List<string> { "kg", "g", "szt", "kompl" };
        private List<string> paymentList = new List<string> { "gotówka", "przelew" };
        public class Commodity
        {


            public string Name { get; set; }
            public string Count { get; set; }
            public string Unit { get; set; }
            public string NettoPrice { get; set; }
            public string PercentVat { get; set; }
            public string CountVAT { get; set; }
            public string BruttoPrice { get; set; }




        }
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Invoicer";

            priceBrutto.Visible = false;
            vatPercentList.DataSource = vatList;
            vatPercentList.Format += VatPercentList_Format;
            unitsList.DataSource = unitList;
            paymentsList.DataSource = paymentList;

            priceNetto.TextChanged += priceBrutto_TextChanged;

            priceNetto.KeyPress += Validation_KeyPress;

            count.KeyPress += Validation_KeyPress;

            amountVAT.KeyPress += Validation_KeyPress;

            priceBrutto.KeyPress += Validation_KeyPress;

            accountNumber.KeyPress += onlyNumberValidation_KeyPress;

        }


        private void VatPercentList_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem != null)
            {
                e.Value = $"{e.ListItem}%";
            }
            else
            {
                e.Value = null;
            }
        }
        private void onlyNumberValidation_KeyPress(object sender, KeyPressEventArgs e)


        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Space))
            {

                e.Handled = true;
            }

        }
        private void Validation_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                string text = textBox.Text;
                char keyPressed = e.KeyChar;

                if (char.IsLetter(keyPressed) || keyPressed == '.' || keyPressed == ',' && text.Contains(',') || keyPressed == (char)Keys.Space)
                {
                    e.Handled = true;
                }
                else if (keyPressed == (char)Keys.Back)
                {
                    return;
                }
                else if (text.Contains(','))
                {
                    string[] parts = text.Split(',');
                    string lastPart = parts[parts.Length - 1];

                    if (lastPart.Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Personal_RightSection_Enter(object sender, EventArgs e)
        {

        }

        private void companyCheckboxRight_CheckedChanged(object sender, EventArgs e)
        {
            Comp_RightSection.Visible = companyCheckboxRight.Checked;

            if (Comp_RightSection.Visible)
            {
                personalCheckboxRight.Checked = false;
                Personal_RightSection.Visible = false;
            }
        }

        private void personalCheckboxRight_CheckedChanged(object sender, EventArgs e)
        {
            Personal_RightSection.Visible = personalCheckboxRight.Checked;

            if (Personal_RightSection.Visible)
            {
                Comp_RightSection.Visible = false;
                companyCheckboxRight.Checked = false;
            }
        }

        private void companyCheckboxLeft_CheckedChanged(object sender, EventArgs e)
        {
            Comp_LeftSection.Visible = companyCheckboxLeft.Checked;

            if (Comp_LeftSection.Visible)
            {
                personalCheckboxLeft.Checked = false;
                Personal_LeftSection.Visible = false;
            }
        }

        private void personalCheckboxLeft_CheckedChanged(object sender, EventArgs e)
        {
            Personal_LeftSection.Visible = personalCheckboxLeft.Checked;

            if (Personal_LeftSection.Visible)
            {
                Comp_LeftSection.Visible = false;
                companyCheckboxLeft.Checked = false;
            }
        }

        private void vatPercentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void unitsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void paymentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (paymentsList.SelectedItem == "gotówka")
            {
                accountNumber.Visible = false;
                accountNumberLabel.Visible = false;
            }
            else
            {
                accountNumber.Visible = true;
                accountNumberLabel.Visible = true;
            }
        }

        private void priceNetto_TextChanged(object sender, EventArgs e)
        {


            if (int.TryParse(priceNetto.Text, out int priceNett))
            {

                if (vatPercentList.SelectedItem != null && int.TryParse(vatPercentList.SelectedItem.ToString(), out int VAT))
                {
                    priceBrutto.Visible = true;
                    double percentVAT = VAT * 0.01;
                    double countVAT = Math.Round(percentVAT * priceNett, 2);
                    double Brutto = Math.Round(priceNett + countVAT, 2);
                    amountVAT.Text = countVAT.ToString();
                    priceBrutto.Text = Brutto.ToString(); ;
                }

            }
        }

        private void priceBrutto_TextChanged(object sender, EventArgs e)
        {

        }

        private void amountVAT_TextChanged(object sender, EventArgs e)
        {

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(commodityName.Text) ||
                string.IsNullOrWhiteSpace(count.Text) ||
                unitsList.SelectedValue == null ||
                string.IsNullOrWhiteSpace(priceNetto.Text) ||
                string.IsNullOrWhiteSpace(priceBrutto.Text) ||
                vatPercentList.SelectedValue == null ||
                string.IsNullOrWhiteSpace(amountVAT.Text))
            {
                return;
            }



            string comName = commodityName.Text;
            string cnt = count.Text;
            string unt = unitsList.SelectedItem?.ToString();
            string netPrice = priceNetto.Text;
            string percVat = vatPercentList.SelectedItem?.ToString();
            string couVAT = amountVAT.Text;
            string bruttPrice = priceBrutto.Text;

            if (comName != null && cnt != null && unt != null && netPrice != null && percVat != null && couVAT != null && bruttPrice != null)
            {


                try
                {

                    DataGridViewButtonColumn RemoveButtonColumn = new DataGridViewButtonColumn();
                    RemoveButtonColumn.Name = "Action";
                    RemoveButtonColumn.Text = "Usuñ";
                    RemoveButtonColumn.UseColumnTextForButtonValue = true;
                    int columnIndex = 0;
                    if (commodityList.Columns["Action"] == null)
                    {
                        commodityList.Columns.Insert(columnIndex, RemoveButtonColumn);
                    }

                    Commodity com = new Commodity
                    {
                        Name = comName,
                        Count = cnt,
                        Unit = unt,
                        NettoPrice = netPrice,
                        PercentVat = percVat,
                        CountVAT = couVAT,
                        BruttoPrice = bruttPrice
                    };

                    lstCommodity.Add(com);
                    commodityList.DataSource = null;
                    commodityList.DataSource = lstCommodity;

                    sumFinalPrice_Click();


                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding commodity: {ex.Message}");
                }


            }

        }

        private void commodityList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (commodityList.Columns[e.ColumnIndex].Name == "Action")
            {
                if (e.RowIndex < lstCommodity.Count)
                {

                    lstCommodity.RemoveAt(e.RowIndex);
                    RefreshDataGridView();
                }
            }
        }

        private void RefreshDataGridView()
        {

            commodityList.DataSource = null;
            commodityList.DataSource = lstCommodity;
        }

        private void commodityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void count_TextChanged(object sender, EventArgs e)
        {

        }
        private void nettoSum_Click(object sender, EventArgs e)
        {
        }
        private void sumFinalPrice_Click()
        {

            if (lstCommodity.Count > 0)
            {
                nettoSum.Visible = true;
                bruttSum.Visible = true;
            }
            double sumNetto = 0;
            double sumBrutto = 0;
            foreach (Commodity com in lstCommodity)
            {
                sumNetto += System.Convert.ToDouble(com.NettoPrice);
                sumBrutto += System.Convert.ToDouble(com.BruttoPrice);

            }
            nettoSum.Text = Math.Round(sumNetto, 2).ToString();
            bruttSum.Text = Math.Round(sumBrutto, 2).ToString();
        }


    }
}