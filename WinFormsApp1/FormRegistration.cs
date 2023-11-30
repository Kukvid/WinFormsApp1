using WinFormsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Design;

namespace WinFormsApp1
{

    public partial class FormRegistration : Form
    {
        //public static FormRegistration instance;

        List<Star> stars = new List<Star>(Star.readFromFile()) { };
        List<Planet> planets = new List<Planet>(Planet.readFromFile()) { };
        List<Moon> moons = new List<Moon>(Moon.readFromFile()) { };

        public static FormRegistration instance;



        public static BindingList<StarSystem> starSystems = new BindingList<StarSystem>(StarSystem.readFromFile()) { };

        public static BindingList<SpaceObject> objects = new BindingList<SpaceObject>(); // UpCasting
        Star star_for_methods = new Star();
        public int lastIndex = -1;
        public FormRegistration()
        {
            InitializeComponent();
            instance = this;
            pictureBox2.Image = Properties.Resources.default_star_system;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;


            updateObjectsList();

            //MessageBox.Show(objects[0].Name + "  " + stars[0].Name);

            foreach (Moon moon in moons)
            {
                moon.LinkWithParent(planets);
            }
            foreach (Planet planet in planets)
            {
                planet.LinkWithParentAndChildren(stars, moons);
            }
            foreach (Star star in stars)
            {
                star.LinkWithParentAndChildren(planets, starSystems);
            }
            foreach (StarSystem starSystem in starSystems)
            {
                starSystem.LinkWithChildren(stars);
            }
            /*
            star_for_methods.SpaceObjectPhotoCheck += SpaceObject.DisplayMessage;
            star_for_methods.SpaceObjectPhotoCheck += (string msg) =>
            {
                richTextBox1.AppendText($"Сработал динамический обработчик событий\n" +
                    $"Сообщение: {msg}\n");
            };

            star_for_methods.ObjectEventCheck += DisplayMessage;

            check_planet.SpaceObjectPhotoCheck += SpaceObject.DisplayMessage;
            */

            //check_planet.SpaceObjectPhotoCheck += SpaceObject.DisplayMessage;
            //star_for_methods
        }

        /*
        private static void DisplayMessage(object obj, AccountEventArgs e)
        {
            MessageBox.Show(String.Format($"Был создан объект со следующим сообщением: \n{e.Message}\n"));
        }*/

        private void updateObjectsList()
        {

            foreach (Star star in stars)
            {
                objects.Add((SpaceObject)star);
            }
            foreach (Planet planet in planets)
            {
                objects.Add((SpaceObject)planet);
            }
            foreach (Moon moon in moons)
            {
                objects.Add((SpaceObject)moon);
            }
            foreach (StarSystem starSystem in starSystems)
            {
                objects.Add((SpaceObject)starSystem);
            }
        }
        private void ButtonChooseObjectColor_Click(object sender, System.EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = true;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = ButtonChooseObjectColor.ForeColor;

            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                ButtonChooseObjectColor.BackColor = MyDialog.Color;

        }

        private void buttonCreateStarSystem_Click(object sender, EventArgs e)
        {
            string message_if_empty = "";
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Выберите тип объекта");
                return;
            }

            //SpaceObject temp = new SpaceObject();

            if (string.IsNullOrEmpty(textBox1.Text) | textBox1.Text == "Не указано")
            {
                message_if_empty += "\nИзмените название космического объекта";
            }

            if ((long)numericUpDown1.Value == 0)
            {
                message_if_empty += "\nОбязательно выберите возраст космического объекта";
            }

            DateTime dateOfDiscovery = DateTime.Parse(dateTimePicker1.Value.ToString());

            foreach (SpaceObject spaceObject in objects)
            {
                if (spaceObject.Name.ToLower() == textBox1.Text.ToLower())
                {
                    message_if_empty += "\nДанное имя уже находится в списке";
                }
            }

            if (comboBox1.Text == "Планета")
            {
                if ((double)numericUpDownWeight.Value <= 0)
                {
                    message_if_empty += "\nДобавьте массу для планеты";
                }
                if ((double)numericUpDownAccelerationOfFreeFall.Value <= 0)
                {
                    message_if_empty += "\nДобавьте ускорение свободного падения для планеты";
                }
            }
            else if (comboBox1.Text == "Луна")
            {
                if ((double)numericUpDownWeight.Value <= 0)
                {
                    message_if_empty += "\nДобавьте массу для луны";
                }
            }

