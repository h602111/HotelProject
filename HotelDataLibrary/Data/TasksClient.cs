using HotelDataLibrary.Database;
using HotelDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelDataLibrary.Data
{
    public class TasksClient
    {
        DatabaseContext Context;

        public TasksClient()
        {
            Context = new DatabaseContext();
        }

        public List<Task> GetAllTasks()
        {
            return Context.Tasks.ToList<Task>();
        }

        public bool DeleteTask(Task task)
        {
            Context.Tasks.Remove(task);

            int Result = Context.SaveChanges();

            return Result > 0;
        }

        public bool CreateTask(Task task)
        {
            Context.Add(task);

            int Result = Context.SaveChanges();

            return Result > 0;
        }
    }
}
