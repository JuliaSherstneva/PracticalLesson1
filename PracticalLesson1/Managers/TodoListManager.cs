using PracticalLesson1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalLesson1.Managers
{
    internal class TodoListManager
    {
        private List<TodoItem> _practicalLesson1 = new List<TodoItem>();

        public TodoListManager() 
        {
            _practicalLesson1.Add(new TodoItem(1, "Buy groceries"));
            _practicalLesson1.Add(new TodoItem(2, "Read a book"));
            _practicalLesson1.Add(new TodoItem(3, "Go for a walk"));
        }
        public void DisplayTodoList()
        {
            Console.WriteLine("\n--- Your To-Do List ---");
            if (_practicalLesson1.Count == 0)
            {
                Console.WriteLine("Your list is empty!");
            }
            else 
            {
                foreach (var item in _practicalLesson1)
                { 
                    Console.WriteLine($"{item.Id}. {item.GetStatusDisplay()} {item.Description}");
                }
            }
            Console.WriteLine("------------------------");        
        }

    }
}
