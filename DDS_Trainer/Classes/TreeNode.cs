// Author: Matthew Alexander Prinsloo
// Student Number: ST10081850
// Subject code: PROG7312
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDS_Trainer.Classes
{
    public class TreeNode
    {
        //Dewey decimal code
        public string DeweyDecimal { get; }
        //Dewey decimal description
        public string Description { get; }
        //list of children linked to the Tree
        public List<TreeNode> Children { get; } = new List<TreeNode>();

        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Parameterised constructor
        /// </summary>
        /// <param name="deweyDecimal"></param>
        /// <param name="description"></param>
        public TreeNode(string deweyDecimal, string description)
        {
            DeweyDecimal = deweyDecimal;
            Description = description;
            Children = new List<TreeNode>();
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Get the dewey decimal from the tree node
        /// </summary>
        /// <returns></returns>
        public string GetDeweyDecimal()
        {
            return DeweyDecimal;
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Get the description from the tree node
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return Description;
        }
        //-----------------------------------------------------------------------------------------------//
        /// <summary>
        /// Adds a child node to the current node's list of children.
        /// </summary>
        /// <param name="child">The child node to add.</param>
        public void AddChild(TreeNode child)
        {
            Children.Add(child);
        }
    }
}
//===============================================================================================//
///References
///https://www.geeksforgeeks.org/generic-tree-level-order-traversal/
///https://www.geeksforgeeks.org/generic-treesn-array-trees/
///https://stackoverflow.com/questions/66893/tree-data-structure-in-c-sharp
///Trees