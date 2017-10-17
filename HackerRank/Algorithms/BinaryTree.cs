using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace HackerRank.Algorithms
{
    public class BinaryTree
    {
        public BinaryTreeNode Head;

        public BinaryTree()
        {

        }

        public BinaryTree(int value)
        {
            Head = new BinaryTreeNode(value);
        }

        public void AddRange(int[] values)
        {
            foreach (var item in values)
            {
                Add(item);
            }
        }

        public void Add(int value)
        {
            if (Head == null)
            {
                Head = new BinaryTreeNode(value);
            }
            else
            {
                AddTo(Head, value);
            }
        }

        private static void AddTo(BinaryTreeNode node, int value)
        {
            if (value >= node.Value)
            {
                if(node.RightNode == null)
                {
                    node.RightNode = new BinaryTreeNode(value);
                }
                else
                {
                    AddTo(node.RightNode, value);
                }
            }
            else
            {
                if (node.LeftNode == null)
                {
                    node.LeftNode = new BinaryTreeNode(value);
                }
                else
                {
                    AddTo(node.LeftNode, value);
                }
            }
        }

        public bool Contains(int value)
        {
            return FindWithParent(value, out var parent) != null;
        }

        public BinaryTreeNode FindWithParent(int value, out BinaryTreeNode parent)
        {
            var current = Head;
            parent = null;

            while(current != null)
            {
                if (value < current.Value)
                {
                    parent = current;
                    current = current.LeftNode;
                }
                else if(value > current.Value)
                {
                    parent = current;
                    current = current.RightNode;
                }
                else
                {
                    break;
                }
            }

            return current;
        }

        public bool Remove(int value)
        {
            var nodeToRemove = FindWithParent(value, out var parent);

            if (nodeToRemove == null)
            {
                return false;
            }

            if (nodeToRemove.RightNode == null)
            {
                if (parent == null)
                {
                    Head = nodeToRemove.LeftNode;
                }
                else if (parent.Value > nodeToRemove.Value)
                {
                    parent.LeftNode = nodeToRemove.LeftNode;
                }
                else if(parent.Value < nodeToRemove.Value)
                {
                    parent.RightNode = nodeToRemove.LeftNode;
                }
            }
            else if(nodeToRemove.RightNode.LeftNode == null)
            {
                nodeToRemove.RightNode.LeftNode = nodeToRemove.LeftNode;
                if(parent == null)
                {
                    Head = nodeToRemove.RightNode;
                }
                else  if (parent.Value > nodeToRemove.Value)
                {
                    parent.LeftNode = nodeToRemove.RightNode;
                }
                else if (parent.Value < nodeToRemove.Value)
                {
                    parent.RightNode = nodeToRemove.RightNode;
                }
            }
            else
            {
                var leftMost = nodeToRemove.RightNode.LeftNode;
                var leftMostParent = nodeToRemove.RightNode;

                while (leftMost == null)
                {
                    leftMostParent = leftMost;
                    leftMost = leftMost.LeftNode;
                }

                leftMost.RightNode = leftMostParent;
                leftMost.LeftNode = nodeToRemove.LeftNode;

                if (parent.Value > nodeToRemove.Value)
                {
                    parent.LeftNode = leftMost;
                }
                else if (parent.Value < nodeToRemove.Value)
                {
                    parent.RightNode = leftMost;
                }
            }

            return true;
        }
    }

    public class BinaryTreeNode
    {
        public BinaryTreeNode(int initialValue)
        {
            Value = initialValue;
        }

        public int Value { get; protected set; }

        public BinaryTreeNode LeftNode { get; set; }

        public BinaryTreeNode RightNode { get; set; }
    }
}
