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
            Console.WriteLine("\n1. Create binary search tree.");
            TreeNode<string> root = GetAlphaBst();

            // 2. find the depth of the tree
            Console.WriteLine("2. Find the depth of the tree.");
            int depth = GetBstDepth(root);
            Console.WriteLine($"Depth is {depth}");

            // 3. create a list of linked lists
            //List<ListNode<string>> listOfListNodes = GetListOfListNodes(depth);

            // 4. print list of linked lists to confirm
            //PrintListOfListNodes(listOfListNodes);


            // 1. Write an algorithm to find the next node (i.e in-order successor) of a given node in a binary search tree. You may assume that each node has a link to its parent.
            // Q: What is an in-order successor? A: Next node in in-order traversal. This is also the node with the smallest key greater than the input key. 
            // Q: input = a node, output = a node
            // if the right subtree != null, the in-order successor is here somewhere. Move 1) right, then 2) all the way left if possible
            // if the right subtree == null, determine whether the current node is a left child. If so, the parent of the current node is the in-roder successor of the input node.

            // 2. Design an algorithm and write code to find the first common ancestor of two nodes in a binary tree. Avoid storing additional nodes in a data structure. NOTE: This is not necessarily a BST
            // Q: input = 2 nodes & root, output = the first common ancestor, link to the parent, can a node be its own parent, the root contains both nodes, right? Can we assume unique data in the nodes?
            // A) if the root matches either node, then return it
            // B) Use boolean arrays to store search results for search of left, right sides
            // c) Recurse until nodes are found on different sides, then return root

            // 3. You have 2 very large binary trees: T1 with millions of nodes, and T2 with hundreds of nodes. Create an algorithm to decide if T2 is a subtree of T1. A tree T2 is a subtree of T1 if there exists a node n in T1 such that the subtree of n is identical to T2. That is, if you cut off the tree at node n, the two trees would be identical.
            // Q: input = rootA & rootB? Output = boolean.
            // A) bool isEqualTreeLeft = false;
            //    bool isEqualTreeRight = false;
            // B) isEqualTreeLeft = SubtreeExists(rootT2, rootT1.Left);
            //    isEqualTreeRight = SubtreeExists(roott2, rootT2.Right);
            // C) if either bool is true, return true, else call recursively with rootT1.Left, rootT1.Right
            // D) return false at end of method 

            // 4. You are given a binary tree in which each node contains a value. Design an algorithm to print all paths which sum to a given value. Note that a path can start or end anywhere in the tree.

            Console.ReadKey();
        }

        private static void PrintListOfListNodes(List<ListNode<string>> listOfListNodes)
        {
            throw new NotImplementedException();
        }

        private static List<ListNode<string>> GetListOfListNodes(int depth)
        {
            throw new NotImplementedException();
        }

        private static int GetBstDepth(TreeNode<string> treeNode)
        {
            // base case
            if (treeNode == null)
            {
                return 0;
            }
            else
            {
                // left case
                int leftDepth = GetBstDepth(treeNode.Left);

                // right case
                int rightDepth = GetBstDepth(treeNode.Right);

                // return larger of left case or right case
                return leftDepth > rightDepth ? leftDepth + 1 : rightDepth + 1;
            }
        }

        private static TreeNode<string> GetAlphaBst()
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
