using DDS_Trainer.Components;
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
    public partial class FrmFCNGame : Form
    {
        //Create an object of FrmMainMenu
        private FrmMainMenu MainMenu;
        //Form that is called when the user wishes to return back to the main menu,
        //endApplication is false so it simply closes this form.
        private FrmClose frmClose = new FrmClose(message: "Are you sure you want close this window?", endApplication: false);

        //-----------------------------------------------------------------------------------------------//     
        /// <summary>
        /// Paramaterised Constructor, we pass 
        /// </summary>
        /// <param name="mainMenu"></param>
        public FrmFCNGame(FrmMainMenu mainMenu)
        {
            InitializeComponent();
            this.MainMenu = mainMenu;
            //Subscribed to event handler that is triggered by CntrlIAGame.
            cntrlFCNGame1.GameOver += FCNGame_GameOver;
            //Subscribed to event handler that is triggered by frmClose.
            this.frmClose.GoBack += Goback;

        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Default constructor
        /// </summary>
        public FrmFCNGame()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------------------------------------------//
        #region Form Operations
        private void btnBack_Click(object sender, EventArgs e)
        {
            Back();
        }
        #endregion
        //-----------------------------------------------------------------------------------------------//
        #region Methods
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Event that is triggered when the game on FCNGame is over.
        /// Updates the leaderboard if called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FCNGame_GameOver(object sender, EventArgs e)
        {
            UpdateLeaderboard();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Calls the UpdateCntrlLeaderboard method from 
        /// the main menu. The instance that was passed into the constructor will
        /// directly update the form behind this one.
        /// </summary>
        public void UpdateLeaderboard()
        {
            this.MainMenu.LbDisplayTxtName = "FCNScoreDisplay.txt";
            this.MainMenu.UpdateCntrlLeaderboard("Finding Call Numbers");
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Stops the timer on the user control and closes this form
        /// When the event is triggered. Is triggered by frmClose.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Goback(object sender, EventArgs e)
        {
            this.cntrlFCNGame1.StopTimeTimer();
            this.Close();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This method opens fromClose on a stack.
        /// </summary>
        public void Back()
        {
            frmClose.ShowDialog();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Event that is triggered when the game on RBGame is over.
        /// Updates the leaderboard if called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RBGame_GameOver(object sender, EventArgs e)
        {
            UpdateLeaderboard();
        }
        #endregion

        
    }
}
//===============================================================================================//