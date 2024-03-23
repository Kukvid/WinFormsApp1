namespace WinFormsApp1
{
    partial class ChangeDataOfObjectView
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
            pictureBox2 = new PictureBox();
            labelAccelerationOfFreeFall = new Label();
            panel1 = new Panel();
            label1 = new Label();
            numericUpDownAccelerationOfFreeFall = new NumericUpDown();
            labelWeight = new Label();
            label8 = new Label();
            numericUpDownWeight = new NumericUpDown();
            dateTimePickerDateOfDiscovery = new DateTimePicker();
            labelObjectType = new Label();
            buttonChangeDataOfSpaceObject = new Button();
            buttonColor = new Button();
            label9 = new Label();
            numericUpDownAge = new NumericUpDown();
            addPhoto = new Button();
            textBoxName = new TextBox();
            labelColor = new Label();
            labelDateOfDiscovery = new Label();
            pictureBoxObjectImage = new PictureBox();
            textBoxType = new TextBox();
            colorDialog1 = new ColorDialog();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAccelerationOfFreeFall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxObjectImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.guap;
            pictureBox2.Location = new Point(848, 607);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 80;
            pictureBox2.TabStop = false;
            // 
            // labelAccelerationOfFreeFall
            // 
            labelAccelerationOfFreeFall.AutoSize = true;
            labelAccelerationOfFreeFall.BackColor = Color.Transparent;
            labelAccelerationOfFreeFall.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelAccelerationOfFreeFall.Location = new Point(12, 500);
            labelAccelerationOfFreeFall.Margin = new Padding(4, 0, 4, 0);
            labelAccelerationOfFreeFall.Name = "labelAccelerationOfFreeFall";
            labelAccelerationOfFreeFall.Size = new Size(335, 76);
            labelAccelerationOfFreeFall.TabIndex = 78;
            labelAccelerationOfFreeFall.Text = "Ускорение силы тяжести\r\n в м/с^2";
            labelAccelerationOfFreeFall.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 150);
            panel1.TabIndex = 69;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1057, 150);
            label1.TabIndex = 68;
            label1.Text = "Редактирование космического\r\n объекта";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownAccelerationOfFreeFall
            // 
            numericUpDownAccelerationOfFreeFall.Cursor = Cursors.Hand;
            numericUpDownAccelerationOfFreeFall.DecimalPlaces = 2;
            numericUpDownAccelerationOfFreeFall.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAccelerationOfFreeFall.Location = new Point(383, 498);
            numericUpDownAccelerationOfFreeFall.Margin = new Padding(4);
            numericUpDownAccelerationOfFreeFall.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDownAccelerationOfFreeFall.Name = "numericUpDownAccelerationOfFreeFall";
            numericUpDownAccelerationOfFreeFall.Size = new Size(288, 45);
            numericUpDownAccelerationOfFreeFall.TabIndex = 77;
            numericUpDownAccelerationOfFreeFall.ThousandsSeparator = true;
            numericUpDownAccelerationOfFreeFall.Visible = false;
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.BackColor = Color.Transparent;
            labelWeight.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelWeight.Location = new Point(12, 443);
            labelWeight.Margin = new Padding(4, 0, 4, 0);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(350, 38);
            labelWeight.TabIndex = 76;
            labelWeight.Text = "Масса объекта в 10^24 кг";
            labelWeight.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 169);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(371, 38);
            label8.TabIndex = 70;
            label8.Text = "Имя космического объекта";
            // 
            // numericUpDownWeight
            // 
            numericUpDownWeight.Cursor = Cursors.Hand;
            numericUpDownWeight.DecimalPlaces = 15;
            numericUpDownWeight.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownWeight.Location = new Point(385, 436);
            numericUpDownWeight.Margin = new Padding(4);
            numericUpDownWeight.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDownWeight.Name = "numericUpDownWeight";
            numericUpDownWeight.Size = new Size(288, 45);
            numericUpDownWeight.TabIndex = 75;
            numericUpDownWeight.ThousandsSeparator = true;
            numericUpDownWeight.Visible = false;
            // 
            // dateTimePickerDateOfDiscovery
            // 
            dateTimePickerDateOfDiscovery.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePickerDateOfDiscovery.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDateOfDiscovery.Format = DateTimePickerFormat.Custom;
            dateTimePickerDateOfDiscovery.Location = new Point(383, 335);
            dateTimePickerDateOfDiscovery.Margin = new Padding(4);
            dateTimePickerDateOfDiscovery.Name = "dateTimePickerDateOfDiscovery";
            dateTimePickerDateOfDiscovery.Size = new Size(290, 45);
            dateTimePickerDateOfDiscovery.TabIndex = 66;
            dateTimePickerDateOfDiscovery.Value = new DateTime(2023, 9, 20, 14, 0, 28, 0);
            // 
            // labelObjectType
            // 
            labelObjectType.AutoSize = true;
            labelObjectType.BackColor = Color.Transparent;
            labelObjectType.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelObjectType.Location = new Point(12, 281);
            labelObjectType.Margin = new Padding(4, 0, 4, 0);
            labelObjectType.Name = "labelObjectType";
            labelObjectType.Size = new Size(175, 38);
            labelObjectType.TabIndex = 74;
            labelObjectType.Text = "Тип объекта";
            labelObjectType.Click += labelObjectType_Click;
            // 
            // buttonChangeDataOfSpaceObject
            // 
            buttonChangeDataOfSpaceObject.BackColor = Color.LightCyan;
            buttonChangeDataOfSpaceObject.Cursor = Cursors.Hand;
            buttonChangeDataOfSpaceObject.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChangeDataOfSpaceObject.Location = new Point(13, 589);
            buttonChangeDataOfSpaceObject.Margin = new Padding(4);
            buttonChangeDataOfSpaceObject.Name = "buttonChangeDataOfSpaceObject";
            buttonChangeDataOfSpaceObject.Size = new Size(135, 87);
            buttonChangeDataOfSpaceObject.TabIndex = 65;
            buttonChangeDataOfSpaceObject.Text = "Сохранить\r\n изменения";
            buttonChangeDataOfSpaceObject.UseVisualStyleBackColor = false;
            buttonChangeDataOfSpaceObject.Click += buttonChangeDataOfSpaceObject_Click;
            // 
            // buttonColor
            // 
            buttonColor.Cursor = Cursors.Hand;
            buttonColor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonColor.ForeColor = SystemColors.ControlText;
            buttonColor.Location = new Point(383, 388);
            buttonColor.Margin = new Padding(0);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(118, 40);
            buttonColor.TabIndex = 64;
            buttonColor.UseVisualStyleBackColor = true;
            buttonColor.Click += ButtonChooseObjectColor_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(12, 229);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(226, 38);
            label9.TabIndex = 71;
            label9.Text = "Возраст объекта";
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Cursor = Cursors.Hand;
            numericUpDownAge.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAge.Location = new Point(383, 229);
            numericUpDownAge.Margin = new Padding(4);
            numericUpDownAge.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(290, 45);
            numericUpDownAge.TabIndex = 63;
            numericUpDownAge.ThousandsSeparator = true;
            // 
            // addPhoto
            // 
            addPhoto.Location = new Point(796, 498);
            addPhoto.Margin = new Padding(4);
            addPhoto.Name = "addPhoto";
            addPhoto.Size = new Size(174, 36);
            addPhoto.TabIndex = 68;
            addPhoto.Text = "добавить фото";
            addPhoto.UseVisualStyleBackColor = true;
            addPhoto.Click += addPhoto_Click;
            // 
            // textBoxName
            // 
            textBoxName.Cursor = Cursors.IBeam;
            textBoxName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(383, 169);
            textBoxName.Margin = new Padding(4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(295, 45);
            textBoxName.TabIndex = 62;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.BackColor = Color.Transparent;
            labelColor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelColor.Location = new Point(12, 389);
            labelColor.Margin = new Padding(4, 0, 4, 0);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(190, 38);
            labelColor.TabIndex = 72;
            labelColor.Text = "Цвет объекта";
            // 
            // labelDateOfDiscovery
            // 
            labelDateOfDiscovery.AutoSize = true;
            labelDateOfDiscovery.BackColor = Color.Transparent;
            labelDateOfDiscovery.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelDateOfDiscovery.Location = new Point(12, 335);
            labelDateOfDiscovery.Margin = new Padding(4, 0, 4, 0);
            labelDateOfDiscovery.Name = "labelDateOfDiscovery";
            labelDateOfDiscovery.Size = new Size(312, 38);
            labelDateOfDiscovery.TabIndex = 73;
            labelDateOfDiscovery.Text = "Дата открытия объекта";
            // 
            // pictureBoxObjectImage
            // 
            pictureBoxObjectImage.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxObjectImage.Location = new Point(699, 167);
            pictureBoxObjectImage.Margin = new Padding(4);
            pictureBoxObjectImage.Name = "pictureBoxObjectImage";
            pictureBoxObjectImage.Size = new Size(349, 323);
            pictureBoxObjectImage.TabIndex = 67;
            pictureBoxObjectImage.TabStop = false;
            pictureBoxObjectImage.Tag = "C:\\\\Users\\\\Daniil\\\\source\\\\repos\\\\WinFormsApp1\\\\WinFormsApp1\\\\media\\\\default-star-system.jpg";
            // 
            // textBoxType
            // 
            textBoxType.Cursor = Cursors.IBeam;
            textBoxType.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxType.Location = new Point(383, 282);
            textBoxType.Margin = new Padding(4);
            textBoxType.Name = "textBoxType";
            textBoxType.ReadOnly = true;
            textBoxType.Size = new Size(295, 45);
            textBoxType.TabIndex = 81;
            textBoxType.TextChanged += textBox2_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormChangeDataOfObjectView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1057, 684);
            Controls.Add(textBoxType);
            Controls.Add(pictureBox2);
            Controls.Add(labelAccelerationOfFreeFall);
            Controls.Add(panel1);
            Controls.Add(numericUpDownAccelerationOfFreeFall);
            Controls.Add(labelWeight);
            Controls.Add(label8);
            Controls.Add(numericUpDownWeight);
            Controls.Add(dateTimePickerDateOfDiscovery);
            Controls.Add(labelObjectType);
            Controls.Add(buttonChangeDataOfSpaceObject);
            Controls.Add(buttonColor);
            Controls.Add(label9);
            Controls.Add(numericUpDownAge);
            Controls.Add(addPhoto);
            Controls.Add(textBoxName);
            Controls.Add(labelColor);
            Controls.Add(labelDateOfDiscovery);
            Controls.Add(pictureBoxObjectImage);
            Name = "FormChangeDataOfObjectView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormChangeDataOfObject";
            Load += FormChangeDataOfObject_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownAccelerationOfFreeFall).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxObjectImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label labelAccelerationOfFreeFall;
        private Panel panel1;
        private Label label1;
        private NumericUpDown numericUpDownAccelerationOfFreeFall;
        private Label labelWeight;
        private Label label8;
        private NumericUpDown numericUpDownWeight;
        private DateTimePicker dateTimePickerDateOfDiscovery;
        private Label labelObjectType;
        private Button buttonChangeDataOfSpaceObject;
        private Button buttonColor;
        private Label label9;
        private NumericUpDown numericUpDownAge;
        private Button addPhoto;
        private TextBox textBoxName;
        private Label labelColor;
        private Label labelDateOfDiscovery;
        private PictureBox pictureBoxObjectImage;
        private TextBox textBoxType;
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
    }
}