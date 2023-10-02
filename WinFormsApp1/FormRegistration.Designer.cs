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
            ButtonMakePlanet = new Button();
            label2 = new Label();
            numericUpDown2 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1241, 103);
            panel1.TabIndex = 0;
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
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.guap;
            pictureBox1.Location = new Point(18, 593);
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
            textBox1.Location = new Point(272, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 34);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Cursor = Cursors.Hand;
            numericUpDown1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(272, 67);
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
            ButtonChooseEyeColor.Location = new Point(272, 205);
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
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 34);
            label3.Name = "label3";
            label3.Size = new Size(234, 26);
            label3.TabIndex = 8;
            label3.Text = "Имя звездной системы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 75);
            label4.Name = "label4";
            label4.Size = new Size(243, 26);
            label4.TabIndex = 9;
            label4.Text = "Возраст главной звезды";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 211);
            label6.Name = "label6";
            label6.Size = new Size(130, 26);
            label6.TabIndex = 11;
            label6.Text = "Цвет звезды";
            // 
            // buttonCreateStarSystem
            // 
            buttonCreateStarSystem.Cursor = Cursors.Hand;
            buttonCreateStarSystem.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateStarSystem.Location = new Point(272, 244);
            buttonCreateStarSystem.Name = "buttonCreateStarSystem";
            buttonCreateStarSystem.Size = new Size(134, 42);
            buttonCreateStarSystem.TabIndex = 12;
            buttonCreateStarSystem.Text = "Создать";
            buttonCreateStarSystem.UseVisualStyleBackColor = true;
            buttonCreateStarSystem.Click += buttonCreateStarSystem_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(545, 23);
            label7.Name = "label7";
            label7.Size = new Size(370, 33);
            label7.TabIndex = 14;
            label7.Text = "Созданные космические тела:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(545, 59);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(372, 182);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // ButtonClear
            // 
            ButtonClear.Anchor = AnchorStyles.None;
            ButtonClear.Cursor = Cursors.Hand;
            ButtonClear.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonClear.Location = new Point(543, 244);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(164, 39);
            ButtonClear.TabIndex = 16;
            ButtonClear.Text = "Очистить";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // ButtonMakePlanet
            // 
            ButtonMakePlanet.Anchor = AnchorStyles.None;
            ButtonMakePlanet.Cursor = Cursors.Hand;
            ButtonMakePlanet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMakePlanet.Location = new Point(722, 245);
            ButtonMakePlanet.Name = "ButtonMakePlanet";
            ButtonMakePlanet.Size = new Size(195, 38);
            ButtonMakePlanet.TabIndex = 17;
            ButtonMakePlanet.Text = "Добавить планету";
            ButtonMakePlanet.UseVisualStyleBackColor = true;
            ButtonMakePlanet.Click += ButtonMakePlanet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 119);
            label2.Name = "label2";
            label2.Size = new Size(184, 26);
            label2.TabIndex = 18;
            label2.Text = "Количество звезд";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Location = new Point(272, 111);
            numericUpDown2.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(230, 34);
            numericUpDown2.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd.MM.yyyy hh:mm";
            dateTimePicker1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(272, 158);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 34);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.Value = new DateTime(2023, 9, 20, 14, 0, 28, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 166);
            label5.Name = "label5";
            label5.Size = new Size(244, 26);
            label5.TabIndex = 21;
            label5.Text = "Дата открытия системы";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(555, 411);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(372, 224);
            listBox1.TabIndex = 22;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(284, 411);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 34);
            textBox2.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(ButtonChooseEyeColor);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(buttonCreateStarSystem);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(ButtonClear);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ButtonMakePlanet);
            groupBox1.Location = new Point(12, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1200, 296);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Создание объектов";
            // 
            // button2
            // 
            button2.Location = new Point(993, 256);
            button2.Name = "button2";
            button2.Size = new Size(139, 29);
            button2.TabIndex = 23;
            button2.Text = "добавить фото";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(939, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(241, 224);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown3.Location = new Point(284, 451);
            numericUpDown3.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(230, 34);
            numericUpDown3.TabIndex = 29;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown4.Location = new Point(284, 491);
            numericUpDown4.Maximum = new decimal(new int[] { 1569325055, 23283064, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(230, 34);
            numericUpDown4.TabIndex = 30;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd.MM.yyyy hh:mm";
            dateTimePicker2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(283, 531);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(231, 34);
            dateTimePicker2.TabIndex = 31;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(283, 576);
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
            pictureBox3.Location = new Point(951, 411);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(241, 224);
            pictureBox3.TabIndex = 24;
            pictureBox3.TabStop = false;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1241, 660);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(978, 515);
            Name = "FormRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistration";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
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
        private Button ButtonMakePlanet;
        private Label label2;
        private NumericUpDown numericUpDown2;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private ListBox listBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox3;
    }
}