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
                Console.Clear();
                Console.WriteLine($"There are {toDoList.Count()} To Do's on your list");
                toDoList.PrintList();
                Console.WriteLine();

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add a new to-do");
                Console.WriteLine("2. Delete a new to-do");
                string input = (Console.ReadLine());

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter a task description:");
                        string description = Console.ReadLine();
                        Console.WriteLine("Enter a due date:");
                        DateTime dueDate = DateTime.Parse(Console.ReadLine());
                        toDoList.AddToDo(description, dueDate);
                        break;
                    case "2":
                        Console.WriteLine("Enter the number of the To-Do you want to delete:");
                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            toDoList.Delete(index);
                        }
                        
                        break;
                    default:
                        break;
                }

                

                
            }
        }

        
    }
}
