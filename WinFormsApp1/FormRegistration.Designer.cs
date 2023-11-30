namespace WinFormsApp1
{
    partial class FormRegistration
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
            panel1 = new Panel();
            buttonLinkObjects = new Button();
            button3 = new Button();
            buttonChangeTheme = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            ButtonChooseObjectColor = new Button();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            buttonCreateStarSystem = new Button();
            label7 = new Label();
            richTextBox1 = new RichTextBox();
            ButtonClear = new Button();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            labelAccelerationOfFreeFall = new Label();
            numericUpDownAccelerationOfFreeFall = new NumericUpDown();
            labelWeight = new Label();
            numericUpDownWeight = new NumericUpDown();
            labelObjectType = new Label();
            label8 = new Label();
            label9 = new Label();
            addPhoto = new Button();
            labelColor = new Label();
            pictureBox2 = new PictureBox();
            labelDateOfDiscovery = new Label();
            numericUpDownAge = new NumericUpDown();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox3 = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            label2 = new Label();
            textBox3 = new TextBox();
            buttonMoreInfo = new Button();
            fontDialog1 = new FontDialog();
            button2 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAccelerationOfFreeFall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(buttonLinkObjects);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(buttonChangeTheme);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1527, 129);
            panel1.TabIndex = 0;
            // 
            // buttonLinkObjects
            // 
            buttonLinkObjects.BackColor = Color.Tomato;
            buttonLinkObjects.Location = new Point(15, 58);
            buttonLinkObjects.Name = "buttonLinkObjects";
            buttonLinkObjects.Size = new Size(255, 63);
            buttonLinkObjects.TabIndex = 44;
            buttonLinkObjects.Text = "перейти к связыванию объектов";
            buttonLinkObjects.UseVisualStyleBackColor = false;
            buttonLinkObjects.Click += buttonLinkObjects_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1320, 28);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(169, 36);
            button3.TabIndex = 34;
            button3.Text = "выбрать шрифт";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // buttonChangeTheme
            // 
            buttonChangeTheme.Location = new Point(15, 15);
            buttonChangeTheme.Margin = new Padding(4);
            buttonChangeTheme.Name = "buttonChangeTheme";
            buttonChangeTheme.Size = new Size(144, 36);
            buttonChangeTheme.TabIndex = 32;
            buttonChangeTheme.Text = "сменить фон";
            buttonChangeTheme.UseVisualStyleBackColor = true;
            buttonChangeTheme.Click += buttonChangeTheme_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1527, 129);
            label1.TabIndex = 0;
            label1.Text = "Регистрация космических тел";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.guap;
            pictureBox1.Location = new Point(3, 911);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(360, 32);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 39);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Cursor = Cursors.Hand;
            numericUpDown1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(360, 84);
            numericUpDown1.Margin = new Padding(4);
            numericUpDown1.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(288, 39);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ThousandsSeparator = true;
            // 
            // ButtonChooseObjectColor
            // 
            ButtonChooseObjectColor.Cursor = Cursors.Hand;
            ButtonChooseObjectColor.ForeColor = SystemColors.ControlText;
            ButtonChooseObjectColor.Location = new Point(360, 231);
            ButtonChooseObjectColor.Margin = new Padding(0);
            ButtonChooseObjectColor.Name = "ButtonChooseObjectColor";
            ButtonChooseObjectColor.Size = new Size(118, 40);
            ButtonChooseObjectColor.TabIndex = 6;
            ButtonChooseObjectColor.UseVisualStyleBackColor = true;
            ButtonChooseObjectColor.Click += ButtonChooseObjectColor_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 588);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(333, 33);
            label3.TabIndex = 8;
            label3.Text = "Имя космического объекта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(25, 639);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(207, 33);
            label4.TabIndex = 9;
            label4.Text = "Возраст объекта";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(28, 809);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(175, 33);
            label6.TabIndex = 11;
            label6.Text = "Цвет Объекта";
            // 
            // buttonCreateStarSystem
            // 
            buttonCreateStarSystem.Cursor = Cursors.Hand;
            buttonCreateStarSystem.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateStarSystem.Location = new Point(681, 310);
            buttonCreateStarSystem.Margin = new Padding(4);
            buttonCreateStarSystem.Name = "buttonCreateStarSystem";
            buttonCreateStarSystem.Size = new Size(135, 49);
            buttonCreateStarSystem.TabIndex = 12;
            buttonCreateStarSystem.Text = "Создать";
            buttonCreateStarSystem.UseVisualStyleBackColor = true;
            buttonCreateStarSystem.Click += buttonCreateStarSystem_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.PeachPuff;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(706, 32);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(396, 33);
            label7.TabIndex = 14;
            label7.Text = "логи создания космических тел:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(681, 69);
            richTextBox1.Margin = new Padding(4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(464, 226);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // ButtonClear
            // 
            ButtonClear.Anchor = AnchorStyles.None;
            ButtonClear.Cursor = Cursors.Hand;
            ButtonClear.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonClear.Location = new Point(996, 310);
            ButtonClear.Margin = new Padding(4);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(149, 49);
            ButtonClear.TabIndex = 16;
            ButtonClear.Text = "Очистить";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(360, 179);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 39);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.Value = new DateTime(2023, 9, 20, 14, 0, 28, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(26, 741);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(296, 33);
            label5.TabIndex = 21;
            label5.Text = "Дата открытия системы";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(696, 591);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(464, 279);
            listBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(375, 589);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 39);
            textBox2.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(labelAccelerationOfFreeFall);
            groupBox1.Controls.Add(numericUpDownAccelerationOfFreeFall);
            groupBox1.Controls.Add(labelWeight);
            groupBox1.Controls.Add(numericUpDownWeight);
            groupBox1.Controls.Add(labelObjectType);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(addPhoto);
            groupBox1.Controls.Add(labelColor);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(labelDateOfDiscovery);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(ButtonChooseObjectColor);
            groupBox1.Controls.Add(buttonCreateStarSystem);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(ButtonClear);
            groupBox1.Location = new Point(15, 136);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(1500, 405);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Создание объектов";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Звездная система", "Звезда", "Планета", "Луна" });
            comboBox1.Location = new Point(358, 134);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 41);
            comboBox1.TabIndex = 43;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // labelAccelerationOfFreeFall
            // 
            labelAccelerationOfFreeFall.AutoSize = true;
            labelAccelerationOfFreeFall.BackColor = Color.Transparent;
            labelAccelerationOfFreeFall.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelAccelerationOfFreeFall.Location = new Point(10, 339);
            labelAccelerationOfFreeFall.Margin = new Padding(4, 0, 4, 0);
            labelAccelerationOfFreeFall.Name = "labelAccelerationOfFreeFall";
            labelAccelerationOfFreeFall.Size = new Size(309, 66);
            labelAccelerationOfFreeFall.TabIndex = 42;
            labelAccelerationOfFreeFall.Text = "Ускорение силы тяжести\r\n в м/с^2";
            labelAccelerationOfFreeFall.Visible = false;
            // 
            // numericUpDownAccelerationOfFreeFall
            // 
            numericUpDownAccelerationOfFreeFall.Cursor = Cursors.Hand;
            numericUpDownAccelerationOfFreeFall.DecimalPlaces = 2;
            numericUpDownAccelerationOfFreeFall.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAccelerationOfFreeFall.Location = new Point(360, 339);
            numericUpDownAccelerationOfFreeFall.Margin = new Padding(4);
            numericUpDownAccelerationOfFreeFall.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDownAccelerationOfFreeFall.Name = "numericUpDownAccelerationOfFreeFall";
            numericUpDownAccelerationOfFreeFall.Size = new Size(288, 39);
            numericUpDownAccelerationOfFreeFall.TabIndex = 41;
            numericUpDownAccelerationOfFreeFall.ThousandsSeparator = true;
            numericUpDownAccelerationOfFreeFall.Visible = false;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.BackColor = Color.Transparent;
            labelWeight.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelWeight.Location = new Point(10, 280);
            labelWeight.Margin = new Padding(4, 0, 4, 0);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(314, 33);
            labelWeight.TabIndex = 40;
            labelWeight.Text = "Масса объекта в 10^24 кг";
            labelWeight.Visible = false;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Cursor = Cursors.Hand;
            numericUpDownWeight.DecimalPlaces = 15;
            numericUpDownWeight.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownWeight.Location = new Point(358, 280);
            numericUpDownWeight.Margin = new Padding(4);
            numericUpDownWeight.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(288, 39);
            numericUpDownWeight.TabIndex = 39;
            numericUpDownWeight.ThousandsSeparator = true;
            numericUpDownWeight.Visible = false;
            numericUpDownWeight.ValueChanged += numericUpDownWeight_ValueChanged;
            // 
            // labelObjectType
            // 
            labelObjectType.AutoSize = true;
            labelObjectType.BackColor = Color.Transparent;
            labelObjectType.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelObjectType.Location = new Point(10, 134);
            labelObjectType.Margin = new Padding(4, 0, 4, 0);
            labelObjectType.Name = "labelObjectType";
            labelObjectType.Size = new Size(158, 33);
            labelObjectType.TabIndex = 38;
            labelObjectType.Text = "Тип объекта";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(10, 32);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(333, 33);
            label8.TabIndex = 32;
            label8.Text = "Имя космического объекта";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(10, 84);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(207, 33);
            label9.TabIndex = 33;
            label9.Text = "Возраст объекта";
            // 
            // addPhoto
            // 
            addPhoto.Location = new Point(1241, 320);
            addPhoto.Margin = new Padding(4);
            addPhoto.Name = "addPhoto";
            addPhoto.Size = new Size(174, 36);
            addPhoto.TabIndex = 23;
            addPhoto.Text = "добавить фото";
            addPhoto.UseVisualStyleBackColor = true;
            addPhoto.Click += addPhoto_Click;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.BackColor = Color.Transparent;
            labelColor.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelColor.Location = new Point(10, 234);
            labelColor.Margin = new Padding(4, 0, 4, 0);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(169, 33);
            labelColor.TabIndex = 34;
            labelColor.Text = "Цвет объекта";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(1174, 32);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 279);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "C:\\\\Users\\\\Daniil\\\\source\\\\repos\\\\WinFormsApp1\\\\WinFormsApp1\\\\media\\\\default-star-system.jpg";
            // 
            // labelDateOfDiscovery
            // 
            labelDateOfDiscovery.AutoSize = true;
            labelDateOfDiscovery.BackColor = Color.Transparent;
            labelDateOfDiscovery.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateOfDiscovery.Location = new Point(9, 179);
            labelDateOfDiscovery.Margin = new Padding(4, 0, 4, 0);
            labelDateOfDiscovery.Name = "labelDateOfDiscovery";
            labelDateOfDiscovery.Size = new Size(287, 33);
            labelDateOfDiscovery.TabIndex = 36;
            labelDateOfDiscovery.Text = "Дата открытия объекта";
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAge.Location = new Point(375, 639);
            numericUpDownAge.Margin = new Padding(4);
            numericUpDownAge.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(288, 39);
            numericUpDownAge.TabIndex = 29;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(375, 741);
            dateTimePicker2.Margin = new Padding(4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(284, 39);
            dateTimePicker2.TabIndex = 31;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(379, 809);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(118, 40);
            button1.TabIndex = 22;
            button1.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Location = new Point(1189, 591);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(300, 279);
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 689);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(158, 33);
            label2.TabIndex = 40;
            label2.Text = "Тип объекта";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(372, 689);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(286, 39);
            textBox3.TabIndex = 47;
            // 
            // buttonMoreInfo
            // 
            buttonMoreInfo.Location = new Point(696, 879);
            buttonMoreInfo.Margin = new Padding(4);
            buttonMoreInfo.Name = "buttonMoreInfo";
            buttonMoreInfo.Size = new Size(179, 58);
            buttonMoreInfo.TabIndex = 48;
            buttonMoreInfo.Text = "Доп. информация";
            buttonMoreInfo.UseVisualStyleBackColor = true;
            buttonMoreInfo.Click += buttonMoreInfo_Click;
            // 
            // button2
            // 
            button2.Location = new Point(895, 879);
            button2.Name = "button2";
            button2.Size = new Size(112, 58);
            button2.TabIndex = 49;
            button2.Text = "изменить\r\nданные\r\n";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(1028, 879);
            button4.Name = "button4";
            button4.Size = new Size(112, 58);
            button4.TabIndex = 50;
            button4.Text = "Удалить объект";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1527, 1010);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(buttonMoreInfo);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(numericUpDownAge);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Margin = new Padding(4);
            MaximumSize = new Size(2394, 1336);
            MinimumSize = new Size(1217, 630);
            Name = "FormRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistration";
            Activated += FormRegistration_Activated;
            FormClosed += FormRegistration_FormClosed;
            Load += FormRegistration_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAccelerationOfFreeFall).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Button ButtonChooseObjectColor;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button buttonCreateStarSystem;
        private Label label7;
        private RichTextBox richTextBox1;
        private Button ButtonClear;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ListBox listBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDownAge;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private PictureBox pictureBox2;
        private Button addPhoto;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox3;
        private Button buttonChangeTheme;
        private SaveFileDialog saveFileDialog1;
        private Label label8;
        private Label label9;
        private Label labelColor;
        private Label labelDateOfDiscovery;
        private Label labelObjectType;
        private Label label2;
        private Label labelAccelerationOfFreeFall;
        private NumericUpDown numericUpDownAccelerationOfFreeFall;
        private Label labelWeight;
        private NumericUpDown numericUpDownWeight;
        private TextBox textBox3;
        private Button buttonMoreInfo;
        private ComboBox comboBox1;
        private Button button3;
        private FontDialog fontDialog1;
        private Button buttonLinkObjects;
        private Button button2;
        private Button button4;
    }
}