            if (message_if_empty != "")
            {
                MessageBox.Show(message_if_empty);
            }
            else
            {

                string star_str = "Имя звезды: {0},\n" +
                    "Возраст звезды: {1} лет,\n" +
                    "Дата открытия звезды: {2}\n" +
                    "Цвет звезды: {3}." +
                    "\n=============================\n";
                string planet_str = "Имя планеты: {0},\n" +
                    "Возраст планеты: {1} лет,\n" +
                    "Дата открытия планеты: {2}\n" +
                    "Цвет планеты: {3}.\n" +
                    "Вес планеты: {4} 10^24 кг." +
                    "Ускорение свободного падения: {5} м/с^2.\n" +
                    "\n=============================\n";
                string moon_str = "Имя планеты: {0},\n" +
                    "Возраст планеты: {1} лет,\n" +
                    "Дата открытия планеты: {2}\n" +
                    "Цвет планеты: {3}.\n" +
                    "Вес планеты: {4} кг." +
                    "\n=============================\n";
                string star_system_str = "Имя звездной системы: {0},\n" +
                    "Возраст системы: {1} лет,\n" +
                    "Дата открытия системы: {2}\n" +
                    "Цвет системы: {3}." +
                    "\n=============================\n";
                //string photo_now = (string)pictureBox2.Tag;
                if (pictureBox2.Tag != null)
                {
                    //temp.Photo = (string)pictureBox2.Tag;

                }
                if (comboBox1.Text == "Звезда")
                {

                    Star newObject = new Star(textBox1.Text, (long)numericUpDown1.Value, dateOfDiscovery, ButtonChooseObjectColor.BackColor, (string)pictureBox2.Tag);

                    richTextBox1.AppendText(String.Format(star_str, newObject.Name, newObject.Age, dateOfDiscovery, newObject.SpaceObjectColor));

                    objects.Add(newObject);
                    stars.Add(newObject);
                }
                else if (comboBox1.Text == "Планета")
                {
                    Planet newObject = new Planet(textBox1.Text, (long)numericUpDown1.Value, (double)numericUpDownWeight.Value, (double)numericUpDownAccelerationOfFreeFall.Value, dateOfDiscovery, ButtonChooseObjectColor.BackColor, (string)pictureBox2.Tag);
                    newObject.DateOfDiscovery = dateOfDiscovery;

                    richTextBox1.AppendText(String.Format(planet_str, newObject.Name, newObject.Age, dateOfDiscovery, newObject.SpaceObjectColor, newObject.Weight, newObject.AccelerationOfFreeFall));

                    objects.Add(newObject);
                    planets.Add(newObject);

                }
                else if (comboBox1.Text == "Луна")
                {

                    Moon newObject = new Moon(textBox1.Text, (long)numericUpDown1.Value, (double)numericUpDownWeight.Value, dateOfDiscovery, ButtonChooseObjectColor.BackColor, (string)pictureBox2.Tag);
                    richTextBox1.AppendText(String.Format(moon_str, newObject.Name, newObject.Age, dateOfDiscovery, newObject.SpaceObjectColor, newObject.Weight));

                    objects.Add(newObject);
                    moons.Add(newObject);
                }
                else if (comboBox1.Text == "Звездная система")
                {

                    StarSystem newObject = new StarSystem(textBox1.Text, (long)numericUpDown1.Value, dateOfDiscovery, ButtonChooseObjectColor.BackColor, (string)pictureBox2.Tag);
                    richTextBox1.AppendText(String.Format(star_system_str, newObject.Name, newObject.Age, dateOfDiscovery, newObject.SpaceObjectColor));

                    objects.Add(newObject);
                    starSystems.Add(newObject);
                }
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }



        private void addPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox2.Refresh();

                star_for_methods.setPhoto(openFileDialog1.FileName);
                star_for_methods.showPhoto(pictureBox2);

