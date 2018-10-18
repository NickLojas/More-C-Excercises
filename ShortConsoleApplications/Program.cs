using System;


namespace ShortConsoleApplications
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Names question

            string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
            string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", Names.FindCommon(names1, names2))); // should print Ava, Emma, Olivia, Sophia

            //Palindrome question
            Console.WriteLine("Racecar " + Palindrome.IsPalindrome("Racecar"));
            Console.WriteLine("NotPalindrome " + Palindrome.IsPalindrome("NotPalindrome"));

            //BST question
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);
            Console.WriteLine(BinarySearchTree.Contains(n2, 3));

            //Song question
            Song first = new Song("Hello");
            Song second = new Song("Eye of the tiger");

            first.NextSong = second;
            second.NextSong = first;

            Console.WriteLine(first.IsRepeatingPlaylist());
        }
    }
}

