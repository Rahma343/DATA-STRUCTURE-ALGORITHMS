using System;
using System.Collections;
using System.Collections.Generic;


#region Main Tester
class Program
{
    static void Main()
    {
        ConsoleKey choice;
        bool quit = false;

        do
        {
            // Clear the console.
           Console. Clear();

            // Show command menu.
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("-    Testing Mohyeldin.DSA - Tree Data Structure     -");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Choose Test [1-2]:");
            Console.WriteLine("1 - Test BinaryTree<int>");
            Console.WriteLine("2 - Test BinarySearchTree<int>");
            Console.WriteLine("0 or Q - Quit.");

            // Get user choice.
            choice =  Console.ReadKey(true).Key;

            // Dispatch user choice.
            switch (choice)
            {
                case ConsoleKey.D1:
                    Test_BinaryTree();
                    break;

                case ConsoleKey.D2:
                    Test_BinarySearchTree();
                    break;

                case ConsoleKey.D0:
                case ConsoleKey.Q:
                    quit = true;
                    break;

                default:
                    Console.WriteLine($"Sorry {choice} is wrong choice, press any key to continue...");
                    Console.ReadKey(); // Wait for a key press.
                    break;
            }
        } while (!quit);

        // Example Tree #1: BT of 8 nodes.
        //
        //                          1
        //                        /   \
        //                       2     3
        //                      /       \
        //                     4         5
        //                     \          \
        //                      6          7
        //                                  \
        //                                   8
        //


        // Example Tree #2: BST of 7 nodes.
        //                           1
        //                        /     \
        //                       2       3
        //                     /   \   /   \
        //                    4     5  6    7
        //
    }

