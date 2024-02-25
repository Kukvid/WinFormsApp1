namespace WinFormsApp1
{
    partial class FormCreateSpaceObject
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
            pictureBox1 = new PictureBox();
            labelDateOfDiscovery = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            ButtonChooseObjectColor = new Button();
            buttonCreateSpaceObject = new Button();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAccelerationOfFreeFall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Звезда", "Планета", "Луна" });
            comboBox1.Location = new Point(389, 271);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(289, 46);
            comboBox1.TabIndex = 43;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // labelAccelerationOfFreeFall
            // 
            labelAccelerationOfFreeFall.AutoSize = true;
            labelAccelerationOfFreeFall.BackColor = Color.Transparent;
            labelAccelerationOfFreeFall.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAccelerationOfFreeFall.Location = new Point(13, 462);
            labelAccelerationOfFreeFall.Margin = new Padding(4, 0, 4, 0);
            labelAccelerationOfFreeFall.Name = "labelAccelerationOfFreeFall";
            labelAccelerationOfFreeFall.Size = new Size(335, 76);
            labelAccelerationOfFreeFall.TabIndex = 42;
            labelAccelerationOfFreeFall.Text = "Ускорение силы тяжести\r\n в м/с^2";
            labelAccelerationOfFreeFall.Visible = false;
            // 
            // numericUpDownAccelerationOfFreeFall
            // 
            numericUpDownAccelerationOfFreeFall.Cursor = Cursors.Hand;
            numericUpDownAccelerationOfFreeFall.DecimalPlaces = 2;
            numericUpDownAccelerationOfFreeFall.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAccelerationOfFreeFall.Location = new Point(391, 482);
            numericUpDownAccelerationOfFreeFall.Margin = new Padding(4);
            numericUpDownAccelerationOfFreeFall.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDownAccelerationOfFreeFall.Name = "numericUpDownAccelerationOfFreeFall";
            numericUpDownAccelerationOfFreeFall.Size = new Size(288, 45);
            numericUpDownAccelerationOfFreeFall.TabIndex = 41;
            numericUpDownAccelerationOfFreeFall.ThousandsSeparator = true;
            numericUpDownAccelerationOfFreeFall.Visible = false;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.BackColor = Color.Transparent;
            labelWeight.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelWeight.Location = new Point(10, 424);
            labelWeight.Margin = new Padding(4, 0, 4, 0);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(350, 38);
            labelWeight.TabIndex = 40;
            labelWeight.Text = "Масса объекта в 10^24 кг";
            labelWeight.Visible = false;
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Cursor = Cursors.Hand;
            numericUpDownWeight.DecimalPlaces = 15;
            numericUpDownWeight.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownWeight.Location = new Point(389, 429);
            numericUpDownWeight.Margin = new Padding(4);
            numericUpDownWeight.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(288, 45);
            numericUpDownWeight.TabIndex = 39;
            numericUpDownWeight.ThousandsSeparator = true;
            numericUpDownWeight.Visible = false;
            // 
            // labelObjectType
            // 
            labelObjectType.AutoSize = true;
            labelObjectType.BackColor = Color.Transparent;
            labelObjectType.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelObjectType.Location = new Point(11, 272);
            labelObjectType.Margin = new Padding(4, 0, 4, 0);
            labelObjectType.Name = "labelObjectType";
            labelObjectType.Size = new Size(175, 38);
            labelObjectType.TabIndex = 38;
            labelObjectType.Text = "Тип объекта";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(13, 172);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(371, 38);
            label8.TabIndex = 32;
            label8.Text = "Имя космического объекта";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(13, 221);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(226, 38);
            label9.TabIndex = 33;
            label9.Text = "Возраст объекта";
            // 
            // addPhoto
            // 
            addPhoto.Location = new Point(774, 482);
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
            labelColor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelColor.Location = new Point(13, 368);
            labelColor.Margin = new Padding(4, 0, 4, 0);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(190, 38);
            labelColor.TabIndex = 34;
            labelColor.Text = "Цвет объекта";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(690, 169);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 305);
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "C:\\\\Users\\\\Daniil\\\\source\\\\repos\\\\WinFormsApp1\\\\WinFormsApp1\\\\media\\\\default-star-system.jpg";
            // 
            // labelDateOfDiscovery
            // 
            labelDateOfDiscovery.AutoSize = true;
            labelDateOfDiscovery.BackColor = Color.Transparent;
            labelDateOfDiscovery.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateOfDiscovery.Location = new Point(13, 324);
            labelDateOfDiscovery.Margin = new Padding(4, 0, 4, 0);
            labelDateOfDiscovery.Name = "labelDateOfDiscovery";
            labelDateOfDiscovery.Size = new Size(312, 38);
            labelDateOfDiscovery.TabIndex = 36;
            labelDateOfDiscovery.Text = "Дата открытия объекта";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(389, 169);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(291, 45);
            textBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Cursor = Cursors.Hand;
            numericUpDown1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(389, 221);
            numericUpDown1.Margin = new Padding(4);
            numericUpDown1.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(293, 45);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ThousandsSeparator = true;
            // 
            // ButtonChooseObjectColor
            // 
            ButtonChooseObjectColor.Cursor = Cursors.Hand;
            ButtonChooseObjectColor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonChooseObjectColor.ForeColor = SystemColors.ControlText;
            ButtonChooseObjectColor.Location = new Point(389, 373);
            ButtonChooseObjectColor.Margin = new Padding(0);
            ButtonChooseObjectColor.Name = "ButtonChooseObjectColor";
            ButtonChooseObjectColor.Size = new Size(120, 40);
            ButtonChooseObjectColor.TabIndex = 6;
            ButtonChooseObjectColor.UseVisualStyleBackColor = true;
            ButtonChooseObjectColor.Click += ButtonChooseObjectColor_Click;
            // 
            // buttonCreateSpaceObject
            // 
            buttonCreateSpaceObject.BackColor = Color.LightCyan;
            buttonCreateSpaceObject.Cursor = Cursors.Hand;
            buttonCreateSpaceObject.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateSpaceObject.Location = new Point(13, 562);
            buttonCreateSpaceObject.Margin = new Padding(4);
            buttonCreateSpaceObject.Name = "buttonCreateSpaceObject";
            buttonCreateSpaceObject.Size = new Size(135, 87);
            buttonCreateSpaceObject.TabIndex = 12;
            buttonCreateSpaceObject.Text = "Создать объект";
            buttonCreateSpaceObject.UseVisualStyleBackColor = false;
            buttonCreateSpaceObject.Click += buttonCreateSpaceObject_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(391, 324);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 45);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.Value = new DateTime(2023, 9, 20, 14, 0, 28, 0);
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 150);
            panel1.TabIndex = 30;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1057, 150);
            label1.TabIndex = 68;
            label1.Text = "Создание космического объекта";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.guap;
            pictureBox2.Location = new Point(844, 573);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 61;
            pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormCreateSpaceObject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1057, 655);
            Controls.Add(pictureBox2);
            Controls.Add(comboBox1);
            Controls.Add(labelAccelerationOfFreeFall);
            Controls.Add(panel1);
            Controls.Add(numericUpDownAccelerationOfFreeFall);
            Controls.Add(labelWeight);
            Controls.Add(label8);
            Controls.Add(numericUpDownWeight);
            Controls.Add(dateTimePicker1);
            Controls.Add(labelObjectType);
            Controls.Add(buttonCreateSpaceObject);
            Controls.Add(ButtonChooseObjectColor);
            Controls.Add(label9);
            Controls.Add(numericUpDown1);
            Controls.Add(addPhoto);
            Controls.Add(textBox1);
            Controls.Add(labelColor);
            Controls.Add(labelDateOfDiscovery);
            Controls.Add(pictureBox1);
            Name = "FormCreateSpaceObject";
            Text = "FormCreateSpaceObject";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAccelerationOfFreeFall).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private Label labelAccelerationOfFreeFall;
        private NumericUpDown numericUpDownAccelerationOfFreeFall;
        private Label labelWeight;
        private NumericUpDown numericUpDownWeight;
        private Label labelObjectType;
        private Label label8;
        private Label label9;
        private Button addPhoto;
        private Label labelColor;
        private PictureBox pictureBox1;
        private Label labelDateOfDiscovery;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Button ButtonChooseObjectColor;
        private Button buttonCreateSpaceObject;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
    }
}