using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class ToDo
    {
        public enum State
        {
            [Description("Not started")]
            Incomplete,
            [Description("In-progress")]
            InProgress,
            [Description("Completed")]
            Completed

        }

        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CompletedDate { get; set; }

        public ToDo(string description, DateTime dueDate)
        {
            Description = description;
            DueDate = dueDate;
            State state = State.Incomplete;
        }
    }
}
