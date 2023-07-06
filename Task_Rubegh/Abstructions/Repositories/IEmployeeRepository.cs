using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Rubegh.Entities;

namespace Task_Rubegh.Abstructions.Repositories
{
    internal interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);
        IEnumerable<Employee> GetAll();
        Employee GetEmployeeDepartment(string department);
        void Add(Employee employee);
        void Delete (Employee employee);
        void Update(Employee employee);
    }
}
