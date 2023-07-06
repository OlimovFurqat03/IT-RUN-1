using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Rubegh.Entities;

namespace Task_Rubegh.Abstructions.Services
{
    internal interface IEmployeeService
    {
        Employee GetById(Guid id);
        IEnumerable<Employee> GetAll();
        Employee GetByDepartment(string department);

        void Create(string name, int id, string email, string username, string password, decimal salary, string position, string department); 
        void Delete(int id);
        void Update(string name, int id,  string email, string username, string password, decimal salary, string position, string department);
    }
}
