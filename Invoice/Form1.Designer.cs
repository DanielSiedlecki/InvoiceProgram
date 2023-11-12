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
            company_Select = new CheckBox();
            personal_Select = new CheckBox();
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBox6 = new TextBox();
            label5 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            textBox8 = new TextBox();
            label7 = new Label();
            textBox9 = new TextBox();
            label8 = new Label();
            textBox10 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox11 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            dataGridView1 = new DataGridView();
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
            textBox14 = new TextBox();
            textBox16 = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            groupBox3 = new GroupBox();
            textBox15 = new TextBox();
            label27 = new Label();
            textBox17 = new TextBox();
            label28 = new Label();
            textBox18 = new TextBox();
            label29 = new Label();
            textBox19 = new TextBox();
            label30 = new Label();
            textBox20 = new TextBox();
            textBox21 = new TextBox();
            label31 = new Label();
            groupBox4 = new GroupBox();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // company_Select
            // 
            company_Select.AutoSize = true;
            company_Select.Location = new Point(55, 132);
            company_Select.Name = "company_Select";
            company_Select.Size = new Size(68, 24);
            company_Select.TabIndex = 0;
            company_Select.Text = "Firma";
            company_Select.UseVisualStyleBackColor = true;
            company_Select.CheckedChanged += company_Select_CheckedChanged;
            // 
            // personal_Select
            // 
            personal_Select.AutoSize = true;
            personal_Select.Location = new Point(129, 132);
            personal_Select.Name = "personal_Select";
            personal_Select.Size = new Size(74, 24);
            personal_Select.TabIndex = 1;
            personal_Select.Text = "Osoba";
            personal_Select.UseVisualStyleBackColor = true;
            personal_Select.CheckedChanged += personal_Select_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(55, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 247);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(167, 205);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(65, 27);
            textBox5.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 182);
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
            textBox4.Size = new Size(161, 27);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 126);
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
            textBox3.Size = new Size(218, 27);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 70);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 3;
            label2.Text = "NIP";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(218, 27);
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
            textBox1.Size = new Size(218, 27);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(textBox10);
            groupBox2.Location = new Point(456, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 247);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(167, 205);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(65, 27);
            textBox6.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 182);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 7;
            label5.Text = "Miasto / Kod Pocztowy";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(0, 205);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(161, 27);
            textBox7.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 126);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 5;
            label6.Text = "Adres";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(0, 149);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(218, 27);
            textBox8.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 70);
            label7.Name = "label7";
            label7.Size = new Size(32, 20);
            label7.TabIndex = 3;
            label7.Text = "NIP";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(0, 93);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(218, 27);
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
            textBox10.Size = new Size(218, 27);
            textBox10.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(530, 132);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(74, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Osoba";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(456, 132);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(68, 24);
            checkBox2.TabIndex = 10;
            checkBox2.Text = "Firma";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(75, 9);
            label9.Name = "label9";
            label9.Size = new Size(104, 20);
            label9.TabIndex = 12;
            label9.Text = "Numer Faktury";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(300, 9);
            label10.Name = "label10";
            label10.Size = new Size(128, 20);
            label10.TabIndex = 13;
            label10.Text = "Data Wystawienia";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(578, 9);
            label11.Name = "label11";
            label11.Size = new Size(113, 20);
            label11.TabIndex = 14;
            label11.Text = "Data Sprzedaży";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(40, 32);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(174, 27);
            textBox11.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(238, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(515, 32);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(55, 92);
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
            label13.Location = new Point(456, 92);
            label13.Margin = new Padding(0);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.No;
            label13.Size = new Size(126, 37);
            label13.TabIndex = 18;
            label13.Text = "Nabywca";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(55, 510);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(651, 140);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(248, 653);
            label14.Name = "label14";
            label14.Size = new Size(140, 54);
            label14.TabIndex = 10;
            label14.Text = "Razem";
            label14.Click += label14_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(413, 653);
            label15.Name = "label15";
            label15.Size = new Size(101, 20);
            label15.TabIndex = 9;
            label15.Text = "Wartość netto";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(567, 653);
            label16.Name = "label16";
            label16.Size = new Size(107, 20);
            label16.TabIndex = 22;
            label16.Text = "Wartość Brutto";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(55, 728);
            label17.Name = "label17";
            label17.Size = new Size(122, 20);
            label17.TabIndex = 9;
            label17.Text = "Sposób Płatności";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(200, 728);
            label19.Name = "label19";
            label19.Size = new Size(117, 20);
            label19.TabIndex = 24;
            label19.Text = "Termin Płatności";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(456, 728);
            label18.Name = "label18";
            label18.Size = new Size(68, 20);
            label18.TabIndex = 25;
            label18.Text = "Nr Konta";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(55, 790);
            label20.Name = "label20";
            label20.Size = new Size(51, 20);
            label20.TabIndex = 26;
            label20.Text = "Uwagi";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(55, 813);
            textBox12.Multiline = true;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(651, 56);
            textBox12.TabIndex = 27;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(456, 751);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(309, 27);
            textBox13.TabIndex = 9;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(200, 751);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(250, 27);
            dateTimePicker3.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(615, 877);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 29;
            button1.Text = "Wystaw Fakture";
            button1.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(55, 428);
            label21.Name = "label21";
            label21.Size = new Size(174, 20);
            label21.TabIndex = 9;
            label21.Text = "Nazwa towaru lub Usługi";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(235, 428);
            label22.Name = "label22";
            label22.Size = new Size(74, 20);
            label22.TabIndex = 30;
            label22.Text = "Jednostka";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(316, 428);
            label23.Name = "label23";
            label23.Size = new Size(84, 20);
            label23.TabIndex = 31;
            label23.Text = "Cena Netto";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(418, 428);
            label24.Name = "label24";
            label24.Size = new Size(85, 20);
            label24.TabIndex = 32;
            label24.Text = "Stawka VAT";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(515, 428);
            label25.Name = "label25";
            label25.Size = new Size(79, 20);
            label25.TabIndex = 33;
            label25.Text = "Kwota VAT";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(601, 428);
            label26.Name = "label26";
            label26.Size = new Size(87, 20);
            label26.TabIndex = 34;
            label26.Text = "Cena Brutto";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(55, 451);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(161, 27);
            textBox14.TabIndex = 9;
            // 
            // textBox16
            // 
            textBox16.Location = new Point(316, 451);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(81, 27);
            textBox16.TabIndex = 36;
            // 
            // button2
            // 
            button2.Location = new Point(55, 475);
            button2.Name = "button2";
            button2.Size = new Size(76, 29);
            button2.TabIndex = 38;
            button2.Text = "Dodaj";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(236, 450);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(74, 28);
            comboBox1.TabIndex = 39;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(418, 451);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(74, 28);
            comboBox2.TabIndex = 40;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(57, 753);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(120, 28);
            comboBox3.TabIndex = 41;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label31);
            groupBox3.Controls.Add(textBox21);
            groupBox3.Controls.Add(textBox15);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(textBox17);
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(textBox18);
            groupBox3.Controls.Add(label29);
            groupBox3.Controls.Add(textBox19);
            groupBox3.Controls.Add(label30);
            groupBox3.Controls.Add(textBox20);
            groupBox3.Location = new Point(55, 162);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 247);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // textBox15
            // 
            textBox15.Location = new Point(167, 205);
            textBox15.Name = "textBox15";
            textBox15.Size = new Size(65, 27);
            textBox15.TabIndex = 8;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(0, 182);
            label27.Name = "label27";
            label27.Size = new Size(161, 20);
            label27.TabIndex = 7;
            label27.Text = "Miasto / Kod Pocztowy";
            // 
            // textBox17
            // 
            textBox17.Location = new Point(0, 205);
            textBox17.Name = "textBox17";
            textBox17.Size = new Size(161, 27);
            textBox17.TabIndex = 6;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(0, 126);
            label28.Name = "label28";
            label28.Size = new Size(47, 20);
            label28.TabIndex = 5;
            label28.Text = "Adres";
            // 
            // textBox18
            // 
            textBox18.Location = new Point(0, 149);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(218, 27);
            textBox18.TabIndex = 4;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(0, 70);
            label29.Name = "label29";
            label29.Size = new Size(42, 20);
            label29.TabIndex = 3;
            label29.Text = "Pesel";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(0, 93);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(218, 27);
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
            textBox20.Size = new Size(106, 27);
            textBox20.TabIndex = 0;
            // 
            // textBox21
            // 
            textBox21.Location = new Point(124, 40);
            textBox21.Name = "textBox21";
            textBox21.Size = new Size(120, 27);
            textBox21.TabIndex = 9;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(124, 23);
            label31.Name = "label31";
            label31.Size = new Size(72, 20);
            label31.TabIndex = 10;
            label31.Text = "Nazwisko";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label32);
            groupBox4.Controls.Add(textBox22);
            groupBox4.Controls.Add(textBox23);
            groupBox4.Controls.Add(label33);
            groupBox4.Controls.Add(textBox24);
            groupBox4.Controls.Add(label34);
            groupBox4.Controls.Add(textBox25);
            groupBox4.Controls.Add(label35);
            groupBox4.Controls.Add(textBox26);
            groupBox4.Controls.Add(label36);
            groupBox4.Controls.Add(textBox27);
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(250, 247);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(124, 23);
            label32.Name = "label32";
            label32.Size = new Size(72, 20);
            label32.TabIndex = 10;
            label32.Text = "Nazwisko";
            // 
            // textBox22
            // 
            textBox22.Location = new Point(124, 40);
            textBox22.Name = "textBox22";
            textBox22.Size = new Size(120, 27);
            textBox22.TabIndex = 9;
            // 
            // textBox23
            // 
            textBox23.Location = new Point(167, 205);
            textBox23.Name = "textBox23";
            textBox23.Size = new Size(65, 27);
            textBox23.TabIndex = 8;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(0, 182);
            label33.Name = "label33";
            label33.Size = new Size(161, 20);
            label33.TabIndex = 7;
            label33.Text = "Miasto / Kod Pocztowy";
            // 
            // textBox24
            // 
            textBox24.Location = new Point(0, 205);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(161, 27);
            textBox24.TabIndex = 6;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(0, 126);
            label34.Name = "label34";
            label34.Size = new Size(47, 20);
            label34.TabIndex = 5;
            label34.Text = "Adres";
            // 
            // textBox25
            // 
            textBox25.Location = new Point(0, 149);
            textBox25.Name = "textBox25";
            textBox25.Size = new Size(218, 27);
            textBox25.TabIndex = 4;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(0, 70);
            label35.Name = "label35";
            label35.Size = new Size(42, 20);
            label35.TabIndex = 3;
            label35.Text = "Pesel";
            // 
            // textBox26
            // 
            textBox26.Location = new Point(0, 93);
            textBox26.Name = "textBox26";
            textBox26.Size = new Size(218, 27);
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
            textBox27.Size = new Size(106, 27);
            textBox27.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 919);
            Controls.Add(groupBox3);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(textBox16);
            Controls.Add(textBox14);
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
            Controls.Add(dataGridView1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox11);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(personal_Select);
            Controls.Add(company_Select);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox company_Select;
        private CheckBox personal_Select;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox5;
        private GroupBox groupBox2;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox7;
        private Label label6;
        private TextBox textBox8;
        private Label label7;
        private TextBox textBox9;
        private Label label8;
        private TextBox textBox10;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox11;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label12;
        private Label label13;
        private DataGridView dataGridView1;
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
        private TextBox textBox14;
        private TextBox textBox16;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private GroupBox groupBox4;
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
        private ComboBox comboBox3;
        private GroupBox groupBox3;
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
    }
}