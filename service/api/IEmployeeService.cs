using HRManagement.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRManagement.service
{
    interface IEmployeeService<T>: IService<T> where T : Employee 
    {
      
        bool AssignTaskToWorker(int workerId, int taskId);

    }
}
