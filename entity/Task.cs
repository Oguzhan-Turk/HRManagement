using System;
using System.Collections.Generic;

namespace HRManagement.entity
{
     public class Task
    {
        public Task(): this("unkown", DateTime.Now.AddDays(7))
        {
        }

        public Task(string description, DateTime deadLine)
        {
            Id = ++idCounter;
            Description = description;
            DeadLine = deadLine;
            EmployeesWorkOn = new List<Worker>();
        }

        private static int idCounter = 0;
        public int Id { get;}
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public List<Worker> EmployeesWorkOn { get; set; }

        public void AssignWorker(Worker worker)
        {
            EmployeesWorkOn.Add(worker);
        }

    }
}