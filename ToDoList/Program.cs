using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<ToDo> toDoList = new List<ToDo>();
            ToDoList toDoList = new ToDoList();

            while (true)
            {
                Console.WriteLine("Enter a task description:");
                string description = Console.ReadLine();
                Console.WriteLine("Enter a due date:");
                DateTime dueDate = DateTime.Parse(Console.ReadLine());
                toDoList.AddToDo(description, dueDate);

                Console.WriteLine($"There are {toDoList.Count()} To Do's on your list");
            }
        }

        
    }
}
