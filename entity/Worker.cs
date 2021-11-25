using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRManagement.entity
{
      public class Worker:Employee
    {
        public List<Task> Tasks { get; set; }


        public Worker()
        {
            Tasks = new List<Task>();
        }

        public Worker(int id, string fullName, string phoneNumber, Address address, Department department, double salaryPerHour) : base(id, fullName, phoneNumber, address, department, salaryPerHour)
        {
            Tasks = new List<Task>();
        }

        public void Assign(Task task)
        {
            Tasks.Add(task);
        }
    }

}
