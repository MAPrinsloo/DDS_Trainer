// Author: Matthew Alexander Prinsloo
// Student Number: ST10081850
// Subject code: PROG7312
using DDS_Trainer.Classes;
using DDS_Trainer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreeNode = DDS_Trainer.Classes.TreeNode;

namespace DDS_Trainer.Components
{
    public partial class CntrlFCNGame : UserControl
    {
        #region variables
        //Checks if the game is over, subscribed to by other forms.
        public event EventHandler GameOver;
        //object of the treemanager class
        private TreeManager treeManager = new TreeManager();
        //object of the treeNode class, holds the full dewey Tree
        private TreeNode TreeRoot;
        //object of the treeNode class, holds the smaller Tree pertaining the questions selected
        private TreeNode QuestionsRoot;
        //List of question labels
        private List<Label> QuestionLabelsList = new List<Label>();
        //List of decimals used in the question labels
        private List<string> QuestionLabelsDecimal = new List<string>();
        //Tree of answers
        private List<TreeNode> AnswerList = new List<TreeNode>();
        //Used for randomisation
        private Random random = new Random();
        //This is the current depth of the question on initialisation
        private int CurrentQuestionLevel = 2;


        //Used for counting down from 2 minutes
        private TimeSpan CountdownTime = TimeSpan.FromMinutes(2);

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
        private string ScoreTxtName = "FCNScore.txt";
        //The name of the txt file that stores the top players name
        private string PlayerTxtName = "FCNPlayers.txt";
        //The name of the txt file that stores the format of the leaderboard to be displayed.
        private string ScoreDisplayTxtName = "FCNScoreDisplay.txt";
        //Stores the player name. is delegated to later.
        public string PlayerName = "";

