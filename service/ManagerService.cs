using HRManagement.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.service
{
    class ManagerService : IEmployeeService<Manager>
    {
        public void AssignTaskToWorker(int workerId, int taskId)
        {
            throw new NotImplementedException();
        }

        public Manager Create(Manager t)
        {
            Console.WriteLine($"{t.FullName} Manager olarak atandı");
            return t;
        }

        public Manager Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Manager Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}
