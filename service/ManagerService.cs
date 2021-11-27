﻿using HRManagement.DB_Simulation;
using HRManagement.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRManagement.service
{
    class ManagerService : IEmployeeService<Manager>
    {

        public Manager Create(Manager manager)
        {
            OnMemoryDataBase.employees.Add(manager.Id, manager);
            Console.WriteLine($"{manager.FullName} Manager olarak atandı");
            return manager;
        }

        public Manager Delete(int managerId)
        {
            Manager manager = Find(managerId);
            OnMemoryDataBase.employees.Remove(managerId);
            return manager;
        }

        public Manager Find(int managerId)
        {
            Manager manager;
            if (OnMemoryDataBase.employees[managerId] is Manager)
            {
                manager = (Manager)OnMemoryDataBase.employees[managerId];
            }
            else
            {
                throw new NotImplementedException("Class Cast Exception. Error!!");
            }
            return manager;
        }
        public bool AssignTaskToWorker(int workerId, int taskId)
        {

            Worker worker = (Worker)OnMemoryDataBase.employees[workerId];
            Task task = OnMemoryDataBase.tasks[taskId];
            if (task == null || worker == null)
            {
                return false;
            }
            worker.Assign(task);
            task.AssignWorker(worker);

            return false;
        }
    }
}
