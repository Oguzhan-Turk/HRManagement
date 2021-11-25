using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagement.service
{
    interface IService<T>
    {
        public T Find(int id);
        public T Create(T t);
        public T Delete(int id);

        
    }
}
