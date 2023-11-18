// Author: Matthew Alexander Prinsloo
// Student Number: ST10081850
// Subject code: PROG7312
using DDSLibrary;
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

namespace DDS_Trainer.Components
{
    public partial class CntrlLeaderboard : UserControl
    {
        //Filemanager being initialised
        FileManager fileManager = new FileManager();
        //name of the text file holding the display info for Replacing Books
        private string RBGameDisplayFile = "RBScoreDisplay.txt";
        //name of the text file holding the display info for Identifying Areas
        private string IAGameDisplayFile = "IAScoreDisplay.txt";
        //name of the text file holding the display info for Finding Call Numbers
        private string FCNGameDisplayFile = "FCNScoreDisplay.txt";
        //string for the name of the game being displayed in the leaderboard
        private string CurrentGame = "";
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Default constructor
        /// </summary>
        public CntrlLeaderboard()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------------------------------------------//
        #region Form Operations
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Next button is clicked, arrow right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            NextLeaderboard();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Previous button is clicked, arrow left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PreviousLeaderboard();
        }
        #endregion
        //-----------------------------------------------------------------------------------------------//
        #region Methods
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Updates the rich text, ie the leaderboard.
        /// Source file is what will be read from when updating the leaderboard.
        /// </summary>
        /// <param name="SourceFileName"></param>
        public void UpdateLeaderBoard(string SourceFileName, string GameName) 
        {
            rtLeaderboard.Clear();
            //Sets template
            txtLeaderboardTitle.Text = GameName + "\r\n Leaderboard";
            this.CurrentGame = GameName;
            rtLeaderboard.Text = "RANK\tSCORE\tNAME\r\n";
            //Uses filemanager to read from the text file.
            this.fileManager.ReadFromFile(FileName: SourceFileName);
            for (int counter = 0; counter < this.fileManager.ReadFromFile(FileName: SourceFileName).Count; counter++)
            {
                rtLeaderboard.Text += this.fileManager.ReadFromFile(FileName: SourceFileName)[counter] + "\r\n";
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Switch with logic on going to next games Leaderboard 
        /// </summary>
        private void NextLeaderboard() 
        {
            switch (this.CurrentGame)
            {
                case "Replacing Books":
                    UpdateLeaderBoard(this.IAGameDisplayFile, "Identifying Areas");
                    break;
                case "Identifying Areas":
                    UpdateLeaderBoard(this.FCNGameDisplayFile, "Finding Call Numbers");
                    break;
                case "Finding Call Numbers":
                    UpdateLeaderBoard(this.RBGameDisplayFile, "Replacing Books");
                    break;
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Switch with logic on going to previous games Leaderboard 
        /// </summary>
        private void PreviousLeaderboard() 
        {
            switch (this.CurrentGame)
            {
                case "Replacing Books":
                    UpdateLeaderBoard(this.FCNGameDisplayFile, "Finding Call Numbers"); 
                    break;
                case "Identifying Areas":
                    UpdateLeaderBoard(this.RBGameDisplayFile, "Replacing Books");
                    break;
                case "Finding Call Numbers":
                    UpdateLeaderBoard(this.IAGameDisplayFile, "Identifying Areas");
                    break;
            }
        }
        #endregion
    }
}
//===============================================================================================//