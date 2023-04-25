using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Stacks_25April2023
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Things we are going to talk about today:
            //Convert stacks to different collection types 
            //Pass a list to a stack 
            //Check if a stack is empty or not (in a different way)

            
            //Console.WriteLine("Enter a value:");
            //while (!int.TryParse(Console.ReadLine(),out int smth)) 
            //{
            //    Console.WriteLine("Enter a valid value.");

            //}

            List<int> list = new List<int>();
            

            Stack <int> stack1 = new Stack<int>(list);//you can pass all the values from a list to a stack 
            stack1.Push (1);
            stack1.Push (2);

            //Convert to an array 
            int[] arr = stack1.ToArray();
            Console.WriteLine(arr[0]); //perform indexing to an array with all the values from the stack 

            var slicing = arr[0..3];
            foreach (int i in slicing)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine(stack1.Pop());

            Console.ForegroundColor = ConsoleColor.Green;
            /*If we call Peek() to an empty stack it will throw 
            /an exception. To avoid this issue to a generic stack there is a TryPeek() method returning true if there is an element at the top of the stack and false otherwise */
            var res = stack1.TryPeek(out var result);
            Console.WriteLine(res);
            Console.ResetColor();

            //If we call Pop() to an empty stack it will throw 
            //an exception. To avoid this issue to a generic stack there is a TryPop() method returning true if there is an element at the top of the stack and false otherwise 
            var res2 = stack1.TryPop(out var result2);








        }
    }
}
