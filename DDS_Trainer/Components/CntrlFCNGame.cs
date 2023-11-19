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
        //Checks if the game is over, subscribed to by other forms.
        public event EventHandler GameOver;
        private TreeManager treeManager = new TreeManager();
        private TreeNode TreeRoot;
        private TreeNode QuestionsRoot;
        private List<Label> QuestionLabelsList = new List<Label>();
        private List<string> QuestionLabelsDecimal = new List<string>();
        private List<TreeNode> AnswerList = new List<TreeNode>();
        private Random random = new Random();
        private int CurrentQuestionLevel = 3;


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
        private bool FlashColor = false;

        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Default constructor
        /// </summary>
        public CntrlFCNGame()
        {
            InitializeComponent();
            InitialiseControl();
            testing();
        }
        //-----------------------------------------------------------------------------------------------//
        #region Form Operations
        //-----------------------------------------------------------------------------------------------//
        private void lblQuestoin1_Click(object sender, EventArgs e)
        {
            if (CheckAnswerList(QuestionLabelsDecimal[0]) == false)
            {
                ResetGame();
            }
        }
        //-----------------------------------------------------------------------------------------------//
        private void lblQuestoin2_Click(object sender, EventArgs e)
        {
            if (CheckAnswerList(QuestionLabelsDecimal[1]) == false)
            {
                ResetGame();
            }
        }
        //-----------------------------------------------------------------------------------------------//      
        private void lblQuestoin3_Click(object sender, EventArgs e)
        {
            if (CheckAnswerList(QuestionLabelsDecimal[2]) == false)
            {
                ResetGame();
            }
        }
        //-----------------------------------------------------------------------------------------------//
        private void lblQuestoin4_Click(object sender, EventArgs e)
        {
            if (CheckAnswerList(QuestionLabelsDecimal[3]) == false)
            {
                ResetGame();
            }
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
        private void testing()
        {
            treeManager.GenerateQuestions(TreeRoot, 4);
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
            AssignQuestions(this.QuestionsRoot, 2, null);
            PopulateAnswerList(this.QuestionsRoot);
            TimeTimer.Start();
        }
        //-----------------------------------------------------------------------------------------------//
        private void ResetGame() 
        {
            this.QuestionsRoot = treeManager.GenerateQuestions(this.TreeRoot, 4);
            this.QuestionLabelsDecimal.Clear();
            this.CurrentQuestionLevel = 3;
            this.AnswerList.Clear();
            AssignQuestions(this.QuestionsRoot, 2, null);
            PopulateAnswerList(this.QuestionsRoot);
        }
        //-----------------------------------------------------------------------------------------------//
        private void InitialiseControl() 
        {
            //Load from text file into tree
            this.TreeRoot = treeManager.BuildTreeFromFile("DeweyDecimals.txt");
            //Initialise Questions root
            this.QuestionsRoot = treeManager.GenerateQuestions(this.TreeRoot, 4);
            QuestionLabelsList.Add(lblQuestoin1);
            QuestionLabelsList.Add(lblQuestoin2);
            QuestionLabelsList.Add(lblQuestoin3);
            QuestionLabelsList.Add(lblQuestoin4);
            
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
        //
        //rootDecimal null = first come first serve
        private void AssignQuestions(TreeNode root, int targetDepth, string queriedDecimal)
        {
            Queue<(TreeNode node, TreeNode parent)> queue = new Queue<(TreeNode, TreeNode)>();
            this.QuestionLabelsDecimal.Clear();
            queue.Enqueue((root, null)); // Initially, parent is null for the root node
            int currentDepth = 0;
            int questionLabelCount = 0;

            while (queue.Count > 0 && currentDepth <= targetDepth)
            {
                int nodesAtCurrentLevel = queue.Count;
                currentDepth++;

                for (int i = 0; i < nodesAtCurrentLevel; i++)
                {
                    (TreeNode node, TreeNode parent) = queue.Dequeue();

                    if (currentDepth == targetDepth)
                    {
                        string parentDewey = parent != null ? parent.GetDeweyDecimal() : "parent decimal";
                        if ((queriedDecimal == null || queriedDecimal == parentDewey) && questionLabelCount < QuestionLabelsList.Count)
                        {
                            this.QuestionLabelsList[questionLabelCount].Text = $"{node.GetDeweyDecimal()} {node.GetDescription()}";
                            this.QuestionLabelsDecimal.Add($"{node.GetDeweyDecimal()}");

                            questionLabelCount++;
                        }
                    }

                    foreach (TreeNode child in node.Children)
                    {
                        queue.Enqueue((child, node)); // Enqueue child node along with its parent
                    }
                }
            }
        }
        //-----------------------------------------------------------------------------------------------//
        //
        //
        private void PopulateAnswerList(TreeNode root)
        {
            int numAnswersNeeded = 3;
            int currentDepth = 2;
            List<TreeNode> optionsAtPreviousDepth = new List<TreeNode> { root };

            for (int counter = 0; counter < numAnswersNeeded; counter++)
            {
                optionsAtPreviousDepth = ChooseRandomOption(optionsAtPreviousDepth, currentDepth);
                currentDepth++;
            }
            lblQuestionHeader.Text = "Find the call number for: \r\n" +
                this.AnswerList[this.AnswerList.Count - 1].GetDeweyDecimal() + " " + this.AnswerList[this.AnswerList.Count - 1].GetDescription();
        }
        //-----------------------------------------------------------------------------------------------//
        //
        //
        private List<TreeNode> ChooseRandomOption(List<TreeNode> nodesAtPreviousDepth, int targetDepth)
        {
            List<TreeNode> optionsAtTargetDepth = new List<TreeNode>();
            Random rand = new Random();

            foreach (TreeNode parent in nodesAtPreviousDepth)
            {
                int randomNumber = getRandomNumber(0, 4);
                if (parent.Children.Count > 0)
                {
                    TreeNode selectedNode = parent.Children[randomNumber];
                    optionsAtTargetDepth.Add(selectedNode);
                }
            }

            foreach (TreeNode option in optionsAtTargetDepth)
            {
                AnswerList.Add(new TreeNode(option.GetDeweyDecimal(), option.GetDescription()));
            }

            return optionsAtTargetDepth;
        }
        //-----------------------------------------------------------------------------------------------//
        //
        private bool CheckAnswerList(string DecimalChosen) 
        {
            bool answer = false;
            for (int counter = 0; counter < AnswerList.Count; counter++)
            {
                if (AnswerList[counter].DeweyDecimal == DecimalChosen)
                {
                    answer = true;
                }
            }
            if (answer == true && CurrentQuestionLevel > 4)
            {
                ResetGame();
                this.Score += 100;
                FlashTimer.Start();
                lblQuestionHeader.ForeColor = Color.LawnGreen;
                this.AddedScore = true;
                lblScore.Text = "SCORE: " + this.Score;
            }
            else if (answer == true)
            {
                AssignQuestions(this.QuestionsRoot, this.CurrentQuestionLevel, DecimalChosen);
                FlashTimer.Start();
                for (int counter = 0; counter < QuestionLabelsList.Count; counter++)
                {
                    QuestionLabelsList[counter].ForeColor = Color.LawnGreen;
                }
                this.CurrentQuestionLevel++;
            }
            else 
            {
                FlashTimer.Start();
                for (int counter = 0; counter < QuestionLabelsList.Count; counter++)
                {
                    QuestionLabelsList[counter].ForeColor = Color.Red;
                }
                lblQuestionHeader.ForeColor = Color.Red;

            }
            return answer;
        //-----------------------------------------------------------------------------------------------//
        //
        }private int getRandomNumber(int min, int max) 
        {
            int randomNumber = this.random.Next(min, max);
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
                this.QuestionLabelsList[count].Visible = !QuestionLabelsList[count].Visible;
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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            StartGame();
        }

  

        private void cntrlFlashTimerEvent(object sender, EventArgs e)
        {
            if (FlashColor == true)
            {
                FlashColor = false;
            }
            else if ((lblQuestionHeader.ForeColor != Color.White || lblQuestoin1.ForeColor != Color.White) && FlashColor == false)
            {
                lblQuestionHeader.ForeColor = Color.White;
                for (int counter = 0; counter < QuestionLabelsList.Count; counter++)
                {
                    QuestionLabelsList[counter].ForeColor = Color.White;
                }
                FlashTimer.Stop();
            }
        }
    }
}
