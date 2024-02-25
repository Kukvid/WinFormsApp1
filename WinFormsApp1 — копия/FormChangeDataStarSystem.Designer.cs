namespace WinFormsApp1
{
    partial class FormChangeDataStarSystem
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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            addPhoto = new Button();
            buttonRemoveMoon = new Button();
            buttonRemovePlanet = new Button();
            buttonRemoveStar = new Button();
            buttonAddMoon = new Button();
            buttonAddPlanet = new Button();
            buttonAddStar = new Button();
            label8 = new Label();
            label9 = new Label();
            labelDateOfDiscovery = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            buttonSaveStarSystem = new Button();
            label4 = new Label();
            listBoxMoons2 = new ListBox();
            listBoxMoons1 = new ListBox();
            listBoxPlanets1 = new ListBox();
            listBoxPlanets2 = new ListBox();
            listBoxStars2 = new ListBox();
            listBoxStars1 = new ListBox();
            panel1 = new Panel();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(14, 312);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 323);
            pictureBox1.TabIndex = 97;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "C:\\\\Users\\\\Daniil\\\\source\\\\repos\\\\WinFormsApp1\\\\WinFormsApp1\\\\media\\\\default-star-system.jpg";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(1174, 445);
            label3.Name = "label3";
            label3.Size = new Size(246, 28);
            label3.TabIndex = 96;
            label3.Text = "используемые планеты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(750, 445);
            label2.Name = "label2";
            label2.Size = new Size(206, 28);
            label2.TabIndex = 95;
            label2.Text = "доступные планеты";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(1179, 151);
            label7.Name = "label7";
            label7.Size = new Size(234, 28);
            label7.TabIndex = 94;
            label7.Text = "используемые звезды";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(733, 151);
            label6.Name = "label6";
            label6.Size = new Size(194, 28);
            label6.TabIndex = 93;
            label6.Text = "доступные звезды";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(1179, 763);
            label5.Name = "label5";
            label5.Size = new Size(214, 28);
            label5.TabIndex = 92;
            label5.Text = "используемые луны";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.guap;
            pictureBox2.Location = new Point(14, 991);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 91;
            pictureBox2.TabStop = false;
            // 
            // addPhoto
            // 
            addPhoto.Location = new Point(82, 643);
            addPhoto.Margin = new Padding(4);
            addPhoto.Name = "addPhoto";
            addPhoto.Size = new Size(174, 36);
            addPhoto.TabIndex = 90;
            addPhoto.Text = "добавить фото";
            addPhoto.UseVisualStyleBackColor = true;
            addPhoto.Click += addPhoto_Click;
            // 
            // buttonRemoveMoon
            // 
            buttonRemoveMoon.Location = new Point(1045, 925);
            buttonRemoveMoon.Name = "buttonRemoveMoon";
            buttonRemoveMoon.Size = new Size(48, 34);
            buttonRemoveMoon.TabIndex = 89;
            buttonRemoveMoon.Text = "<";
            buttonRemoveMoon.UseVisualStyleBackColor = true;
            buttonRemoveMoon.Click += buttonRemoveMoon_Click;
            // 
            // buttonRemovePlanet
            // 
            buttonRemovePlanet.Location = new Point(1045, 607);
            buttonRemovePlanet.Name = "buttonRemovePlanet";
            buttonRemovePlanet.Size = new Size(48, 34);
            buttonRemovePlanet.TabIndex = 88;
            buttonRemovePlanet.Text = "<";
            buttonRemovePlanet.UseVisualStyleBackColor = true;
            buttonRemovePlanet.Click += buttonRemovePlanet_Click;
            // 
            // buttonRemoveStar
            // 
            buttonRemoveStar.Location = new Point(1045, 300);
            buttonRemoveStar.Name = "buttonRemoveStar";
            buttonRemoveStar.Size = new Size(48, 34);
            buttonRemoveStar.TabIndex = 87;
            buttonRemoveStar.Text = "<";
            buttonRemoveStar.UseVisualStyleBackColor = true;
            buttonRemoveStar.Click += buttonRemoveStar_Click;
            // 
            // buttonAddMoon
            // 
            buttonAddMoon.Location = new Point(1045, 885);
            buttonAddMoon.Name = "buttonAddMoon";
            buttonAddMoon.Size = new Size(48, 34);
            buttonAddMoon.TabIndex = 86;
            buttonAddMoon.Text = ">";
            buttonAddMoon.UseVisualStyleBackColor = true;
            buttonAddMoon.Click += buttonAddMoon_Click;
            // 
            // buttonAddPlanet
            // 
            buttonAddPlanet.Location = new Point(1045, 567);
            buttonAddPlanet.Name = "buttonAddPlanet";
            buttonAddPlanet.Size = new Size(48, 34);
            buttonAddPlanet.TabIndex = 85;
            buttonAddPlanet.Text = ">";
            buttonAddPlanet.UseVisualStyleBackColor = true;
            buttonAddPlanet.Click += buttonAddPlanet_Click;
            // 
            // buttonAddStar
            // 
            buttonAddStar.Location = new Point(1045, 260);
            buttonAddStar.Name = "buttonAddStar";
            buttonAddStar.Size = new Size(48, 34);
            buttonAddStar.TabIndex = 84;
            buttonAddStar.Text = ">";
            buttonAddStar.UseVisualStyleBackColor = true;
            buttonAddStar.Click += buttonAddStar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 171);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(244, 28);
            label8.TabIndex = 81;
            label8.Text = "Имя звездной системы";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(12, 223);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(278, 28);
            label9.TabIndex = 82;
            label9.Text = "Возраст звездной системы";
            // 
            // labelDateOfDiscovery
            // 
            labelDateOfDiscovery.AutoSize = true;
            labelDateOfDiscovery.BackColor = Color.Transparent;
            labelDateOfDiscovery.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelDateOfDiscovery.Location = new Point(12, 270);
            labelDateOfDiscovery.Margin = new Padding(4, 0, 4, 0);
            labelDateOfDiscovery.Name = "labelDateOfDiscovery";
            labelDateOfDiscovery.Size = new Size(347, 28);
            labelDateOfDiscovery.TabIndex = 83;
            labelDateOfDiscovery.Text = "Дата открытия звездной системы";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(362, 171);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 34);
            textBox1.TabIndex = 78;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Cursor = Cursors.Hand;
            numericUpDown1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(362, 223);
            numericUpDown1.Margin = new Padding(4);
            numericUpDown1.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(288, 34);
            numericUpDown1.TabIndex = 79;
            numericUpDown1.ThousandsSeparator = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePicker1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(363, 270);
            dateTimePicker1.Margin = new Padding(4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 34);
            dateTimePicker1.TabIndex = 80;
            dateTimePicker1.Value = new DateTime(2023, 9, 20, 14, 0, 28, 0);
            // 
            // buttonSaveStarSystem
            // 
            buttonSaveStarSystem.BackColor = Color.LightCyan;
            buttonSaveStarSystem.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveStarSystem.Location = new Point(380, 537);
            buttonSaveStarSystem.Name = "buttonSaveStarSystem";
            buttonSaveStarSystem.Size = new Size(130, 93);
            buttonSaveStarSystem.TabIndex = 77;
            buttonSaveStarSystem.Text = "Сохранить изменения";
            buttonSaveStarSystem.UseVisualStyleBackColor = false;
            buttonSaveStarSystem.Click += buttonSaveStarSystem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(753, 763);
            label4.Name = "label4";
            label4.Size = new Size(174, 28);
            label4.TabIndex = 76;
            label4.Text = "доступные луны";
            // 
            // listBoxMoons2
            // 
            listBoxMoons2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxMoons2.FormattingEnabled = true;
            listBoxMoons2.ItemHeight = 28;
            listBoxMoons2.Location = new Point(1113, 804);
            listBoxMoons2.Name = "listBoxMoons2";
            listBoxMoons2.Size = new Size(349, 256);
            listBoxMoons2.TabIndex = 75;
            // 
            // listBoxMoons1
            // 
            listBoxMoons1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxMoons1.FormattingEnabled = true;
            listBoxMoons1.ItemHeight = 28;
            listBoxMoons1.Location = new Point(676, 804);
            listBoxMoons1.Name = "listBoxMoons1";
            listBoxMoons1.Size = new Size(349, 256);
            listBoxMoons1.TabIndex = 74;
            // 
            // listBoxPlanets1
            // 
            listBoxPlanets1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxPlanets1.FormattingEnabled = true;
            listBoxPlanets1.ItemHeight = 28;
            listBoxPlanets1.Location = new Point(677, 486);
            listBoxPlanets1.Name = "listBoxPlanets1";
            listBoxPlanets1.Size = new Size(349, 256);
            listBoxPlanets1.TabIndex = 73;
            // 
            // listBoxPlanets2
            // 
            listBoxPlanets2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxPlanets2.FormattingEnabled = true;
            listBoxPlanets2.ItemHeight = 28;
            listBoxPlanets2.Location = new Point(1113, 486);
            listBoxPlanets2.Name = "listBoxPlanets2";
            listBoxPlanets2.Size = new Size(349, 256);
            listBoxPlanets2.TabIndex = 72;
            // 
            // listBoxStars2
            // 
            listBoxStars2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxStars2.FormattingEnabled = true;
            listBoxStars2.ItemHeight = 28;
            listBoxStars2.Location = new Point(1113, 182);
            listBoxStars2.Name = "listBoxStars2";
            listBoxStars2.Size = new Size(349, 256);
            listBoxStars2.TabIndex = 71;
            // 
            // listBoxStars1
            // 
            listBoxStars1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxStars1.FormattingEnabled = true;
            listBoxStars1.ItemHeight = 28;
            listBoxStars1.Location = new Point(676, 182);
            listBoxStars1.Name = "listBoxStars1";
            listBoxStars1.Size = new Size(349, 256);
            listBoxStars1.TabIndex = 70;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1474, 150);
            panel1.TabIndex = 69;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1474, 150);
            label1.TabIndex = 1;
            label1.Text = "Редактирование звездной системы";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormChangeDataStarSystem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1474, 1074);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(addPhoto);
            Controls.Add(buttonRemoveMoon);
            Controls.Add(buttonRemovePlanet);
            Controls.Add(buttonRemoveStar);
            Controls.Add(buttonAddMoon);
            Controls.Add(buttonAddPlanet);
            Controls.Add(buttonAddStar);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(labelDateOfDiscovery);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonSaveStarSystem);
            Controls.Add(label4);
            Controls.Add(listBoxMoons2);
            Controls.Add(listBoxMoons1);
            Controls.Add(listBoxPlanets1);
            Controls.Add(listBoxPlanets2);
            Controls.Add(listBoxStars2);
            Controls.Add(listBoxStars1);
            Controls.Add(panel1);
            Name = "FormChangeDataStarSystem";
            Text = "FormChangeDataStarSystem";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox2;
        private Button addPhoto;
        private Button buttonRemoveMoon;
        private Button buttonRemovePlanet;
        private Button buttonRemoveStar;
        private Button buttonAddMoon;
        private Button buttonAddPlanet;
        private Button buttonAddStar;
        private Label label8;
        private Label label9;
        private Label labelDateOfDiscovery;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private Button buttonSaveStarSystem;
        private Label label4;
        private ListBox listBoxMoons2;
        private ListBox listBoxMoons1;
        private ListBox listBoxPlanets1;
        private ListBox listBoxPlanets2;
        private ListBox listBoxStars2;
        private ListBox listBoxStars1;
        private Panel panel1;
        private Label label1;
        private OpenFileDialog openFileDialog1;
    }
}