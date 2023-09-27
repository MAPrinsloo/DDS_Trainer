// Author: Matthew Alexander Prinsloo
// Student Number: ST10081850
// Subject code: PROG7312
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
    public partial class FrmHighScore : Form
    {
        //Type Delegate to receive the information passes from the user control
        //CntrlHighScore
        public NameEnteredHandler NameEnteredCallback;

        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Default constructor
        /// </summary>
        public FrmHighScore()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------------------------------------------//
        #region Form Operations
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// When cntrlHighScore1 is loaded into the form.
        /// The event handler for returning the player name to FrmRBGame 
        /// will be initiated here.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cntrlHighScore1_Load(object sender, EventArgs e)
        {
            cntrlHighScore1.NameEntered += (enteredName) =>
            {
                //The entered name will be sent back to FrmRBGame
                NameEnteredCallback?.Invoke(enteredName);
                this.Close();
            };
        }
        #endregion
    }
}
//===============================================================================================//
