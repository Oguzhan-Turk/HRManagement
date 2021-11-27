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

        public Worker Create(Worker worker)
        {
            OnMemoryDataBase.employees.Add(worker.Id, worker);
            return worker;
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
        public bool AssignTaskToWorker(int workerId, int taskId)
        {
            Worker worker;
            Task task = OnMemoryDataBase.tasks[taskId];
            if (OnMemoryDataBase.employees[workerId] is Worker)
            {
                worker = (Worker)OnMemoryDataBase.employees[workerId];
                //if (worker == null || task == null )
                //{
                //    return false;
                //}
            }
            else
            {
                Console.WriteLine("Class Cast Exception. Error!!");
                return false;
            }
            worker.Assign(task);
            task.AssignWorker(worker);
                return true;
        }


    }
}
