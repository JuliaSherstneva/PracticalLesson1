using System;
using PracticalLesson1.Models;
using PracticalLesson1.Managers;

namespace PracticalLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To-Do Лист Application!");

            var todoManager = new TodoListManager();

            todoManager.DisplayTodoList();

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}