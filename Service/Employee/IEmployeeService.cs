using System.Collections.Generic;
using Core.Domain;

namespace Service.Employee
{
    public interface IEmployeeService
    {
        List<EmployeeDto> GetEmployees();
    }
}
