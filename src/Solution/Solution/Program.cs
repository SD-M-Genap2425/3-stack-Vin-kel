using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
            HistoryManager history = new HistoryManager();

            history.KunjungiHalaman("google.com");
            Console.WriteLine("Mengunjungi halaman: google.com");

            history.KunjungiHalaman("example.com");
            Console.WriteLine("Mengunjungi halaman: example.com");

            history.KunjungiHalaman("stackoverflow.com");
            Console.WriteLine("Mengunjungi halaman: stackoverflow.com");

            Console.WriteLine($"Halaman saat ini: {history.LihatHalamanSaatIni()}");

            Console.WriteLine("Kembali ke halaman sebelumnya...");
            string previousPage = history.Kembali();
            Console.WriteLine($"Halaman saat ini: {history.LihatHalamanSaatIni()}");

            Console.WriteLine("Menampilkan history:");
            history.TampilkanHistory();
        
        
        
            string ekspresiValid = "[{}](){}"; 
            string ekspresiInvalid = "(]";

    
            var validator = new BracketValidator();
            Console.WriteLine($"Ekspresi '{ekspresiValid}' valid? {validator.ValidasiEkspresi(ekspresiValid)}");
            Console.WriteLine($"Ekspresi '{ekspresiInvalid}' valid? {validator.ValidasiEkspresi(ekspresiInvalid)}");

        

            string[] testCases = { "Kasur ini rusak", "Ibu Ratna antar ubi", "Hello World" };
            
            foreach (var test in testCases) {
                Console.WriteLine($"Input: \"{test}\" -> Output: {PalindromeChecker.CekPalindrom(test)}");
            }

        

    }
}
