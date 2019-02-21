using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(prefix("what    ...  did you say?? "));//input string
        }
        static string prefix(string input){
            if(input == null){  //error prevention
                return null;
            }
            if (input == "")
            {
                return "0,0:";
            }
            int length = input.Length;
           
           
            int wordCount = 0, index = 0;

            while (index < input.Length)//count the number of words
            {
            // check if current char is part of a word
            while (index < input.Length && !char.IsWhiteSpace(input[index]))
                index++;

            wordCount++;

            // skip whitespace until next word
            while (index < input.Length && char.IsWhiteSpace(input[index]))
                index++;
            }
            
            return length + "," + wordCount + ":" + input;
        }
        
    }
}