        //Filemanager called from the class library. handles txt files
        private DDSLibrary.FileManager fileManager = new DDSLibrary.FileManager();
        //bool value for if the game should flash the labels a color
        private bool FlashColor = false;
        #endregion
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Default constructor
        /// </summary>
        public CntrlFCNGame()
        {
            InitializeComponent();
            InitialiseControl();
        }
        //-----------------------------------------------------------------------------------------------//
        #region Form Operations
        #region question labels
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Question 1 click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblQuestoin1_Click(object sender, EventArgs e)
        {
            if (CheckAnswerList(this.QuestionLabelsDecimal[0]) == false)
            {
                ResetGame();
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Question 2 click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblQuestoin2_Click(object sender, EventArgs e)
        {
            if (CheckAnswerList(this.QuestionLabelsDecimal[1]) == false)
            {
                ResetGame();
            }
        }
        //-----------------------------------------------------------------------------------------------//      
        /// <summary>
        /// Question 3 click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblQuestoin3_Click(object sender, EventArgs e)
        {
            if (CheckAnswerList(this.QuestionLabelsDecimal[2]) == false)
            {
                ResetGame();
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Question 4 click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblQuestoin4_Click(object sender, EventArgs e)
        {
            if (CheckAnswerList(this.QuestionLabelsDecimal[3]) == false)
            {
                ResetGame();
            }
        }
        #endregion
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
                this.ScoreFlashCounter++;
            }
            //toggle visible 4 times. (shows twice)
            if (this.ScoreFlashCounter == 4)
            {
                this.ScoreFlashCounter = 0;
                this.AddedScore = false;
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Play button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Timer used to flash the labels a certain color
        /// green for correct
        /// red for incorrect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cntrlFlashTimerEvent(object sender, EventArgs e)
        {
            //Toggle state on flash color
            if (this.FlashColor == true)
            {
                this.FlashColor = false;
            }
            //Stop timer and reset to white
            else if ((lblQuestionHeader.ForeColor != Color.White || lblQuestoin1.ForeColor != Color.White) && this.FlashColor == false)
            {
                lblQuestionHeader.ForeColor = Color.White;
                for (int counter = 0; counter < this.QuestionLabelsList.Count; counter++)
                {
                    this.QuestionLabelsList[counter].ForeColor = Color.White;
                }
                FlashTimer.Stop();
            }
        }
        #endregion
        //-----------------------------------------------------------------------------------------------//
        #region Methods
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Called when the user starts the game.
        /// </summary>
        private void StartGame()
        {
            btnPlay.Enabled = false;
            lblScore.Text = "SCORE: " + this.Score;
            ToggleVisibility();
            AssignQuestions(this.QuestionsRoot, this.CurrentQuestionLevel, null);
            PopulateAnswerList(this.QuestionsRoot);
            TimeTimer.Start();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Resets the game to be re-played
        /// </summary>
        private void ResetGame() 
        {
            this.QuestionsRoot = this.treeManager.GenerateQuestions(this.TreeRoot, 4);
            this.QuestionLabelsDecimal.Clear();
            this.CurrentQuestionLevel = 2;
            this.AnswerList.Clear();
            AssignQuestions(this.QuestionsRoot, this.CurrentQuestionLevel, null);
            PopulateAnswerList(this.QuestionsRoot);
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Initialises the control that houses FCNGame
        /// </summary>
        private void InitialiseControl() 
        {
            UpdateLabel();
            //Load from text file into tree
            this.TreeRoot = this.treeManager.BuildTreeFromFile("DeweyDecimals.txt");
            //Initialise Questions root
            this.QuestionsRoot = this.treeManager.GenerateQuestions(this.TreeRoot, 4);
            this.QuestionLabelsList.Add(lblQuestoin1);
            this.QuestionLabelsList.Add(lblQuestoin2);
            this.QuestionLabelsList.Add(lblQuestoin3);
            this.QuestionLabelsList.Add(lblQuestoin4);
            
            //create the files needed for storing user leaderboard data
            this.fileManager.CreateFile(this.ScoreTxtName);
            this.fileManager.CreateFile(this.ScoreDisplayTxtName);
            this.fileManager.CreateFile(this.PlayerTxtName);

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
        /// Assign questions to the question labels
        /// queriedDecimal null = first come first serve
        /// setting the queriedDecimal will allow traversal to that node in the tree
        /// showing the children of the queriedDecimal
        /// </summary>
        /// <param name="root"></param>
        /// <param name="targetDepth"></param>
        /// <param name="queriedDecimal"></param>
        private void AssignQuestions(TreeNode root, int targetDepth, string queriedDecimal)
        {
            Queue<(TreeNode node, TreeNode parent)> queue = new Queue<(TreeNode, TreeNode)>();
            this.QuestionLabelsDecimal.Clear();
            //Parent is null for the root node
            queue.Enqueue((root, null)); 
            int currentDepth = 0;
            int questionLabelCount = 0;

            while (queue.Count > 0 && currentDepth <= targetDepth)
            {
                int nodesAtCurrentLevel = queue.Count;
                currentDepth++;

                for (int count = 0; count < nodesAtCurrentLevel; count++)
                {
                    //Deque a node and its parent
                    (TreeNode node, TreeNode parent) = queue.Dequeue();

                    if (currentDepth == targetDepth)
                    {
                        //assign parent Dewey decimal code
                        string parentDewey = parent != null ? parent.GetDeweyDecimal() : "parent decimal";
                        if ((queriedDecimal == null || queriedDecimal == parentDewey) && questionLabelCount < this.QuestionLabelsList.Count)
                        {
                            this.QuestionLabelsList[questionLabelCount].Text = $"{node.GetDeweyDecimal()} {node.GetDescription()}";
                            this.QuestionLabelsDecimal.Add($"{node.GetDeweyDecimal()}");

                            questionLabelCount++;
                        }
                    }
                    //Node becomes the new parent as we traverse
                    foreach (TreeNode child in node.Children)
                    {
                        //Enqueue child node and its parent with its parent(node)
                        queue.Enqueue((child, node)); 
                    }
                }
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Populates the global <TreeNode>Answerlist with answers relating
        /// to the randomly chosen options from the parameter "root" Tree
        /// users to follow the path of the answerlist to get points
        /// </summary>
        /// <param name="root"></param>
        private void PopulateAnswerList(TreeNode root)
        {
            //relates the the lowest depth that can be reached in the tree
            int numAnswersNeeded = 3;
            //Record the current root as previous for when we treverse
            List<TreeNode> optionsAtPreviousDepth = new List<TreeNode> { root };

            for (int counter = 0; counter < numAnswersNeeded; counter++)
            {
                //Recursively traverese the Tree and randomly select a path that will be the answer
                optionsAtPreviousDepth = ChooseRandomOption(optionsAtPreviousDepth);
            }
            //Set the question header to the top level nodes description
            lblQuestionHeader.Text = "Find the call number for: \r\n" +
                this.AnswerList[this.AnswerList.Count - 1].GetDescription();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Choose nodes Randomly from the Parameter Tree until answerlist is full
        /// </summary>
        /// <param name="nodesAtPreviousDepth"></param>
        /// <returns></returns>
        private List<TreeNode> ChooseRandomOption(List<TreeNode> nodesAtPreviousDepth)
        {
            //Traverse and load the children at the next depth
            List<TreeNode> nodesAtNextDepth = new List<TreeNode>();

            foreach (TreeNode parent in nodesAtPreviousDepth)
            {
                //Generate a random index to select a child node
                //Analysing the text file reveals that there are at a max 4 child nodes in the tree
                var randomNumber = getRandomNumber(0, 4);
                //If there are children continue
                //No children means that the last level has been reached
                if (parent.Children.Count > 0)
                {
                    //Select a random child node
                    TreeNode randomNodeSelected = parent.Children[randomNumber];
                    //Add the random node to the next depth list
                    nodesAtNextDepth.Add(randomNodeSelected);
                }
            }
            //Add selected nodes at the next depth to the AnswerList
            foreach (TreeNode randomNodeSelected in nodesAtNextDepth)
            {
                this.AnswerList.Add(new TreeNode(randomNodeSelected.GetDeweyDecimal(), randomNodeSelected.GetDescription()));
            }
            //List of nodes at the next depth
            return nodesAtNextDepth;
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Checks the parameter Decimal Chosen and checks the answer list
        /// to see if it contains it
        /// Handles the answer correctness by manipulating the labels
        /// </summary>
        /// <param name="DecimalChosen"></param>
        /// <returns></returns>
        private bool CheckAnswerList(string DecimalChosen) 
        {
            bool answer = false;
            //Check to see if the answerlist contains the DecimalChosen by the user
            for (int counter = 0; counter < this.AnswerList.Count; counter++)
            {
                if (this.AnswerList[counter].DeweyDecimal == DecimalChosen)
                {
                    answer = true;
                }
            }
            //Reset and handle game if the lowest level has been selected correctly
            if (answer == true && this.CurrentQuestionLevel > 3)
            {
                ResetGame();
                this.Score += 100;
                //Flash timer for flashing green
                FlashTimer.Start();
                //Flash green
                lblQuestionHeader.ForeColor = Color.LawnGreen;
                this.AddedScore = true;
                lblScore.Text = "SCORE: " + this.Score;
            }
            //Display next layer of children in the Tree
            else if (answer == true)
            {
                this.CurrentQuestionLevel++;
                AssignQuestions(this.QuestionsRoot, this.CurrentQuestionLevel, DecimalChosen);
                //Flash timer for flashing green
                FlashTimer.Start();
                //Flash green for all question labels
                for (int counter = 0; counter < this.QuestionLabelsList.Count; counter++)
                {
                    this.QuestionLabelsList[counter].ForeColor = Color.LawnGreen;
                }
            }
            else 
            {
                //Flash timer for flashing red
                FlashTimer.Start();
                //Flash red for all question labels
                for (int counter = 0; counter < this.QuestionLabelsList.Count; counter++)
                {
                    this.QuestionLabelsList[counter].ForeColor = Color.Red;
                }
                lblQuestionHeader.ForeColor = Color.Red;

            }
            return answer;        
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Return a random number between the min and max parameters
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        private int getRandomNumber(int min, int max) 
        {
            var randomNumber = this.random.Next(min, max);
            return randomNumber;
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
        /// Toggle the visibility on the components of the control.
        /// </summary>
        private void ToggleVisibility()
        {
            for (int count = 0; count < this.QuestionLabelsList.Count; count++)
            {
                this.QuestionLabelsList[count].Visible = !this.QuestionLabelsList[count].Visible;
            }
            lblQuestionHeader.Visible = !lblQuestionHeader.Visible;
            btnPlay.Visible = !btnPlay.Visible;
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Stops the game, tallies score and resets values.
        /// </summary>
        private void StopGame()
        {
            btnPlay.Enabled = true;
            ToggleVisibility();
            this.CountdownTime = TimeSpan.FromMinutes(2);
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
        #endregion
    }
}
//===============================================================================================//
///References
///https://www.geeksforgeeks.org/queue-data-structure/
///https://www.programiz.com/csharp-programming/queue
///Using Queues
