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
            button3 = new Button();
            button2 = new Button();
            buttonChangeTheme = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            ButtonChooseEyeColor = new Button();
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
            label12 = new Label();
            label8 = new Label();
            label9 = new Label();
            addPhoto = new Button();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            label11 = new Label();
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
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonChangeTheme);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1241, 103);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(1056, 22);
            button3.Name = "button3";
            button3.Size = new Size(135, 29);
            button3.TabIndex = 34;
            button3.Text = "выбрать шрифт";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 49);
            button2.Name = "button2";
            button2.Size = new Size(245, 29);
            button2.TabIndex = 33;
            button2.Text = "проверить абстрактные методы";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonChangeTheme
            // 
            buttonChangeTheme.Location = new Point(12, 12);
            buttonChangeTheme.Name = "buttonChangeTheme";
            buttonChangeTheme.Size = new Size(115, 29);
            buttonChangeTheme.TabIndex = 32;
            buttonChangeTheme.Text = "сменить фон";
            buttonChangeTheme.UseVisualStyleBackColor = true;
            buttonChangeTheme.Click += buttonChangeTheme_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1241, 103);
            label1.TabIndex = 0;
            label1.Text = "Регистрация космических тел";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.guap;
            pictureBox1.Location = new Point(12, 729);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 55);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(288, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 34);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Cursor = Cursors.Hand;
            numericUpDown1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(288, 67);
            numericUpDown1.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(230, 34);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ThousandsSeparator = true;
            // 
            // ButtonChooseEyeColor
            // 
            ButtonChooseEyeColor.Cursor = Cursors.Hand;
            ButtonChooseEyeColor.ForeColor = SystemColors.ControlText;
            ButtonChooseEyeColor.Location = new Point(288, 185);
            ButtonChooseEyeColor.Margin = new Padding(0);
            ButtonChooseEyeColor.Name = "ButtonChooseEyeColor";
            ButtonChooseEyeColor.Size = new Size(94, 32);
            ButtonChooseEyeColor.TabIndex = 6;
            ButtonChooseEyeColor.UseVisualStyleBackColor = true;
            ButtonChooseEyeColor.Click += ButtonChooseEyeColor_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 470);
            label3.Name = "label3";
            label3.Size = new Size(276, 26);
            label3.TabIndex = 8;
            label3.Text = "Имя космического объекта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 511);
            label4.Name = "label4";
            label4.Size = new Size(171, 26);
            label4.TabIndex = 9;
            label4.Text = "Возраст объекта";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 647);
            label6.Name = "label6";
            label6.Size = new Size(145, 26);
            label6.TabIndex = 11;
            label6.Text = "Цвет Объекта";
            // 
            // buttonCreateStarSystem
            // 
            buttonCreateStarSystem.Cursor = Cursors.Hand;
            buttonCreateStarSystem.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateStarSystem.Location = new Point(545, 248);
            buttonCreateStarSystem.Name = "buttonCreateStarSystem";
            buttonCreateStarSystem.Size = new Size(133, 39);
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
            label7.Location = new Point(565, 26);
            label7.Name = "label7";
            label7.Size = new Size(326, 26);
            label7.TabIndex = 14;
            label7.Text = "логи создания космических тел:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(545, 53);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(372, 182);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // ButtonClear
            // 
            ButtonClear.Anchor = AnchorStyles.None;
            ButtonClear.Cursor = Cursors.Hand;
            ButtonClear.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonClear.Location = new Point(784, 248);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(133, 39);
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
            dateTimePicker1.Location = new Point(288, 143);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 34);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.Value = new DateTime(2023, 9, 20, 14, 0, 28, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(21, 593);
            label5.Name = "label5";
            label5.Size = new Size(244, 26);
            label5.TabIndex = 21;
            label5.Text = "Дата открытия системы";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(557, 473);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(372, 224);
            listBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(300, 471);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(230, 34);
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
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(addPhoto);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(ButtonChooseEyeColor);
            groupBox1.Controls.Add(buttonCreateStarSystem);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(ButtonClear);
            groupBox1.Location = new Point(12, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1200, 324);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Создание объектов";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Звезда", "Планета", "Луна" });
            comboBox1.Location = new Point(286, 107);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 34);
            comboBox1.TabIndex = 43;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // labelAccelerationOfFreeFall
            // 
            labelAccelerationOfFreeFall.AutoSize = true;
            labelAccelerationOfFreeFall.BackColor = Color.Transparent;
            labelAccelerationOfFreeFall.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelAccelerationOfFreeFall.Location = new Point(8, 271);
            labelAccelerationOfFreeFall.Name = "labelAccelerationOfFreeFall";
            labelAccelerationOfFreeFall.Size = new Size(253, 52);
            labelAccelerationOfFreeFall.TabIndex = 42;
            labelAccelerationOfFreeFall.Text = "Ускорение силы тяжести\r\n в м/с^2";
            labelAccelerationOfFreeFall.Visible = false;
            // 
            // numericUpDownAccelerationOfFreeFall
            // 
            numericUpDownAccelerationOfFreeFall.Cursor = Cursors.Hand;
            numericUpDownAccelerationOfFreeFall.DecimalPlaces = 2;
            numericUpDownAccelerationOfFreeFall.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAccelerationOfFreeFall.Location = new Point(288, 271);
            numericUpDownAccelerationOfFreeFall.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDownAccelerationOfFreeFall.Name = "numericUpDownAccelerationOfFreeFall";
            numericUpDownAccelerationOfFreeFall.Size = new Size(230, 34);
            numericUpDownAccelerationOfFreeFall.TabIndex = 41;
            numericUpDownAccelerationOfFreeFall.ThousandsSeparator = true;
            numericUpDownAccelerationOfFreeFall.Visible = false;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.BackColor = Color.Transparent;
            labelWeight.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelWeight.Location = new Point(8, 224);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(256, 26);
            labelWeight.TabIndex = 40;
            labelWeight.Text = "Масса объекта в 10^24 кг";
            labelWeight.Visible = false;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Cursor = Cursors.Hand;
            numericUpDownWeight.DecimalPlaces = 15;
            numericUpDownWeight.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownWeight.Location = new Point(286, 224);
            numericUpDownWeight.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(230, 34);
            numericUpDownWeight.TabIndex = 39;
            numericUpDownWeight.ThousandsSeparator = true;
            numericUpDownWeight.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(8, 107);
            label12.Name = "label12";
            label12.Size = new Size(131, 26);
            label12.TabIndex = 38;
            label12.Text = "Тип объекта";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(8, 26);
            label8.Name = "label8";
            label8.Size = new Size(276, 26);
            label8.TabIndex = 32;
            label8.Text = "Имя космического объекта";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(8, 67);
            label9.Name = "label9";
            label9.Size = new Size(171, 26);
            label9.TabIndex = 33;
            label9.Text = "Возраст объекта";
            // 
            // addPhoto
            // 
            addPhoto.Location = new Point(993, 256);
            addPhoto.Name = "addPhoto";
            addPhoto.Size = new Size(139, 29);
            addPhoto.TabIndex = 23;
            addPhoto.Text = "добавить фото";
            addPhoto.UseVisualStyleBackColor = true;
            addPhoto.Click += addPhoto_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(8, 187);
            label10.Name = "label10";
            label10.Size = new Size(140, 26);
            label10.TabIndex = 34;
            label10.Text = "Цвет объекта";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(939, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(241, 224);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "C:\\\\Users\\\\Daniil\\\\source\\\\repos\\\\WinFormsApp1\\\\WinFormsApp1\\\\media\\\\default-star-system.jpg";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(7, 143);
            label11.Name = "label11";
            label11.Size = new Size(238, 26);
            label11.TabIndex = 36;
            label11.Text = "Дата открытия объекта";
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAge.Location = new Point(300, 511);
            numericUpDownAge.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.ReadOnly = true;
            numericUpDownAge.Size = new Size(230, 34);
            numericUpDownAge.TabIndex = 29;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(300, 593);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(228, 34);
            dateTimePicker2.TabIndex = 31;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(303, 647);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(94, 32);
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
            pictureBox3.Location = new Point(951, 473);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(241, 224);
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 551);
            label2.Name = "label2";
            label2.Size = new Size(131, 26);
            label2.TabIndex = 40;
            label2.Text = "Тип объекта";
            label2.Click += label2_Click;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(298, 551);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(230, 34);
            textBox3.TabIndex = 47;
            // 
            // buttonMoreInfo
            // 
            buttonMoreInfo.Location = new Point(557, 703);
            buttonMoreInfo.Name = "buttonMoreInfo";
            buttonMoreInfo.Size = new Size(143, 29);
            buttonMoreInfo.TabIndex = 48;
            buttonMoreInfo.Text = "Доп. информация";
            buttonMoreInfo.UseVisualStyleBackColor = true;
            buttonMoreInfo.Click += buttonMoreInfo_Click;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1241, 808);
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
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(978, 515);
            Name = "FormRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistration";
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
        private Button ButtonChooseEyeColor;
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
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label2;
        private Label labelAccelerationOfFreeFall;
        private NumericUpDown numericUpDownAccelerationOfFreeFall;
        private Label labelWeight;
        private NumericUpDown numericUpDownWeight;
        private TextBox textBox3;
        private Button buttonMoreInfo;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private FontDialog fontDialog1;
    }
}