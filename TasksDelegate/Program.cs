using System;
using System.Collections.Generic;

namespace TasksDelegate
{
    internal class Program
    {
        #region task1
        //task1
        //public static Action<string> deleget;

        //static void Main(string[] args)
        //{

        //    deleget += Print;

        //    Console.WriteLine("Enter text");
        //    string text = Console.ReadLine();
        //    deleget?.Invoke(text);
        //}

        //public static void Print(string text)
        //{
        //    Console.WriteLine($"{text}");
        //}
        #endregion

        static void Main(string[] args)
        {
            #region task2
            //task2
            //int num = 7;
            //Func<int, int> square = x => x * x;
            //int result = square(num);
            //Console.WriteLine($"  {num} Kvadrati: {result}.");
            #endregion
            #region task3
            //task3
            //    List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, };
            //    Predicate<int> isEven = x => x % 2 == 0;
            //    List<int> evenNumbers = Print(number, isEven);
            //}

            //private static List<int> Print(List<int> number, Predicate<int> isEven)
            //{
            //    var result = new List<int>();
            //    Predicate<int> isOdd = x => x % 2 == 1;
            //    List<int> oddNumbers = number.FindAll(isOdd);
            //    return oddNumbers;

            //}
            #endregion
            #region task4
            //task4
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //Action<int> increment = x => Console.Write($"{x + 1} ");
            //numbers.ForEach(increment);
            #endregion
            #region task5
            //task5
            //List<Action> actions = new List<Action>();
            //actions.Add(() => Console.WriteLine("Step 1"));
            //actions.Add(() => Console.WriteLine("Step 2"));
            //actions.Add(() => Console.WriteLine("Step 3"));
            //actions.Add(() => Console.WriteLine("Step 4"));

            //foreach (var action in actions)
            //{
            //    action();

            //}
            #endregion
            #region task6
            //task6
            //List<string> words = new List<string> { "Salam", "necesen", "keyfin", "ehvalin", "Shadow" };
            //int minLength = 3;
            //Predicate<string> isLongerThan = s => s.Length > minLength;
            //List<string> longWords = words.FindAll(isLongerThan);
            #endregion

        }
    }
}   
