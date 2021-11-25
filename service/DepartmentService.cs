using HRManagement.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.service
{
    class DepartmentService : IDepartmentService
    {
        public Department Create(Department t)
        {
            Console.WriteLine($"{t.Name} Departmanı oluşturuldu");
            return t;
        }

        public Department Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Department Find(int id)
        {
            throw new NotImplementedException();
        }

        public List<Department> GetAllDepartments()
        {
            throw new NotImplementedException();
        }

        public Department GetDepartmentByEmployeeId(int employeeId)
        {
            throw new NotImplementedException();
        }

        public bool SetManagerOfDepartment(Manager manager)
        {
            throw new NotImplementedException();
        }
    }
}
