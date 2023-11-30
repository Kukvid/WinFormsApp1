using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary
{

    public interface ISpaceObject
    {
        string Name { get; set; }
        long Age { get;}
        
        string Photo { get;}

        Image Img { get; }

        Color SpaceObjectColor { get; set; }

        DateTime DateOfDiscovery { get; set; }

        string GetParsedColorFromString(string colorString);

        Color ParseColor(string input);

        void setAge(long age);
        void setPhoto(string photo, bool isRead);
        void setPhoto(string photo);

        void showPhoto(Form box, string themePhoto);
        void showPhoto(PictureBox box);

        Image getImageFromPath(string path);
    }
}
