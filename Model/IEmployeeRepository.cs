namespace PrimeiraAPI.Model
{
    public interface IEmployeeRepository
    {

        void Add(Employee employee);

        List<Employee> GetAll();

        Employee UpdateEmployee(Employee employee);
     
    }
}