                pictureBox2.Tag = openFileDialog1.FileName;
            }
        }

        private void buttonChangeTheme_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string themePhoto = saveFileDialog1.FileName;
                Star temp = new Star();
                pictureBox2.Refresh();
                temp.showPhoto(Form.ActiveForm, themePhoto);
            }
        }


        private void FormRegistration_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = objects;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Name";

            this.dateTimePicker1.Text = DateTime.Now.ToString();
            this.textBox2.DataBindings.Add(new Binding("Text", objects, "Name"));
            this.numericUpDownAge.DataBindings.Add(new Binding("Value", objects, "Age"));

            this.dateTimePicker2.DataBindings.Add(new Binding("Value", objects, "DateOfDiscovery"));
            this.button1.DataBindings.Add(new Binding("BackColor", objects, "SpaceObjectColor"));
            this.pictureBox3.DataBindings.Add(new Binding("Image", objects, "Img"));

            this.textBox3.DataBindings.Add(new Binding("Text", objects, "Type"));


        }
        /*
        private void FormRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {

            //MessageBox.Show(starSystem.Name);
            foreach (Star star in new_stars)
            {
                star.writeToFile();
            }
            foreach (Moon moon in new_moons)
            {
                moon.writeToFile();
            }
            foreach (Planet planet in new_planets)
            {
                planet.writeToFile();

            }
            //MessageBox.Show("За всё время было добавлено: " + StarSystem.readFromFile(saveFileDialog1).ToString() + " фонов." + "\n" +
            //    "За всё время было добавлено: " + StarSystem.readFromFile(openFileDialog1).ToString() + " фотографий космических объектов.");
        }*/

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonMoreInfo_Click(object sender, EventArgs e)
        {
            string selected = listBox1.SelectedValue.ToString();
            string msg_add_info = "Дополнительная информация по объекту: \n";
            foreach (Moon moon in moons)
            {
                if (moon.Name == selected)
                {
                    richTextBox1.AppendText(msg_add_info + moon.getStringWithAdditionalInfo());
                }
            }
            foreach (Planet planet in planets)
            {
                if (planet.Name == selected)
                {
                    richTextBox1.AppendText(msg_add_info + planet.getStringWithAdditionalInfo());
                }
            }
            foreach (Star star in stars)
            {
                if (star.Name == selected)
                {
                    richTextBox1.AppendText(msg_add_info + star.getStringWithAdditionalInfo());
                }
            }
            foreach (StarSystem starSystem in starSystems)
            {
                if (starSystem.Name == selected)
                {
                    richTextBox1.AppendText(msg_add_info + starSystem.getStringWithAdditionalInfo());
                }
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selected = this.comboBox1.Text;

            if (selected == "Планета")
            {
                this.labelWeight.Visible = true;
                this.numericUpDownWeight.Visible = true;
                this.labelAccelerationOfFreeFall.Visible = true;
                this.numericUpDownAccelerationOfFreeFall.Visible = true;
            }
            else if (selected == "Звезда")
            {
                this.labelWeight.Visible = false;
                this.numericUpDownWeight.Visible = false;
                this.numericUpDownAccelerationOfFreeFall.Visible = false;
                this.labelAccelerationOfFreeFall.Visible = false;
            }
            else if (selected == "Луна")
            {
                this.labelWeight.Visible = true;
                this.numericUpDownWeight.Visible = true;
                this.numericUpDownAccelerationOfFreeFall.Visible = false;
                this.labelAccelerationOfFreeFall.Visible = false;
            }
            else if (selected == "Звездная система")
            {
                this.labelWeight.Visible = false;
                this.numericUpDownWeight.Visible = false;
                this.numericUpDownAccelerationOfFreeFall.Visible = false;
                this.labelAccelerationOfFreeFall.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            StarSystem checkStarSystem = new StarSystem(stars, planets, moons);
            richTextBox1.AppendText("Вывод объектов из звездной системы с помощью индексаторов: \n");

            for (int index = 0; index < stars.Count + moons.Count + planets.Count; index++)
            {
                richTextBox1.AppendText(checkStarSystem[index].Name + "\n");
            }
            */

            /*
            for (int indexObjectType = 0; indexObjectType < 3; indexObjectType++)
            {
                if (indexObjectType == 0)
                {
                    richTextBox1.AppendText("Звезды:\n");
                }
                else if (indexObjectType == 1)
                {
                    richTextBox1.AppendText("Планеты:\n");
                }
                else if (indexObjectType == 2)
                {
                    richTextBox1.AppendText("Луны:\n");
                }
                for (int indexObject = 0; indexObject < checkStarSystem[indexObjectType].Count; indexObject++)
                {

                    richTextBox1.AppendText(checkStarSystem[indexObjectType][indexObject].Name + "\n");
                }
            }*/

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = textBox1.Font;
            fontDialog1.Color = textBox1.ForeColor;


            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                ChangeFont(richTextBox1, fontDialog1.Font);

            }
            //MessageBox.Show(check_star.ToString());
        }
        public void ChangeFont(RichTextBox rtb, Font newFont)
        {
            rtb.Font = newFont;
        }

        private void numericUpDownWeight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.WriteAllText(SpaceObject.spaceObjectsPath, string.Empty);
            foreach (Moon moon in moons) { moon.writeToFile(); }
            foreach (Planet planet in planets) { planet.writeToFile(); }
            foreach (Star star in stars) { star.writeToFile(); }
            foreach (StarSystem starSystem in starSystems) { starSystem.writeToFile(); }
        }

        private void buttonLinkObjects_Click(object sender, EventArgs e)
        {
            FormLink formLink = new FormLink();
            formLink.ShowDialog();
        }

        public void RecieveDataFromForm(SpaceObject object1, SpaceObject object2)
        {
            //Обработка лун с объектами
            if (object1.Type == "Луна" & object2.Type == "Луна")
            {
                RecieveData(new Moon("error"), new Moon("error"));
            }
            else if (object1.Type == "Луна" & object2.Type == "Планета")
            {

                RecieveData((Moon)object1, (Planet)object2);
            }
            else if (object1.Type == "Луна" & object2.Type == "Звезда")
            {
                RecieveData(new Moon("error"), new Star("error"));
            }
            else if (object1.Type == "Луна" & object2.Type == "Звездная система")
            {
                RecieveData(new Star("error"), new StarSystem("error"));
            }
            //обработка планет с объектами
            else if (object1.Type == "Планета" & object2.Type == "Луна")
            {
                RecieveData((Planet)object1, (Moon)object2);
            }
            else if (object1.Type == "Планета" & object2.Type == "Планета")
            {

                RecieveData(new Planet("error"), new Planet("error"));
            }
            else if (object1.Type == "Планета" & object2.Type == "Звезда")
            {
                RecieveData((Planet)object1, (Star)object2);
            }
            else if (object1.Type == "Планета" & object2.Type == "Звездная система")
            {
                RecieveData(new Planet("error"), new StarSystem("error"));
            }
            // обработка звезд с объектами
            else if (object1.Type == "Звезда" & object2.Type == "Луна")
            {
                RecieveData(new Star("error"), new Moon("error"));
            }
            else if (object1.Type == "Звезда" & object2.Type == "Планета")
            {

                RecieveData((Star)object1, (Planet)object2);
            }
            else if (object1.Type == "Звезда" & object2.Type == "Звезда")
            {
                RecieveData(new Star("error"), new Star("error"));
            }
            else if (object1.Type == "Звезда" & object2.Type == "Звездная система")
            {
                RecieveData((Star)object1, (StarSystem)object2);
            }
            // обработка звездных систем с объектами
            else if (object1.Type == "Звездная система" & object2.Type == "Луна")
            {
                RecieveData(new StarSystem("error"), new Moon("error"));
            }
            else if (object1.Type == "Звездная система" & object2.Type == "Планета")
            {

                RecieveData(new StarSystem("error"), new Planet("error"));
            }
            else if (object1.Type == "Звездная система" & object2.Type == "Звезда")
            {
                RecieveData((StarSystem)object1, (Star)object2);
            }
            else if (object1.Type == "Звездная система" & object2.Type == "Звездная система")
            {
                RecieveData(new StarSystem("error"), new StarSystem("error"));
            }

        }

        // Обработка привязки луны с объектами
        public void RecieveData(Moon spaceObject, Moon spaceObject2)
        {
            MessageBox.Show("Невозможно связать два объекта одного типа.");
        }
        public void RecieveData(Moon spaceObject, Planet spaceObject2)
        {
            // Проверяем, не привязана ли луна уже к какой-то планете, если да, то удаляем ссылку на неё у той планеты.
            if (spaceObject.ParentPlanet.Name != "Не указано")
            {
                Planet tempParent = spaceObject.ParentPlanet;
                tempParent.ChildrenMoons.Remove(spaceObject);
                if (tempParent.ChildrenMoons.Count == 0)
                {
                    tempParent.ChildrenMoons.Add(new Moon("Не указано"));
                }
                spaceObject.ParentPlanet = new Planet("Не указано");
                // Проверяем не была ли луна привязана к переданной планете, если да, то дальнейшие действия не требуются.
                if (tempParent.Name == spaceObject2.Name) { return; }
            }

            spaceObject.ParentPlanet = spaceObject2;
            if (spaceObject2.ChildrenMoons[0].Name == "Не указано")
            {
                spaceObject2.ChildrenMoons[0] = spaceObject;
            }
            else
            {
                spaceObject2.ChildrenMoons.Add(spaceObject);
            }
        }
        public void RecieveData(Moon spaceObject, Star spaceObject2)
        {
            MessageBox.Show("Невозможно связать объект типа 'Луна' с объектом типа 'Звезда'.");
        }
        public void RecieveData(Moon spaceObject, StarSystem spaceObject2)
        {
            MessageBox.Show("Невозможно связать объект типа 'Луна' с объектом типа 'Звездная система'.");
        }


        // Обработка привязки Планеты
        public void RecieveData(Planet spaceObject, Moon spaceObject2)
        {
            // Проверяем, не привязана ли луна уже к какой-то планете, если да, то удаляем ссылку на неё у той планеты.
            if (spaceObject2.ParentPlanet.Name != "Не указано")
            {
                Planet tempParent = spaceObject2.ParentPlanet;
                tempParent.ChildrenMoons.Remove(spaceObject2);
                if (tempParent.ChildrenMoons.Count == 0)
                {
                    tempParent.ChildrenMoons.Add(new Moon("Не указано"));
                }
                spaceObject2.ParentPlanet = new Planet("Не указано");
                // Проверяем не была ли луна привязана к переданной планете, если да, то дальнейшие действия не требуются.
                if (tempParent.Name == spaceObject.Name) { return; }
            }

            spaceObject2.ParentPlanet = spaceObject;

            if (spaceObject.ChildrenMoons[0].Name == "Не указано")
            {
                spaceObject.ChildrenMoons[0] = spaceObject2;
            }
            else
            {
                spaceObject.ChildrenMoons.Add(spaceObject2);
            }
        }
        public void RecieveData(Planet spaceObject, Planet spaceObject2)
        {
            MessageBox.Show("Невозможно связать два объекта одного типа.");
        }
        public void RecieveData(Planet spaceObject, Star spaceObject2)
        {
            // Проверяем, не привязана ли планета уже к какой-то звезде, если да, то удаляем ссылку на неё у той звезды.
            if (spaceObject.ParentStar.Name != "Не указано")
            {
                Star tempParent = spaceObject.ParentStar;
                tempParent.ChildrenPlanets.Remove(spaceObject);
                if (tempParent.ChildrenPlanets.Count == 0)
                {
                    tempParent.ChildrenPlanets.Add(new Planet("Не указано"));
                }
                spaceObject.ParentStar = new Star("Не указано");
                // Проверяем не была ли планета привязана к переданной звезде, если да, то дальнейшие действия не требуются.
                if (tempParent.Name == spaceObject2.Name) { return; }
            }

            spaceObject.ParentStar = spaceObject2;
            if (spaceObject2.ChildrenPlanets[0].Name == "Не указано")
            {
                spaceObject2.ChildrenPlanets[0] = spaceObject;
            }
            else
            {
                spaceObject2.ChildrenPlanets.Add(spaceObject);
            }
        }
        public void RecieveData(Planet spaceObject, StarSystem spaceObject2)
        {
            MessageBox.Show("Невозможно связать объект типа 'Планета' с объектом типа 'Звездная система'.");
        }


        //Обработка привязки звезды
        public void RecieveData(Star spaceObject, Moon spaceObject2)
        {
            MessageBox.Show("Невозможно связать объект типа 'Звезда' с объектом типа 'Луна'.");
        }
        public void RecieveData(Star spaceObject, Planet spaceObject2)
        {
            // Проверяем, не привязана ли планета уже к какой-то звезде, если да, то удаляем ссылку на неё у той звезды.
            if (spaceObject2.ParentStar.Name != "Не указано")
            {
                Star tempParent = spaceObject2.ParentStar;
                tempParent.ChildrenPlanets.Remove(spaceObject2);
                if (tempParent.ChildrenPlanets.Count == 0)
                {
                    tempParent.ChildrenPlanets.Add(new Planet("Не указано"));
                }
                spaceObject2.ParentStar = new Star("Не указано");
                // Проверяем не была ли планета привязана к переданной звезде, если да, то дальнейшие действия не требуются.
                if (tempParent.Name == spaceObject.Name) { return; }
            }

            spaceObject2.ParentStar = spaceObject;
            if (spaceObject.ChildrenPlanets[0].Name == "Не указано")
            {
                spaceObject.ChildrenPlanets[0] = spaceObject2;
            }
            else
            {
                spaceObject.ChildrenPlanets.Add(spaceObject2);
            }
        }
        public void RecieveData(Star spaceObject, Star spaceObject2)
        {
            MessageBox.Show("Невозможно связать два объекта одного типа.");
        }
        public void RecieveData(Star spaceObject, StarSystem spaceObject2)
        {
            // Проверяем, не привязана ли звезда уже к какой-то звездной системе, если да, то удаляем ссылку на неё у той системы.
            if (spaceObject.ParentStarSystem.Name != "Не указано")
            {
                StarSystem tempParent = spaceObject.ParentStarSystem;
                tempParent.ChildrenStars.Remove(spaceObject);
                if (tempParent.ChildrenStars.Count == 0)
                {
                    tempParent.ChildrenStars.Add(new Star("Не указано"));
                }
                spaceObject.ParentStarSystem = new StarSystem("Не указано");
                // Проверяем не была ли звезда привязана к переданной звездной системе, если да, то
                // дальнейшие действия не требуются.
                if (tempParent.Name == spaceObject2.Name) { return; }
            }

            spaceObject.ParentStarSystem = spaceObject2;
            if (spaceObject2.ChildrenStars[0].Name == "Не указано")
            {
                spaceObject2.ChildrenStars[0] = spaceObject;
            }
            else
            {
                spaceObject2.ChildrenStars.Add(spaceObject);
            }
        }

        //Обработка привязки звездной системы
        public void RecieveData(StarSystem spaceObject, Moon spaceObject2)
        {
            MessageBox.Show("Невозможно связать объект типа 'Звездная система' с объектом типа 'Луна'.");
        }
        public void RecieveData(StarSystem spaceObject, Planet spaceObject2)
        {
            MessageBox.Show("Невозможно связать объект типа 'Звездная система' с объектом типа 'Планета'.");
        }
        public void RecieveData(StarSystem spaceObject, Star spaceObject2)
        {
            // Проверяем, не привязана ли звезда уже к какой-то звездной системе, если да, то удаляем ссылку на неё у той звездной системы.
            if (spaceObject2.ParentStarSystem.Name != "Не указано")
            {
                StarSystem tempParent = spaceObject2.ParentStarSystem;
                tempParent.ChildrenStars.Remove(spaceObject2);
                if (tempParent.ChildrenStars.Count == 0)
                {
                    tempParent.ChildrenStars.Add(new Star("Не указано"));
                }
                spaceObject2.ParentStarSystem = new StarSystem("Не указано");
                // Проверяем не была ли звезда привязана к переданной звездной системе, если да, то дальнейшие действия не требуются.
                if (tempParent.Name == spaceObject.Name) { return; }
            }

            spaceObject2.ParentStarSystem = spaceObject;
            if (spaceObject.ChildrenStars[0].Name == "Не указано")
            {
                spaceObject.ChildrenStars[0] = spaceObject2;
            }
            else
            {
                spaceObject.ChildrenStars.Add(spaceObject2);
            }
        }
        public void RecieveData(StarSystem spaceObject, StarSystem spaceObject2)
        {
            MessageBox.Show("Невозможно связать два объекта одного типа.");
        }
        private void FormRegistration_Activated(object sender, EventArgs e)
        {
            objects.ResetBindings();
        }
        private void deleteSpaceObjectFromLists(string objectName)
        {
            for (int i = 0; i < moons.Count; i++)
            {
                if (moons[i].Name == objectName)
                {
                    moons.RemoveAt(i);
                }
            }
            for (int i = 0; i < planets.Count; i++)
            {
                if (planets[i].Name == objectName)
                {
                    planets.RemoveAt(i);
                }
            }
            for (int i = 0; i < stars.Count; i++)
            {
                if (stars[i].Name == objectName)
                {
                    stars.RemoveAt(i);
                }
            }
            for (int i = 0; i < starSystems.Count; i++)
            {
                if (starSystems[i].Name == objectName)
                {
                    starSystems.RemoveAt(i);
                }
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            string objectName = listBox1.SelectedValue.ToString();
            deleteSpaceObjectFromLists(objectName);
            objects.RemoveAt(listBox1.SelectedIndex);

        }
    }

}