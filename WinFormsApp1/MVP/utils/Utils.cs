using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WinFormsLibrary.classes;

namespace WinFormsLibrary.utils
{
    public static class Utils
    {
        // Метод для записи лога в файл.
        public static void writeLog(string log)
        {
            string logging_path = "C:\\Users\\Daniil\\source\\repos\\WinFormsApp1\\WinFormsApp1\\logs.txt";
            StreamWriter streamWriter = new StreamWriter(logging_path, true);
            streamWriter.WriteLine(log);
            streamWriter.Close();
        }
        //Метод для получения нужной подстроки из строки с цветом объекта
        static string getParsedColorFromString(string colorString)
        {
            if (colorString.StartsWith("Color [") && colorString.EndsWith("]"))
            {
                string colorName = colorString.Substring(7, colorString.Length - 8); // Extract the color name
                return colorName;
            }
            else
            {
                return ""; // Return Color.Empty for an invalid format
            }
        }
        //Метод для получения цвет из строки
        internal static Color ParseColor(string input, string Name)
        {
            string color = getParsedColorFromString(input);
            Color parsedColor = Color.FromName(color);
            if (!color.Contains("="))
            {
                return parsedColor;
            }
            else
            {
                try
                {
                    string[] argbValues = color.Split(", ");
                    if (argbValues.Length == 4)
                    {
                        int a = int.Parse(argbValues[0].Substring(2, argbValues[0].Length - 2));
                        int r = int.Parse(argbValues[1].Substring(2, argbValues[1].Length - 2));
                        int g = int.Parse(argbValues[2].Substring(2, argbValues[2].Length - 2));
                        int b = int.Parse(argbValues[3].Substring(2, argbValues[3].Length - 2));
                        return Color.FromArgb(a, r, g, b);
                    }
                    else
                    {
                        writeLog($"{DateTime.Now}. У объекта с именем {Name} произошла ошибка(недопустимый формат цвета) чтения цвета из файла с данными");
                        return Color.White;
                    }
                }

                catch (Exception ex)
                {
                    writeLog($"{DateTime.Now}. У объекта с именем {Name} произошла ошибка({ex.Message}) чтения цвета из файла с данными");
                    return Color.White;
                }
            }
        }

        //Объявляется шаблонный метод Join, который принимает разделитель (separator) и список объектов соответствующего типа
        //(звезд, планет или лун, наследники SpaceObject).
        //Этот метод используется для объединения информации об объектах в строку с использованием заданного разделителя.
        public static string Join<T>(string separator, List<T> objects) where T : SpaceObject
        {
            string result_string = objects[0].Name;
            for (int i = 1; i < objects.Count; i++)
            {
                result_string += separator + objects[i].Name;
            }
            return result_string;
        }
    }
}
