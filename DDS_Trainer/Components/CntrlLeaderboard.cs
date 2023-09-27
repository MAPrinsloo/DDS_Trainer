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
        FileManager fileManager = new FileManager();
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Default constructor
        /// </summary>
        public CntrlLeaderboard()
        {
            InitializeComponent();
        }
        //-----------------------------------------------------------------------------------------------//
        #region Methods
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Updates the rich text, ie the leaderboard.
        /// Source file is what will be read from when updating the leaderboard.
        /// </summary>
        /// <param name="SourceFileName"></param>
        public void UpdateLeaderBoard(string SourceFileName) 
        {
            rtLeaderboard.Clear();
            //Sets template
            rtLeaderboard.Text = "RANK\tSCORE\tNAME\r\n";
            //Uses filemanager to read from the text file.
            fileManager.ReadFromFile(FileName: SourceFileName);
            for (int counter = 0; counter < fileManager.ReadFromFile(FileName: SourceFileName).Count; counter++)
            {
                rtLeaderboard.Text += fileManager.ReadFromFile(FileName: SourceFileName)[counter] + "\r\n";
            }
        }
       #endregion
    }
}
//===============================================================================================//