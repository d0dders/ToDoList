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
    }
}
