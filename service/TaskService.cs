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
        public Task Create(Task t)
        {
            OnMemoryDataBase.tasks.Add(t.Id, t);
            return t;
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
    }
}
