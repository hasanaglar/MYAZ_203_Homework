using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_2
{
    public class Employee
    {
        private string? _firstName;
        private string? _lastName;
        private List<Employee> _list;

        public int Id { get; set; }
        public string? FirstName 
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string? LastName 
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public int Age { get; set; }
        public int WorkingYear { get; set; }
        public decimal Salary { get; set; }



        public Employee()
        {
            _list = new List<Employee>();
        }

        public Employee(int ıd, string? firstName, string? lastName, int age, int workingYear)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            WorkingYear = workingYear;
            Salary = 3_000+(workingYear*500);
            _list = new List<Employee>();
        }

        public override string ToString()
        {
            return $"{Id,-5}" +
                $"{FirstName,-10}" +
                $"{LastName,-10}" +
                $"{Age,5}" +
                $"{WorkingYear,5}" +
                $"{Salary,10}";
        }

        public void Add(Employee employee)
        {
            _list.Add(employee);
        }

        public void Remove(int Id)
        {
            _list.RemoveAt(Id);
        }

        public List<Employee> GetEmployees() => _list;
    }

}
