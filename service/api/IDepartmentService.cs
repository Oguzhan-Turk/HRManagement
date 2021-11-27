using HRManagement.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.service
{
    interface IDepartmentService : IService<Department>
    {
        List<Department> GetAllDepartments();
        Department GetDepartmentByEmployeeId(int employeeId);
        bool SetManagerOfDepartment(int departmentId, int managerId);
    }
}
