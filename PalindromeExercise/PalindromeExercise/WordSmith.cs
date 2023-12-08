using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsAPalindrome(string input) 
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            var charArray = input.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray) == input;
        }
    }
}
