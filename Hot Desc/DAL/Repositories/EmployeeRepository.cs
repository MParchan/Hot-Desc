using Hot_Desc.DAL.Repositories.Interfaces;
using Hot_Desc.Models;
using System.Linq.Expressions;

namespace Hot_Desc.DAL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        protected readonly HotDescDbContext _context;
        public EmployeeRepository(HotDescDbContext context)
        {
            _context = context;
        }

        public Employee GetById(int id)
        {
            return _context.Employees.Find(id);
        }
        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }
    }
}
