namespace WinFormsApp1
{
    partial class FormListOfObjects
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
            textBox3 = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            numericUpDownAge = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            label5 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            buttonCreateSpaceObject = new Button();
            label7 = new Label();
            label8 = new Label();
            buttonCreateStarSystem = new Button();
            button4 = new Button();
            buttonDelete = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(905, 247);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(286, 39);
            textBox3.TabIndex = 63;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(460, 249);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 38);
            label2.TabIndex = 62;
            label2.Text = "Тип объекта";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(1199, 194);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 257);
            pictureBox1.TabIndex = 59;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(905, 406);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(118, 40);
            button1.TabIndex = 56;
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(905, 346);
            dateTimePicker2.Margin = new Padding(4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(284, 39);
            dateTimePicker2.TabIndex = 61;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAge.Location = new Point(905, 299);
            numericUpDownAge.Margin = new Padding(4);
            numericUpDownAge.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(288, 39);
            numericUpDownAge.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(459, 192);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(438, 38);
            label3.TabIndex = 52;
            label3.Text = "Название космического объекта";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(460, 298);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(226, 38);
            label4.TabIndex = 53;
            label4.Text = "Возраст объекта";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(460, 404);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(195, 38);
            label6.TabIndex = 54;
            label6.Text = "Цвет Объекта";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(905, 194);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 39);
            textBox2.TabIndex = 58;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(13, 197);
            listBox1.Margin = new Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(439, 254);
            listBox1.TabIndex = 57;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(460, 345);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(312, 38);
            label5.TabIndex = 55;
            label5.Text = "Дата открытия объекта";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1513, 150);
            label1.TabIndex = 67;
            label1.Text = "Список космических объектов";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1513, 150);
            panel1.TabIndex = 68;
            // 
            // buttonCreateSpaceObject
            // 
            buttonCreateSpaceObject.BackColor = Color.PaleGreen;
            buttonCreateSpaceObject.Location = new Point(13, 458);
            buttonCreateSpaceObject.Name = "buttonCreateSpaceObject";
            buttonCreateSpaceObject.Size = new Size(240, 65);
            buttonCreateSpaceObject.TabIndex = 70;
            buttonCreateSpaceObject.Text = "Создать космический объект";
            buttonCreateSpaceObject.UseVisualStyleBackColor = false;
            buttonCreateSpaceObject.Click += buttonCreateSpaceObject_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Ivory;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(453, 525);
            label7.MaximumSize = new Size(840, 0);
            label7.Name = "label7";
            label7.Size = new Size(840, 64);
            label7.TabIndex = 71;
            label7.Text = "Если вы хотите изменить какие-то свойства объекта, то кликните по нему 2 раза в списке объектов.\r\n";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(10, 153);
            label8.Name = "label8";
            label8.Size = new Size(243, 38);
            label8.TabIndex = 72;
            label8.Text = "Список объектов:";
            // 
            // buttonCreateStarSystem
            // 
            buttonCreateStarSystem.BackColor = Color.PaleGreen;
            buttonCreateStarSystem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateStarSystem.Location = new Point(259, 458);
            buttonCreateStarSystem.Name = "buttonCreateStarSystem";
            buttonCreateStarSystem.Size = new Size(193, 65);
            buttonCreateStarSystem.TabIndex = 75;
            buttonCreateStarSystem.Text = "Создать звездную систему\r\n";
            buttonCreateStarSystem.UseVisualStyleBackColor = false;
            buttonCreateStarSystem.Click += buttonCreateStarSystem_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.Location = new Point(13, 527);
            button4.Name = "button4";
            button4.Size = new Size(243, 65);
            button4.TabIndex = 76;
            button4.Text = "Показать дополнительную информацию";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.OrangeRed;
            buttonDelete.Location = new Point(262, 527);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(190, 65);
            buttonDelete.TabIndex = 77;
            buttonDelete.Text = "Удалить объект";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.guap;
            pictureBox2.Location = new Point(1300, 527);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 78;
            pictureBox2.TabStop = false;
            // 
            // FormListOfObjects
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1513, 604);
            Controls.Add(pictureBox2);
            Controls.Add(buttonDelete);
            Controls.Add(button4);
            Controls.Add(buttonCreateStarSystem);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(buttonCreateSpaceObject);
            Controls.Add(panel1);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(numericUpDownAge);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Name = "FormListOfObjects";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += FormListOfObjects_FormClosed;
            Load += FormListOfObjects_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox3;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numericUpDownAge;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private Label label1;
        private Panel panel1;
        private Button buttonCreateSpaceObject;
        private Label label7;
        private Label label8;
        private Button buttonCreateStarSystem;
        private Button button4;
        private Button buttonDelete;
        private PictureBox pictureBox2;
        internal ListBox listBox1;
    }
}