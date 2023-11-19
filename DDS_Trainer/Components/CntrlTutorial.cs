using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DDS_Trainer.Components.CntrlHighScore;

namespace DDS_Trainer.Components
{
    
    public partial class CntrlTutorial : UserControl
    {
        //Exit Applicaton is to exit the application.
        public event EventHandler FinishTutorial;
        private int currentIndex = 0;
        private List<Image> TutImages = new List<Image>();
        public CntrlTutorial()
        {
            InitializeComponent();
        }
        public void LoadImages(List<Image> images) 
        {
            TutImages = images;
            pbTutorial.BackgroundImage = TutImages[0];
            btnPrevious.Visible = false;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex != TutImages.Count - 1)
            {
                currentIndex++;
                pbTutorial.BackgroundImage = TutImages[currentIndex];
                btnPrevious.Visible = true;
            }
            if (currentIndex == TutImages.Count- 1)
            {
                btnNext.Visible = false;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex != 0)
            {
                currentIndex--;
                pbTutorial.BackgroundImage = TutImages[currentIndex];
                btnNext.Visible = true;
            }
            if (currentIndex == 0)
            {
                btnPrevious.Visible = false;
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.FinishTutorial?.Invoke(this, EventArgs.Empty);
        }
    }
}
