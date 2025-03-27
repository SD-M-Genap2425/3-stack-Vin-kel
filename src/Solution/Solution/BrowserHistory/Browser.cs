using System;
using System.Collections.Generic;

namespace Solution.BrowserHistory {
    public class Halaman {
        public string URL { get; }

        public Halaman(string url) {
            URL = url;
        }
    }

    public class Node {
        public Halaman Data { get; }
        public Node Next { get; set; }

        public Node(Halaman data) {
            this.Data = data;
            this.Next = null;
        }
    }

    public class HistoryManager {
        private Node top;

        public HistoryManager() {
            this.top = null;
        }

        public void KunjungiHalaman(string url) {
            Halaman halaman = new Halaman(url);
            Node newNode = new Node(halaman);
            newNode.Next = top;
            top = newNode;
        }

        public string Kembali() {
            if (top == null || top.Next == null) {
                return "Tidak ada halaman sebelumnya.";
            }

            top = top.Next;
            return top.Data.URL;
        }

        public string LihatHalamanSaatIni() {
            return top?.Data.URL;
        }

        public string TampilkanHistory() {
            if (top == null) {
            return "";
        }

        List<string> urls = new List<string>();
        Node current = top;
    
        while (current != null) {
            urls.Add(current.Data.URL);
            current = current.Next;
        }

        urls.Reverse();

        string result = string.Join(Environment.NewLine, urls);

        for (int i = 0; i < urls.Count; i++) {
        Console.WriteLine($"{i+1}. {urls[i]}");
        }

        return result;
        }
    }
}