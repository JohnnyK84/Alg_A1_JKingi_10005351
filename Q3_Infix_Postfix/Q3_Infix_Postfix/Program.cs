using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please input string to be converted from infix to postfix:\n");
            string input = "2+3*2/6+18";
            string postfix = " ";

            Stack s = new Stack();
            //s.Push(')');

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (char.IsNumber(c) == true)
                {
                    postfix += c;
                }

                else if (IsOperator(c) == true)
                {
                    if (s.Count <= 0)
                    {
                        Console.WriteLine("Count 0 - pushing:  " + c);
                        s.Push(c);
                    }
                    else
                    {
                        var d = s.Peek().ToString();
                        char op2 = d[0];//top of stack to char
                        int Prec = 0;
                        Console.WriteLine("top of stack:  " + op2);
                        Console.ReadLine();

                        if (op2 == '*' || op2 == '/')
                        {
                            Prec = 2;
                        }
                        else
                        {
                            Prec = 0;
                        }

                        if (Prec == 2)
                        {
                            if (c == '+' || c == '-')
                            {
                                postfix += s.Pop();
                                i--;
                            }
                            else
                            {
                                Console.WriteLine("Top of stack: ", +op2);
                                postfix += s.Pop();
                                i--;
                            }
                        }


                        else
                        {
                            if (c == '+' || c == '-')
                            {
                                Console.WriteLine("Top of stack: ", +op2);
                                postfix += s.Pop();
                                s.Push(c);
                            }
                            else
                                s.Push(c);

                        }
                    }

                }
            }

            int len = s.Count;

            for (int i = 0; i < len; i++)
                postfix += s.Pop();

            Console.WriteLine();
            foreach (var item in s)
            {
                Console.WriteLine("Stack:  " + item);
            }

            Console.WriteLine("final Postfix: " + postfix);
            Console.ReadLine();

        }
        public static bool IsOperator(char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^' || c == '%')
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
