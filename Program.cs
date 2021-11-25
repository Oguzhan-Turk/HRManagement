using HRManagement.entity;
using HRManagement.service;
using System;

namespace HRManagement
{
    class Program
    {
        DepartmentService departmentService = new DepartmentService();
        WorkerService workerService = new WorkerService();
        TaskService taskService = new TaskService();
        ManagerService managerService = new ManagerService();

        static void Main(string[] args)
        {

            Program program = new Program();
            program.run();

        }

        public void run()
        {
            Task task = new Task("Al bunu götür", DateTime.Now.AddDays(2));
            Task task2 = new Task("Geri getir", DateTime.Now.AddDays(3));

            Address adres = new Address("Turkey", "Istanbul", "Bagdat Caddesi", 987, "41400A");
            Manager man = new Manager(9, "Mehmet", "5548157083", adres, 500);
            Department ik = new Department(5, "İnsan Kaynakları", man);
            man.Department = ik;
            Worker cocuk = new Worker(7, "Ahmet", "5548158793", adres, ik, 250);

            taskService.Create(task);
            taskService.Create(task2);

            departmentService.Create(ik);
            managerService.Create(man);
            workerService.Create(cocuk);

            workerService.AssignTaskToWorker(cocuk.Id, task.Id);
            workerService.AssignTaskToWorker(cocuk.Id, task2.Id);

            
            Worker arananWorker = workerService.Find(7);
            foreach (var item in arananWorker.Tasks)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Description);
                Console.WriteLine(item.DeadLine);
            }


        }

    }
}
