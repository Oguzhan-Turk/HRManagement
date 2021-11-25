using HRManagement.DB_Simulation;
using HRManagement.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRManagement.service
{
    class WorkerService : IEmployeeService<Worker>
    {
        public void AssignTaskToWorker(int workerId, int taskId)
        {
            Worker worker;
            if (OnMemoryDataBase.employees[workerId] is Worker)
            {
                worker = (Worker)OnMemoryDataBase.employees[workerId];
            }
            else
            {
                Console.WriteLine("Class Cast Exception. Error!!");
                return;
            }
            Task task = OnMemoryDataBase.tasks[taskId];
            worker.Assign(task);
            task.AssignWorker(worker);
        }

        public Worker Create(Worker t)
        {
            OnMemoryDataBase.employees.Add(t.Id, t);
            Console.WriteLine("eklendi ..");
            return t;
        }

        public Worker Delete(int workerId)
        {
            Worker worker = Find(workerId);
            OnMemoryDataBase.employees.Remove(workerId);
            return worker;

        }

        public Worker Find(int workerId)
        {
            Worker worker;
            if (OnMemoryDataBase.employees[workerId] is Worker)
            {
                worker = (Worker)OnMemoryDataBase.employees[workerId];
            }
            else
            {
                throw new NotImplementedException("Class Cast Exception. Error!!");
            }
            return worker;

        }

    
    }
}
