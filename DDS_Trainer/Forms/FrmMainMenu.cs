// Author: Matthew Alexander Prinsloo
// Student Number: ST10081850
// Subject code: PROG7312
using DDS_Trainer.Classes;
using DDS_Trainer.Components;
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
    public partial class FrmMainMenu : Form
    {
        //Form that prompts the user if they would like to exit the app.
        private FrmClose frmClose = new FrmClose(message: "Are you sure you want to exit the application?", endApplication: true);
        //Name of the text file used to display info onto the leaderboard user control.
        private string LbDisplayTxtName = "RBScoreDisplay.txt";

        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Default constructor
        /// </summary>
        public FrmMainMenu()
        {
            InitializeComponent();
            //Ensures that the leaderboard is up to date with the text files.
            UpdateCntrlLeaderboard();
            //Event Handler, event triggered by frmClose.
            frmClose.ExitApplicaton += ExitApplication;
        }
        //-----------------------------------------------------------------------------------------------//
        #region Form Operations
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Opens the Form "FrmRBGame"
        /// Displays FrmRBGame on a stack using ShowDialog()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplacingBooks_Click(object sender, EventArgs e)
        {
            //We pass this form into the constructor so that FrmRBGame can have access to updating the leaderboard.
            FrmRBGame frmReplacingBooksGame = new FrmRBGame(this);
            frmReplacingBooksGame.ShowDialog();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Queries user to if they would like to close the application
        /// Displays FrmClose on a stack using ShowDialog()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            frmClose.ShowDialog();
        }
        #endregion

        //-----------------------------------------------------------------------------------------------//
        #region Methods
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Uses a formatted text file to display a leaderbaord in the CntrlLeaderboard user control.
        /// </summary>
        public void UpdateCntrlLeaderboard() 
        {
            cntrlLeaderboard1.UpdateLeaderBoard(LbDisplayTxtName);
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Triggered by frmClose. Closes the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
//===============================================================================================//