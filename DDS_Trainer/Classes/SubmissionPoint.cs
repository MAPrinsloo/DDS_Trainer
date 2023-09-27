using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDS_Trainer.Classes
{
    internal class SubmissionPoint
    {
        public Rectangle Rect { get; set; }
        public bool Occupied { get; set; }
        public string BookLabel { get; set; }

        public SubmissionPoint(Rectangle rect)
        {
            Rect = rect;
            Occupied = false;
            BookLabel = "";
        }
    }
}
///References
///https://youtu.be/1J8-wc8fq8I
///The above code was inspired by the following video.
