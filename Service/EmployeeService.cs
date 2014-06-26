using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Domain;
using Service.Employee;

namespace Service
{
    public class EmployeeService : IEmployeeService
    {
        public List<EmployeeDto> GetEmployees()
        {
            return new List<EmployeeDto>
            {
                new EmployeeDto() { Id = Guid.NewGuid(), Age = 22, FirstName = "Christopher", Surname = "Auret", Mobile = "0416380246"},
                new EmployeeDto() { Id = Guid.NewGuid(), Age = 27, FirstName = "Daniel", Surname = "Pearson", Mobile = "0416992422"},
                new EmployeeDto() { Id = Guid.NewGuid(), Age = 25, FirstName = "Lexie", Surname = "Lewis", Mobile = "0414570246"},
                new EmployeeDto() { Id = Guid.NewGuid(), Age = 34, FirstName = "Rebecca", Surname = "McMahon", Mobile = "0489320246"}
            };
        }
    }
}
