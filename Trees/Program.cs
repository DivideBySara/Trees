using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class TreeNode<T>
    {
        T data;
        TreeNode<T> left;
        TreeNode<T> right;

        public TreeNode(T data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }

    class ListNode<T>
    {
        T data;
        ListNode<T> next;

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
        }
    }
}
