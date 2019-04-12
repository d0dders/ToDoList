using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class ToDoList
    {
        private List<ToDo> toDoList = new List<ToDo>();

        public void AddToDo(string description, DateTime dueDate)
        {
            ToDo toDo = new ToDo(description, dueDate);
            toDoList.Add(toDo);
        }

        public int Count()
        {
            return toDoList.Count;
        }

        public void Delete(int index)
        {
            toDoList.RemoveAt(index - 1);
        }

        public void PrintList()
        {
            for (int i = 0; i < toDoList.Count; i++)
            {
                Console.WriteLine($"{i+1}. {String.Format("{0:d}", toDoList[i].DueDate)} - {toDoList[i].Description}");
            }
        }
    }
}
