using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Body

            //Ensures correct character set available for currency
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Creates employee1 using requestInfo and requestSalary methods
            Employee employee1 = new Employee(requestInfo("Employee 1's First name"),
                requestInfo("Employee 1's Surname"), requestInfo("Employee 1's ID"),
                requestInfo("Employee 1's Department"), requestSalary("Employee 1's Salary"));

            Console.WriteLine("Employee 1 Registered, please press Enter to continue.");
            Console.ReadLine();
            Console.Clear();

            //Creates employee2 using requestInfo and requestSalary methods
            Employee employee2 = new Employee(requestInfo("Employee 2's First name"),
                requestInfo("Employee 2's Surname"), requestInfo("Employee 2's ID"),
                requestInfo("Employee 2's Department"), requestSalary("Employee 2's Salary"));

            Console.WriteLine("Employee 2 Registered, please press Enter to continue.");
            Console.ReadLine();
            Console.Clear();

            //displays information on employee1
            displayInfo(employee1);

            //displays information on employee2
            displayInfo(employee2);

            //request percentage salary increase for Employee1
            int employee1Increase;
            employee1Increase = requestIncrease("Employee 1");

            //request percentage salary increase for Employee2
            int employee2Increase;
            employee2Increase = requestIncrease("Employee 2");

            //apply pay rise to employee1
            employee1.PayRise(employee1Increase);

            //apply pay rise to employee2
            employee2.PayRise(employee2Increase);

            //display info of employee1
            displayInfo(employee1);

            //display info of employee2
            displayInfo(employee2);

            #endregion Body
        }

        #region Methods

        //Method to request information on employee in string format
        public static string requestInfo(string info)
        {
            Console.WriteLine("Please enter {0}:", info);
            return Console.ReadLine();
        }//end of requestInfo method

        //method to request employee salary information, repeats until acceptable input given
        public static decimal requestSalary(string info)
        {
            Console.WriteLine("Please enter {0}:", info);
            decimal salaryAmount;
            //this if-else statement tests input and repeats until an acceptable user input
            if (decimal.TryParse(Console.ReadLine(), out salaryAmount) == true)
            {
                return salaryAmount;
            }//end of if true
            else
            {
                Console.WriteLine("Invalid data entered, please try again.");
                return requestSalary(info);
            }//end of else

        }//end of requestSalary method

        //method to request salary increase percentage, repeats until acceptable input given
        public static int requestIncrease(string employee)
        {
            Console.WriteLine("Please enter the percentage pay rise," +
                    " without decimals, for {0}", employee);

            int increaseAmount;
            //this if-else statement tests input and repeats until an acceptable user input
            if (int.TryParse(Console.ReadLine(), out increaseAmount) == true)
            {
                Console.WriteLine("Thank you, please press Enter to continue.");
                Console.ReadLine();
                Console.Clear();
                return increaseAmount;
            }//end of if true
            else
            {
                Console.WriteLine("Invalid data entered.");
                return requestIncrease(employee);
            }//end of else

        }//end of requestIncrease method

        //method to display info on employee, this method calls the ToString() function
        public static void displayInfo(Object employee)
        {
            Console.WriteLine(employee);
            Console.WriteLine("Please press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
        #endregion Methods
    }//end of displayInfo method
}
