using Hot_Desc.Models;
using System.Linq.Expressions;

namespace Hot_Desc.DAL.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Employee GetById(int id);
        IEnumerable<Employee> GetAll();
        void Add(Employee employee);
    }
}
