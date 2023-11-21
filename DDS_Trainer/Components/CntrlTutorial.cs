// Author: Matthew Alexander Prinsloo
// Student Number: ST10081850
// Subject code: PROG7312
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
        //Finish Tutorial is to handle when the tutorial has been finished.
        public event EventHandler FinishTutorial;
        //current tutorial index
        private int currentIndex = 0;
        //List of tutorial images
        private List<Image> TutImages = new List<Image>();
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Default constructor
        /// </summary>
        public CntrlTutorial()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Load images into the image list
        /// set the pbTutorial background to the first image
        /// </summary>
        /// <param name="images"></param>
        public void LoadImages(List<Image> images) 
        {
            TutImages = images;
            pbTutorial.BackgroundImage = TutImages[0];
            //Previous is disabled as there is no image before 0
            btnPrevious.Visible = false;
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// When the right arrow is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            //-1 because 0 indexed
            if (currentIndex != TutImages.Count - 1)
            {
                //Set the background image to the next image
                currentIndex++;
                pbTutorial.BackgroundImage = TutImages[currentIndex];
                btnPrevious.Visible = true;
            }
            //Disable button if equal to 0
            if (currentIndex == TutImages.Count- 1)
            {
                btnNext.Visible = false;
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// When the left arrow is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex != 0)
            {
                //Set the background image to the previous image
                currentIndex--;
                pbTutorial.BackgroundImage = TutImages[currentIndex];
                btnNext.Visible = true;
            }
            //Disable button if equal to 0
            if (currentIndex == 0)
            {
                btnPrevious.Visible = false;
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// When the finish button is clicked invoke the finishTutorial event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.FinishTutorial?.Invoke(this, EventArgs.Empty);
        }
    }
}
//===============================================================================================//