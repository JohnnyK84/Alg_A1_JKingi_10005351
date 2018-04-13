using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Q2_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack _stack = new Stack();
            Stack _stack2 = new Stack();
            Stack _stack3 = new Stack();
            palindromeCheck(_stack, _stack2, _stack3);
            printPalindrome(_stack);
        }

        static void palindromeCheck(Stack _stack, Stack _stack2, Stack _stack3)
        {
            Console.WriteLine("Enter a pharse to check if it is a palindrome");
            var input = Console.ReadLine();

            input = input.ToLower(); //ignore capitlization
            input = Regex.Replace(input, @"[^\w]", string.Empty); //remove all Punctuation

            foreach (char i in input)//adding chars of input individually into stack array 
            {
                _stack.Push(i);
            }
            Console.WriteLine("Stack1:  ");
            foreach (char item in _stack)//writing stack to check
            {
                Console.Write(item);
            }

            _stack2 = new Stack(_stack.ToArray());//Copyin Stack to _stack2
            Console.WriteLine();

            Console.WriteLine("Stack2:  ");
            foreach (char item in _stack2)//writing stack to check
            {
                Console.Write(item);
            }

            Console.WriteLine();

            foreach (var item in _stack2)//using _stack3 to take items back into stack
            {
                _stack3.Push(item);
            }

            printPalindrome(_stack);

            Console.WriteLine();

            while (_stack2.Count > 0)
            {
                var peek1 = _stack2.Peek();
                var peek2 = _stack3.Peek();
                //Console.WriteLine("{0}  {1}",peek1,peek2);
                if (peek1.ToString() == peek2.ToString())
                {
                    _stack2.Pop();
                    _stack3.Pop();
                }
                else
                {
                    _stack2.Clear();
                }
            }

            Console.WriteLine();

            if (_stack3.Count == 0)
            {
                Console.WriteLine("Yes this is a Palindrome");

            }
            else
            {
                Console.WriteLine("Nope not a Palindrome");
            }

            //Console.Write(item);
            /*
            if (_stack2.Equals(_stack3) == true)
            {
                Console.WriteLine("Yes this string is a Palindrome");
            }
            else
            {
                Console.WriteLine("No string is not a Palindrome");
            }
            //Console.WriteLine(compare);*/

            Console.ReadLine();
        }

        static void printPalindrome(Stack _Stack)
        {
            Stack _stack = new Stack();
            foreach (char item in _stack)//writing stack to check
            {
                Console.Write(item);
            }

        }
    }

    
}
