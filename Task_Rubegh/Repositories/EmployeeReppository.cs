using Task_Rubegh.Abstructions.Repositories;
using Task_Rubegh.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Rubegh.Repositories
{
    public class EmployeeReppository : IEmployeeRepository
    {
        List<Employee> _employees;

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employees.Remove(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public void Update(Guid id,  Employee employee)
        {
            var index = _employees.FindIndex (s => s.Id == id);
            _employees[index] = employee;
        }

    
    }
    
}
