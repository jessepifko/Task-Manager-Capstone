using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Transactions;

namespace Task_List_Capstone
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Task Manager!");
            bool showMenu = true;
            List<Task> tasks = new List<Task>()
            {
                new Task("John", "Change water filter", DateTime.Parse("2-1-2020"), false),
                new Task("Jim", "Change light bulb", DateTime.Parse("3-1-2020"), false),
                new Task("James", "Purchase new desk chair", DateTime.Parse("4-1-2020"), false),
                new Task("Joe", "Purchase new computer", DateTime.Parse("1-1-2020"), true),
                new Task("Jose", "Purchase mechanical keyboard", DateTime.Parse("5-1-2020"), false)
            };
            while (showMenu)
            {
                showMenu = MainMenu(tasks);
            }
        }

        public static string GetCompletedStatus(bool status)
        {
            if (status == true)
            {
                return "Completed!";
            }
            else
            {
                return "Incomplete.";
            }
        }

        public static bool MainMenu(List<Task> tasks)
        {
            Console.WriteLine();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. List Tasks");
            Console.WriteLine("2. Add Task");
            Console.WriteLine("3. Delete Task");
            Console.WriteLine("4. Mark Task Complete");
            Console.WriteLine("5. Quit");
            Console.Write("\r\nSelect an option (1-5): ");

            switch (Console.ReadLine())
            {
                case "1"://Display Task List
                    DisplayList(tasks);
                    //foreach (Task T in tasks)
                    //{
                    //    Console.WriteLine($"{GetCompletedStatus(T.Status)}\t {T.TeamMemberName}\t\t {T.DueDate:d}\t {T.Description}");
                    //}
                    return true;

                case "2": //Add new task item to existing list
                    AddTask(tasks);
                    return true;

                case "3": //Delete task from the numbered task list
                    DeleteTask(tasks);
                    return true;

                case "4"://Mark a task complete
                    MarkedTaskComplete(tasks);

                    return true;
                case "5"://Quit
                    Console.WriteLine();
                    Console.WriteLine("Have a great day!");
                    return false;
            }
            return true;
        }
        
        public static void AddTask(List<Task> tasks)
        {
            Console.WriteLine();
            Console.WriteLine("ADD TASK:");
            Console.WriteLine();
            Console.Write("Team Member Name:");
            string teamMemberName = Console.ReadLine();
            Console.Write("Task Description:");
            string description = Console.ReadLine();
            DateTime dueDate = GetDate();
            Task NewTask = new Task(teamMemberName, description, dueDate, false);
            tasks.Add(NewTask);
            Console.WriteLine();
            Console.WriteLine("ADDED!");
        }
        public static void DeleteTask(List<Task> tasks)
        {
            Console.WriteLine();

            int i = 0;
            foreach (Task T in tasks)
            {
                i++;
                Console.WriteLine(i + ")" + " " + $"{GetCompletedStatus(T.Status)}\t {T.TeamMemberName}\t\t {T.DueDate:d}\t {T.Description}");
            }
            Console.WriteLine("Delete which task? (Enter a number)");
            int index;
            while (true)
            {
                try
                {
                    index = int.Parse(Console.ReadLine());
                    if (index >= 1 && index <= tasks.Count)
                    {

                        break;
                    }
                    throw new IndexOutOfRangeException();

                }

                catch (FormatException)
                {
                    Console.WriteLine("Please input a number.");
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Error: Number out of range");
                }

            }
            while (true)
            {
                Console.WriteLine("Are you sure you want to Delete? (y/n)");
                string confirmDelete = Console.ReadLine().ToLower();
                if (confirmDelete == "y")
                {
                    tasks.RemoveAt(index - 1);
                    return;
                }
                else if (confirmDelete == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, there was an error.");
                }
            }
        }
    public static void MarkedTaskComplete(List<Task> tasks)
    {
        Console.WriteLine();
        Console.WriteLine("Mark a task complete:");
        int i = 0;
        foreach (Task T in tasks)
        {
            i++;
            // T.Status = true;
            Console.WriteLine(i + ")" + " " + $"{GetCompletedStatus(T.Status)}\t {T.TeamMemberName}\t\t {T.DueDate:d}\t {T.Description}");

            //tasks.Count - 1
        }

        int input;
        while (true)
        {
            try
            {
                input = int.Parse(Console.ReadLine());
                if (input >= 1 && input <= tasks.Count)
                {

                    break;
                }
                throw new IndexOutOfRangeException();

            }

            catch (FormatException)
            {
                Console.WriteLine("Please input a number.");
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Number out of range");
            }


        }
        Task selectedTask = tasks[input - 1];
        if (selectedTask.Status == true)
        {
            Console.WriteLine("This is already marked completed!");
        }
        else
        {
            selectedTask.Status = true;
        }

        // if (GetCompletedStatus(input))
        {

        }

        if (tasks.Count <= 0)
        {
            Console.WriteLine("No tasks to change");
        }
    }

    private static bool GetCompletedStatus(int input)
    {
        throw new NotImplementedException();
    }

    public static void RemoveTask(List<Task> task)
    {

    }
    public static void DisplayList(List<Task> tasks)
    {
            foreach (Task T in tasks)
            {
                Console.WriteLine($"{GetCompletedStatus(T.Status)}\t {T.TeamMemberName}\t\t {T.DueDate:d}\t {T.Description}");
            }
            //for (int i = 0; i < task.Count; i++)
            //{
            //    //Console.WriteLine($"{i + 1}) : {task[i].ToString()}");
            //    Console.WriteLine($"{i + 1})");
            //}
        }

    public static DateTime GetDate()
    {
        DateTime dueDate;
        while (true)
        {
            Console.Write("Due Date (mm/dd/yyyy):");

            try
            {
                dueDate = DateTime.Parse(Console.ReadLine());
                return dueDate;
            }
            catch
            {
                Console.WriteLine("Invalid date");
            }

        }
    }
    }

 }   


