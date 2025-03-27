using System;

namespace Solution.BracketValidation { 
    public class Node {
        public char Data {get;}
        public Node Next {get;set;}

        public Node(char data) {
            this.Data = data;
            this.Next = null;
        }   
    }

    public class BracketValidator {
        private Node top;

        public BracketValidator() {
            top = null;
        }

        public void Push(char ch) {
            Node newNode = new Node(ch);
            newNode.Next = top;
            top = newNode;
        }

        public char Pop() {
            if (top == null)
                return '\0';
            
            char popped = top.Data;
            top = top.Next;
            return popped;
        }

        public bool Empty() {
            return top == null;
        }

        public bool ValidasiEkspresi(string ekspresi) {
            top = null;
            
            foreach (char ch in ekspresi) {
                if (ch == '(' || ch == '{' || ch == '[') {
                    Push(ch);
                } else if (ch == ')' || ch == '}' || ch == ']') {
                    char popped = Pop();
                    if ((ch == ')' && popped != '(') ||
                        (ch == '}' && popped != '{') ||
                        (ch == ']' && popped != '[')) {
                        return false;
                    }
                }
            }
            return Empty();
        }
    }
}