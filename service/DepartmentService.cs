using HRManagement.DB_Simulation;
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
        public Department Create(Department department)
        {

            OnMemoryDataBase.departments.Add(department.Id, department);
            return department;
        }

        public Department Delete(int id)
        {
            Department department = Find(id);
            OnMemoryDataBase.departments.Remove(id);
            return department;
        }

        public Department Find(int id)
        {
            Department department = OnMemoryDataBase.departments[id];
            return department;

        }

        public List<Department> GetAllDepartments()
        {
            List<Department> allDepartments = new List<Department>();

            foreach (var item in OnMemoryDataBase.departments)
            {
                allDepartments.Add(item.Value);
            }
            return allDepartments;
        }

        public Department GetDepartmentByEmployeeId(int employeeId)
        {
            Employee employee = OnMemoryDataBase.employees[employeeId];
            Department department = employee.Department;
            return department;
        }

        public bool SetManagerOfDepartment(int departmentId, int managerId)
        {
            Department department = OnMemoryDataBase.departments[departmentId];
            Employee employee = OnMemoryDataBase.employees[managerId];
            if (employee == null || department == null)
            {
                return false;
            }
            if (OnMemoryDataBase.employees[managerId] is Manager)
            {
                Manager manager = (Manager)OnMemoryDataBase.employees[managerId];
                department.HeadOf = manager;
                return true;
            }
            else
            {
                Console.WriteLine("Class Cast Exception. Error!!");
                return false;
            }
        }
    }
}
