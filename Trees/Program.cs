using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class TreeNode<T>
    {
        public T Data { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
        }
    }

    public class ListNode<T>
    {
        public T Data { get; set; }
        public ListNode<T> Next { get; set; }

        public ListNode(T data)
        {
            this.Data = data;
            this.Next = null;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 21. Given a BST, create a linkedlist of all the nodes at each depth
            // Q's: Is the tree balanced? How deep is it? 
            // Input = a bst?
            // Output = a list of linked lists?
            // Should I write my TreeNode and ListNode classes? Handle edge cases?

            Console.WriteLine("Given a BST, create a linked list of all the nodes at each depth.");

            // 1. create bst
            Console.WriteLine("\n1. Create binary tree.");
            TreeNode<string> root = GetBst();

            // 2. find the depth of the tree
            Console.WriteLine("2. Find the depth of the tree.");
            int depth = GetBstDepth(root);

            // 3. create a list of linked lists
            List<ListNode<string>> listOfListNodes = GetListOfListNodes(depth);

            // 4. print list of linked lists to confirm
            PrintListOfListNodes(listOfListNodes);
        }

        private static void PrintListOfListNodes(List<ListNode<string>> listOfListNodes)
        {
            throw new NotImplementedException();
        }

        private static List<ListNode<string>> GetListOfListNodes(int depth)
        {
            throw new NotImplementedException();
        }

        private static int GetBstDepth(TreeNode<string> root)
        {
            throw new NotImplementedException();
        }

        private static TreeNode<string> GetBst()
        {
            TreeNode<string> root = new TreeNode<string>("d");
            root.Left = new TreeNode<string>("b");
            root.Right = new TreeNode<string>("c");
            root.Left.Left = new TreeNode<string>("a");
            root.Left.Right = new TreeNode<string>("f");
            root.Right.Left = new TreeNode<string>("e");
            root.Right.Right = new TreeNode<string>("g");

            return root;
        }
    }
}
