using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDS_Trainer.Forms
{
    public partial class FrmTutorial : Form
    {
        //Exit Applicaton is to exit the application.
        public event EventHandler ExitApplicaton;
        public FrmTutorial()
        {
            InitializeComponent();
            cntrlTutorial1.FinishTutorial += Finished;
        }

        /// <summary>
        /// Invoked on button exit click. This checks
        /// if the application or form needs to close
        /// or not.
        /// </summary>
        private void Finished(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadImages(List<Image> images) 
        {
            cntrlTutorial1.LoadImages(images);
        }


        private void cntrlTutorial1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
