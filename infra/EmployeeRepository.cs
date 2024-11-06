using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Model;

namespace PrimeiraAPI.infra
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Connection _context;

        public EmployeeRepository(Connection context)
        {
            _context = context;
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();

        }
    }
}
