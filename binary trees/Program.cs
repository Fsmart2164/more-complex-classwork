using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace binary_trees
{
    internal class Program
    {
        struct TreeNode
        {
            public int Left, Right;
            public string Data;

            public TreeNode(int left, int right, string data)
            {
                Left = left;
                Right = right;
                Data = data;
            }
        }

        static void InOrderTraverse(TreeNode[] tree, int currentNode)
        {
            if (currentNode != 0)
            {
                // Left
                InOrderTraverse(tree, tree[currentNode].Left);

                // Print
                Console.WriteLine(tree[currentNode].Data);

                // Right
                InOrderTraverse(tree, tree[currentNode].Right);
            }
        }

        static void PreOrderTraverse(TreeNode[] tree, int currentNode)
        {
            if (currentNode != 0)
            {
                // Print
                Console.WriteLine(tree[currentNode].Data);
                // Left
                PreOrderTraverse(tree, tree[currentNode].Left);



                // Right
                PreOrderTraverse(tree, tree[currentNode].Right);
            }
        }

        static void PostOrderTraversal(TreeNode[] tree, int currentNode)
        {
            if (currentNode != 0)
            {
                PostOrderTraversal(tree, tree[currentNode].Left);
                PostOrderTraversal(tree,tree[currentNode].Right);
                Console.WriteLine(tree[currentNode].Data);
            }
        }

        static void insert(ref TreeNode[] tree, string data,int currentnode)
        {

        }

        static void Main(string[] args)
        {
            TreeNode[] tree = new TreeNode[10];

            tree[1] = new TreeNode(2, 5, "Humboldt");
            tree[2] = new TreeNode(0, 3, "Adelie");
            tree[3] = new TreeNode(4, 7, "Emperor");
            tree[4] = new TreeNode(0, 0, "African");
            tree[5] = new TreeNode(8, 6, "Macaroni");
            tree[6] = new TreeNode(0, 0, "Snares");
            tree[7] = new TreeNode(0, 0, "Fairy");
            tree[8] = new TreeNode(0, 0, "King");

            PreOrderTraverse(tree, 1);
        }

        }
    }
