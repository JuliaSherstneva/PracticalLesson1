using System;
using PracticalLesson1.Models;
using PracticalLesson1.Managers;

namespace PracticalLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the To-Do List Application!");

            var todoManager = new TodoListManager();

            RunInteractive(todoManager);

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
        static void RunInteractive(TodoListManager manager)
        {
            while (true)
            { 
                manager.DisplayTodoList();
                Console.WriteLine("\nAvailable commands: add, toggle, exit");
                Console.Write("Enter command:");
                string command = Console.ReadLine()?.Trim().ToLower();
                
                bool operationSuccessful = false;

                switch (command)
                {
                    case "add":
                        Console.Write("Enter the description for the new task: ");
                        string description = Console.ReadLine();
                        operationSuccessful = manager.AddTask(description);
                        break;

                    case "toggle":
                        Console.Write("Enter the ID of the task to toggle completion: ");
                        string taskIdInput = Console.ReadLine();
                        if (int.TryParse(taskIdInput, out int taskId))
                        {
                            operationSuccessful = manager.ToggleTaskCompletion(taskId);
                        }
                        else
                        {
                            Console.WriteLine("Error: Invalid ID format. Please enter a number.");
                            operationSuccessful = false; // Считаем операцию неуспешной
                        }
                        break;

                    case "exit":
                        return; // Выходим из цикла RunInteractive, а значит и из программы

                    default:
                        Console.WriteLine("Error: Unknown command. Please try again.");
                        operationSuccessful = false; // Неизвестная команда - неуспех
                        break;                                       
                }
                if (operationSuccessful || command == "add" || command == "toggle" || command == "exit" || command == null)
                {
                    Console.WriteLine("\nPress Enter to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("\nPress Enter to continue");
                    Console.ReadLine();
                }
            }
        }
    }
}