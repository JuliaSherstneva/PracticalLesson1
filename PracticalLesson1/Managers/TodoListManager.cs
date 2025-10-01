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
        private int _nextId = 1;

        // Конструктор: инициализация тестовыми данными
        public TodoListManager()
        {
            // Тестовые данные для демонстрации
            _practicalLesson1.Add(new TodoItem(_nextId++, "Buy groceries"));
            _practicalLesson1.Add(new TodoItem(_nextId++, "Read a book"));
            _practicalLesson1.Add(new TodoItem(_nextId++, "Go for a walk"));
        }

        // Метод для получения списка задач (можно использовать для внешних операций)
        public List<TodoItem> GetTodoList()
        {
            return _practicalLesson1;
        }

        // Метод для добавления новой задачи
        // Возвращает true при успехе, false при неудаче
        public bool AddTask(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
            {
                Console.WriteLine("Error: Task description cannot be empty.");
                return false;
            }

            _practicalLesson1.Add(new TodoItem(_nextId++, description));
            Console.WriteLine($"Success: Task '{description}' added.");
            return true;
        }

        // Метод для переключения статуса выполнения задачи
        // Возвращает true при успехе, false при неудаче (неверный ID)
        public bool ToggleTaskCompletion(int taskId)
        {
            var taskToToggle = _practicalLesson1.FirstOrDefault(t => t.Id == taskId);
            if (taskToToggle == null)
            {
                Console.WriteLine($"Error: Task with ID {taskId} not found.");
                return false;
            }

            taskToToggle.IsCompleted = !taskToToggle.IsCompleted;
            Console.WriteLine($"Success: Task {taskId} status updated to {taskToToggle.GetStatusDisplay()}.");
            return true;
        }

        // Метод для отображения списка дел в консоли
        public void DisplayTodoList()
        {
            Console.Clear(); // Очищаем консоль для лучшей читаемости
            Console.WriteLine("---- Your To-Do List ----");

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

            Console.WriteLine("-------------------------");
        }
    }
}

