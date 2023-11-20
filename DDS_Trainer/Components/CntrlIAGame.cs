// Author: Matthew Alexander Prinsloo
// Student Number: ST10081850
// Subject code: PROG7312
using DDS_Trainer.Classes;
using DDS_Trainer.Forms;
using DDSLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace DDS_Trainer.Components
{
    public partial class CntrlIAGame : UserControl
    {
        #region variables
        //List of question labels
        List<Label> QuestionLabelsList = new List<Label>();
        //List of option labels
        List<Label> OptionLabelsList = new List<Label>();
        //Dictionary holding the top level categories and their related descriptions
        private Dictionary<string, string> DeweyCategories = new Dictionary<string, string>()
        {
            {"000","General Knowledge" },
            {"100","Philosophy and Psychology" },
            {"200","Religion" },
            {"300","Social Sciences" },
            {"400","Languages" },
            {"500","Science" },
            {"600","Technology" },
            {"700","Arts and Recreation" },
            {"800","Literature" },
            { "900", "History and Geography" }
        };
        //bool value to check if the user is being questioned on the call numbers
        //false means they're being tested on description
        private bool QuestionCallNumbers = true;
        //Label of the question selected
        private Label QuestionSelected = null;
        //Used for counting down from 30 seconds
        private TimeSpan CountdownTime = TimeSpan.FromSeconds(30);

        //User score starts at 0
        private int Score = 0;
        //Counter to track how many times the +100 points flashed.
        private int ScoreFlashCounter = 0;
        //Limit of players on the leaderboard.
        private int LeaderboardPlayerLimit = 10;
        //Bool to see if the score was added.
        private bool AddedScore = false;
        //String list of the TopPlayers, read from the txt file.
        private List<string> TopPlayers = new List<string>();
        //Int list of the Top Scores, read from the txt fie.
        private List<int> TopScores = new List<int>();
        //List of leaderboard players, holding score and name.
        private List<LeaderboardPLayers> lbPlayersList = null;

        //The name of the txt file that stores the top players score
        private string ScoreTxtName = "IAScore.txt";
        //The name of the txt file that stores the top players name
        private string PlayerTxtName = "IAPlayers.txt";
        //The name of the txt file that stores the format of the leaderboard to be displayed.
        private string ScoreDisplayTxtName = "IAScoreDisplay.txt";
        //Stores the player name. is delegated to later.
        public string PlayerName = "";

        //Filemanager called from the class library. handles txt files
        private DDSLibrary.FileManager fileManager = new DDSLibrary.FileManager();
        //Checks if the game is over, subscribed to by other forms.
        public event EventHandler GameOver;

        //
        private List<string> AnswersList = new List<string>();
        #endregion
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Default Constructor
        /// </summary>
        public CntrlIAGame()
        {
            InitializeComponent();
            InitializeControl();
        }
        //-----------------------------------------------------------------------------------------------//
        #region Form Operations
        //-----------------------------------------------------------------------------------------------//
        #region Question Labels
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Question 1 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblQuestion1_Click(object sender, EventArgs e)
        {
            btnMarker.ImageIndex = 1;
            this.QuestionSelected = lblQuestion1;
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Quesiton 2 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblQuestion2_Click(object sender, EventArgs e)
        {
            btnMarker.ImageIndex = 2;
            this.QuestionSelected = lblQuestion2;
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Question 3 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblQuestion3_Click(object sender, EventArgs e)
        {
            btnMarker.ImageIndex = 3;
            this.QuestionSelected = lblQuestion3;
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Question 4 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblQuestion4_Click(object sender, EventArgs e)
        {
            btnMarker.ImageIndex = 4;
            this.QuestionSelected = lblQuestion4;
        }
        #endregion
        //-----------------------------------------------------------------------------------------------//
        #region Option Labels
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Option 1 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblOption1_Click(object sender, EventArgs e)
        {
            if (this.QuestionSelected != null)
            {
                OptionClicked(this.QuestionSelected, lblOption1);
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Option 2 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblOption2_Click(object sender, EventArgs e)
        {
            if (this.QuestionSelected != null)
            {
                OptionClicked(this.QuestionSelected, lblOption2);
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Option 3 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblOption3_Click(object sender, EventArgs e)
        {
            if (this.QuestionSelected != null)
            {
                OptionClicked(this.QuestionSelected, lblOption3);
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Option 4 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblOption4_Click(object sender, EventArgs e)
        {
            if (this.QuestionSelected != null) 
            {
                OptionClicked(this.QuestionSelected, lblOption4);
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Option 5 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblOption5_Click(object sender, EventArgs e)
        {
            if (this.QuestionSelected != null)
            {
                OptionClicked(this.QuestionSelected, lblOption5);
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Option 6 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblOption6_Click(object sender, EventArgs e)
        {
            if (this.QuestionSelected != null)
            {
                OptionClicked(this.QuestionSelected, lblOption6);
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Option 7 clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblOption7_Click(object sender, EventArgs e)
        {
            if (this.QuestionSelected != null)
            {
                OptionClicked(this.QuestionSelected, lblOption7);
            }
        }
        #endregion
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Does nothing - disabled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMarker_Click(object sender, EventArgs e)
        {
            //disabling it traditionally would gray the colors
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// start game when play button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Timer countdown 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cntrlTimeTimerEvent(object sender, EventArgs e)
        {
            if (this.CountdownTime.TotalSeconds > 0)
            {
                //countdown and update each second. ie 1 sec increments.
                this.CountdownTime = this.CountdownTime.Subtract(TimeSpan.FromSeconds(1));
                UpdateLabel();
            }
            else
            {
                StopTimeTimer();
                StopGame();
            }

            if (this.AddedScore == true)
            {
                lblAddedScore.Visible = !lblAddedScore.Visible;
                lblAddedTime.Visible = !lblAddedTime.Visible;
                this.ScoreFlashCounter++;
            }
            //toggle visible 4 times. (shows twice)
            if (this.ScoreFlashCounter == 4)
            {
                this.ScoreFlashCounter = 0;
                this.AddedScore = false;
            }
        }
        #endregion
        //-----------------------------------------------------------------------------------------------//
        #region Methods
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Initialises the control
        /// </summary>
        private void InitializeControl()
        {
            UpdateLabel();
            TimeTimer.Stop();
            RandomiseImageLists();
            //create the files needed for storing user leaderboard data
            this.fileManager.CreateFile(this.ScoreTxtName);
            this.fileManager.CreateFile(this.ScoreDisplayTxtName);
            this.fileManager.CreateFile(this.PlayerTxtName);
          
            //Add questions labels to List
            QuestionLabelsList.Add(lblQuestion1);
            QuestionLabelsList.Add(lblQuestion2);
            QuestionLabelsList.Add(lblQuestion3);
            QuestionLabelsList.Add(lblQuestion4);

            //AnswersList needs to be initialised with empty data
            //This is done to ensure that answers are in the correct order when being compared to questions
            for (int count = 0; count < QuestionLabelsList.Count; count++)
            {
                this.AnswersList.Add("");
            }

            //Add option labels to List
            OptionLabelsList.Add(lblOption1);
            OptionLabelsList.Add(lblOption2);
            OptionLabelsList.Add(lblOption3);
            OptionLabelsList.Add(lblOption4);
            OptionLabelsList.Add(lblOption5);
            OptionLabelsList.Add(lblOption6);
            OptionLabelsList.Add(lblOption7);


            //Get old game information from txt file
            for (int counter = 0; counter < this.fileManager.ReadFromFile(this.ScoreTxtName).Count; counter++)
            {
                try
                {
                    this.TopScores.Add(Convert.ToInt32(this.fileManager.ReadFromFile(this.ScoreTxtName)[counter]));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }
            //Get old game information from txt file and assign to lbPlayerList
            for (int counter = 0; counter < this.fileManager.ReadFromFile(this.PlayerTxtName).Count; counter++)
            {
                try
                {
                    this.TopPlayers.Add(this.fileManager.ReadFromFile(this.PlayerTxtName)[counter]);
                    if (this.lbPlayersList == null)
                    {
                        this.lbPlayersList = new List<LeaderboardPLayers>();
                    }
                    LeaderboardPLayers lbPlayers = new LeaderboardPLayers(PlayerScore: this.TopScores[counter],
                                                                          PlayerName: this.TopPlayers[counter]);
                    this.lbPlayersList.Add(lbPlayers);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Users is questioned using call numbers and must answer using descriptions
        /// Populates labels stored in QuestionLabelsList and OptionLabelsList
        /// </summary>
        private void GenerateQuestions_CallNum()
        {
            Random random = new Random();
            //string list of keys assigned to questions
            List<string> questionKeyList = new List<string>();
            //keys stores the keys of the dictionary DeweyCategories - can safely remove used keys without tampering with source
            List<string> keys = this.DeweyCategories.Keys.ToList();
            //populate with OptionLabelsList - used to remove already populated option labels without tampering with source
            List<Label> tempOptionLabels = this.OptionLabelsList.ToList();
            //randomise the index
            var randomIndex = 0;

            //Populates question labels with random keys
            for (int counter = 0; counter < this.QuestionLabelsList.Count; counter++)
            {
                randomIndex = random.Next(minValue: 0, maxValue: keys.Count);
                this.QuestionLabelsList[counter].Text = keys[randomIndex];
                questionKeyList.Add(this.QuestionLabelsList[counter].Text);
                //Remove to ensure no duplicates occur
                keys.RemoveAt(randomIndex);
            }

            //Populates options with descriptions
            for (int counter = 0; counter < this.OptionLabelsList.Count; counter++)
            {
                var minValue = 0;
                var maxValue = tempOptionLabels.Count;

                //Random options receive correct answers relating to questionKeyList
                if (counter < questionKeyList.Count)
                {
                    randomIndex = random.Next(minValue, maxValue);
                    //Use dictionary to convert question callnum to description
                    tempOptionLabels[randomIndex].Text = this.DeweyCategories[questionKeyList[counter]];
                    //Remove to ensure all options are populated
                    tempOptionLabels.RemoveAt(randomIndex);
                }
                //Remaining options receive incorrect answers
                else
                {
                    randomIndex = random.Next(minValue, maxValue);
                    //Use dictionary to convert key callnum to description
                    tempOptionLabels[randomIndex].Text = this.DeweyCategories[keys[randomIndex]];
                    //Remove to ensure all options are populated
                    tempOptionLabels.RemoveAt(randomIndex);
                    //Remove to ensure no duplicates occur
                    keys.RemoveAt(randomIndex);
                }
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Users is questioned using descriptions and must answer using call numbers
        /// Populates labels stored in QuestionLabelsList and OptionLabelsList
        /// </summary>
        private void GenerateQuestions_Description()
        {
            Random random = new Random();
            //string list of keys assigned to questions
            List<string> questionKeyList = new List<string>();
            //keys stores the keys of the dictionary DeweyCategories - can safely remove used keys without tampering with source
            List<string> keys = this.DeweyCategories.Keys.ToList();
            //populate with OptionLabelsList - used to remove already populated option labels without tampering with source
            List<Label> tempOptionLabels = this.OptionLabelsList.ToList();
            //randomise the index
            var randomIndex = 0;

            //Populates question labels with random descriptions
            for (int counter = 0; counter < this.QuestionLabelsList.Count; counter++)
            {
                randomIndex = random.Next(minValue: 0, maxValue: keys.Count);
                //Use dictionary to convert Random key to description
                this.QuestionLabelsList[counter].Text = this.DeweyCategories[keys[randomIndex]];
                //Save keys to QuestionKeyList to assign to random options
                questionKeyList.Add(keys[randomIndex]);
                //Remove to ensure no duplicates occur
                keys.RemoveAt(randomIndex);
            }

            //Populates options with keys
            for (int counter = 0; counter < this.OptionLabelsList.Count; counter++)
            {
                var minValue = 0;
                var maxValue = tempOptionLabels.Count;

                //Random options receive correct answers relating to questionKeyList
                if (counter < questionKeyList.Count)
                {
                    randomIndex = random.Next(minValue, maxValue);
                    //Remove to ensure all options are populated
                    tempOptionLabels[randomIndex].Text = questionKeyList[counter];
                    //Remove to ensure no duplicates occur
                    tempOptionLabels.RemoveAt(randomIndex);
                }
                //Remaining options receive incorrect answers
                else
                {
                    randomIndex = random.Next(minValue, maxValue);
                    //Assign an unsused (incorrect) key to an option
                    tempOptionLabels[randomIndex].Text = keys[randomIndex];
                    //Remove to ensure all options are populated
                    tempOptionLabels.RemoveAt(randomIndex);
                    //Remove to ensure no duplicates occur
                    keys.RemoveAt(randomIndex);
                }
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Clears all the 
        /// </summary>
        private void ClearAllLabelText()
        {
            for (int count = 0; count < this.QuestionLabelsList.Count; count++)
            {
                this.QuestionLabelsList[count].Text = "";
            }

            for (int count = 0; count < this.OptionLabelsList.Count; count++)
            {
                this.OptionLabelsList[count].Text = "";
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Toggle the visibility on the components of the control.
        /// </summary>
        private void ToggleVisibility()
        {
            for (int count = 0; count < this.QuestionLabelsList.Count; count++)
            {
                this.QuestionLabelsList[count].Visible = !QuestionLabelsList[count].Visible;
            }

            for (int count = 0; count < this.OptionLabelsList.Count; count++)
            {
                this.OptionLabelsList[count].Visible = !this.OptionLabelsList[count].Visible;
            }

            btnPlay.Visible = !btnPlay.Visible;
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// When an option is clicked, pass the question and option selected.
        /// will assign questions image index to options image index.
        /// Will perform a check to see when to check the answers submitted.
        /// </summary>
        /// <param name="question"></param>
        /// <param name="option"></param>
        private void OptionClicked(Label question, Label option)
        {
            var optionsMarked = 0;
            //iterate through all options
            for (int counter = 0; counter < this.OptionLabelsList.Count; counter++)
            {
                //if previous option as been assigned the same Image index - set to 0
                if (this.OptionLabelsList[counter].ImageIndex == question.ImageIndex)
                {
                    this.OptionLabelsList[counter].ImageIndex = 0;
                }
                //count all options that have been assigned a related quetion index.
                if (OptionLabelsList[counter].ImageIndex > 0)
                {
                    optionsMarked++;
                }
            }
            //Assign index to option selected
            option.ImageIndex = question.ImageIndex;
            //Account for the current option being marked
            optionsMarked++;
            //Code has been structed to relate image index to its option,
            //imageindex - 1 is to convert it to the zero based indexing of AnswersList
            this.AnswersList[question.ImageIndex - 1] = option.Text;
            //if the amount of options marked = the amount of questions asked then check answers
            if (optionsMarked == QuestionLabelsList.Count)
            {
                CheckAnswers();
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Checks if the answers selected are correct
        /// Checks AnswerList against QuestionLabelsList
        /// </summary>
        private void CheckAnswers() 
        {
            try
            {
                var isCorrect = true;
                //If the call numbers are being questioned
                if (this.QuestionCallNumbers == true)
                {
                    //iterate through all question labels
                    for (int counter = 0; counter < this.QuestionLabelsList.Count; counter++)
                    {
                        //convert Question label text key to description using dictionary
                        //if they do not match, set isCorrect to false
                        if (this.DeweyCategories[this.QuestionLabelsList[counter].Text] != this.AnswersList[counter]) 
                        { 
                            isCorrect = false; 
                        }
                    }
                }
                //If the descriptions are being questioned
                else if (this.QuestionCallNumbers == false)
                {
                    //iterate through all question labels
                    for (int counter = 0; counter < this.QuestionLabelsList.Count; counter++)
                    {
                        //convert AnswerList text key to description using dictionary
                        //if they do not match, set isCorrect to false
                        if (this.QuestionLabelsList[counter].Text != this.DeweyCategories[this.AnswersList[counter]]) 
                        { 
                            isCorrect = false; 
                        }
                    }
                }
                //If the asnwers are correct tally the score
                if (isCorrect == true)
                {
                    this.Score += 100;
                    this.AddedScore = true;
                    lblScore.Text = "SCORE: " + this.Score;
                    this.CountdownTime += TimeSpan.FromSeconds(10);
                    ResetGame();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Updates the label as the timer counts down
        /// </summary>
        private void UpdateLabel()
        {
            lblTime.Text = "TIME: " + this.CountdownTime.ToString(@"mm\:ss");
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Can be called to stop the 2 minute countdown timer.
        /// </summary>
        public void StopTimeTimer()
        {
            TimeTimer.Stop();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Stops the game, tallies score and resets values.
        /// </summary>
        private void StopGame()
        {
            btnPlay.Enabled = true;
            ToggleVisibility();
            ResetOptionImages();
            this.QuestionSelected = null;
            this.CountdownTime = TimeSpan.FromSeconds(30);
            ResetGame();
            for (int counter = 0; counter < this.TopScores.Count; counter++)
            {
                if (this.TopScores.Count <= this.LeaderboardPlayerLimit - 1)
                {
                    NewHighScore();
                    UpdateLeaderboard();
                    break;
                }
                if (this.Score > this.TopScores[counter])
                {
                    NewHighScore();
                    UpdateLeaderboard();
                    break;
                }
            }
            if (this.TopScores.Count == 0)
            {
                NewHighScore();
                UpdateLeaderboard();
            }
            this.Score = 0;
            btnMarker.ImageIndex = 0;
            this.Invalidate();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// When the user achieves a new high score.
        /// Form is shown promting player to enter 3 intitials
        /// </summary>
        private void NewHighScore()
        {
            FrmHighScore frmHighScore = new FrmHighScore();

            //Delegate assinged. 
            frmHighScore.NameEnteredCallback = GetNameFromCntrlHighScore;

            frmHighScore.ShowDialog();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Updates the leaderboard by processing all the inforation
        /// this means:
        /// recreating the txt files used to operate the application
        /// as well as display the scores to the leaderboard.
        /// The game over event is called to signal to the subscribers that
        /// the game is over and should update the control that shows the leaderboard.
        /// </summary>
        private void UpdateLeaderboard()
        {
            //Can use DDSLibrary sorting class to use an actual algorithm
            //https://stackoverflow.com/questions/3309188/how-to-sort-a-listt-by-a-property-in-the-object
            List<LeaderboardPLayers> SortedLbPlayers = this.lbPlayersList.OrderByDescending(p => p.score).ToList();


            if (SortedLbPlayers.Count > this.LeaderboardPlayerLimit - 1)
            {
                for (int counter = this.LeaderboardPlayerLimit - 1; counter < SortedLbPlayers.Count; counter++)
                {
                    int lastScoreIndex = SortedLbPlayers.Count - 1;
                    SortedLbPlayers.RemoveAt(lastScoreIndex);
                }
            }


            //Recreate and write all to file.
            if (this.fileManager.RecreateFile(this.ScoreTxtName) == true &&
                this.fileManager.RecreateFile(this.ScoreDisplayTxtName) == true &&
                this.fileManager.RecreateFile(this.PlayerTxtName) == true)
            {
                for (int counter = 0; counter < SortedLbPlayers.Count; counter++)
                {
                    var rank = counter + 1;
                    this.fileManager.WriteToFile(FileName: this.ScoreTxtName,
                                            ContentToWrite: Convert.ToString(SortedLbPlayers[counter].score));

                    this.fileManager.WriteToFile(FileName: this.PlayerTxtName,
                                            ContentToWrite: SortedLbPlayers[counter].name);
                    if (this.Score >= 1000)
                    {
                        this.fileManager.WriteToFile(FileName: this.ScoreDisplayTxtName,
                                            ContentToWrite: rank + "\t\t" + SortedLbPlayers[counter].score.ToString() + "\t" + SortedLbPlayers[counter].name);
                    }
                    if (this.Score < 1000)
                    {
                        this.fileManager.WriteToFile(FileName: this.ScoreDisplayTxtName,
                                            ContentToWrite: rank + "\t\t" + SortedLbPlayers[counter].score.ToString() + "\t\t" + SortedLbPlayers[counter].name);
                    }
                }
            }
            this.GameOver?.Invoke(this, EventArgs.Empty);
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Initials are delegated back and processed here.
        /// </summary>
        /// <param name="enteredName"></param>
        private void GetNameFromCntrlHighScore(string enteredName)
        {
            this.PlayerName = enteredName;

            LeaderboardPLayers newPlayer = new LeaderboardPLayers(PlayerScore: this.Score, PlayerName: this.PlayerName);
            if (this.lbPlayersList == null)
            {
                this.lbPlayersList = new List<LeaderboardPLayers>();
            }
            this.lbPlayersList.Add(newPlayer);

            UpdateLeaderboard();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Resets the game
        /// </summary>
        private void ResetGame()
        {
            ClearAllLabelText();
            ResetOptionImages();
            RandomiseImageLists();
            this.QuestionSelected = null;
            btnMarker.ImageIndex = 0;
            this.QuestionCallNumbers = !this.QuestionCallNumbers;
            if (this.QuestionCallNumbers == true)
            {
                GenerateQuestions_CallNum();
            }
            else if (this.QuestionCallNumbers == false)
            {
                GenerateQuestions_Description();
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Called when the user starts the game.
        /// </summary>
        private void StartGame()
        {
            btnPlay.Enabled = false;
            lblScore.Text = "SCORE: " + this.Score;
            ToggleVisibility();
            ClearAllLabelText();
            GenerateQuestions_CallNum();
            TimeTimer.Start();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Resets all the options in OptionLabelsList to image index 0.
        /// Image index 0 should be a blank/empty image.
        /// </summary>
        private void ResetOptionImages()
        {
            for (int count = 0; count < OptionLabelsList.Count; count++)
            {
                this.OptionLabelsList[count].ImageIndex = 0;
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Randomises the assets used in coloring the labels and marker image
        /// </summary>
        private void RandomiseImageLists() 
        {
            Random random = new Random();
            List <int> indexList = new List<int>();
            List<Image> newColorImages = new List<Image>();
            List<Image> newMarkerImages = new List<Image>();
            //populate index list and image lists
            //count is 1 to avoid the gray default marker for startup
            for (int count = 1; count < ilMarkers.Images.Count; count++)
            {
                //Initialise with temp image
                newColorImages.Add(ilMarkers.Images[count]);
                newMarkerImages.Add(ilMarkers.Images[count]);
                //set up index list
                indexList.Add(count);
            }
            //Randomise images into indexes of the image lists
            //count is 1 to avoid the gray default marker for startup
            for (int count = 1; count < ilMarkers.Images.Count; count++)
            {
                var minValue = 0;
                var maxValue = indexList.Count;
                var randomIndex = random.Next(minValue, maxValue);
                //count - 1 because 0 based
                newColorImages[count - 1] = ilColorMarks.Images[indexList[randomIndex]];
                newMarkerImages[count - 1] = ilMarkers.Images[indexList[randomIndex]];
                indexList.RemoveAt(randomIndex);
            }
            //set the image list components to the new image list
            //count is 1 to avoid the gray default marker for startup
            for (int count = 1; count < ilMarkers.Images.Count; count++)
            {
                //count - 1 because 0 based
                ilColorMarks.Images[count] = newColorImages[count - 1];
                ilMarkers.Images[count] = newMarkerImages[count - 1];
            }
        }
        #endregion
    }
}
//===============================================================================================//
///References
///https://www.c-sharpcorner.com/UploadFile/mahesh/dictionary-in-C-Sharp/
///Using dictionaries