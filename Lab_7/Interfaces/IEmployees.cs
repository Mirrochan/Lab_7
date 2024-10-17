using Lab_7.Models;

namespace Lab_7.Interfaces
{
    public interface IEmployees
    {
       public IEnumerable<Employees> employees { get;  }
        void AddEmployee(Employees newEmployee);
        void DeleteEmployee(int id);
        public void UpdateEmployee(Employees newEmployee);
        

    }
}
