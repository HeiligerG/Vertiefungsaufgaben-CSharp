using System;

namespace EmployeeManagement
{
    abstract class Employee
    {
        public string FullName { get; }
        public int EmployeeNumber { get; }
        public double MonthlySalary { get; }

        protected Employee(string fullName, int employeeNumber, double monthlySalary)
        {
            FullName = fullName;
            EmployeeNumber = employeeNumber;
            MonthlySalary = monthlySalary;
        }

        public virtual double GetYearlySalary()
        {
            return MonthlySalary * 12;
        }
    }

    class Manager : Employee
    {
        private double Bonus { get; }

        public Manager(string fullName, int employeeNumber, double monthlySalary, double bonus)
            : base(fullName, employeeNumber, monthlySalary)
        {
            Bonus = bonus;
        }

        public override double GetYearlySalary()
        {
            return base.GetYearlySalary() + Bonus;
        }
    }

    class RegularEmployee : Employee
    {
        public RegularEmployee(string fullName, int employeeNumber, double monthlySalary)
            : base(fullName, employeeNumber, monthlySalary)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RegularEmployee employee = new RegularEmployee("John Doe", 1001, 5000);
            Manager manager = new Manager("Jane Smith", 2001, 8000, 10000);

            PrintEmployeeInfo(employee);
            PrintEmployeeInfo(manager);
        }

        static void PrintEmployeeInfo(Employee employee)
        {
            Console.WriteLine($"Name: {employee.FullName}");
            Console.WriteLine($"Employee Number: {employee.EmployeeNumber}");
            Console.WriteLine($"Monthly Salary: {employee.MonthlySalary:C}");
            Console.WriteLine($"Yearly Salary: {employee.GetYearlySalary():C}");
            Console.WriteLine();
        }
    }
}