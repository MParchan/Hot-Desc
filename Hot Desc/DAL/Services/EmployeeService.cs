using Hot_Desc.DAL.Services.Interfaces;
using Hot_Desc.DAL.UnitOfWork;
using Hot_Desc.Models;

namespace Hot_Desc.DAL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void AddEmployee(Employee employee)
        {
            _unitOfWork.Employees.Add(employee);
        }
    }
}
