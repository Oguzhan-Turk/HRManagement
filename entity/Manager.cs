using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.entity
{

    public class Manager : Employee
    {
        private Rank rank;
        private Manager manager;
        private Department departmentManages;
        private int spanOfControl;

        public Manager()
        {
        }

        public Manager(int id, string fullName, string phoneNumber, Address address, double salaryPerHour) : base(id, fullName, phoneNumber, address, null, salaryPerHour)
        {
        }

        public int SpanOfControl { get => spanOfControl; set => spanOfControl = value; }
        public Rank Rank { get => rank; set => rank = value; }
        public Manager Manager_ { get => manager; set => manager = value; }
        public Department DepartmentManages { get => departmentManages; set => departmentManages = value; }
    }
}
