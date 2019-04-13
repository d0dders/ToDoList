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
        private List<ToDo> completedList = new List<ToDo>();

        public void AddToDo(string description, DateTime dueDate)
        {
            ToDo toDo = new ToDo(description, dueDate);
            toDoList.Add(toDo);
        }

        public int ToDoCount()
        {
            return toDoList.Count;
        }

        public int DoneCount()
        {
            return completedList.Count;
        }

        public void Delete(int index)
        {
            toDoList.RemoveAt(index - 1);
        }

        public void MarkComplete(int index)
        {
            toDoList[index - 1].state = ToDo.State.Completed;
            toDoList[index - 1].CompletedDate = DateTime.Now;
            completedList.Add(toDoList[index - 1]);
            toDoList.RemoveAt(index - 1);
        }

        public void PrintToDos()
        {
            for (int i = 0; i < toDoList.Count; i++)
            {
                Console.WriteLine($"{i+1}. {String.Format("{0:d}", toDoList[i].DueDate)} - {toDoList[i].Description}");
            }
        }

        public void PrintCompleted()
        {
            for (int i = 0; i < completedList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {String.Format("{0:d}", completedList[i].CompletedDate)} - {completedList[i].Description}");
            }
        }
    }
}
