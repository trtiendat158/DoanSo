using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEmployeeClass
{
    class Employee
    {
        private int Id;
        private string FirstName;
        private string LastName;
        private int Salary;

        public Employee (int Id, string FirstName, string LastName, int Salary)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Salary = Salary;
        }

        public int GetId()
        {
            return Id;
        }

        public string GetFirstName()
        {
            return FirstName;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public int GetSalary()
        {
            return Salary;
        }
        public void SetSalary(int NewSalary)
        {
            Salary = NewSalary;
        }
        public int GetAnnualSalary()
        {
            return Salary * 12;
        }

        public int raiseSalary(int percent)
        {
            percent = percent / 100;
            return Salary * percent;
        }
        public override string ToString()
        {
            return string.Format("The Employee has a ID is: {0}  \nName is: {1} {2} \nSalary is: {3} \nAnnual is: {4}", GetId(), GetFirstName(), GetLastName(), GetSalary(),GetAnnualSalary());
        }
    }
}
