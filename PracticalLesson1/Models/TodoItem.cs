using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalLesson1.Models
{
    internal class TodoItem
    {
        // Свойства класса
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        //Крнструктор для удобного создания задач
        public TodoItem(int id, string description) 
        {
            Id = id;
            Description = description;
            IsCompleted = false;
        }

        // Метод для отображения статуса задачи
        public string GetStatusDisplay()
        {
            return IsCompleted ? "[x]" : "[ ]";
        }
    }
}
