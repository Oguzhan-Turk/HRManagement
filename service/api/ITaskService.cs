using HRManagement.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRManagement.service.api
{
    interface ITaskService:IService<Task>
    {
        public bool AssingWorkerToTask(int taskId, int workerId);

    }
}
