using System.Collections.Generic;

namespace HRManagement.entity
{
    public class Department
    {
        public Department()
        {

        }
        public Department(int ıd, string name,Manager headOf)
        {
            Id = ıd;
            Name = name;
            Employees = new List<Employee>();
            HeadOf = headOf;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public Manager HeadOf { get; set; }
    }
}