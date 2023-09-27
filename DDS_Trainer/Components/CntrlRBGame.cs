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
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DDS_Trainer.Components
{
    //Delegating the passed name from HighScore
    public delegate void NameEnteredHandler(string name);

    public partial class CntrlRBGame : UserControl
    {
        #region Variables
        //Used for counting down from 2 minutes
        private TimeSpan countdownTime = TimeSpan.FromMinutes(2);

        //List of submission points to display their rectangel space and check storage conditions.
        private List<SubmissionPoint> submissionPoints = new List<SubmissionPoint>();
        //List of leaderboard players, holding score and name.
        private List<LeaderboardPLayers> lbPlayersList = null;
        //Is filled and sorted with the call numbers and checked against the books order.
        private List<string> SortedDecimalsList = new List<string>();
        //String list of the TopPlayers, read from the txt file.
        private List<string> TopPlayers = new List<string>();
        //Int list of the Top Scores, read from the txt fie.
        private List<int> TopScores = new List<int>();
        //List of books to generate as well as their values.
        private List<Book> books = new List<Book>();

        //Bool to see if the score was added.
        private bool AddedScore = false;
        //Bool to see if the user got the correct order.
        private bool CorrectOrder = false;

        //User score starts at 0
        private int Score = 0;
        //Counter to track how many times the +100 points flashed.
        private int ScoreFlashCounter = 0;
        //Limit of players on the leaderboard.
        private int LeaderboardPlayerLimit = 10;
        //Number of books to generate.
        int numberOfBooks = 10;

        //The name of the txt file that stores the top players score
        private string ScoreTxtName = "RBScore.txt";
        //The name of the txt file that stores the top players name
        private string PlayerTxtName = "RBPlayers.txt";
        //The name of the txt file that stores the format of the leaderboard to be displayed.
        private string ScoreDisplayTxtName = "RBScoreDisplay.txt";
        //Stores the player name. is delegated to later.
        public string PlayerName = "";
        

        //Event handler to check if a name was entered sucessfully
        public NameEnteredHandler NameEnteredCallback;
        //Checks if the game is over, subscribed to by other forms.
        public event EventHandler GameOver;
        //Filemanager called from the class library. handles txt files
        private DDSLibrary.FileManager fileManager = new DDSLibrary.FileManager();
        //DDecimal called from the class library. handles the generation of the call numbers.
        private DDSLibrary.DDecimal dDecimal = new DDSLibrary.DDecimal();
        //Assinged in constructor
        private FrmMainMenu MainMenu;
        //Holds the values of the selected book that is being dragged.
        private Book SelectedBook;

        #endregion


        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Default constructor
        /// </summary>
        public CntrlRBGame()
        {
            InitializeComponent();
            InitializeControl();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Parameterised constructor
        /// </summary>
        /// <param name="mainMenu"></param>
        /// <param name="frmRBGame"></param>
        public CntrlRBGame(FrmMainMenu mainMenu, FrmRBGame frmRBGame) 
        {
            InitializeComponent();
            this.MainMenu = mainMenu;
            //event triggered.
            NameEnteredCallback = GetNameFromCntrlHighScore;
            InitializeControl();
        }        
        //-----------------------------------------------------------------------------------------------//
        #region Form Operations
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// button play is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// When the mouse is pressed down check if the user 
        /// has clicked onto a book and track its position.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMouseDown(object sender, MouseEventArgs e)
        {
            Point mousePosition = new Point(e.X, e.Y);
            foreach (Book newBook in books)
            {
                if (SelectedBook == null)
                {
                    if (newBook.rect.Contains(mousePosition))
                    {
                        SelectedBook = newBook;
                        newBook.active = true;
                    }
                }
            }
        }

        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Track book as the mouse is being moved and check 
        /// if it overlaps a submissoin point.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMouseMove(object sender, MouseEventArgs e)
        {
            int subPointPos = 0;
            //setting to negative effectively resets the book
            //as long as occupied is also set to false.
            //This allows users to drag a book out and try again.
            //SelectedBook.PosSnapped tracks the position a book is slotted in.
            if (SelectedBook != null && SelectedBook.PosSnapped >= 0)
            {
                submissionPoints[SelectedBook.PosSnapped - 1].Occupied = false;
                SelectedBook.PosSnapped = -1;
            }

            if (SelectedBook != null)
            {
                SelectedBook.Position.X = e.X - (SelectedBook.Width / 2);
                SelectedBook.Position.Y = e.Y - (SelectedBook.Height / 2);

                //Checks the location and index of each sub point
                //assign subPointPos to the selected book as its position snapped value.
                foreach (SubmissionPoint point in submissionPoints)
                {
                    subPointPos++;
                    if (!point.Occupied && point.Rect.Contains(SelectedBook.Position))
                    {
                        SelectedBook.Position = new Point(point.Rect.X, point.Rect.Y);
                        point.Occupied = true;
                        SelectedBook.PosSnapped = subPointPos;
                        point.BookLabel = SelectedBook.Text;
                        //Forces the mouse to be released. Allows better snapping.
                        FormMouseUp(this, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
                        break;
                    }
                }
                Invalidate();
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// When the mouse down is stopped being pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMouseUp(object sender, MouseEventArgs e)
        {
            foreach (Book tempBook in books)
            {
                tempBook.active = false;
            }
            SelectedBook = null;

            List<string> placedBooksLabels = submissionPoints.Where(point => point.Occupied).Select(point => point.BookLabel).ToList();
            //checks to see if all sub slots are full
            if (placedBooksLabels.Count == numberOfBooks)
            {
                checkBooks(placedBooksLabels);
                placedBooksLabels.Clear();
            }

        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            foreach (Book book in books)
            {
                e.Graphics.DrawImage(book.BookImage, book.Position.X, book.Position.Y, book.Width, book.Height);

                //Draw the corresponding text at the specified offset from the books drawn position
                if (!string.IsNullOrEmpty(book.Text))
                {
                    Font textFont = new Font("MS PGothic", 9.5F, FontStyle.Bold);
                    SolidBrush textBrush = new SolidBrush(Color.Black);
                    int textX = book.Position.X + book.TextOffsetX;
                    int textY = book.Position.Y + book.TextOffsetY;
                    e.Graphics.DrawString(book.Text, textFont, textBrush, textX, textY);
                }
            }

            foreach (SubmissionPoint point in submissionPoints)
            {
                if (!point.Occupied)
                {
                    //draws gray rectangles.
                    using (SolidBrush brush = new SolidBrush(Color.FromArgb(100, 169, 169, 169)))
                    {
                        e.Graphics.FillRectangle(brush, point.Rect);
                    }
                }
            }
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Updates the postion of all the books placed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CntrlBookTimerEvent(object sender, EventArgs e)
        {
            foreach (Book book in books)
            {
                book.rect.X = book.Position.X;
                book.rect.Y = book.Position.Y;
            }

            this.Invalidate();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Timer countdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CntrlTimeTimerEvent(object sender, EventArgs e)
        {
            if (countdownTime.TotalSeconds > 0)
            {
                //countdown and update each second. ie 1 sec increments.
                countdownTime = countdownTime.Subtract(TimeSpan.FromSeconds(1));
                UpdateLabel();
            }
            else
            {
                StopTimeTimer();
                StopGame();
            }
            
            if (AddedScore == true)
            {
                lblAddedScore.Visible = !lblAddedScore.Visible;
                this.ScoreFlashCounter++;
            }
            //toggle visible 4 times. (shows twice)
            if (this.ScoreFlashCounter == 4)
            {
                this.ScoreFlashCounter = 0;
                AddedScore = false;
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
            fileManager.CreateFile(ScoreTxtName);
            fileManager.CreateFile(ScoreDisplayTxtName);
            fileManager.CreateFile(PlayerTxtName);
            //Get old game information from txt file
            for (int counter = 0; counter < fileManager.ReadFromFile(ScoreTxtName).Count; counter++)
            {
                try
                {
                    TopScores.Add(Convert.ToInt32(fileManager.ReadFromFile(ScoreTxtName)[counter]));
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Exception: " + ex.Message);
                }
            }
            //Get old game information from txt file and assign to lbPlayerList
            for (int counter = 0; counter < fileManager.ReadFromFile(PlayerTxtName).Count; counter++)
            {
                try
                {
                    TopPlayers.Add(fileManager.ReadFromFile(PlayerTxtName)[counter]);
                    if (lbPlayersList == null)
                    {
                        this.lbPlayersList = new List<LeaderboardPLayers>();
                    }
                    LeaderboardPLayers lbPlayers = new LeaderboardPLayers(PlayerScore: TopScores[counter],
                                                                          PlayerName: TopPlayers[counter]);
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
        /// 
        /// </summary>
        private void UpdateLabel()
        {
            lblTime.Text = "TIME: " + countdownTime.ToString(@"mm\:ss");
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Generates the book according to quantity, x & y Stat position
        /// ySubDisplacement is for how far up or down the sub points should be.
        /// </summary>
        /// <param name="bookQuantity"></param>
        /// <param name="xStart"></param>
        /// <param name="yStart"></param>
        /// <param name="ySubDisplacement"></param>
        private void GenerateBooks(int bookQuantity, int xStart, int yStart, int ySubDisplacement)
        {
            Random random = new Random();
            int xPos = 0;
            xPos += xStart;

            for (int counter = 0; counter < bookQuantity; counter++)
            {
                string generatedDecimal = (dDecimal.GenerateDD(minFractionLength: 0, maxFractionLength: 4));
                byte randomIndex = (byte)random.Next(minValue: 0, maxValue: imageListBooks.Images.Count);
                SortedDecimalsList.Add(generatedDecimal);
                Book newBook = new Book(bookAssets: imageListBooks, index: randomIndex, generatedDecimal);
                newBook.Position.X = xPos;
                newBook.Position.Y = yStart;
                newBook.rect.X = newBook.Position.X;
                newBook.rect.Y = newBook.Position.Y;
                books.Add(newBook);
                //They will have the same positions and size besides the y offset.
                Rectangle submissionRect = new Rectangle(xPos, yStart - ySubDisplacement, newBook.Width, newBook.Height);
                submissionPoints.Add(new SubmissionPoint(submissionRect));
                //xValue for how much space to make before another point should be drawn.
                xPos += 95;
            }
            //Sort is the most effecient algorithm, can use DDSLibrary sorting class to use an actual algorithm
            //Visual studio analyses the data and chooses the most suited algorithm
            SortedDecimalsList.Sort();
            this.Invalidate();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// checks if the books are in the correct order.
        /// </summary>
        /// <param name="placedBooksList"></param>
        private void checkBooks(List<string> placedBooksList)
        {
            for (int counter = 0; counter < SortedDecimalsList.Count; counter++)
            {
                this.CorrectOrder = true;
                if (SortedDecimalsList[counter] != placedBooksList[counter])
                {
                    this.CorrectOrder = false;
                    break;
                }
            }
            if (CorrectOrder == true)
            {
                this.Score += 100;
                this.AddedScore = true;
                lblScore.Text = "SCORE: " + this.Score;

                ResetGame();
                GenerateBooks(bookQuantity: numberOfBooks, xStart: 290, yStart: 400, ySubDisplacement: 170);
            }
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
        /// Called when the user starts the game.
        /// </summary>
        private void StartGame()
        {
            btnPlay.Enabled = false;
            btnPlay.Visible = false;
            lblScore.Text = "SCORE: " + Score;
            GenerateBooks(bookQuantity: numberOfBooks, xStart: 290, yStart: 400, ySubDisplacement: 170);
            TimeTimer.Start();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Stops the game, tallies score and resets values.
        /// </summary>
        private void StopGame()
        {
            btnPlay.Enabled = true;
            btnPlay.Visible = true;
            countdownTime = TimeSpan.FromMinutes(2);
            ResetGame();
            for (int counter = 0; counter < TopScores.Count; counter++)
            {
                if (TopScores.Count <= LeaderboardPlayerLimit-1)
                {
                    NewHighScore();
                    UpdateLeaderboard();
                    break;
                }
                if (this.Score > TopScores[counter])
                {
                    NewHighScore();
                    UpdateLeaderboard();
                    break;
                }
            }
            if (TopScores.Count == 0)
            {
                NewHighScore();
                UpdateLeaderboard();
            }
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
        /// Initials are delegated back and processed here.
        /// </summary>
        /// <param name="enteredName"></param>
        private void GetNameFromCntrlHighScore(string enteredName)
        {
            PlayerName = enteredName;

            LeaderboardPLayers newPlayer = new LeaderboardPLayers(PlayerScore: this.Score, PlayerName: PlayerName);
            if (lbPlayersList == null)
            {
                this.lbPlayersList = new List<LeaderboardPLayers>();
            }
            this.lbPlayersList.Add(newPlayer);

            UpdateLeaderboard();
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


            if (SortedLbPlayers.Count > LeaderboardPlayerLimit - 1)
            {
                for (int counter = LeaderboardPlayerLimit - 1; counter < SortedLbPlayers.Count; counter++)
                {
                    int lastScoreIndex = SortedLbPlayers.Count - 1;
                    SortedLbPlayers.RemoveAt(lastScoreIndex);
                }
            }


            //Recreate and write all to file.
            if (fileManager.RecreateFile(ScoreTxtName) == true && 
                fileManager.RecreateFile(ScoreDisplayTxtName) == true &&
                fileManager.RecreateFile(PlayerTxtName) == true)
            {
                for (int counter = 0; counter < SortedLbPlayers.Count; counter++)
                {
                    int rank = counter + 1;
                    fileManager.WriteToFile(FileName: ScoreTxtName, 
                                            ContentToWrite: Convert.ToString(SortedLbPlayers[counter].score));

                    fileManager.WriteToFile(FileName: PlayerTxtName,
                                            ContentToWrite: SortedLbPlayers[counter].name);
                    if (Score >= 1000)
                    {
                        fileManager.WriteToFile(FileName: ScoreDisplayTxtName,
                                            ContentToWrite: rank + "\t\t" + SortedLbPlayers[counter].score.ToString() + "\t" + SortedLbPlayers[counter].name);
                    }
                    if (Score < 1000)
                    {
                        fileManager.WriteToFile(FileName: ScoreDisplayTxtName,
                                            ContentToWrite: rank + "\t\t" + SortedLbPlayers[counter].score.ToString() + "\t\t" + SortedLbPlayers[counter].name);
                    }
                }
            }
            GameOver?.Invoke(this, EventArgs.Empty);
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Resets the game
        /// </summary>
        private void ResetGame() 
        {
            books.Clear();
            submissionPoints.Clear();

            SortedDecimalsList.Clear();
            this.CorrectOrder = false;
        }

        #endregion
    }
}
//===============================================================================================//
///References
///https://youtu.be/1J8-wc8fq8I
///The drawing books function was adapted from the video above.
///https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates
///The following was consulted for the use of delegates.
///https://youtu.be/H1mBizULjiw
///https://josipmisko.com/posts/c-sharp-timer
///The following video and document was consulted for implemetation of the timer.