namespace WinFormsApp1
{
    partial class ListOfObjectsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOfObjectsView));
            textBoxType = new TextBox();
            label2 = new Label();
            pictureBoxObjectImage = new PictureBox();
            buttonColor = new Button();
            dateTimePickerDateOfDiscovery = new DateTimePicker();
            numericUpDownAge = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            textBoxName = new TextBox();
            listBoxObjects = new ListBox();
            label5 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            buttonCreateSpaceObject = new Button();
            label7 = new Label();
            buttonCreateStarSystem = new Button();
            buttonAdditionalInfo = new Button();
            buttonDelete = new Button();
            pictureBox2 = new PictureBox();
            buttonClear = new Button();
            textBoxSearch = new TextBox();
            comboBoxSort = new ComboBox();
            label8 = new Label();
            labelCountObjectsInListBox = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxObjectImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBoxType
            // 
            textBoxType.Cursor = Cursors.IBeam;
            textBoxType.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxType.Location = new Point(905, 247);
            textBoxType.Margin = new Padding(4);
            textBoxType.Name = "textBoxType";
            textBoxType.Size = new Size(286, 39);
            textBoxType.TabIndex = 63;
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
            // pictureBoxObjectImage
            // 
            pictureBoxObjectImage.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxObjectImage.Location = new Point(1199, 194);
            pictureBoxObjectImage.Margin = new Padding(4);
            pictureBoxObjectImage.Name = "pictureBoxObjectImage";
            pictureBoxObjectImage.Size = new Size(300, 257);
            pictureBoxObjectImage.TabIndex = 59;
            pictureBoxObjectImage.TabStop = false;
            // 
            // buttonColor
            // 
            buttonColor.Cursor = Cursors.Hand;
            buttonColor.ForeColor = SystemColors.ControlText;
            buttonColor.Location = new Point(905, 406);
            buttonColor.Margin = new Padding(0);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(118, 40);
            buttonColor.TabIndex = 56;
            buttonColor.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDateOfDiscovery
            // 
            dateTimePickerDateOfDiscovery.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePickerDateOfDiscovery.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDateOfDiscovery.Format = DateTimePickerFormat.Custom;
            dateTimePickerDateOfDiscovery.Location = new Point(905, 346);
            dateTimePickerDateOfDiscovery.Margin = new Padding(4);
            dateTimePickerDateOfDiscovery.Name = "dateTimePickerDateOfDiscovery";
            dateTimePickerDateOfDiscovery.Size = new Size(284, 39);
            dateTimePickerDateOfDiscovery.TabIndex = 61;
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
            // textBoxName
            // 
            textBoxName.Cursor = Cursors.IBeam;
            textBoxName.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(905, 194);
            textBoxName.Margin = new Padding(4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(286, 39);
            textBoxName.TabIndex = 58;
            // 
            // listBoxObjects
            // 
            listBoxObjects.FormattingEnabled = true;
            listBoxObjects.ItemHeight = 25;
            listBoxObjects.Location = new Point(13, 197);
            listBoxObjects.Margin = new Padding(4);
            listBoxObjects.Name = "listBoxObjects";
            listBoxObjects.Size = new Size(439, 254);
            listBoxObjects.TabIndex = 57;
            listBoxObjects.SelectedIndexChanged += listBoxObjects_SelectedIndexChanged;
            listBoxObjects.MouseDoubleClick += listBoxObjects_MouseDoubleClick;
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
            buttonCreateSpaceObject.Location = new Point(16, 497);
            buttonCreateSpaceObject.Name = "buttonCreateSpaceObject";
            buttonCreateSpaceObject.Size = new Size(240, 65);
            buttonCreateSpaceObject.TabIndex = 70;
            buttonCreateSpaceObject.Text = "Создать космический \r\nобъект";
            buttonCreateSpaceObject.UseVisualStyleBackColor = false;
            buttonCreateSpaceObject.Click += buttonCreateSpaceObject_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Ivory;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(458, 566);
            label7.MaximumSize = new Size(830, 0);
            label7.Name = "label7";
            label7.Size = new Size(654, 64);
            label7.TabIndex = 71;
            label7.Text = "Если вы хотите изменить какие-то свойства объекта, \r\nто кликните по нему 2 раза в списке объектов.\r\n";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCreateStarSystem
            // 
            buttonCreateStarSystem.BackColor = Color.PaleGreen;
            buttonCreateStarSystem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateStarSystem.Location = new Point(262, 497);
            buttonCreateStarSystem.Name = "buttonCreateStarSystem";
            buttonCreateStarSystem.Size = new Size(193, 65);
            buttonCreateStarSystem.TabIndex = 75;
            buttonCreateStarSystem.Text = "Создать звездную\r\n систему\r\n";
            buttonCreateStarSystem.UseVisualStyleBackColor = false;
            buttonCreateStarSystem.Click += buttonCreateStarSystem_Click;
            // 
            // buttonAdditionalInfo
            // 
            buttonAdditionalInfo.BackColor = Color.Gold;
            buttonAdditionalInfo.Location = new Point(16, 568);
            buttonAdditionalInfo.Name = "buttonAdditionalInfo";
            buttonAdditionalInfo.Size = new Size(243, 65);
            buttonAdditionalInfo.TabIndex = 76;
            buttonAdditionalInfo.Text = "Показать дополнительную информацию";
            buttonAdditionalInfo.UseVisualStyleBackColor = false;
            buttonAdditionalInfo.Click += buttonAdditionalInfo_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.OrangeRed;
            buttonDelete.Location = new Point(262, 568);
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
            pictureBox2.Location = new Point(1299, 561);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 78;
            pictureBox2.TabStop = false;
            // 
            // buttonClear
            // 
            buttonClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonClear.BackgroundImageLayout = ImageLayout.Zoom;
            buttonClear.ForeColor = SystemColors.ControlText;
            buttonClear.Image = (Image)resources.GetObject("buttonClear.Image");
            buttonClear.Location = new Point(419, 160);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(33, 31);
            buttonClear.TabIndex = 80;
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(13, 160);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(400, 31);
            textBoxSearch.TabIndex = 81;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // comboBoxSort
            // 
            comboBoxSort.CausesValidation = false;
            comboBoxSort.DropDownWidth = 250;
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "Звездная система -> Луна", "Луна -> Звездная система", "А -> Я", "Я -> А" });
            comboBoxSort.Location = new Point(16, 458);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(135, 33);
            comboBoxSort.TabIndex = 82;
            comboBoxSort.Text = "Звездная система -> Луна";
            comboBoxSort.SelectedValueChanged += comboBoxSort_SelectedValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(157, 461);
            label8.Name = "label8";
            label8.Size = new Size(183, 25);
            label8.TabIndex = 83;
            label8.Text = "Найдено объектов:";
            // 
            // labelCountObjectsInListBox
            // 
            labelCountObjectsInListBox.AutoSize = true;
            labelCountObjectsInListBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCountObjectsInListBox.ForeColor = Color.Navy;
            labelCountObjectsInListBox.Location = new Point(346, 461);
            labelCountObjectsInListBox.Name = "labelCountObjectsInListBox";
            labelCountObjectsInListBox.Size = new Size(22, 25);
            labelCountObjectsInListBox.TabIndex = 84;
            labelCountObjectsInListBox.Text = "0";
            // 
            // ListOfObjectsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1513, 650);
            Controls.Add(labelCountObjectsInListBox);
            Controls.Add(label8);
            Controls.Add(comboBoxSort);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonClear);
            Controls.Add(pictureBox2);
            Controls.Add(buttonDelete);
            Controls.Add(buttonAdditionalInfo);
            Controls.Add(buttonCreateStarSystem);
            Controls.Add(label7);
            Controls.Add(buttonCreateSpaceObject);
            Controls.Add(panel1);
            Controls.Add(textBoxType);
            Controls.Add(label2);
            Controls.Add(pictureBoxObjectImage);
            Controls.Add(buttonColor);
            Controls.Add(dateTimePickerDateOfDiscovery);
            Controls.Add(numericUpDownAge);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(textBoxName);
            Controls.Add(listBoxObjects);
            Controls.Add(label5);
            Name = "ListOfObjectsView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormListOfObjects";
            FormClosed += FormListOfObjects_FormClosed;
            Load += FormListOfObjects_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxObjectImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxType;
        private Label label2;
        private PictureBox pictureBoxObjectImage;
        private Button buttonColor;
        private DateTimePicker dateTimePickerDateOfDiscovery;
        private NumericUpDown numericUpDownAge;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox textBoxName;
        private Label label5;
        private Label label1;
        private Panel panel1;
        private Button buttonCreateSpaceObject;
        private Label label7;
        private Button buttonCreateStarSystem;
        private Button buttonAdditionalInfo;
        private Button buttonDelete;
        private PictureBox pictureBox2;
        internal ListBox listBoxObjects;
        private Button buttonSearch;
        private Button buttonClear;
        private TextBox textBoxSearch;
        private ComboBox comboBoxSort;
        private Label label8;
        private Label labelCountObjectsInListBox;
    }
}