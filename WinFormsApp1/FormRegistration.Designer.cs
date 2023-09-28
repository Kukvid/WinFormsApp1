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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 103);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(960, 103);
            label1.TabIndex = 0;
            label1.Text = "Регистрация космических тел";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.guap;
            pictureBox1.Location = new Point(788, 409);
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
            textBox1.Location = new Point(294, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 34);
            textBox1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Cursor = Cursors.Hand;
            numericUpDown1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(294, 163);
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
            ButtonChooseEyeColor.Location = new Point(294, 313);
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
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(234, 26);
            label3.TabIndex = 8;
            label3.Text = "Имя звездной системы";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 163);
            label4.Name = "label4";
            label4.Size = new Size(243, 26);
            label4.TabIndex = 9;
            label4.Text = "Возраст главной звезды";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 313);
            label6.Name = "label6";
            label6.Size = new Size(130, 26);
            label6.TabIndex = 11;
            label6.Text = "Цвет звезды";
            // 
            // buttonCreateStarSystem
            // 
            buttonCreateStarSystem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCreateStarSystem.AutoSize = true;
            buttonCreateStarSystem.Cursor = Cursors.Hand;
            buttonCreateStarSystem.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateStarSystem.Location = new Point(294, 358);
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
            label7.Location = new Point(555, 118);
            label7.Name = "label7";
            label7.Size = new Size(370, 33);
            label7.TabIndex = 14;
            label7.Text = "Созданные космические тела:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(555, 163);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(389, 182);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // ButtonClear
            // 
            ButtonClear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonClear.AutoSize = true;
            ButtonClear.Cursor = Cursors.Hand;
            ButtonClear.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonClear.Location = new Point(555, 361);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(148, 42);
            ButtonClear.TabIndex = 16;
            ButtonClear.Text = "Очистить";
            ButtonClear.UseVisualStyleBackColor = true;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // ButtonMakePlanet
            // 
            ButtonMakePlanet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonMakePlanet.AutoSize = true;
            ButtonMakePlanet.Cursor = Cursors.Hand;
            ButtonMakePlanet.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMakePlanet.Location = new Point(715, 361);
            ButtonMakePlanet.Name = "ButtonMakePlanet";
            ButtonMakePlanet.Size = new Size(229, 42);
            ButtonMakePlanet.TabIndex = 17;
            ButtonMakePlanet.Text = "Добавить планету";
            ButtonMakePlanet.UseVisualStyleBackColor = true;
            ButtonMakePlanet.Click += ButtonMakePlanet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 212);
            label2.Name = "label2";
            label2.Size = new Size(184, 26);
            label2.TabIndex = 18;
            label2.Text = "Количество звезд";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Location = new Point(294, 212);
            numericUpDown2.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(230, 34);
            numericUpDown2.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(294, 257);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 34);
            dateTimePicker1.TabIndex = 20;
            dateTimePicker1.Value = new DateTime(2023, 9, 20, 14, 0, 28, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 257);
            label5.Name = "label5";
            label5.Size = new Size(244, 26);
            label5.TabIndex = 21;
            label5.Text = "Дата открытия системы";
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(960, 468);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown2);
            Controls.Add(label2);
            Controls.Add(ButtonMakePlanet);
            Controls.Add(ButtonClear);
            Controls.Add(richTextBox1);
            Controls.Add(label7);
            Controls.Add(buttonCreateStarSystem);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ButtonChooseEyeColor);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MaximumSize = new Size(978, 515);
            MinimumSize = new Size(978, 515);
            Name = "FormRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegistration";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
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
    }
}