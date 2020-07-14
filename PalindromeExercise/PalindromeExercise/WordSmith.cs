using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public WordSmith()
        {

        }
        public bool IsAPalindrome(string word)
        {
            
            char[] backwardWords = word.ToUpper().ToCharArray();
            Array.Reverse(backwardWords);
            var convertCharTostring = new string[backwardWords.Length];
            for (int i = 0; i < convertCharTostring.Length; i++)
            {
                string theString = backwardWords[i].ToString();
                convertCharTostring[i] = theString;
            }
            
            string newWord = String.Concat(convertCharTostring).ToUpper();

            //Array.Reverse(backwardWords);

            //string reversed = new string(backwardWords).ToUpper();
            //bool check = word.Equals(reversed, StringComparison.OrdinalIgnoreCase);

            if(word.ToUpper() == newWord)
            {
                return true;
                
            }
            else
            {
                return false;
            }
            
        }
    }
}
