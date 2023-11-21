// Author: Matthew Alexander Prinsloo
// Student Number: ST10081850
// Subject code: PROG7312
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDS_Trainer.Classes
{
    public class TreeManager

    {
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Default constructor
        /// </summary>
        public TreeManager() 
        {
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Create A tree from the data stored in the filepath
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public TreeNode BuildTreeFromFile(string filePath)
        {
            //Create a Root node
            TreeNode root = new TreeNode("Root", "Dewey Decimal Root"); 
            Dictionary<int, TreeNode> nodesByDepth = new Dictionary<int, TreeNode>();
            //Add Root node to dictionary
            nodesByDepth[0] = root;

            string[] lines = File.ReadAllLines(filePath);
            //Read all lines in text file
            foreach (string line in lines)
            {
                //check what depth is being read
                int depth = line.TakeWhile(c => c == '\t').Count();

                string[] parts = line.Trim().Split(' ');
                string deweyDecimal = parts[0];
                string description = string.Join(" ", parts.Skip(1));

                TreeNode newNode = new TreeNode(deweyDecimal, description);
                //Add new node to its parent in the dictionary at the correct depth
                nodesByDepth[depth].AddChild(newNode); 
                //Update dictionary with new node at current depth
                nodesByDepth[depth + 1] = newNode; 
            }
            //root contains reference to all the treenodes added from the text file
            return root;
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Creates a Tree Root with top level nodes from the root in the parameter
        /// The number of random nodes selected relates to the numQuestions parameter
        /// </summary>
        /// <param name="root"></param>
        /// <param name="numQuestions"></param>
        /// <returns></returns>
        public TreeNode GenerateQuestions(TreeNode root, int numQuestions)
        {
            //Top level nodes Tree
            List<TreeNode> topLevelNodes = new List<TreeNode>();

            //Collect top level nodes
            foreach (TreeNode node in root.Children)
            {
                topLevelNodes.Add(node);
            }

            List<TreeNode> selectedNodes = new List<TreeNode>();
            Random rand = new Random();

            //Randomly select nodes
            while (selectedNodes.Count < numQuestions && topLevelNodes.Count > 0)
            {
                int index = rand.Next(topLevelNodes.Count);
                TreeNode selectedNode = topLevelNodes[index];

                selectedNodes.Add(selectedNode);
                topLevelNodes.RemoveAt(index);
            }

            selectedNodes = selectedNodes.OrderBy(node => node.GetDeweyDecimal()).ToList();

            //New Tree to return, contains smaller tree to query and manage
            //holds the question nodes selected and all their children
            TreeNode QuestionsRoot = new TreeNode("Questions", "Root");
            foreach (TreeNode node in selectedNodes)
            {
                QuestionsRoot.AddChild(node);
            }

            return QuestionsRoot;
        }
    }
}
/////===============================================================================================//
///References
///https://www.geeksforgeeks.org/generic-tree-level-order-traversal/
///https://www.geeksforgeeks.org/generic-treesn-array-trees/
///https://stackoverflow.com/questions/66893/tree-data-structure-in-c-sharp
///Trees
///https://codereview.stackexchange.com/questions/181683/building-a-data-tree-out-of-a-text-file-c
///reading from text file to build tree