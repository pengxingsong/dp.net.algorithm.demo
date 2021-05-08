using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmTrainingConsole.算法框架学习.二叉树
{
    /// <summary>
    /// 翻转二叉树
    /// </summary>
    public class FlipBinaryTree
    {

        public TreeNode CreateTree(int[] values)
        {
            if (values == null || values.Length == 0)
                return null;
            TreeNode root = new TreeNode(values[0]);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int index = 1;
            while (queue.Count > 0 && index < values.Length)
            {
                TreeNode node = queue.Dequeue();
                if (node == null) 
                    continue;
                if (index < values.Length)
                {
                    node.LeftNode = new TreeNode(values[index++]);
                    queue.Enqueue(node.LeftNode);
                }
                if (index < values.Length)
                {
                    node.RightNode = new TreeNode(values[index++]);
                    queue.Enqueue(node.RightNode);
                }
            }
            return root;
        }

        public TreeNode FlipTree(TreeNode root)
        {
            if (root == null)
                return null;
            var left = root.LeftNode;
            root.LeftNode = root.RightNode;
            root.RightNode = left;
            FlipTree(root.LeftNode);
            FlipTree(root.RightNode);
            return root;
        }

        public void PrintTree(TreeNode root)
        {
            if (root == null)
                return;
            Console.WriteLine($"根：{root?.Value},left:{root.LeftNode?.Value},right:{root.RightNode?.Value}");
            PrintTree(root.LeftNode);
            PrintTree(root.RightNode);
        }

        public static void Test()
        {
            var values = Util.UseDoubleArrayToNonRepeatedRandom(8, 1, 100);
            FlipBinaryTree tree = new FlipBinaryTree();
            TreeNode root = new TreeNode();
            root = tree.CreateTree(values) ;
            Console.WriteLine("数组：" + string.Join(",", values));
            Console.WriteLine("原Tree");
            tree.PrintTree(root);
            tree.FlipTree(root);
            Console.WriteLine("翻转后Tree");
            tree.PrintTree(root);
        }

    }
}
