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
                Console.WriteLine($"There are {toDoList.ToDoCount()} To-Do's on your list. You have completed {toDoList.DoneCount()} To-Do's");
                toDoList.PrintToDos();
                Console.WriteLine();

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add a new to-do");
                Console.WriteLine("2. Complete a to-do");
                Console.WriteLine("3. Show completed to-do's");
                Console.WriteLine("4. Delete a to-do");
                Console.WriteLine("Q. Quit");
                string input = (Console.ReadLine());

                switch (input.ToUpper())
                {
                    case "1":
                        Console.WriteLine("Enter a task description:");
                        string description = Console.ReadLine();
                        Console.WriteLine("Enter a due date:");
                        DateTime dueDate = DateTime.Parse(Console.ReadLine());
                        toDoList.AddToDo(description, dueDate);
                        break;
                    case "2":
                        Console.WriteLine("Great job! Enter the number of the To-Do you completed:");
                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            toDoList.MarkComplete(index);
                        }
                        break;
                    case "3":
                        Console.WriteLine();
                        Console.WriteLine("You completed the following to-do's, great job!");
                        toDoList.PrintCompleted();
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to main menu...");
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Enter the number of the To-Do you want to delete:");
                        if (int.TryParse(Console.ReadLine(), out int index2))
                        {
                            toDoList.Delete(index2);
                        }
                        break;
                    case "Q":
                        return;
                    default:
                        break;
                }

                

                
            }
        }

        
    }
}
