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

            priceNetto.KeyPress += TextBox_spaceKeyBlock;
            priceNetto.KeyPress += TextBox_letterKeyBlock;

            count.KeyPress += TextBox_letterKeyBlock;
            count.KeyPress += TextBox_letterKeyBlock;

            amountVAT.KeyPress += TextBox_letterKeyBlock;
            amountVAT.KeyPress += TextBox_letterKeyBlock;

            priceBrutto.KeyPress += TextBox_letterKeyBlock;
            priceBrutto.KeyPress += TextBox_letterKeyBlock;

            accountNumber.KeyPress += TextBox_letterKeyBlock;
            accountNumber.KeyPress += TextBox_letterKeyBlock;
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
        private void TextBox_spaceKeyBlock(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
        private void TextBox_letterKeyBlock(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;

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
            string comName = commodityName.Text;
            string cnt = count.Text;
            string unt = unitsList.SelectedItem?.ToString();
            string netPrice = priceNetto.Text;
            string percVat = vatPercentList.SelectedItem?.ToString();
            string couVAT = amountVAT.Text;
            string bruttPrice = priceBrutto.Text;

            if (comName != null && cnt != null && unt != null && netPrice != null && percVat != null && couVAT != null && bruttPrice != null)
            {
                DataGridViewButtonColumn uninstallButtonColumn = new DataGridViewButtonColumn();
                uninstallButtonColumn.Name = "uninstall_column";
                uninstallButtonColumn.Text = "Uninstall";
                uninstallButtonColumn.UseColumnTextForButtonValue = true;
                int columnIndex = 0;
                commodityList.Columns.Insert(columnIndex, uninstallButtonColumn);
                try
                {
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

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding commodity: {ex.Message}");
                }
            }

        }

        private void commodityList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void commodityName_TextChanged(object sender, EventArgs e)
        {

        }

        private void count_TextChanged(object sender, EventArgs e)
        {

        }
    }
}