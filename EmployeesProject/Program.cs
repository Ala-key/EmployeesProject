using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProject
{
    public class Employee
    {
        public int id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Position { get; set; }
    }

    

    public class EmployeeManagement
    {
        private List<Employee> list = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            if (employee == null)
                return;
            list.Add(employee);
        }


        public void RemoveEmployee(int id)
        {
            var emp = list.FirstOrDefault(x => x.id == id);
            if (emp == null)
                return;
            list.Remove(emp);
        }


        public List<Employee> GetAllEmployee()
        {
            if (list == null)
            {
                return new List<Employee>();
            }

            return list;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
