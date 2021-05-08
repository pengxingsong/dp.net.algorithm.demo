using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTrainingConsole.算法框架学习
{
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode() { }
        public TreeNode(int value)
        {
            this.Value = value;
        }
        public TreeNode LeftNode { get; set; }
        public TreeNode RightNode { get; set; }
    }
}
