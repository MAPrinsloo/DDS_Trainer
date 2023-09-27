// Author: Matthew Alexander Prinsloo
// Student Number: ST10081850
// Subject code: PROG7312
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDS_Trainer.Components
{
    
    public partial class CntrlHighScore : UserControl
    {
        //Delegate for passing the name entered by the user
        public delegate void NameEnteredEventHandler(string name);
        //Event that will be triggered when a name is entered
        public event NameEnteredEventHandler NameEntered;

        //public event EventHandler<string> NameEntered;
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Default constructor
        /// </summary>
        public CntrlHighScore()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------------------------------------------//
        #region Form Operations
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Button used to trigger the Save() method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        #endregion
        //-----------------------------------------------------------------------------------------------//
        #region Methods
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Triggers the NameEntered Event when the user has properly entered their data.
        /// </summary>
        private void Save() 
        {
            if (txtInitials.TextLength > 0) 
            {
                string enteredName = txtInitials.Text;
                NameEntered?.Invoke(enteredName);
            }
        }
        #endregion
    }
}
//===============================================================================================//