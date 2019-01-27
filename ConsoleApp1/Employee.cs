using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        #region Properties
        //Read-only property of EmployeeSalary limits changes to take place via class method PayRise
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeeID { get; set; }
        public string EmployeeDepartment { get; set; }
        private decimal employeeSalary;
        public decimal EmployeeSalary
        {
            get
            {
                return employeeSalary;
            }
        }
        #endregion Properties

        #region Constructors
        //Only one constructor needed as all arguments are required to create an Employee. 
        //Feedback reommended using 3 as a rule of thumb
        public Employee(string employeeFirstName, string employeeLastName, string employeeID,
            string employeeDepartment, decimal initialSalary)
        {
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
            EmployeeID = employeeID;
            EmployeeDepartment = employeeDepartment;
            employeeSalary = initialSalary;
        }//end of main constructor

        public Employee()
        {

        }//end of zero argument constructor, he also recommended one more constructor
        #endregion Contructors

        #region Methods
        //This ToString method returns all employee information when called
        public override string ToString()
        {
            return string.Format("Information on Employee ID No: {0}\nFirst Name: {1}\nSurname: {2}" +
                "\nDepartment: {3}\nSalary: {4:C}",
                EmployeeID, EmployeeFirstName, EmployeeLastName, EmployeeDepartment, EmployeeSalary);
        }//end of toString method

        //method takes percentageIncrease as argument and increases employeeSalary accordingly
        public void PayRise(int percentageIncrease)
        {
            employeeSalary += (employeeSalary * percentageIncrease/100);
        }//end of PayRise class method

        #endregion Methods
    }
}