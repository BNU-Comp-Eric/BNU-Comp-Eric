using System;
using System.Collections.Generic;
using System.Text;

namespace EricConsoleApp.Unit5
{
    class Bubble
    {
        int[] answer = new int[20];
        bool flag = true;
        int temp;

        /// <summary>
        /// This method will ask the user 
        /// for numbers to be inputted
        /// </summary>
        public void InputNumbers()
        {
            SimpleIO.WriteTitle("Bubble Sort", "Task 5.4");
            Console.WriteLine("Please enter numbers to sort ");
            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }

        /// <summary>
        /// This method will display the
        /// the numbers one above another
        /// </summary>
        public void Display()
        {
            Console.Clear();
            SimpleIO.WriteTitle("Bubble Sort", "Task 5.4");
            Console.WriteLine("Array after sorting");

            Array.Sort(answer);

            for (int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine("Numbers " + answer[i]);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// This method will sort the numbers
        /// into numerical order
        /// </summary>
        public void SortNumbers()
        {
            Console.Clear();
            SimpleIO.WriteTitle("Bubble Sort", "Task 5.4");
            Console.WriteLine("Bubble Sort method");
            for (int i = 0; (i <= (answer.Length - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (answer.Length - 1); j++)
                {
                    if (answer[j + 1] > answer[j])
                    {
                        temp = answer[j];
                        answer[j] = answer[j + 1];
                        answer[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            foreach (int num in answer)
            {
                Console.Write("\t {0}", num);
            }
            Console.ReadLine();
        }
    }
}
