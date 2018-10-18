﻿using System;
namespace ShortConsoleApplications
{

    /*Binary search tree (BST) is a binary tree where the value of each node is
     * larger or equal to the values in all the nodes in that node's left subtree 
     * and is smaller than the values in all the nodes in that node's right subtree.

    Write a function that checks if a given binary search tree contains a given value.

    For example, for the following tree:

    n1 (Value: 1, Left: null, Right: null)
    n2 (Value: 2, Left: n1, Right: n3)
    n3 (Value: 3, Left: null, Right: null)
    Call to Contains(n2, 3) should return true since a tree with root at n2 contains number 3.
    */
    public class Node
    {
        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(int value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

    public static class BinarySearchTree
    {
        public static bool Contains(Node root, int value)
        {
            if (root.Value > value){
                if (root.Left == null)
                    return false;
                return Contains(root.Left, value);
            }

            if (root.Value < value){
                if (root.Right == null)
                    return false;
                return Contains(root.Right, value);
            }

            return true;
        }
    }
}