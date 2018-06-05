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
            // Q: Is the value an int? input = root, value, sum? output = void, print to console?
            // A) public void PrintPathsToSum(root, sum, listOfValues)
            //        if (list.Sum() == sum) PrintList() & move left and right;
            //        if (list.Sum() > sum) move left and right through the tree
            //        if (list.Sum() < sum) add node.Value to the list

            // This next set of tree problems includes tree traversals
            // 1. Given a BST, create a linkedlist of all the nodes at each depth
            // Q's: Is the tree balanced? How deep is it? 
            // Input = a bst?
            // Output = a list of linked lists?
            // Should I write my TreeNode and ListNode classes? Handle edge cases?
            Console.WriteLine("\nThis set of tree problems includes traversals.");
            Console.WriteLine("1. Given a BST, create a linked list of all the nodes at each depth.");

            // A. create bst
            Console.WriteLine("\nA. Create binary search tree.");
            TreeNode<string> root = GetAlphaBst();

            // B. find the depth of the tree
            Console.WriteLine("B. Find the depth of the tree. Turns out there's no need to do this if main method includes creating the listoflists. Maybe update method?");
            int depth = GetBstDepth(root);
            Console.WriteLine($"Depth is {depth}");
            
            // C. Create linked lists
            Console.WriteLine("C. Create linked lists for each depth. Store in a list of linkedlists");
            List<ListNode<string>> listOfLinkedLists = GetListOfLinkedLists(depth);
            
            Console.WriteLine($"Size of listOfLinkedList = {listOfLinkedLists.Count}");

            // D. Traverse the tree and store data in the linked lists
            Console.WriteLine("D. Traverse the tree and store the data in the linked lists.");
            PopulateListOfLinkedLists(listOfLinkedLists, root, 0);
            PrintListNodesAtEachDepth(listOfLinkedLists);

            Console.ReadKey();
        }

        private static void PrintListNodesAtEachDepth(List<ListNode<string>> listOfLinkedLists)
        {
            Console.WriteLine();
            for (int i = 0; i < listOfLinkedLists.Count; ++i)
            {
                var current = listOfLinkedLists[i];
                while (current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }
                Console.WriteLine();
            }
        }

        private static void PopulateListOfLinkedLists(List<ListNode<string>> listOfLinkedLists, TreeNode<string> root, int depth)
        {
            // base case
            if (root == null)
            {
                return;
            }
            else // add some nodes!
            {
                Console.WriteLine(root.Data); // for testing

                // 1st create a new ListNode
                var listNode = new ListNode<string>(root.Data);

                // case listOfLinkedLists is null
                if (listOfLinkedLists == null)
                {
                    listOfLinkedLists = new List<ListNode<string>>();
                }                
                else if (depth > listOfLinkedLists.Count) // case list doesn't have this index (depth) yet
                {
                    listOfLinkedLists.Add(listNode);
                }
                else // case a linked list already exists at this depth (index), so add to it to the front of the linked list
                {
                    listNode.Next = listOfLinkedLists[depth];
                    listOfLinkedLists[depth] = listNode;
                }

                // increment depth
                ++depth;

                // traverse the tree
                PopulateListOfLinkedLists(listOfLinkedLists, root.Left, depth);
                PopulateListOfLinkedLists(listOfLinkedLists, root.Right, depth);
            }
        }

        private static List<ListNode<string>> GetListOfLinkedLists(int depth)
        {
            var listOfListNodes = new List<ListNode<string>>();
            for (int i = 0; i < depth; i++)
            {
                var node = new ListNode<string>("a");
                node = null;
                listOfListNodes.Add(node);
            }

            return listOfListNodes;
        }
        
        private static int GetBstDepth(TreeNode<string> treeNode)
        {
            // base case
            if (treeNode == null)
            {
                return 0;
            }
            else // depth is at least 1
            {
                // left case
                int leftDepth = GetBstDepth(treeNode.Left);

                // right case
                int rightDepth = GetBstDepth(treeNode.Right);

                // return larger of left case or right case
                return leftDepth > rightDepth ? leftDepth + 1 : rightDepth + 1; // Need to add 1 for root node
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
