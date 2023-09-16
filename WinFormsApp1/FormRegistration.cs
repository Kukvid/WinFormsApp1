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

        private void ButtonChooseEyeColor_Click(object sender, System.EventArgs e)
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
                ButtonChooseEyeColor.BackColor = MyDialog.Color;

        }

        private void buttonCreateEmployee_Click(object sender, EventArgs e)
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

            emp.eye_color = ButtonChooseEyeColor.BackColor;

            if (message_if_empty != "")
            {
                MessageBox.Show(message_if_empty);
            }
            else
            {
                string emp_str = "Сотрудник ГУАП {0} {1}, {2} лет, пол: {3}, цвет глаз: {4}.\n=============================\n";

                Employee emp_2 = new Employee();
                Employee emp_3 = new Employee(emp.name, emp.surname, emp.age, emp.gender, emp.eye_color);
                Employee emp_4 = new Employee(emp.name);

                richTextBox1.AppendText(String.Format(emp_str, emp.name, emp.surname, emp.age, emp.gender, emp.eye_color));
                richTextBox1.ForeColor = Employee.BackColor;
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void ButtonMakeDisc_Click(object sender, EventArgs e)
        {
            Discipline discipline = new Discipline();


            Discipline disc = new Discipline("Основы программирования", 85, 3, true);

            //disc.Name = "Основы программирования";
            //disc.NumberOfHours = 85;
            //disc.DifficultyLevel = 3;
            //disc.IsUseful = true;


            string msg_default = "Конструктор по умолчанию:\n" +
                "Название дисциплины: {0}\n" +
                "Количество часов: {1}\n" +
                "Сложность: {2}\n" +
                "Полезно ли: {3}\n************************\n";

            string msg_normal = "Без конструктора:\n" +
                "Название дисциплины: {0}\n" +
                "Количество часов: {1}\n" +
                "Сложность: {2}\n" +
                "Полезно ли: {3}\n************************\n";

            richTextBox1.AppendText(String.Format(msg_default, discipline.Name, discipline.NumberOfHours, discipline.DifficultyLevel, discipline.IsUseful));


            richTextBox1.AppendText(String.Format(msg_normal, disc.Name, disc.NumberOfHours, disc.DifficultyLevel, disc.IsUseful));

        }


    }
}
