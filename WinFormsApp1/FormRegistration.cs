using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void button_choose_eye_color_Click(object sender, System.EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = textBox1.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                button_choose_eye_color.BackColor = MyDialog.Color;

        }

        private void button_create_employee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            string message_if_empty = "";
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                message_if_empty += "Обязательно заполните имя";
            }
            else
            {
                emp.name = textBox1.Text;
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                message_if_empty += "\nОбязательно заполните фамилию";
            }
            else
            {
                emp.surname = textBox2.Text;
            }

            if ((int)numericUpDown1.Value == 0)
            {
                message_if_empty += "\nОбязательно выберите свой возраст";
            }
            else
            {
                emp.age = (int)numericUpDown1.Value;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                message_if_empty += "\nОбязательно выберите пол";
            }
            else
            {
                //MessageBox.Show(comboBox1.SelectedItem.ToString());
                emp.gender = comboBox1.SelectedItem.ToString()[0];
            }

            emp.eye_color = button_choose_eye_color.BackColor;

            if (message_if_empty != "")
            {
                MessageBox.Show(message_if_empty);
            }
            else
            {
                string emp_str = "Сотрудник ГУАП {0} {1}, {2} лет, пол: {3}, цвет глаз: {4}.\n=============================\n";
                
                Employee emp_

                richTextBox1.AppendText(String.Format(emp_str, emp.name, emp.surname, emp.age, emp.gender, emp.eye_color));
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void button_get_hash_Click(object sender, EventArgs e)
        {
            Employee emp2 = new Employee();

            richTextBox1.AppendText(emp2.GetHashCode().ToString() + "\n\n");
        }

        private void FormRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
