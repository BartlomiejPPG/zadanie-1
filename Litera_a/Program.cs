using System;
namespace imienazwisko
{
    class zadanie1
    {
        static void Main(string[] args)
        {
            string plik = @"C:\test\test_jakub_wanat.txt";
            string nazwa = Path.GetFileName(plik);
            int countA = CountOccurrences(nazwa, 'a');
            Console.WriteLine(countA);
        }
        static int CountOccurrences(string text, char target)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (c == target)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
