namespace Invoice
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
            Comp_LeftSection = new GroupBox();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            Comp_RightSection = new GroupBox();
            textBox6 = new TextBox();
            label5 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            textBox8 = new TextBox();
            label7 = new Label();
            textBox9 = new TextBox();
            label8 = new Label();
            textBox10 = new TextBox();
            Personal_RightSection = new GroupBox();
            label32 = new Label();
            textBox22 = new TextBox();
            textBox23 = new TextBox();
            label33 = new Label();
            textBox24 = new TextBox();
            label34 = new Label();
            textBox25 = new TextBox();
            label35 = new Label();
            textBox26 = new TextBox();
            label36 = new Label();
            textBox27 = new TextBox();
            personalCheckboxRight = new CheckBox();
            companyCheckboxRight = new CheckBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox11 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label19 = new Label();
            label18 = new Label();
            label20 = new Label();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            dateTimePicker3 = new DateTimePicker();
            button1 = new Button();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            commodityName = new TextBox();
            priceNetto = new TextBox();
            addItemButton = new Button();
            vatPercentList = new ComboBox();
            paymentsList = new ComboBox();
            Personal_LeftSection = new GroupBox();
            label31 = new Label();
            textBox21 = new TextBox();
            textBox15 = new TextBox();
            label27 = new Label();
            textBox17 = new TextBox();
            label28 = new Label();
            textBox18 = new TextBox();
            label29 = new Label();
            textBox19 = new TextBox();
            label30 = new Label();
            textBox20 = new TextBox();
            companyCheckboxLeft = new CheckBox();
            personalCheckboxLeft = new CheckBox();
            unitsList = new ComboBox();
            priceBrutto = new TextBox();
            amountVAT = new TextBox();
            commodityList = new DataGridView();
            count = new TextBox();
            label37 = new Label();
            Comp_LeftSection.SuspendLayout();
            Comp_RightSection.SuspendLayout();
            Personal_RightSection.SuspendLayout();
            Personal_LeftSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)commodityList).BeginInit();
            SuspendLayout();
            // 
            // Comp_LeftSection
            // 
            Comp_LeftSection.Controls.Add(textBox5);
            Comp_LeftSection.Controls.Add(label4);
            Comp_LeftSection.Controls.Add(textBox4);
            Comp_LeftSection.Controls.Add(label3);
            Comp_LeftSection.Controls.Add(textBox3);
            Comp_LeftSection.Controls.Add(label2);
            Comp_LeftSection.Controls.Add(textBox2);
            Comp_LeftSection.Controls.Add(label1);
            Comp_LeftSection.Controls.Add(textBox1);
            Comp_LeftSection.Location = new Point(125, 179);
            Comp_LeftSection.Name = "Comp_LeftSection";
            Comp_LeftSection.Size = new Size(325, 247);
            Comp_LeftSection.TabIndex = 2;
            Comp_LeftSection.TabStop = false;
            Comp_LeftSection.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(226, 205);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(65, 27);
            textBox5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 181);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 7;
            label4.Text = "Miasto / Kod Pocztowy";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(0, 205);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(198, 27);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 125);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 5;
            label3.Text = "Adres";
            label3.Click += label3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(0, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(291, 27);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 73);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 3;
            label2.Text = "NIP";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 27);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 17);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 1;
            label1.Text = "Nazwa Firmy";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 27);
            textBox1.TabIndex = 0;
            // 
            // Comp_RightSection
            // 
            Comp_RightSection.Controls.Add(textBox6);
            Comp_RightSection.Controls.Add(label5);
            Comp_RightSection.Controls.Add(textBox7);
            Comp_RightSection.Controls.Add(label6);
            Comp_RightSection.Controls.Add(textBox8);
            Comp_RightSection.Controls.Add(label7);
            Comp_RightSection.Controls.Add(textBox9);
            Comp_RightSection.Controls.Add(label8);
            Comp_RightSection.Controls.Add(textBox10);
            Comp_RightSection.Location = new Point(624, 178);
            Comp_RightSection.Name = "Comp_RightSection";
            Comp_RightSection.Size = new Size(381, 247);
            Comp_RightSection.TabIndex = 9;
            Comp_RightSection.TabStop = false;
            Comp_RightSection.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(242, 205);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(65, 27);
            textBox6.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 181);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 7;
            label5.Text = "Miasto / Kod Pocztowy";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(0, 205);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(216, 27);
            textBox7.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 125);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 5;
            label6.Text = "Adres";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(0, 149);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(268, 27);
            textBox8.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 73);
            label7.Name = "label7";
            label7.Size = new Size(32, 20);
            label7.TabIndex = 3;
            label7.Text = "NIP";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(0, 93);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(146, 27);
            textBox9.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 17);
            label8.Name = "label8";
            label8.Size = new Size(94, 20);
            label8.TabIndex = 1;
            label8.Text = "Nazwa Firmy";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(0, 40);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(307, 27);
            textBox10.TabIndex = 0;
            // 
            // Personal_RightSection
            // 
            Personal_RightSection.Controls.Add(label32);
            Personal_RightSection.Controls.Add(textBox22);
            Personal_RightSection.Controls.Add(textBox23);
            Personal_RightSection.Controls.Add(label33);
            Personal_RightSection.Controls.Add(textBox24);
            Personal_RightSection.Controls.Add(label34);
            Personal_RightSection.Controls.Add(textBox25);
            Personal_RightSection.Controls.Add(label35);
            Personal_RightSection.Controls.Add(textBox26);
            Personal_RightSection.Controls.Add(label36);
            Personal_RightSection.Controls.Add(textBox27);
            Personal_RightSection.Location = new Point(623, 179);
            Personal_RightSection.Name = "Personal_RightSection";
            Personal_RightSection.Size = new Size(383, 247);
            Personal_RightSection.TabIndex = 11;
            Personal_RightSection.TabStop = false;
            Personal_RightSection.Visible = false;
            Personal_RightSection.Enter += Personal_RightSection_Enter;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(188, 17);
            label32.Name = "label32";
            label32.Size = new Size(72, 20);
            label32.TabIndex = 10;
            label32.Text = "Nazwisko";
            // 
            // textBox22
            // 
            textBox22.Location = new Point(188, 40);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(157, 27);
            textBox22.TabIndex = 9;
            // 
            // textBox23
            // 
            textBox23.Location = new Point(248, 205);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(65, 27);
            textBox23.TabIndex = 8;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(0, 181);
            label33.Name = "label33";
            label33.Size = new Size(161, 20);
            label33.TabIndex = 7;
            label33.Text = "Miasto / Kod Pocztowy";
            // 
            // textBox24
            // 
            textBox24.Location = new Point(0, 205);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(218, 27);
            textBox24.TabIndex = 6;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(0, 125);
            label34.Name = "label34";
            label34.Size = new Size(47, 20);
            label34.TabIndex = 5;
            label34.Text = "Adres";
            // 
            // textBox25
            // 
            textBox25.Location = new Point(0, 149);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(241, 27);
            textBox25.TabIndex = 4;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(0, 69);
            label35.Name = "label35";
            label35.Size = new Size(42, 20);
            label35.TabIndex = 3;
            label35.Text = "Pesel";
            // 
            // textBox26
            // 
            textBox26.Location = new Point(0, 93);
            textBox26.Name = "textBox26";
            textBox26.Size = new Size(161, 27);
            textBox26.TabIndex = 2;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(0, 17);
            label36.Name = "label36";
            label36.Size = new Size(38, 20);
            label36.TabIndex = 1;
            label36.Text = "Imie";
            // 
            // textBox27
            // 
            textBox27.Location = new Point(0, 40);
            textBox27.Name = "textBox27";
            textBox27.Size = new Size(148, 27);
            textBox27.TabIndex = 0;
            // 
            // personalCheckboxRight
            // 
            personalCheckboxRight.AutoSize = true;
            personalCheckboxRight.Location = new Point(697, 151);
            personalCheckboxRight.Name = "personalCheckboxRight";
            personalCheckboxRight.Size = new Size(74, 24);
            personalCheckboxRight.TabIndex = 11;
            personalCheckboxRight.Text = "Osoba";
            personalCheckboxRight.UseVisualStyleBackColor = true;
            personalCheckboxRight.CheckedChanged += personalCheckboxRight_CheckedChanged;
            // 
            // companyCheckboxRight
            // 
            companyCheckboxRight.AutoSize = true;
            companyCheckboxRight.Location = new Point(623, 151);
            companyCheckboxRight.Name = "companyCheckboxRight";
            companyCheckboxRight.Size = new Size(68, 24);
            companyCheckboxRight.TabIndex = 10;
            companyCheckboxRight.Text = "Firma";
            companyCheckboxRight.UseVisualStyleBackColor = true;
            companyCheckboxRight.CheckedChanged += companyCheckboxRight_CheckedChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(127, 9);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 12;
            label9.Text = "Numer Faktury";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(397, 12);
            label10.Name = "label10";
            label10.Size = new Size(128, 20);
            label10.TabIndex = 13;
            label10.Text = "Data Wystawienia";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(736, 12);
            label11.Name = "label11";
            label11.Size = new Size(113, 20);
            label11.TabIndex = 14;
            label11.Text = "Data Sprzedaży";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(127, 33);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(196, 27);
            textBox11.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(397, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(273, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(735, 35);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(270, 27);
            dateTimePicker2.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(125, 111);
            label12.Name = "label12";
            label12.Size = new Size(158, 37);
            label12.TabIndex = 17;
            label12.Text = "Sprzedawca";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ImageAlign = ContentAlignment.TopLeft;
            label13.Location = new Point(623, 111);
            label13.Margin = new Padding(0);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.No;
            label13.Size = new Size(126, 37);
            label13.TabIndex = 18;
            label13.Text = "Nabywca";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(579, 665);
            label14.Name = "label14";
            label14.Size = new Size(140, 54);
            label14.TabIndex = 10;
            label14.Text = "Razem";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(740, 665);
            label15.Name = "label15";
            label15.Size = new Size(101, 20);
            label15.TabIndex = 9;
            label15.Text = "Wartość netto";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(899, 665);
            label16.Name = "label16";
            label16.Size = new Size(107, 20);
            label16.TabIndex = 22;
            label16.Text = "Wartość Brutto";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(125, 731);
            label17.Name = "label17";
            label17.Size = new Size(122, 20);
            label17.TabIndex = 9;
            label17.Text = "Sposób Płatności";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(295, 731);
            label19.Name = "label19";
            label19.Size = new Size(117, 20);
            label19.TabIndex = 24;
            label19.Text = "Termin Płatności";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(599, 734);
            label18.Name = "label18";
            label18.Size = new Size(68, 20);
            label18.TabIndex = 25;
            label18.Text = "Nr Konta";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(127, 792);
            label20.Name = "label20";
            label20.Size = new Size(51, 20);
            label20.TabIndex = 26;
            label20.Text = "Uwagi";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(125, 815);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(881, 56);
            textBox12.TabIndex = 27;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(599, 757);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(309, 27);
            textBox13.TabIndex = 9;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(295, 755);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(274, 27);
            dateTimePicker3.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(1008, 903);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 29;
            button1.Text = "Wystaw Fakture";
            button1.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(127, 431);
            label21.Name = "label21";
            label21.Size = new Size(174, 20);
            label21.TabIndex = 9;
            label21.Text = "Nazwa towaru lub Usługi";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(435, 429);
            label22.Name = "label22";
            label22.Size = new Size(74, 20);
            label22.TabIndex = 30;
            label22.Text = "Jednostka";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(543, 431);
            label23.Name = "label23";
            label23.Size = new Size(84, 20);
            label23.TabIndex = 31;
            label23.Text = "Cena Netto";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(664, 429);
            label24.Name = "label24";
            label24.Size = new Size(85, 20);
            label24.TabIndex = 32;
            label24.Text = "Stawka VAT";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(771, 431);
            label25.Name = "label25";
            label25.Size = new Size(79, 20);
            label25.TabIndex = 33;
            label25.Text = "Kwota VAT";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(897, 427);
            label26.Name = "label26";
            label26.Size = new Size(87, 20);
            label26.TabIndex = 34;
            label26.Text = "Cena Brutto";
            // 
            // commodityName
            // 
            commodityName.Location = new Point(127, 453);
            commodityName.Name = "commodityName";
            commodityName.Size = new Size(196, 27);
            commodityName.TabIndex = 9;
            commodityName.TextChanged += commodityName_TextChanged;
            // 
            // priceNetto
            // 
            priceNetto.Location = new Point(543, 453);
            priceNetto.Name = "priceNetto";
            priceNetto.Size = new Size(105, 27);
            priceNetto.TabIndex = 36;
            priceNetto.TextChanged += priceNetto_TextChanged;
            // 
            // addItemButton
            // 
            addItemButton.Location = new Point(1025, 451);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(75, 31);
            addItemButton.TabIndex = 38;
            addItemButton.Text = "Dodaj";
            addItemButton.UseVisualStyleBackColor = true;
            addItemButton.Click += addItemButton_Click;
            // 
            // vatPercentList
            // 
            vatPercentList.FormattingEnabled = true;
            vatPercentList.Location = new Point(665, 451);
            vatPercentList.Name = "vatPercentList";
            vatPercentList.Size = new Size(84, 28);
            vatPercentList.TabIndex = 40;
            vatPercentList.SelectedIndexChanged += vatPercentList_SelectedIndexChanged;
            // 
            // paymentsList
            // 
            paymentsList.FormattingEnabled = true;
            paymentsList.Location = new Point(127, 754);
            paymentsList.Name = "paymentsList";
            paymentsList.Size = new Size(142, 28);
            paymentsList.TabIndex = 41;
            paymentsList.SelectedIndexChanged += paymentsList_SelectedIndexChanged;
            // 
            // Personal_LeftSection
            // 
            Personal_LeftSection.Controls.Add(label31);
            Personal_LeftSection.Controls.Add(textBox21);
            Personal_LeftSection.Controls.Add(textBox15);
            Personal_LeftSection.Controls.Add(label27);
            Personal_LeftSection.Controls.Add(textBox17);
            Personal_LeftSection.Controls.Add(label28);
            Personal_LeftSection.Controls.Add(textBox18);
            Personal_LeftSection.Controls.Add(label29);
            Personal_LeftSection.Controls.Add(textBox19);
            Personal_LeftSection.Controls.Add(label30);
            Personal_LeftSection.Controls.Add(textBox20);
            Personal_LeftSection.Location = new Point(125, 181);
            Personal_LeftSection.Name = "Personal_LeftSection";
            Personal_LeftSection.Size = new Size(351, 245);
            Personal_LeftSection.TabIndex = 9;
            Personal_LeftSection.TabStop = false;
            Personal_LeftSection.Visible = false;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(170, 23);
            label31.Name = "label31";
            label31.Size = new Size(72, 20);
            label31.TabIndex = 10;
            label31.Text = "Nazwisko";
            // 
            // textBox21
            // 
            textBox21.Location = new Point(170, 40);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(149, 27);
            textBox21.TabIndex = 9;
            // 
            // textBox15
            // 
            textBox15.Location = new Point(219, 205);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(65, 27);
            textBox15.TabIndex = 8;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(0, 181);
            label27.Name = "label27";
            label27.Size = new Size(161, 20);
            label27.TabIndex = 7;
            label27.Text = "Miasto / Kod Pocztowy";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(0, 205);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(183, 27);
            textBox17.TabIndex = 6;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(0, 125);
            label28.Name = "label28";
            label28.Size = new Size(47, 20);
            label28.TabIndex = 5;
            label28.Text = "Adres";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(0, 149);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(242, 27);
            textBox18.TabIndex = 4;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(0, 69);
            label29.Name = "label29";
            label29.Size = new Size(42, 20);
            label29.TabIndex = 3;
            label29.Text = "Pesel";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(0, 93);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(161, 27);
            textBox19.TabIndex = 2;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(0, 17);
            label30.Name = "label30";
            label30.Size = new Size(38, 20);
            label30.TabIndex = 1;
            label30.Text = "Imie";
            // 
            // textBox20
            // 
            textBox20.Location = new Point(0, 40);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(148, 27);
            textBox20.TabIndex = 0;
            // 
            // companyCheckboxLeft
            // 
            companyCheckboxLeft.AutoSize = true;
            companyCheckboxLeft.Location = new Point(125, 151);
            companyCheckboxLeft.Name = "companyCheckboxLeft";
            companyCheckboxLeft.Size = new Size(68, 24);
            companyCheckboxLeft.TabIndex = 42;
            companyCheckboxLeft.Text = "Firma";
            companyCheckboxLeft.UseVisualStyleBackColor = true;
            companyCheckboxLeft.CheckedChanged += companyCheckboxLeft_CheckedChanged;
            // 
            // personalCheckboxLeft
            // 
            personalCheckboxLeft.AutoSize = true;
            personalCheckboxLeft.Location = new Point(199, 151);
            personalCheckboxLeft.Name = "personalCheckboxLeft";
            personalCheckboxLeft.Size = new Size(74, 24);
            personalCheckboxLeft.TabIndex = 43;
            personalCheckboxLeft.Text = "Osoba";
            personalCheckboxLeft.UseVisualStyleBackColor = true;
            personalCheckboxLeft.CheckedChanged += personalCheckboxLeft_CheckedChanged;
            // 
            // unitsList
            // 
            unitsList.FormattingEnabled = true;
            unitsList.Location = new Point(435, 451);
            unitsList.Name = "unitsList";
            unitsList.Size = new Size(84, 28);
            unitsList.TabIndex = 44;
            unitsList.SelectedIndexChanged += unitsList_SelectedIndexChanged;
            // 
            // priceBrutto
            // 
            priceBrutto.Location = new Point(897, 451);
            priceBrutto.Margin = new Padding(3, 4, 3, 4);
            priceBrutto.Name = "priceBrutto";
            priceBrutto.Size = new Size(109, 27);
            priceBrutto.TabIndex = 46;
            priceBrutto.TextChanged += priceBrutto_TextChanged;
            // 
            // amountVAT
            // 
            amountVAT.Location = new Point(771, 451);
            amountVAT.Margin = new Padding(3, 4, 3, 4);
            amountVAT.Name = "amountVAT";
            amountVAT.Size = new Size(106, 27);
            amountVAT.TabIndex = 47;
            amountVAT.TextChanged += amountVAT_TextChanged;
            // 
            // commodityList
            // 
            commodityList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            commodityList.Location = new Point(121, 525);
            commodityList.Margin = new Padding(3, 4, 3, 4);
            commodityList.Name = "commodityList";
            commodityList.RowHeadersWidth = 51;
            commodityList.RowTemplate.Height = 25;
            commodityList.Size = new Size(885, 136);
            commodityList.TabIndex = 48;
            commodityList.CellContentClick += commodityList_CellContentClick;
            // 
            // count
            // 
            count.Location = new Point(344, 453);
            count.Name = "count";
            count.Size = new Size(72, 27);
            count.TabIndex = 49;
            count.TextChanged += count_TextChanged;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(344, 431);
            label37.Name = "label37";
            label37.Size = new Size(39, 20);
            label37.TabIndex = 50;
            label37.Text = "Ilość";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 944);
            Controls.Add(label37);
            Controls.Add(count);
            Controls.Add(Comp_RightSection);
            Controls.Add(commodityList);
            Controls.Add(amountVAT);
            Controls.Add(priceBrutto);
            Controls.Add(unitsList);
            Controls.Add(personalCheckboxLeft);
            Controls.Add(companyCheckboxLeft);
            Controls.Add(paymentsList);
            Controls.Add(vatPercentList);
            Controls.Add(addItemButton);
            Controls.Add(Personal_LeftSection);
            Controls.Add(priceNetto);
            Controls.Add(commodityName);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(button1);
            Controls.Add(dateTimePicker3);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(label20);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox11);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(personalCheckboxRight);
            Controls.Add(companyCheckboxRight);
            Controls.Add(Comp_LeftSection);
            Controls.Add(Personal_RightSection);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Comp_LeftSection.ResumeLayout(false);
            Comp_LeftSection.PerformLayout();
            Comp_RightSection.ResumeLayout(false);
            Comp_RightSection.PerformLayout();
            Personal_RightSection.ResumeLayout(false);
            Personal_RightSection.PerformLayout();
            Personal_LeftSection.ResumeLayout(false);
            Personal_LeftSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)commodityList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox Comp_LeftSection;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox5;
        private GroupBox Comp_RightSection;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox7;
        private Label label6;
        private TextBox textBox8;
        private Label label7;
        private TextBox textBox9;
        private Label label8;
        private TextBox textBox10;
        private CheckBox personalCheckboxRight;
        private CheckBox companyCheckboxRight;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox11;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label19;
        private Label label18;
        private Label label20;
        private TextBox textBox12;
        private TextBox textBox13;
        private DateTimePicker dateTimePicker3;
        private Button button1;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private TextBox commodityName;
        private TextBox priceNetto;
        private Button addItemButton;
        private ComboBox vatPercentList;
        private GroupBox Personal_RightSection;
        private Label label32;
        private TextBox textBox22;
        private TextBox textBox23;
        private Label label33;
        private TextBox textBox24;
        private Label label34;
        private TextBox textBox25;
        private Label label35;
        private TextBox textBox26;
        private Label label36;
        private TextBox textBox27;
        private ComboBox paymentsList;
        private GroupBox Personal_LeftSection;
        private Label label31;
        private TextBox textBox21;
        private TextBox textBox15;
        private Label label27;
        private TextBox textBox17;
        private Label label28;
        private TextBox textBox18;
        private Label label29;
        private TextBox textBox19;
        private Label label30;
        private TextBox textBox20;
        private CheckBox companyCheckboxLeft;
        private CheckBox personalCheckboxLeft;
        private ComboBox unitsList;
        private TextBox priceBrutto;
        private TextBox amountVAT;
        private DataGridView commodityList;
        private TextBox count;
        private Label label37;
    }
}