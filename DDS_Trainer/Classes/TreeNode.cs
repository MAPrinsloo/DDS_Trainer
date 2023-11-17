using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDS_Trainer.Classes
{
    public class TreeNode
    {
        public string DeweyDecimal { get; }
        public string Description { get; }
        public List<TreeNode> Children { get; } = new List<TreeNode>();

        public TreeNode(string deweyDecimal, string description)
        {
            DeweyDecimal = deweyDecimal;
            Description = description;
        }
        public string GetDeweyDecimal()
        {
            return DeweyDecimal;
        }

        public string GetDescription()
        {
            return Description;
        }
    }
}
