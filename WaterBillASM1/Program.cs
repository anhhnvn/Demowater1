using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBillASM1
{
    internal class Program
    {
        
        
            static void MenuChon()
        {
            Console.WriteLine("1. Family");
            Console.WriteLine("2. Administrative agency");
            Console.WriteLine("3. Production unit");
            Console.WriteLine("4. Business service");
            Console.Write("Which group do you belong to? ");
        }

        static void Family(double numberOfCountries, double previousMonthBill)
        {
            double waterFee;
            if (numberOfCountries <= 10)
            {
                waterFee = numberOfCountries * 5.973;
            }
            else if (numberOfCountries <= 20)
            {
                waterFee = numberOfCountries * 7.052;
            }
            else if (numberOfCountries <= 30)
            {
                waterFee = numberOfCountries * 8.699;
            }
            else
            {
                waterFee = numberOfCountries * 15.929;
            }
            double tax = waterFee * 0.1;
            Display(previousMonthBill, waterFee, tax);
        }

        static void AdministrativeAgency(double numberOfCountries, double previousMonthBill)
        {
            double waterFee = numberOfCountries * 9.955;
            double tax = waterFee * 0.1;
            Display(previousMonthBill, waterFee, tax);
        }

        static void ProductionUnit(double numberOfCountries, double previousMonthBill)
        {
            double waterFee = numberOfCountries * 11.615;
            double tax = waterFee * 0.1;
            Display(previousMonthBill, waterFee, tax);
        }

        static void BusinessService(double numberOfCountries, double previousMonthBill)
        {
            double waterFee = numberOfCountries * 22.608;
            double tax = waterFee * 0.1;
            
            Display(previousMonthBill, waterFee, tax);
        }

        static void Display(double previousMonthBill, double waterFee, double tax)
        {
            Console.WriteLine();
            Console.WriteLine("Previous month's water bill: {0:C}", previousMonthBill);
            Console.WriteLine("Your taxes are: {0:C}", tax);
            Console.WriteLine("Your water bill is: {0:C}", waterFee);
            Console.WriteLine("The total amount you have to pay is: {0:C}", tax + waterFee);
        }

        static void Main(string[] args)
        {
            MenuChon();

            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid customer group.");
                return;
            }

            Console.Write("Enter the number of countries: ");
            if (!double.TryParse(Console.ReadLine(), out double numberOfCountries) || numberOfCountries < 0)
            {
                Console.WriteLine("Invalid number of countries.");
                return;
            }

            Console.Write("Enter the previous month's water bill: ");
            if (!double.TryParse(Console.ReadLine(), out double previousMonthBill) || previousMonthBill < 0)
            {
                Console.WriteLine("Invalid previous month's water bill.");
                return;
            }

            switch (choice)
            {
                case 1:
                    Family(numberOfCountries, previousMonthBill);
                    break;
                case 2:
                    AdministrativeAgency(numberOfCountries, previousMonthBill);
                    break;
                case 3:
                    ProductionUnit(numberOfCountries, previousMonthBill);
                    break;
                case 4:
                    BusinessService(numberOfCountries, previousMonthBill);
                    break;
            }
        }
    }
        }
    

