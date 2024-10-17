using Lab_7.Models;
using Lab_7.Interfaces;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace Lab_7.Mocks
{
    public class MockEmployees : IEmployees
    {
       
        private static List<Employees> _employeeList = new List<Employees>
        {
            
      
        new Employees{Id=1, FirstName="Olga", LastName="Ivanova", Email="olga.ivanova@company.com", Date=new DateTime(2020, 2, 15), Department="HR", Salary=50000, Phone="555-123-1111"},
    new Employees{Id=2, FirstName="Pavlo", LastName="Kravchuk", Email="p.kravchuk@company.com", Date=new DateTime(2018, 5, 22), Department="IT", Salary=72000, Phone="555-123-2222"},
    new Employees { Id = 3, FirstName = "Diana", LastName = "Melnyk", Email = "d.melnyk@company.com", Date = new DateTime(2021, 3, 10), Department = "Finance", Salary = 63000, Phone = "555-123-3333" },
    new Employees { Id = 4, FirstName = "Ivan", LastName = "Koval", Email = "ivan.koval@company.com", Date = new DateTime(2019, 8, 3), Department = "HR", Salary = 52000, Phone = "555-123-4444" },
    new Employees { Id = 5, FirstName = "Vasyl", LastName = "Bondarenko", Email = "vasyl.bond@company.com", Date = new DateTime(2020, 1, 20), Department = "IT", Salary = 78000, Phone = "555-123-5555" },
    new Employees { Id = 6, FirstName = "Nina", LastName = "Shevchenko", Email = "nina.shev@company.com", Date = new DateTime(2017, 10, 5), Department = "Finance", Salary = 61000, Phone = "555-123-6666" },
    new Employees { Id = 7, FirstName = "Oleg", LastName = "Petrenko", Email = "oleg.petrenko@company.com", Date = new DateTime(2021, 11, 11), Department = "HR", Salary = 54000, Phone = "555-123-7777" },
    new Employees { Id = 8, FirstName = "Kateryna", LastName = "Lysenko", Email = "kateryna.lysenko@company.com", Date = new DateTime(2019, 6, 17), Department = "IT", Salary = 80000, Phone = "555-123-8888" },
    new Employees { Id = 9, FirstName = "Mykhailo", LastName = "Tkachenko", Email = "m.tkachenko@company.com", Date = new DateTime(2016, 9, 30), Department = "Finance", Salary = 64000, Phone = "555-123-9999" },
    new Employees { Id = 10, FirstName = "Iryna", LastName = "Horova", Email = "iryna.horova@company.com", Date = new DateTime(2022, 2, 19), Department = "HR", Salary = 51000, Phone = "555-124-0000" },
    new Employees { Id = 11, FirstName = "Bohdan", LastName = "Verbytskyi", Email = "bohdan.verb@company.com", Date = new DateTime(2020, 4, 1), Department = "IT", Salary = 79000, Phone = "555-124-1111" },
    new Employees { Id = 12, FirstName = "Anna", LastName = "Sergeeva", Email = "anna.sergeeva@company.com", Date = new DateTime(2018, 12, 12), Department = "Finance", Salary = 62000, Phone = "555-124-2222" },
    new Employees { Id = 13, FirstName = "Yurii", LastName = "Romanenko", Email = "y.romanenko@company.com", Date = new DateTime(2019, 7, 14), Department = "HR", Salary = 53000, Phone = "555-124-3333" },
    new Employees { Id = 14, FirstName = "Larysa", LastName = "Moroz", Email = "larysa.moroz@company.com", Date = new DateTime(2021, 5, 25), Department = "IT", Salary = 81000, Phone = "555-124-4444" },
    new Employees { Id = 15, FirstName = "Oleksandr", LastName = "Zhuk", Email = "oleksandr.zhuk@company.com", Date = new DateTime(2020, 10, 10), Department = "Finance", Salary = 65000, Phone = "555-124-5555" }
    };
     
        public IEnumerable<Employees> employees
        {
            get { return _employeeList; }
        }

    
        public void AddEmployee(Employees newEmployee)
        {
            _employeeList.Add(newEmployee);
        }
        public void DeleteEmployee(int id)
        {
            var employee = _employeeList.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
        }
        public void UpdateEmployee(Employees updatedEmployee)
        {
            var employee = _employeeList.FirstOrDefault(e => e.Id == updatedEmployee.Id);
            if (employee != null)
            {
                employee.FirstName = updatedEmployee.FirstName;
                employee.LastName = updatedEmployee.LastName;
                employee.Email = updatedEmployee.Email;
                employee.Date = DateTime.Now;
                
            }
        }
    }
}
