using HRManagement.DB_Simulation;
using HRManagement.entity;
using HRManagement.service.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRManagement.service
{
    class TaskService : ITaskService
    {
        public Task Create(Task task)
        {
            OnMemoryDataBase.tasks.Add(task.Id, task);
            return task;
        }

        public Task Delete(int id)
        {
            Task task = Find(id);
            OnMemoryDataBase.tasks.Remove(id);
            return task;
        }

        public Task Find(int id)
        {
            Task task = OnMemoryDataBase.tasks[id];
            return task;
        }
        public bool AssingWorkerToTask(int taskId, int workerId)
        {
            Task task = Find(taskId);
            Worker worker = (Worker)OnMemoryDataBase.employees[workerId];
            if (task == null || worker == null)
            {
                return false;
            }
            worker.Assign(task);
            task.AssignWorker(worker);
            return true;
        }
    }
}
