// Author: Matthew Alexander Prinsloo
// Student Number: ST10081850
// Subject code: PROG7312
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
    public partial class FrmIAGame : Form
    {
        //Create an object of FrmMainMenu
        private FrmMainMenu MainMenu;
        //Form that is called when the user wishes to return back to the main menu,
        //endApplication is false so it simply closes this form.
        private FrmClose frmClose = new FrmClose(message: "Are you sure you want close this window?", endApplication: false);
        //List of tutorial images
        private List<Image> TutImages = new List<Image>();
        //-----------------------------------------------------------------------------------------------//     
        /// <summary>
        /// Paramaterised Constructor, we pass 
        /// </summary>
        /// <param name="mainMenu"></param>
        public FrmIAGame(FrmMainMenu mainMenu)
        {
            InitializeComponent();
            this.MainMenu = mainMenu;
            //Subscribed to event handler that is triggered by CntrlIAGame.
            cntrlIAGame1.GameOver += IAGame_GameOver;
            //Subscribed to event handler that is triggered by frmClose.
            this.frmClose.GoBack += Goback;
            //Add all tutorial images to list
            this.TutImages.Add(Properties.Resources.IAStartGame);
            this.TutImages.Add(Properties.Resources.IAColorSelect);
            this.TutImages.Add(Properties.Resources.IAApplyColor);
            this.TutImages.Add(Properties.Resources.IAMatchingQtoA);
            this.TutImages.Add(Properties.Resources.IAMatchingReassign);
            this.TutImages.Add(Properties.Resources.IAScoreTimeAdd);
            this.TutImages.Add(Properties.Resources.IANewPrompts);
        }
        //-----------------------------------------------------------------------------------------------//
        #region Form Operations
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Back button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            Back();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Tutorial button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTutorial_Click(object sender, EventArgs e)
        {
            LoadTutorial();
        }
        #endregion
        //-----------------------------------------------------------------------------------------------//
        #region Methods
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// This method opens fromClose on a stack.
        /// </summary>
        public void Back()
        {
            this.frmClose.ShowDialog();
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
            this.cntrlIAGame1.StopTimeTimer();
            this.Close();
        }        
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Event that is triggered when the game on IAGame is over.
        /// Updates the leaderboard if called.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IAGame_GameOver(object sender, EventArgs e)
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
            this.MainMenu.LbDisplayTxtName = "IAScoreDisplay.txt";
            this.MainMenu.UpdateCntrlLeaderboard("Identifying Areas");
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Shows the tutorial Form and loads images into it
        /// </summary>
        private void LoadTutorial()
        {
            FrmTutorial tutorial = new FrmTutorial();
            tutorial.LoadImages(this.TutImages);
            tutorial.Show();
        }
        #endregion
    }
}
//===============================================================================================//