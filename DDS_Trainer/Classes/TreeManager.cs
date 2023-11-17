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
        public TreeNode BuildTreeFromFile(string filePath)
        {
            TreeNode root = new TreeNode("Root", "Dewey Decimal Root"); // Create a Root node
            Dictionary<int, TreeNode> nodesByDepth = new Dictionary<int, TreeNode>();
            nodesByDepth[0] = root; // Add Root node to dictionary

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                int depth = line.TakeWhile(c => c == '\t').Count();

                string[] parts = line.Trim().Split(' ');
                string deweyDecimal = parts[0];
                string description = string.Join(" ", parts.Skip(1));

                TreeNode newNode = new TreeNode(deweyDecimal, description);

                nodesByDepth[depth].Children.Add(newNode); // Add new node to its appropriate parent

                nodesByDepth[depth + 1] = newNode; // Update dictionary with new node at current depth
            }

            return root;
        }
        //-----------------------------------------------------------------------------------------------//
        //
        public TreeNode GenerateQuestions(TreeNode root, int numQuestions)
        {
            List<TreeNode> topLevelNodes = new List<TreeNode>();

            // Collect top-level nodes
            foreach (TreeNode node in root.Children)
            {
                topLevelNodes.Add(node);
            }

            List<TreeNode> selectedNodes = new List<TreeNode>();
            Random rand = new Random();

            // Randomly select nodes
            while (selectedNodes.Count < numQuestions && topLevelNodes.Count > 0)
            {
                int index = rand.Next(topLevelNodes.Count);
                TreeNode selectedNode = topLevelNodes[index];

                selectedNodes.Add(selectedNode);
                topLevelNodes.RemoveAt(index);
            }

            selectedNodes = selectedNodes.OrderBy(node => node.GetDeweyDecimal()).ToList(); // Change the criterion for sorting if needed

            // Create a new higher-level node to contain selected nodes
            TreeNode QuestionsRoot = new TreeNode("Questions", "Root"); // Name it appropriately
            foreach (TreeNode node in selectedNodes)
            {
                QuestionsRoot.Children.Add(node);
            }

            return QuestionsRoot;
        }
    }
}
