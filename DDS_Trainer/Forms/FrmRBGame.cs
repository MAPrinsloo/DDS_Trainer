﻿// Author: Matthew Alexander Prinsloo
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
    public partial class FrmRBGame : Form
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
        public FrmRBGame(FrmMainMenu mainMenu)
        {
            InitializeComponent();
            this.MainMenu = mainMenu;
            //Subscribed to event handler that is triggered by CntrlRBGame.
            cntrlRBGame1.GameOver += RBGame_GameOver;
            //Subscribed to event handler that is triggered by frmClose.
            frmClose.GoBack += Goback;

        }
        //-----------------------------------------------------------------------------------------------//
        #region Form Operations
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            Back();
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
            frmClose.ShowDialog();
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
            this.cntrlRBGame1.StopTimeTimer();
            this.Close();
        }
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
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Calls the UpdateCntrlLeaderboard method from 
        /// the main menu. The instance that was passed into the constructor will
        /// directly update the form behind this one.
        /// </summary>
        public void UpdateLeaderboard()
        {
            this.MainMenu.UpdateCntrlLeaderboard();
        }
        #endregion
    }
}
//===============================================================================================//