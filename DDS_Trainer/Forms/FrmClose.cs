// Author: Matthew Alexander Prinsloo
// Student Number: ST10081850
// Subject code: PROG7312
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDS_Trainer.Forms
{
    public partial class FrmClose : Form
    {
        //Assigned in Parameterised constructor
        private string DisplayMessage = "";
        //Bool value for checking whether closing is 
        //exiting the form or the application as a whole.
        private bool EndApplicaton = false;
        //Go back is to just close the form
        public event EventHandler GoBack;
        //Exit Applicaton is to exit the application.
        public event EventHandler ExitApplicaton;

        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Defualt constructor
        /// </summary>
        public FrmClose()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Parameterised constructor
        /// Must pass a message to query user 
        /// and pass a bool for if the app should close entirely or 
        /// just the form it is on.
        /// Subcribe to GoBack and/or ExitApplicaton event handlers.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="endApplication"></param>
        public FrmClose(string message, bool endApplication) 
        {
            InitializeComponent();
            DisplayMessage = message;
            EndApplicaton = endApplication;

            //Assign the closing message to the rich text.
            rtDisplay.Text = message;

            //Change button to the image stored in the image list.
            //If the condition is met,
            //The image will say back instead of close.
            if (EndApplicaton == false)
            {
                btnExit.BackgroundImage = ilButtonAssets.Images[0];
            }
        }        
        //-----------------------------------------------------------------------------------------------//
        #region Form Operations
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// When the Button no is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// When the button exit is clicked, 
        /// Can appear as a red close button or
        /// a blue back button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        #endregion
        //-----------------------------------------------------------------------------------------------//
        #region Methods
        /// <summary>
        /// Invoked on button exit click. This checks
        /// if the application or form needs to close
        /// or not.
        /// </summary>
        private void Exit() 
        {
            if (this.EndApplicaton == true)
            {
                ExitApplicaton?.Invoke(this, EventArgs.Empty);
            }
            if (this.EndApplicaton == false)
            {
                GoBack?.Invoke(this, EventArgs.Empty);
            }
            this.Close();
        }
        #endregion
    }
}
//===============================================================================================//