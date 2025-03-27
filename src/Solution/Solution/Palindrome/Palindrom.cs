using System;
using System.Linq;

namespace Solution.Palindrome {
    public class Node {
        public char Data;
        public Node Next;

        public Node(char data) {
            this.Data = data;
            this.Next = null;
        }
    }

    public class LinkedListStack {
        private Node top;

        public LinkedListStack() {
            top = null;
        }

        public void Push(char data) {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        public char Pop() {
            if (top == null)
                throw new InvalidOperationException("Stack is empty");

            char value = top.Data;
            top = top.Next;
            return value;
        }

        public bool Empty() {
            return top == null;
        }
    }

    public static class PalindromeChecker {
        public static bool CekPalindrom(string input) {
            string normalized = new string(input.ToLower().Where(char.IsLetter).ToArray());
            
            LinkedListStack stack = new LinkedListStack();
            
            foreach (char c in normalized) {
                stack.Push(c);
            }

            foreach (char c in normalized) {
                if (stack.Pop() != c) {
                    return false;
                }
            }
            
            return true;
        }
    }
}