using Task_Rubegh.Abstructions.Repositories;
using Task_Rubegh.Abstructions.Services;
using Task_Rubegh.Entities;
using Task_Rubegh.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Task_Rubegh.Servise
{
    public class EmployeeServise : IEmployeeService
    {

           IEmployeeRepository is_repository;
           IEmailSenderService is_emailSanderService;
           public EmployeeServise(IEmployeeRepository employeeRepository, IEmailSenderService emailSenderService)
           {
               is_repository = employeeRepository;
               is_emailSanderService = emailSenderService;
           }
           public void Create(string name, int id, string email, string username, string password, decimal salary, string position, string department)
           {
               var newEmployee = new Employee
               {
                   Id = Guid.NewGuid(),
                   Name = name,
                   Email = email,
                   Salary = salary,
                   Position = position,
                   Department = department,
                   Password = password,
                   UserName = username,
               };
               is_repository.Add(newEmployee);
               is_emailSanderService.SendEmail(email, "Welcome to company");

           }
           public void Delete(Guid id)
           {
            var employee = is_repository.GetAll().SingleOrDefault(s => s.Id == id);
               if (employee != null)
               {
                   is_repository.Delete(employee);
               }
           }

          public IEnumerable<Employee> GetAll()
           {
               return is_repository.GetAll();
           }

           public Employee GetByDepartment(string department)
           {
               return is_repository.GetAll().FirstOrDefault(s => s.Department == department);
           }

           public Employee GetById(Guid id)
           {
            var is_repository = GetAll();
               return is_repository.FirstOrDefault(s => s.Id == id);
           }

        public void Update(string name, int id, string email, string username, string password, decimal salary, string position, string department)
        {
            throw new NotImplementedException();
        }
    }
}

