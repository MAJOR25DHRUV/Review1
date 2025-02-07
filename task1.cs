using System;

class Program
{
    
    static string[] SplitWords(string sentence)
    {
        int count = 0;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ' ') 
            {
                count++;
            }
        }
        string[] words = new string[count + 1];
        int index = 0;
        string temp = "";
        
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                temp += sentence[i]; 
            }
            else
            {
                words[index] = temp; 
                index++;
                temp = "";
            }
        }
        words[index] = temp; 
        return words;
    }
    
    
    static bool IsGreater(string a, string b)
    {
        int len = a.Length < b.Length ? a.Length : b.Length;
        for (int i = 0; i < len; i++)
        {
            if (a[i] > b[i])
            {
                return true;
            }
            else if (a[i] < b[i])
            {
                return false;
            }
        }
        return a.Length > b.Length;
    }
    
    
    static void SortWords(string[] words)
    {
        int n = words.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (!IsGreater(words[j], words[j + 1])) 
                {
                    string temp = words[j];
                    words[j] = words[j + 1];
                    words[j + 1] = temp;
                }
            }
        }
    }
    
    
    static void PrintWords(string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            Console.Write(words[i]);
            if (i < words.Length - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    
    static void Main()
    {
        Console.Write("sentence");
        string sentence = Console.ReadLine(); 
        
        string[] words = SplitWords(sentence); 
        SortWords(words); 
        
        Console.Write("Sort");
        PrintWords(words); 	
    }
}	
