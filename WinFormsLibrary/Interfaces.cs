using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary
{
    public interface ISpaceObjectsRegistration
    {
        string Name { get; set; }

    }

    public interface ISpaceObjectRegistration2
    {
        long Age { get; }

        string Photo { get; set; }

        Image Img { get; }

        void setPhoto(string photo, bool isRead);

        void showPhoto(PictureBox box);

        Image getImageFromPath(string path);
    }
}
