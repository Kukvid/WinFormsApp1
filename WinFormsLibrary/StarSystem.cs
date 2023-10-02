using WinFormsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace WinFormsLibrary
{
    public class StarSystem
    {

        /// <remarks>Имя системы</remarks>
        private string name;
        public string Name {
            get { return name; }
            set
            {
                if (value[0].ToString().ToUpper() == value[0].ToString())
                {
                    name = value;
                }
                else
                {
                    string temp = "";
                    temp += value[0].ToString().ToUpper();
                    for (int i = 1; i < value.Length; i++)
                    {
                        temp += value[i];
                    }
                    name = temp;
                }
            }
        }
        public long Age { get; private set; } = 400000000;

        private int countStars = 0;

        public int CountStars
        {
            //убрать private
            get { return countStars; }
            set
            {
                if (value > 0)
                {
                    countStars = value;
                }
                else
                {
                    countStars = 1;
                }
            }
        }

        private decimal countUniverses = (decimal)4e12;
        public decimal CountUniverses => countUniverses;

        /// <remarks>Возраст системы</remarks>

        /// <remarks>Цвет звезды</remarks>
        public Color starColor { get; set; }

        //public Color StarColor => starColor;

        //public static Color AdditionalColor { get; }

        public static Color AdditionalColor { get; } = Color.Black;

        private DateTime dateOfDiscovery;

        public DateTime DateOfDiscovery
        {
            get { return dateOfDiscovery; }
            set
            {
                if (value > DateTime.Now)
                {
                    dateOfDiscovery = DateTime.Parse(DateTime.Now.ToString("dd.MM.yyyy HH:mm"));

                }
                else
                {
                    dateOfDiscovery = DateTime.Parse(value.ToString("dd.MM.yyyy HH:mm"));
                }
            }
        }

        private string photo = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\media\\default-star-system.jpg";

        public string Photo{
            get { return photo; }
            set { 
                if (value != "") {
                    photo = value;
                }
            }
        }
        public int getCountStars()
        {
            return countStars;
        }

        public void setAge(long age)
        {
            this.Age = age;
        }
        
        public void showPhoto(PictureBox box)
        {
            Graphics g = Graphics.FromHwnd(box.Handle);
            g.DrawImage(Image.FromFile(this.photo), new Rectangle(0,0,box.Width,box.Height));
        }

        public StarSystem() { }

        public StarSystem(string name)
        {
            this.name = name;
        }
        public StarSystem(string name, string photo)
        {
            this.name = name;
            this.Photo = photo;
        }
        public StarSystem(string name, int CountStars, long Age, DateTime DateOfDiscovery,Color starColor,string photo)
        {
            this.name = name;
            this.CountStars = CountStars;
            this.Age = Age;
            this.DateOfDiscovery = DateOfDiscovery;
            this.starColor= starColor;
            this.Photo = photo;
        }

        /*
        static StarSystem()
        {
            DateTime now = DateTime.Now;
            if (now.DayOfYear % 2 == 0)
            {
                StarSystem.AdditionalColor = Color.Red;
            }
            else
            {
                StarSystem.AdditionalColor = Color.LimeGreen;
            }
        }
        */

    }
}