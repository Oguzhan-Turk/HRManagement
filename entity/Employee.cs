using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.entity
{
    public abstract class Employee
    {
        private int id;
        private string fullName;
        private string phoneNumber;
        private int workingHours;
        private double salaryPerHour;
        private double totalSalary;
        private Address address;
        private Department department;

        protected Employee()
        {

        }
        protected Employee(int id, string fullName, string phoneNumber,Address address,Department department, double salaryPerHour)
        {
            this.id = id;
            this.fullName = fullName;
            this.phoneNumber = phoneNumber;
            this.salaryPerHour = salaryPerHour;
            this.address = address;
            this.department = department;
        }

        public int Id { get => id;}
        public string FullName { get => fullName;}
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public int WorkingHours { get => workingHours; set => workingHours = value; }
        public double SalaryPerHour { get => salaryPerHour; set => salaryPerHour = value; }
        public double TotalSalary { get => totalSalary;}       
        public Address Address { get => address; set => address = value; }
        public Department Department { get => department; set => department = value; }
    }
}
