using System.Runtime.CompilerServices;

namespace WinFormsApp1

{
    partial class FormLink
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
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1291, 150);
            panel1.TabIndex = 0;
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.Bisque;
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(36, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(570, 849);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Структура звездных систем";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(6, 288);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(550, 531);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(296, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 229);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 45;
            listBox1.Location = new Point(6, 54);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(267, 229);
            listBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Bisque;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(652, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(603, 396);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Привязка/ отвязка объектов";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(28, 240);
            button1.Name = "button1";
            button1.Size = new Size(261, 55);
            button1.TabIndex = 5;
            button1.Text = "привязать/ отвязать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(28, 178);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(350, 40);
            comboBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 143);
            label3.Name = "label3";
            label3.Size = new Size(160, 32);
            label3.TabIndex = 4;
            label3.Text = "к(от) объекта";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 54);
            label2.Name = "label2";
            label2.Size = new Size(323, 32);
            label2.TabIndex = 3;
            label2.Text = "Привязать/ отвязать объект";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(28, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(350, 40);
            comboBox1.TabIndex = 0;
            // 
            // FormLink
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1291, 1046);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "FormLink";
            Text = "Form1";
            FormClosed += FormLink_FormClosed;
            Load += FormLink_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private GroupBox groupBox2;
        private Button button1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
    }
}