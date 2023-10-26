using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class Program
    {
        static string[] names = new string[100];
        static string[] ids = new string[100];
        static double[] incomes = new double[100];
        static int counter = 0;
        

        static void Main(string[] args)
        {
            

            bool logic = true;
            for(;logic;)
            {
                Console.WriteLine("Welcome to the HR Program");
                Console.WriteLine("Please Choose one of he following options\n");
              
                Console.WriteLine("1- Add Employee");
                Console.WriteLine("2- Display Emplyee");
                Console.WriteLine("3- Exit\n\n");

                Console.Write("Selection....: ");
                int select = Convert.ToInt32(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        Console.Clear();
                        addEmployee();
                        break;
                    case 2:
                        Console.Clear();
                        displayEmployee();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("you Selected to Exit");
                        logic = false;
                        break;
                    default:
                        
                        Console.WriteLine("\n\nInvalid Entery");
                        break;

                }
            }
            Console.ReadKey();
        }
        static void addEmployee()
        {
            
            bool logic2 = true;
                for(; logic2;)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Employee Add Program");
                Console.WriteLine("Please Choose Type of Emplyee\n\n");
                Console.WriteLine("1- Commission Employee");
                Console.WriteLine("2- Salaried Employee");
                Console.WriteLine("3- Hourly Employee");

                Console.WriteLine("4- Main Manu\n\n");
                Console.Write("Selection.....: ");
                int typeOfEmployee = int.Parse(Console.ReadLine());

                switch (typeOfEmployee)
                {
                    case 1:
                       
                        commissionEmployee();
                        counter++;
                        break;
                    case 2:
                        salariedEmployee();
                        counter++;
                        break;
                    case 3:
                        hourlyEmployee();
                        counter++;
                        break;
                    case 4:
                       Console.Clear();
                        logic2 = false;
                        break;
                    default:

                        Console.WriteLine("\n\nInvalid Entery");
                        break;
                }
                Console.ReadKey();

            }
           

        }
        static void commissionEmployee()
        {
            Console.Clear();
            Console.WriteLine("You selected to Add [ Commission Employee ]");
            Console.Write("Please Enter Employee Name           : ");
            names[counter] = Console.ReadLine();
            Console.Write("Plese Enter Employee Id              : ");
            ids[counter] = Console.ReadLine();
            Console.Write("Please Enter total sales value       : ");
            int salesValue = int.Parse(Console.ReadLine());
            Console.Write("Please Enter Commission rates        : ");
            int comSale = int.Parse(Console.ReadLine());
            
            int earnings = comSale * salesValue / 100;
            incomes[counter] = earnings;
            Console.WriteLine("Total Earnings is                    : {0}", earnings);

            Console.ReadKey();
        }
        static void salariedEmployee()
        {
            Console.Clear();
            Console.WriteLine("You selected to Add [ Salaried Employee ]");
            Console.Write("Please Enter Employee Name           : ");
            names[counter] = Console.ReadLine();
            Console.Write("Plese Enter Employee Id              : ");
            ids[counter] = Console.ReadLine();
            int earnings;
            Console.Write("Please Enter salary                  : ");
            int salary = int.Parse(Console.ReadLine());
            if (salary <= 50000)
            {
                earnings = salary + salary * 30 / 100;
            }
            else if (salary > 50000 && salary <= 250000)
            {
                earnings = salary + salary * 20 / 100;
            }
            else
            {
                earnings = salary + salary * 10 / 100;
            }
            incomes[counter] = salary;
            Console.WriteLine("Total Earnings is                    : {0}", earnings);
            Console.ReadKey();
        }
        static void hourlyEmployee()
        {
            Console.Clear();
            Console.WriteLine("You selected to Add [ Hourly Employee ]");
            Console.Write("Please Enter Employee Name           : ");
            names[counter] = Console.ReadLine();
            Console.Write("Plese Enter Employee Id              : ");
            ids[counter] = Console.ReadLine();
            Console.Write("Please Enter hourly rate              : ");
            int hourlyRate = int.Parse(Console.ReadLine());
            Console.Write("Please Enter total Weekly hours       : ");
            int weeklyHours = int.Parse(Console.ReadLine());
            int earnings;
            if (weeklyHours > 40)
            {
                int overtime = weeklyHours - 40;
                earnings = 40 * hourlyRate + overtime * (hourlyRate + hourlyRate * 50 / 100);

            }
            else
            {
                earnings = weeklyHours * hourlyRate;
            }
            incomes[counter] = earnings;
            Console.WriteLine("Total Earnings is                    : {0}", earnings);
            Console.ReadKey();
        }
        static void displayEmployee()
        {
            
            bool logic3 = true;
            for (; logic3;)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Employee Display");
                Console.WriteLine("Please Choose one of the following options\n");
                Console.WriteLine("1- Display Information of All Employees");
                Console.WriteLine("2- Display Information of one Emplyee");
                Console.WriteLine("3- Return to Main Menu\n");
                Console.Write("Selection....: ");
                int displaySetting = Convert.ToInt32(Console.ReadLine());
                switch (displaySetting)
                {
                    case 1:
                        
                        displayAllEmployees();
                        break;
                    case 2:
                        displayOneEmployee();
                        break;
                    case 3:
                        Console.Clear();
                        logic3 = false;
                        break;
                    default:

                        Console.WriteLine("\n\nInvalid Entery");
                        break;
                }
                Console.ReadKey();
            }
            
        }
        static void displayAllEmployees()
        {
            Console.Clear();
            Console.WriteLine($"{"Name",-20}|{"Id",-20}|{"Income",-20}");
            Console.WriteLine($"{"----",-20}|{"--",-20}|{"------",-20}");
            for( int i = 0; i < counter; i++)
            {
                string value = $"{names[i],-20}|{ids[i],-20}|{incomes[i],-20}";
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
        static void displayOneEmployee()
        {
            Console.Clear();
            Console.Write("please enter employee name : ");
            string emp = Console.ReadLine();
            
            Console.WriteLine($"{"Name",-20}|{"Id",-20}|{"Income",-20}");
            Console.WriteLine($"{"----",-20}|{"--",-20}|{"------",-20}");
            for ( int i = 0; i < counter; i++)
            {
                if (emp == names[i])
                {
                    string value = $"{names[i],-20}|{ids[i],-20}|{incomes[i],-20}";
                    Console.WriteLine(value);
                }
            }
            Console.ReadKey();
        }
    }
}
