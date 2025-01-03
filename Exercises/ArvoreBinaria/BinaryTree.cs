using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode<T>? Root { get; set; }
        public int Count { get; set; }

        public enum TraversalEnum
        {
            PREORDER, INORDER, POSTORDER
        }
        public void TraversePreOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                result.Add(node);
                TraversePreOrder(node.Left, result);
                TraversePreOrder(node.Right, result);

            }
        }
        public void TraverseInOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                result.Add(node);
                TraverseInOrder(node.Left, result);
                TraverseInOrder(node.Right, result);

            }
        }

        public void TraversePostOrder(BinaryTreeNode<T> node, List<BinaryTreeNode<T>> result)
        {
            if (node != null)
            {
                result.Add(node);
                TraversePostOrder(node.Left, result);
                TraversePostOrder(node.Right, result);

            }
        }

        public List<BinaryTreeNode<T>> Traverse(TraversalEnum node)
        {
            List<BinaryTreeNode<T>> nodes = new List<BinaryTreeNode<T>>();

            switch (node)
            {
                case TraversalEnum.PREORDER:
                    TraversePreOrder(Root!, nodes);
                    break;

                case TraversalEnum.POSTORDER:
                    TraversePostOrder(Root!, nodes);
                    break;

                case TraversalEnum.INORDER:
                    TraverseInOrder(Root!, nodes);
                    break;
            }
            return nodes;
        }
        public int GetHeight()
        {
            int height = 0;
            foreach (BinaryTreeNode<T> node in Traverse(TraversalEnum.PREORDER))
            {
                height = Math.Max(height, node.GetHeight()); // Math.Max só vai comparar o maior valor que ele trouxe
            }
            return height;
        }
    }
}