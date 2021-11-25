using HRManagement.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HRManagement.DB_Simulation
{
    public class OnMemoryDataBase
    {
        public static SortedDictionary<int, Employee> employees = new SortedDictionary<int, Employee>();
        public static SortedDictionary<int, Department> departments = new SortedDictionary<int, Department>();
        public static SortedDictionary<int, Task> tasks = new SortedDictionary<int, Task>();
        public static SortedDictionary<int, Address> addresses = new SortedDictionary<int, Address>();
    }
}
