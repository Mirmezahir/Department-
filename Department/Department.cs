using Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    internal class Department
    {
        public string No;
        public Employee[] Employees = new Employee[0];
        public int EmployeeLimit;
        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, +1);


            Employees[Employees.Length - 1] = employee;


        }
        public void GetEmployee(int a)
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].ID == a)
                {
                    Console.WriteLine("Axdardiginiz isci : " + Employees[i].name + " " + Employees[i].Surname + " " + Employees[i].Salary);
                }
                else { Console.WriteLine("Bu id sahib isci yoxdur !!!"); }
            }

        }
        public void EmployeeInfo()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine(Employees[i].ID + "." + Employees[i].name + " " + Employees[i].Surname + " " + Employees[i].Salary);
            }
        }
        public void GetAllEmployees()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                EmployeeInfo();
            }

        }
        public void GetAllEmployeesBySalary(int minmaas, int maxmaas)
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                if (minmaas <= Employees[i].Salary && maxmaas >= Employees[i].Salary)
                {
                    EmployeeInfo();
                }

            }

        }

    }
}
