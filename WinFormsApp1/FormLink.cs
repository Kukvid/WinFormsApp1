using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WinFormsLibrary;

namespace WinFormsApp1
{
    public partial class FormLink : Form
    {
        //static StarSystem starSystems = FormRegistration.
        public FormLink()
        {
            InitializeComponent();
            comboBox1.DataSource = FormRegistration.objects;
            comboBox1.DisplayMember = "NameWithType";

            comboBox2.DataSource = FormRegistration.objects;
            comboBox2.DisplayMember = "NameWithType";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormLink_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = FormRegistration.starSystems;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Name";

            this.pictureBox1.DataBindings.Add(new Binding("Image", FormRegistration.starSystems, "Img"));
            this.richTextBox1.DataBindings.Add(new Binding("Text", FormRegistration.starSystems, "StructureInfo"));
        }

        private void FormLink_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistration.instance.RecieveDataFromForm(FormRegistration.objects[comboBox1.SelectedIndex], FormRegistration.objects[comboBox2.SelectedIndex]);
        }
    }
}
