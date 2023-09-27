using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DDS_Trainer.Classes
{
    internal class Book
    {
        public System.Drawing.Image BookImage;
        public int Width;
        public int Height;
        public Point Position = new Point();
        public bool active = false;
        public Rectangle rect;
        public string Text = "";
        public int TextOffsetX { get; set; }
        public int TextOffsetY { get; set; }
        public bool ShowText { get; set; }
        //negative number because a book cant be placed in a negative submissoin point.
        public int PosSnapped = -1;

        public Book(ImageList bookAssets, byte index, string text) 
        {
            try
            {
                Width = 90;
                Height = 125;
                BookImage = bookAssets.Images[index];
                rect = new Rectangle(Position.X, Position.Y, Width, Height);
                Text = text;
                TextOffsetX = 26;
                TextOffsetY = 30;
            }
            catch (ArgumentOutOfRangeException e)
            {
                Debug.WriteLine(e);
            }
            
        }
    }
}
///References
///https://youtu.be/1J8-wc8fq8I
///The above code was inspired by the following video.
