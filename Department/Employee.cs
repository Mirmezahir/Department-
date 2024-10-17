using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department
{
    public class Employee
    {
        static private int _id;
        public string name;
        private double _salary;
        public int ID { get; set; }
        public string Surname;
        public int age;
        public int DepartmentNO;
        public double Salary { get { return _salary; } set { if (Salary > 0) { Salary = _salary; } } }

        public Employee( string name, string surname, int age, int departmentNO, double salary)
        {
            
           this.name = name;    
            Surname = surname;
            this.age = age;
            DepartmentNO = departmentNO;
            Salary = salary;
            ++_id;
            ID = _id;
        }

        


    }
}
