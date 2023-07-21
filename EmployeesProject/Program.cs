﻿using System;
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

        public bool AddEmployee(Employee employee)
        {
            var emp = list.FirstOrDefault(x => x.id == employee.id);
            if (employee == null)
                return false;
            else if (emp != null)
            {
                Console.WriteLine("Such employee already exist");
                return false;

            }
            list.Add(employee);
            return true;
        }


        public bool RemoveEmployee(int id)
        {
            var emp = list.FirstOrDefault(x => x.id == id);
            if (emp == null)
                return false;
            list.Remove(emp);
            return true;
        }


        public List<Employee> GetAllEmployee()
        {
            if (list.Count <= 0)
            {
                Console.WriteLine("No employee found!");
                return new List<Employee>();
            }

            return list;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        { 
            EmployeeManagement employeeManagement = new EmployeeManagement();

            bool exit = true;

            int opt;

            bool res;

            while (exit)
            {
                Console.WriteLine("Choise options \n 1.Add employee \n 2.Delete employee \n 3.Get all employees \n 4.Exit");

                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out opt))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Choise number range 1 at 5");
                    }
                }
                
                int id = 0;

                string name;

                int age = 0;

                string position;


                switch (opt)
                {
                    case 1:

                        while (true)
                        {
                            Console.WriteLine("id");
                            if (!int.TryParse(Console.ReadLine(), out id))
                            {
                                Console.WriteLine("Wrong format try again");
                            }
                            else
                            {
                                break;
                            }
                        }

                        while (true)
                        {
                            Console.WriteLine("Name employee");
                            name = Console.ReadLine();

                            Console.WriteLine("Position");
                            position = Console.ReadLine();

                            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(position))
                            {
                                break;
                            }

                        }
                           

                            while (true)
                            {
                            Console.WriteLine("Age");
                            if (!int.TryParse(Console.ReadLine(), out age))
                                {
                                    Console.WriteLine("Wrong format try again");
                                }
                                else
                                {
                                    break;
                                }
                            }

                       

                        bool isadd = employeeManagement.AddEmployee(new Employee { id = id, Name = name, Age = age, Position = position });

                        if (isadd)
                        {
                            Console.WriteLine("Succes! employee added");
                        }

                        id = 0;
                    break;

                       

                    case 2:
                        while (true)
                        {
                            Console.WriteLine("Enter id employee for delete");
                            bool resdel = int.TryParse(Console.ReadLine(),out id);

                            if (resdel)
                            {
                                bool isdel = employeeManagement.RemoveEmployee(id);

                                if (isdel)
                                {
                                    Console.WriteLine("Succes! employee delete");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Try again");
                                }
                               
                            }
                        }

                    break;

                    case 3:
                        foreach (var item in employeeManagement.GetAllEmployee())
                        {
                            Console.WriteLine($"id {item.id}, name {item.Name}, age {item.Age}, position {item.Position}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        exit = false;
                        break;

                    default:
                        Console.WriteLine("Wrong choise");
                        break;
                }

            }
        }
    }
}
