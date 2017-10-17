using FluentAssertions;
using HackerRank.Algorithms;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankTest.Algorithms
{
    public class BinaryTreeTest
    {
        [Test]
        public void Add_SmallerValue_ShouldBeAddedTo_LeftNode()
        {
            var tree = new BinaryTree();
            tree.Add(5);
            tree.Add(3);

            tree.Head.LeftNode.Value.Should().Be(3);
        }

        [Test]
        public void Add_BiggerValue_ShouldBeAddedTo_RightNode()
        {
            var tree = new BinaryTree();
            tree.Add(5);
            tree.Add(8);

            tree.Head.RightNode.Value.Should().Be(8);
        }

        [Test]
        public void Add_SameValue_ShouldBeAddedTo_RightNode()
        {
            var tree = new BinaryTree();
            tree.Add(5);
            tree.Add(5);

            tree.Head.RightNode.Value.Should().Be(5);
        }

        [Test]
        public void Contains_ExistingSmallerThanCurrent_ShouldReturnTrue()
        {
            var tree = new BinaryTree(5);
            tree.Add(3);

            tree.Contains(3).Should().BeTrue();
        }

        [Test]
        public void Contains_ExistingBiggerThanCurrent_ShouldReturnTrue()
        {
            var tree = new BinaryTree(5);
            tree.Add(7);

            tree.Contains(7).Should().BeTrue();
        }

        [Test]
        public void Contains_NonExisting_ShouldReturnFalse()
        {
            var tree = new BinaryTree(5);
            tree.Add(3);
            tree.Add(7);

            tree.Contains(8).Should().BeFalse();
            tree.Contains(1).Should().BeFalse();
        }

        [Test]
        public void Contains_All()
        {
            var tree = new BinaryTree(5);
            tree.Add(3);
            tree.Add(7);

            tree.Contains(3).Should().BeTrue();
            tree.Contains(7).Should().BeTrue();
            tree.Contains(8).Should().BeFalse();
            tree.Contains(1).Should().BeFalse();

            tree.FindWithParent(3, out BinaryTreeNode parent).Value.Should().Be(3);
            parent.Value.Should().Be(5);
            tree.FindWithParent(7, out parent).Value.Should().Be(7);
            parent.Value.Should().Be(5);
        }

        [Test]
        public void Remove_Head()
        {
            BinaryTree tree = new BinaryTree();
            tree.AddRange(new[] { 4, 5, 2, 7, 3, 6, 1, 8 });

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Remove(4).Should().BeTrue();

            //        5
            //       /   \
            //      2      7
            //     / \    / \
            //    1   3  6  8

            tree.Contains(4).Should().BeFalse();

            tree.Contains(5).Should().BeTrue();

            tree.Contains(2).Should().BeTrue();
            tree.Contains(1).Should().BeTrue();
            tree.Contains(3).Should().BeTrue();

            tree.Contains(7).Should().BeTrue();
            tree.Contains(6).Should().BeTrue();
            tree.Contains(8).Should().BeTrue();
        }

        [Test]
        public void Remove_Head_Line_Right()
        {
            BinaryTree tree = new BinaryTree();
            tree.AddRange(new[] { 1, 2, 3 });

            // 1
            //  \
            //   2
            //    \
            //     3

            tree.Remove(1).Should().BeTrue();

            // 2
            //  \
            //   3

            tree.Contains(1).Should().BeFalse();
            tree.Contains(2).Should().BeTrue();
            tree.Contains(3).Should().BeTrue();
        }

        [Test]
        public void Remove_Head_Line_Left()
        {
            BinaryTree tree = new BinaryTree();
            tree.AddRange(new[] { 3, 2, 1 });
            //     3
            //    /
            //   2
            //  /
            // 1

            tree.Remove(3);

            //   2
            //  /
            // 1

            tree.Contains(3).Should().BeFalse();
            tree.Contains(2).Should().BeTrue();
            tree.Contains(1).Should().BeTrue();
        }

        [Test]
        public void Remove_Head_Only_Node()
        {
            BinaryTree tree = new BinaryTree(4);

            tree.Remove(4).Should().BeTrue();
            tree.Contains(4).Should().BeFalse();
        }

        [Test]
        public void Remove_Node_No_Left_Child()
        {
            BinaryTree tree = new BinaryTree();
            tree.AddRange(new[] { 4, 2, 1, 3, 5, 7, 6, 8 });

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Remove(5).Should().BeTrue();

            //        4
            //       /  \
            //      2    6
            //     / \    \
            //    1   3    7
            //              \
            //               8

            tree.Contains(5).Should().BeFalse();

            tree.Contains(2).Should().BeTrue();
            tree.Contains(1).Should().BeTrue();
            tree.Contains(3).Should().BeTrue();

            tree.Contains(6).Should().BeTrue();
            tree.Contains(7).Should().BeTrue();
            tree.Contains(8).Should().BeTrue();
        }

        [Test]
        public void Remove_Node_Right_Leaf()
        {
            BinaryTree tree = new BinaryTree();
            tree.AddRange(new[] { 4, 5, 2, 7, 3, 6, 1, 8 });

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Remove(8).Should().BeTrue();

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           /
            //          6

            tree.Contains(8).Should().BeFalse();

            tree.Contains(2).Should().BeTrue();
            tree.Contains(1).Should().BeTrue();
            tree.Contains(3).Should().BeTrue();

            tree.Contains(5).Should().BeTrue();
            tree.Contains(7).Should().BeTrue();
            tree.Contains(6).Should().BeTrue();
        }

        [Test]
        public void Remove_Node_Left_Leaf()
        {
            BinaryTree tree = new BinaryTree();
            tree.AddRange(new[] { 4, 5, 2, 7, 3, 6, 1, 8 });

            //        4
            //       / \
            //      2   5
            //     / \   \
            //    1   3   7
            //           / \
            //          6   8

            tree.Remove(1).Should().BeTrue();

            //        4
            //       / \
            //      2   5
            //       \   \
            //        3   7
            //           / \
            //          6   8

            tree.Contains(1).Should().BeFalse();

            tree.Contains(2).Should().BeTrue();
            tree.Contains(3).Should().BeTrue();

            tree.Contains(5).Should().BeTrue();
            tree.Contains(7).Should().BeTrue();
            tree.Contains(6).Should().BeTrue();
            tree.Contains(8).Should().BeTrue();
        }

        [Test]
        public void Remove_Current_Right_Has_No_Left()
        {
            BinaryTree tree = new BinaryTree();
            tree.AddRange(new[] { 4, 6, 2, 1, 3, 5, 7, 8 });

            //         4
            //       /   \
            //      2     6
            //     / \    /\
            //    1   3  5  7
            //               \
            //                8

            tree.Remove(6).Should().BeTrue();

            //          4
            //       /    \
            //      2      7
            //     / \    / \
            //    1   3  5   8

            tree.Contains(6).Should().BeFalse();

            tree.Contains(2).Should().BeTrue();
            tree.Contains(1).Should().BeTrue();
            tree.Contains(3).Should().BeTrue();

            tree.Contains(7).Should().BeTrue();
            tree.Contains(5).Should().BeTrue();
            tree.Contains(8).Should().BeTrue();
        }

        [Test]
        public void Remove_Current_Has_No_Right()
        {
            BinaryTree tree = new BinaryTree();
            tree.AddRange(new[] { 4, 2, 1, 3, 8, 6, 7, 5 });

            //         4
            //       /   \
            //      2     8 
            //     / \    /
            //    1   3  6
            //          / \
            //         5   7   

            tree.Remove(8).Should().BeTrue();

            //         4
            //       /   \
            //      2      6 
            //     / \    / \
            //    1   3  5   7

            tree.Contains(8).Should().BeFalse();

            tree.Contains(2).Should().BeTrue();
            tree.Contains(1).Should().BeTrue();
            tree.Contains(3).Should().BeTrue();

            tree.Contains(6).Should().BeTrue();
            tree.Contains(5).Should().BeTrue();
            tree.Contains(7).Should().BeTrue();
        }

        [Test]
        public void Remove_Current_Right_Has_Left()
        {
            BinaryTree tree = new BinaryTree();
            tree.AddRange(new[] { 4, 2, 1, 3, 6, 5, 8, 7 });

            //         4
            //       /    \
            //      2      6 
            //     / \    / \
            //    1   3  5   8
            //              /
            //             7

            tree.Remove(6).Should().BeTrue();

            //         4
            //       /    \
            //      2      7 
            //     / \    / \
            //    1   3  5   8

            tree.Contains(6).Should().BeFalse();

            tree.Contains(2).Should().BeTrue();
            tree.Contains(1).Should().BeTrue();
            tree.Contains(3).Should().BeTrue();

            tree.Contains(7).Should().BeTrue();
            tree.Contains(5).Should().BeTrue();
            tree.Contains(8).Should().BeTrue();
        }

        [Test]
        public void Remove_From_Empty()
        {
            BinaryTree tree = new BinaryTree();
            tree.Remove(10).Should().BeFalse();
        }
    }
}
