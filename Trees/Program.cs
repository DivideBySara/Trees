using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class TreeNode<T>
    {
        public T data { get; set; }
        public TreeNode<T> left { get; set; }
        public TreeNode<T> right { get; set; }

        public TreeNode(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }

    public class ListNode<T>
    {
        public T data { get; set; }
        public ListNode<T> next { get; set; }

        public ListNode(T data)
        {
            this.data = data;
            this.next = null;
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
            int size = 7;
            TreeNode<int> root = GetBst(size);            
        }

        private static TreeNode<int> GetBst(int size)
        {
            TreeNode<int> root = new TreeNode<int>(1);

            // https://stackoverflow.com/questions/828398/how-to-create-a-binary-tree for more details

            return root;
        }
    }
}
