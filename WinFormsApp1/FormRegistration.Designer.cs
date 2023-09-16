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
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            ButtonChooseEyeColor = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonCreateEmployee = new Button();
            label7 = new Label();
            richTextBox1 = new RichTextBox();
            ButtonClear = new Button();
            ButtonMakeDisc = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Size = new Size(960, 103);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(960, 103);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
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
            textBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(142, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 39);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(142, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 39);
            textBox2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Cursor = Cursors.Hand;
            numericUpDown1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(142, 212);
            numericUpDown1.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 39);
            numericUpDown1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.Cursor = Cursors.Hand;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "м", "ж" });
            comboBox1.Location = new Point(142, 257);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 39);
            comboBox1.TabIndex = 5;
            // 
            // ButtonChooseEyeColor
            // 
            ButtonChooseEyeColor.Cursor = Cursors.Hand;
            ButtonChooseEyeColor.ForeColor = SystemColors.ControlText;
            ButtonChooseEyeColor.Location = new Point(142, 312);
            ButtonChooseEyeColor.Margin = new Padding(0);
            ButtonChooseEyeColor.Name = "ButtonChooseEyeColor";
            ButtonChooseEyeColor.Size = new Size(94, 32);
            ButtonChooseEyeColor.TabIndex = 6;
            ButtonChooseEyeColor.UseVisualStyleBackColor = true;
            ButtonChooseEyeColor.Click += ButtonChooseEyeColor_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(124, 33);
            label2.TabIndex = 7;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(65, 33);
            label3.TabIndex = 8;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 212);
            label4.Name = "label4";
            label4.Size = new Size(109, 33);
            label4.TabIndex = 9;
            label4.Text = "Возраст";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 257);
            label5.Name = "label5";
            label5.Size = new Size(62, 33);
            label5.TabIndex = 10;
            label5.Text = "Пол";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 312);
            label6.Name = "label6";
            label6.Size = new Size(125, 33);
            label6.TabIndex = 11;
            label6.Text = "Цвет глаз";
            // 
            // buttonCreateEmployee
            // 
            buttonCreateEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCreateEmployee.AutoSize = true;
            buttonCreateEmployee.Cursor = Cursors.Hand;
            buttonCreateEmployee.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreateEmployee.Location = new Point(142, 361);
            buttonCreateEmployee.Name = "buttonCreateEmployee";
            buttonCreateEmployee.Size = new Size(134, 42);
            buttonCreateEmployee.TabIndex = 12;
            buttonCreateEmployee.Text = "Создать";
            buttonCreateEmployee.UseVisualStyleBackColor = true;
            buttonCreateEmployee.Click += buttonCreateEmployee_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(555, 118);
            label7.Name = "label7";
            label7.Size = new Size(318, 33);
            label7.TabIndex = 14;
            label7.Text = "Созданные пользователи:";
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
            // ButtonMakeDisc
            // 
            ButtonMakeDisc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonMakeDisc.AutoSize = true;
            ButtonMakeDisc.Cursor = Cursors.Hand;
            ButtonMakeDisc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonMakeDisc.Location = new Point(715, 361);
            ButtonMakeDisc.Name = "ButtonMakeDisc";
            ButtonMakeDisc.Size = new Size(229, 42);
            ButtonMakeDisc.TabIndex = 17;
            ButtonMakeDisc.Text = "Добавить дисциплину";
            ButtonMakeDisc.UseVisualStyleBackColor = true;
            ButtonMakeDisc.Click += ButtonMakeDisc_Click;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(960, 468);
            Controls.Add(ButtonMakeDisc);
            Controls.Add(ButtonClear);
            Controls.Add(richTextBox1);
            Controls.Add(label7);
            Controls.Add(buttonCreateEmployee);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ButtonChooseEyeColor);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private Button ButtonChooseEyeColor;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonCreateEmployee;
        private Label label7;
        private RichTextBox richTextBox1;
        private Button ButtonClear;
        private Button ButtonMakeDisc;
    }
}