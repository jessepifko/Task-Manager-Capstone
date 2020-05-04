using System;
using System.Collections.Generic;
using System.Text;

namespace Task_List_Capstone
{
   public class Task
    {
        private string teamMemberName;
        private string description;
        private DateTime dueDate;
        private bool status;
        
        public string TeamMemberName
        {
        get
        {
            return teamMemberName;
        }
        set
        {
            teamMemberName = value;
        }
    }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }      
        public DateTime DueDate
        {
            get
            {
                return dueDate;
            }
            set
            {
                dueDate = value; 
            }
        }
        public bool Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public Task() { }

        public Task(string _teamMemberName, string _description, DateTime _dueDate, bool _status )
        {
            teamMemberName = _teamMemberName;
            description = _description;
            dueDate = _dueDate;
            status = _status; 
        }

        //public static void AddTask()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("ADD TASK:");
        //    Console.WriteLine();
        //    Console.Write("Team Member Name:");
        //    string teamMemberName = Console.ReadLine();
        //    Console.Write("Task Description:");
        //    string description = Console.ReadLine();
        //    DateTime dueDate = GetDate();
        //    Task NewTask = new Task(teamMemberName, description, dueDate, false);
        //    tasks.Add(NewTask);
        //    Console.WriteLine();
        //    Console.WriteLine("ADDED!");
        //    return true;
        //}
        
        //public static List<Task> GetTaskList()
        //{
        //    List<Task> taskList = new List<Task>
        //    {
        //        new Task("John", "List tasks", DateTime.Parse("1-1-2020"), false),
        //        new Task("Jim", "Add task", DateTime.Parse("1-1-2020"), false),
        //        new Task("James", "Delete task", DateTime.Parse("1-1-2020"), false),
        //        new Task("Joe", "Mark task complete", DateTime.Parse("1-1-2020"), true),
        //        new Task("Jose", "Quit", DateTime.Parse("1-1-2020"), false)
        //    };
        //    return taskList;
        //}
    }
}