    /// <summary> 
    /// Defines the BinaryTree{T} Class test driver. 
    /// </summary>
    static void Test_BinaryTree()
    {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("-          Testing Mohyeldin.DSA.BinaryTree<T>       -");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(@"+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
        Console.WriteLine(@"- Test Tree Topology: Binary Search Tree of 7 nodes -");
        Console.WriteLine(@"+                                                   +");
        Console.WriteLine(@"-                          1                        -");
        Console.WriteLine(@"+                       /     \                     +");
        Console.WriteLine(@"-                      2       3                    -");
        Console.WriteLine(@"+                    /           \                  +");
        Console.WriteLine(@"-                   4             5                 -");
        Console.WriteLine(@"-                     \             \               -");
        Console.WriteLine(@"-                       6             7             -");
        Console.WriteLine(@"-                                      \            -");
        Console.WriteLine(@"-                                       8          -");
        Console.WriteLine(@"+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");

        // The following code fragment generates the BT shown above.
        BinaryTree<int> bTree = new BinaryTree<int>();
        bTree.Root = new BinaryTreeNode<int>(1);
        bTree.Root.Left = new BinaryTreeNode<int>(2);
        bTree.Root.Right = new BinaryTreeNode<int>(3);

        bTree.Root.Left.Left = new BinaryTreeNode<int>(4);
        bTree.Root.Right.Right = new BinaryTreeNode<int>(5);

        bTree.Root.Left.Left.Right = new BinaryTreeNode<int>(6);
        bTree.Root.Right.Right.Right = new BinaryTreeNode<int>(7);

        bTree.Root.Right.Right.Right.Right = new BinaryTreeNode<int>(8);

        // Test BTree.PreorderTraversal(BTree.Root):
        Console.WriteLine("Test: Preorder Traversal of BinaryTree bTree1:");
        bTree.PreorderTraversal(bTree.Root);

        // Test BTree.InorderTraversal(BTree.Root):
        Console.WriteLine("Test: Inorder Traversal of BinaryTree bTree1:");
        bTree.InorderTraversal(bTree.Root);

        // Test BTree.PostorderTraversal(BTree.Root):
        Console.WriteLine("Test: Postorder Traversal of BinaryTree bTree1:");
        bTree.PostorderTraversal(bTree.Root);


        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(); // Wait for a key press.
    }

    /// <summary> 
    /// Defines the BinarySearchTree{T} Class test driver. 
    /// </summary>
    static void Test_BinarySearchTree()
    {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("-       Testing Mohyeldin.DSA.BinarySearchTree<T>    -");
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(@"+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
        Console.WriteLine(@"- Test Tree Topology: Binary Search Tree of 7 nodes -");
        Console.WriteLine(@"+                                                   +");
        Console.WriteLine(@"-                          4                        -");
        Console.WriteLine(@"+                       /     \                     +");
        Console.WriteLine(@"-                      2       6                    -");
        Console.WriteLine(@"+                    /   \   /   \                  +");
        Console.WriteLine(@"-                   1     3  5    7                 -");
        Console.WriteLine(@"+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");

        // The following code fragment generates the BST shown above.
        BinarySearchTree<int> bsTree = new BinarySearchTree<int>();
        bsTree.Add(4);
        bsTree.Add(6);
        bsTree.Add(2);
        bsTree.Add(5);
        bsTree.Add(1);
        bsTree.Add(3);
        bsTree.Add(7);

        //Test the BST.Count property.
        Console.WriteLine($"Test: BSTree.Count = {bsTree.Count} nodes.\n\n");

        // Test BST.ToString() method.
        Console.WriteLine("Test: BST.ToString()");
        Console.WriteLine(bsTree.ToString());
        Console.WriteLine("Test: BST.ToString(TraversalMethod.Inorder)");
        Console.WriteLine(bsTree.ToString(TraversalMethod.Inorder));
        Console.WriteLine("\n");

        // Test BST.Contains(value) method.            
        Console.WriteLine("Test: Search for a node with specific value:");
        Console.WriteLine($"BSTree.Contains(3) => {bsTree.Contains(3)}");
        Console.WriteLine($"BSTree.Contains(9) => {bsTree.Contains(9)}");
        Console.WriteLine("\n");

        // Test BST.Preorder traversal property.
        Console.WriteLine("Test: BST.Preorder (Preorder Traversal):");
        foreach (var item in bsTree.Preorder)
        {
            Console.WriteLine($"{item}\t");
        }
        Console.WriteLine();

        // Test BST.Inorder traversal property.
        Console.WriteLine("Test: BST.Inorder (Inorder Traversal):");
        foreach (var item in bsTree.Inorder)
        {
            Console.WriteLine($"{item}\t");
        }
        Console.WriteLine();

        // Test BST.Postorder traversal property..
        Console.WriteLine("Test: BST.Postorder (Postorder Traversal):");
        foreach (var item in bsTree.Postorder)
        {
            Console.WriteLine($"{item}\t");
        }
        Console.WriteLine("\n");

        // Test BST.GetEnumerator(TraversalMethod.Preorder) traversal method.
        Console.WriteLine("Test: BST.GetEnumerator(TraversalMethod.Preorder):");
        var inorderIterator = bsTree.GetEnumerator(TraversalMethod.Preorder);
        while (inorderIterator.MoveNext())
        {
            Console.WriteLine($"{inorderIterator.Current.ToString()}\t");
        }
        Console.WriteLine("");

        // Test BST.GetEnumerator(TraversalMethod.Inorder) traversal method.
        Console.WriteLine("Test: BST.GetEnumerator(TraversalMethod.Inorder):");
        inorderIterator = bsTree.GetEnumerator(TraversalMethod.Inorder);
        while (inorderIterator.MoveNext())
        {
            Console.WriteLine($"{inorderIterator.Current.ToString()}\t");
        }
        Console.WriteLine("");

        // Test BST.GetEnumerator(TraversalMethod.Postorder) traversal method.
        Console.WriteLine("Test: BST.GetEnumerator(TraversalMethod.Postorder):");
        inorderIterator = bsTree.GetEnumerator(TraversalMethod.Postorder);
        while (inorderIterator.MoveNext())
        {
            Console.WriteLine($"{inorderIterator.Current.ToString()}\t");
        }
        Console.WriteLine("\n");

        // Test BST.Remove() method
        Console.WriteLine("Test: BST.Remove(4):");
        bsTree.Remove(4); // Remove node with value 4.            
        Console.WriteLine($"After node of value = 4 is removed: BST.Count = {bsTree.Count} nodes.");
        Console.WriteLine("BSTree.Inorder Traversal:");
        foreach (var item in bsTree.Inorder)
        {
            Console.WriteLine($"{item}\t");
        }
        Console.WriteLine("\n");

        // Test BST.Clear() method.
        Console.WriteLine("Test: BST.Clear():");
        bsTree.Clear(); // Remove the entire tree.
        Console.WriteLine($"After clearing the entire tree: BSTree.Count = {bsTree.Count} nodes.\n");

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey(); // Wait for a key press.
    }
    public enum TraversalMethod
    {
        Inorder,
        Preorder,
        Postorder
    }

    public class BinarySearchTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        #region Node Definition
        private class Node
        {
            public T Value;
            public Node Left, Right;

            public Node(T value)
            {
                Value = value;
            }
        }
        #endregion

        #region Fields and Properties
        private Node root;
        public int Count { get; private set; }
        #endregion

        #region Add
        public void Add(T value)
        {
            root = Add(root, value);
            Count++;
        }

        private Node Add(Node node, T value)
        {
            if (node == null) return new Node(value);
            if (value.CompareTo(node.Value) < 0)
                node.Left = Add(node.Left, value);
            else
                node.Right = Add(node.Right, value);
            return node;
        }
        #endregion

        #region Contains
        public bool Contains(T value) => Contains(root, value);

        private bool Contains(Node node, T value)
        {
            if (node == null) return false;
            int cmp = value.CompareTo(node.Value);
            if (cmp == 0) return true;
            return cmp < 0 ? Contains(node.Left, value) : Contains(node.Right, value);
        }
        #endregion

        #region Clear
        public void Clear()
        {
            root = null;
            Count = 0;
        }
        #endregion

        #region Remove
        public bool Remove(T value)
        {
            bool removed;
            (root, removed) = Remove(root, value);
            if (removed) Count--;
            return removed;
        }

        private (Node, bool) Remove(Node node, T value)
        {
            if (node == null) return (null, false);
            int cmp = value.CompareTo(node.Value);
            if (cmp < 0)
            {
                (node.Left, var removed) = Remove(node.Left, value);
                return (node, removed);
            }
            else if (cmp > 0)
            {
                (node.Right, var removed) = Remove(node.Right, value);
                return (node, removed);
            }
            else
            {
                if (node.Left == null) return (node.Right, true);
                if (node.Right == null) return (node.Left, true);
                var min = FindMin(node.Right);
                node.Value = min.Value;
                (node.Right, _) = Remove(node.Right, min.Value);
                return (node, true);
            }
        }

        private Node FindMin(Node node)
        {
            while (node.Left != null) node = node.Left;
            return node;
        }
        #endregion

        #region ToString
        public override string ToString() => string.Join(" ", Inorder);

        public string ToString(TraversalMethod method)
        {
            return method switch
            {
                TraversalMethod.Preorder => string.Join(" ", Preorder),
                TraversalMethod.Inorder => string.Join(" ", Inorder),
                TraversalMethod.Postorder => string.Join(" ", Postorder),
                _ => string.Join(" ", Inorder),
            };
        }
        #endregion

        #region Traversals
        public IEnumerable<T> Preorder => TraversePreorder(root);
        public IEnumerable<T> Inorder => TraverseInorder(root);
        public IEnumerable<T> Postorder => TraversePostorder(root);

        private IEnumerable<T> TraversePreorder(Node node)
        {
            if (node != null)
            {
                Console.Write($"{node.Value}\t");
                yield return node.Value;
                foreach (var v in TraversePreorder(node.Left)) yield return v;
                foreach (var v in TraversePreorder(node.Right)) yield return v;
            }
        }

        private IEnumerable<T> TraverseInorder(Node node)
        {
            if (node != null)
            {
                foreach (var v in TraverseInorder(node.Left)) yield return v;
                Console.Write($"{node.Value}\t");
                yield return node.Value;
                foreach (var v in TraverseInorder(node.Right)) yield return v;
            }
        }

        private IEnumerable<T> TraversePostorder(Node node)
        {
            if (node != null)
            {
                foreach (var v in TraversePostorder(node.Left)) yield return v;
                foreach (var v in TraversePostorder(node.Right)) yield return v;
                Console.Write($"{node.Value}\t");
                yield return node.Value;
            }
        }
        #endregion

        #region IEnumerable
        public IEnumerator<T> GetEnumerator() => Inorder.GetEnumerator();

        public IEnumerator<T> GetEnumerator(TraversalMethod method)
        {
            return method switch
            {
                TraversalMethod.Preorder => Preorder.GetEnumerator(),
                TraversalMethod.Inorder => Inorder.GetEnumerator(),
                TraversalMethod.Postorder => Postorder.GetEnumerator(),
                _ => Inorder.GetEnumerator(),
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        #endregion
    }


    #region BinaryTree Class
    public class BinaryTree<T>
    {
        // Private field
        private BinaryTreeNode<T> root = null;

        #region Constructors
        public BinaryTree()
        {
        }

        ~BinaryTree()
        {
            // Optional: cleanup code here if needed
        }
        #endregion

        #region Public Methods

        public void Clear(T value)
        {
            // Clear tree logic (implementation not shown in diagram)
            root = null; // Placeholder logic
        }

        public void InorderTraversal(BinaryTreeNode<T> current)
        {
            if (current == null) return;

            InorderTraversal(current.Left);
            // Process current.Value
            InorderTraversal(current.Right);
        }

        public void PreorderTraversal(BinaryTreeNode<T> current)
        {
            if (current == null) return;

            // Process current.Value
            PreorderTraversal(current.Left);
            PreorderTraversal(current.Right);
        }

        public void PostorderTraversal(BinaryTreeNode<T> current)
        {
            if (current == null) return;

            PostorderTraversal(current.Left);
            PostorderTraversal(current.Right);
            // Process current.Value
        }

        #endregion

        #region Property
        public BinaryTreeNode<T> Root
        {
            get { return root; }
            set { root = value; }
        }
        #endregion
    }
    #endregion

    #region BinaryTreeNode Class
    public class BinaryTreeNode<T>
    {
        // Private fields
        private BinaryTreeNode<T> left = null;
        private BinaryTreeNode<T> right = null;
        private T value = default(T);

        #region Constructors
        public BinaryTreeNode()
        {
        }

        public BinaryTreeNode(T value)
        {
            this.value = value;
        }

        public BinaryTreeNode(T value, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
        #endregion

        #region Destructor
        ~BinaryTreeNode()
        {
            // Optional: cleanup code here if needed
        }
        #endregion

        #region Properties
        public BinaryTreeNode<T> Left
        {
            get { return left; }
            set { left = value; }
        }

        public BinaryTreeNode<T> Right
        {
            get { return right; }
            set { right = value; }
        }

        public T Value
        {
            get { return value; }
            set { this.value = value; }
        }
        #endregion
    }
    #endregion





}
#endregion
