namespace WinFormsApp1
{
    partial class FormStarSystems
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
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            listBox5 = new ListBox();
            listBox6 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            labelObjectType = new Label();
            label8 = new Label();
            label9 = new Label();
            labelDateOfDiscovery = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1367, 150);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(243, 37);
            label1.Name = "label1";
            label1.Size = new Size(840, 70);
            label1.TabIndex = 0;
            label1.Text = "Привязка звездных объектов";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(61, 390);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 144);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 28;
            listBox2.Location = new Point(305, 390);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(180, 144);
            listBox2.TabIndex = 5;
            // 
            // listBox3
            // 
            listBox3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 28;
            listBox3.Location = new Point(305, 578);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(180, 144);
            listBox3.TabIndex = 7;
            // 
            // listBox4
            // 
            listBox4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 28;
            listBox4.Location = new Point(61, 578);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(180, 144);
            listBox4.TabIndex = 6;
            // 
            // listBox5
            // 
            listBox5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 28;
            listBox5.Location = new Point(305, 756);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(180, 144);
            listBox5.TabIndex = 9;
            // 
            // listBox6
            // 
            listBox6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 28;
            listBox6.Location = new Point(61, 756);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(180, 144);
            listBox6.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(243, 352);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 10;
            label2.Text = "Звезды";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.PeachPuff;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(229, 547);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 11;
            label3.Text = "Планеты";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(243, 725);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 12;
            label4.Text = "Луны";
            // 
            // button1
            // 
            button1.BackColor = Color.LightCyan;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(491, 807);
            button1.Name = "button1";
            button1.Size = new Size(130, 93);
            button1.TabIndex = 13;
            button1.Text = "Создать звездную систему";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Звездная система", "Звезда", "Планета", "Луна" });
            comboBox1.Location = new Point(361, 264);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(286, 36);
            comboBox1.TabIndex = 51;
            // 
            // labelObjectType
            // 
            labelObjectType.AutoSize = true;
            labelObjectType.BackColor = Color.Transparent;
            labelObjectType.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelObjectType.Location = new Point(13, 264);
            labelObjectType.Margin = new Padding(4, 0, 4, 0);
            labelObjectType.Name = "labelObjectType";
            labelObjectType.Size = new Size(133, 28);
            labelObjectType.TabIndex = 50;
            labelObjectType.Text = "Тип объекта";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(13, 162);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(284, 28);
            label8.TabIndex = 47;
            label8.Text = "Имя космического объекта";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(13, 214);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(174, 28);
            label9.TabIndex = 48;
            label9.Text = "Возраст объекта";
            // 
            // labelDateOfDiscovery
            // 
            labelDateOfDiscovery.AutoSize = true;
            labelDateOfDiscovery.BackColor = Color.Transparent;
            labelDateOfDiscovery.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelDateOfDiscovery.Location = new Point(12, 309);
            labelDateOfDiscovery.Margin = new Padding(4, 0, 4, 0);
            labelDateOfDiscovery.Name = "labelDateOfDiscovery";
            labelDateOfDiscovery.Size = new Size(243, 28);
            labelDateOfDiscovery.TabIndex = 49;
            labelDateOfDiscovery.Text = "Дата открытия объекта";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(363, 162);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 34);
            textBox1.TabIndex = 44;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Cursor = Cursors.Hand;
            numericUpDown1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(363, 214);
            numericUpDown1.Margin = new Padding(4);
            numericUpDown1.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(288, 34);
            numericUpDown1.TabIndex = 45;
            numericUpDown1.ThousandsSeparator = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(363, 309);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 34);
            dateTimePicker1.TabIndex = 46;
            dateTimePicker1.Value = new DateTime(2023, 9, 20, 14, 0, 28, 0);
            // 
            // FormStarSystems
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1367, 924);
            Controls.Add(comboBox1);
            Controls.Add(labelObjectType);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(labelDateOfDiscovery);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox5);
            Controls.Add(listBox6);
            Controls.Add(listBox3);
            Controls.Add(listBox4);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "FormStarSystems";
            Text = "FormStarSystems";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private ListBox listBox5;
        private ListBox listBox6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private ComboBox comboBox1;
        private Label labelObjectType;
        private Label label8;
        private Label label9;
        private Label labelDateOfDiscovery;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
    }
}