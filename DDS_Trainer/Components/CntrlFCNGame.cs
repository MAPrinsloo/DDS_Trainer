using DDS_Trainer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private List<Label> QuestionLabels = new List<Label>();
        private List<TreeNode> AnswerList = new List<TreeNode>();
        private Random random = new Random();
        private int CurrentQuestionLevel = 3;
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
            if (CheckAnswerList(lblQuestoin1.Text) == true)
            {
                AssignQuestions(this.QuestionsRoot, this.CurrentQuestionLevel, lblQuestoin1.Text);
                this.CurrentQuestionLevel++;
            }
        }
        //-----------------------------------------------------------------------------------------------//
        private void lblQuestoin2_Click(object sender, EventArgs e)
        {
            if (CheckAnswerList(lblQuestoin2.Text) == true)
            {
                AssignQuestions(this.QuestionsRoot, this.CurrentQuestionLevel, lblQuestoin2.Text);
                this.CurrentQuestionLevel++;
            }
        }
        //-----------------------------------------------------------------------------------------------//      
        private void lblQuestoin3_Click(object sender, EventArgs e)
        {
            if (CheckAnswerList(lblQuestoin3.Text) == true)
            {
                AssignQuestions(this.QuestionsRoot, this.CurrentQuestionLevel, lblQuestoin3.Text);
                this.CurrentQuestionLevel++;
            }
        }
        //-----------------------------------------------------------------------------------------------//
        private void lblQuestoin4_Click(object sender, EventArgs e)
        {
            if (CheckAnswerList(lblQuestoin4.Text) == true)
            {
                AssignQuestions(this.QuestionsRoot, this.CurrentQuestionLevel, lblQuestoin4.Text);
                this.CurrentQuestionLevel++;
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
        private void InitialiseControl() 
        {
            //Load from text file into tree
            this.TreeRoot = treeManager.BuildTreeFromFile("DeweyDecimals.txt");
            //Initialise Questions root
            this.QuestionsRoot = treeManager.GenerateQuestions(this.TreeRoot, 4);
            QuestionLabels.Add(lblQuestoin1);
            QuestionLabels.Add(lblQuestoin2);
            QuestionLabels.Add(lblQuestoin3);
            QuestionLabels.Add(lblQuestoin4);

            AssignQuestions(this.QuestionsRoot, 2, null);
            PopulateAnswerList(this.QuestionsRoot);

        }
        //-----------------------------------------------------------------------------------------------//
        //
        //rootDecimal null = first come first serve
        private void AssignQuestions(TreeNode root, int targetDepth, string queriedDecimal)
        {
            Queue<(TreeNode node, TreeNode parent)> queue = new Queue<(TreeNode, TreeNode)>();
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
                        if ((queriedDecimal == null || queriedDecimal == parentDewey) && questionLabelCount < QuestionLabels.Count)
                        {
                            QuestionLabels[questionLabelCount].Text = $"{node.GetDeweyDecimal()}";
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
            lblQuestionHeader.Text = this.AnswerList[numAnswersNeeded - 1].GetDeweyDecimal() + this.AnswerList[numAnswersNeeded - 1].GetDescription();
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
                    //MessageBox.Show("woop woop");
                    answer = true;
                }
            }
            return answer;
        }private int getRandomNumber(int min, int max) 
        {
            int randomNumber = this.random.Next(min, max);
            return randomNumber;
        }
        

        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Can be called to stop the 2 minute countdown timer.
        /// </summary>
        public void StopTimeTimer()
        {
            //TimeTimer.Stop();
        }

        #endregion
    }
}
