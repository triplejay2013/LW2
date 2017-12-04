using System;

namespace Palindrome{
	class Program {
		public bool isPalindrome(string word, int begin, int end)   {
			//base case, if this is reached then the rest of the letters match and the word IS a PALINDROME
			if(begin >= end) {
                return true; 
            }
			//continue to recurse if beginning and ending letters match
			if(word[begin] == word[end]){
            return isPalindrome(word, begin + 1, end - 1);
            }else {
			return false;
            }
		}

		static int Main(string[] args) {
			string[] array1 = {"racecar", "I like food", "asdffdsa"};
			for(int i = 0; i < 3; ++i){
				if(isPalindrome(array1[i], 0, array1[i].Length)) {
					Console.WriteLine("{0} is a PALINDROME", array1[i]);
                }else {
					Console.WriteLine("{0} is NOT a PALINDROME", array1[i]);
			    }
            }
		}
	}
}