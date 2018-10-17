using System;
using System.Collections.Generic;

namespace BstTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            BST testing = new BST();
            root = testing.Insert(root, 50);
            root = testing.Insert(root, 20);
            root = testing.Insert(root, 10);
            root = testing.Insert(root, 80);
            root = testing.Insert(root, 90);
            root = testing.Insert(root, 60);
            root = testing.Insert(root, 70);
            root = testing.Insert(root, 30);

            Console.WriteLine("Breadth First Traversal");
            testing.DisplayBF(root);

            Console.WriteLine("Depth First Traversal");
            testing.DisplayDF(root);
            Console.ReadLine();
        }
    }
    
    //Class to define the nodes.
    class Node
    {
        public int value;
        public Node left;
        public Node right;

    }

    //Class to define the Binary Search Tree
    class BST
    {
        public Node Insert(Node root, int val)
        {
            //If the root node is empty create a new node
            if (root == null)
            {
                root = new Node();
                root.value = val;
            }
            //eIf the value is less than the value in the root node add it to the left
            else if(val < root.value)
            {
                root.left = Insert(root.left, val);
            }
            //If the value is greater than the value in the root node add it to the right
            else
            {
                root.right = Insert(root.right, val);
            }

            return root;
        }

        //Breadth First Traversal using a queue
        public void DisplayBF(Node root)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while(q.Count > 0)
            {
                //display that node
                Node n = q.Dequeue();
                Console.WriteLine(n.value);

                //add the next nodes depending if they are null or not.
                if (n.left != null)
                    q.Enqueue(n.left);
                if (n.right != null)
                    q.Enqueue(n.right);
            }
        }

        //Depth First Traversal using a stack
        public void DisplayDF(Node root)
        {
            Stack<Node> s = new Stack<Node>();
            s.Push(root);
            while (s.Count > 0)
            {
                //display that node
                Node n = s.Pop();
                Console.WriteLine(n.value);

                //add the next nodes depending if they are null or not.
                if (n.left != null)
                    s.Push(n.left);
                if (n.right != null)
                    s.Push(n.right);
            }

        }
    }
}
