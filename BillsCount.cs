using System;

namespace TestConsole
{
    class BillsCount
    {
        static void Main(string[] args)
        {
            int money = 0;
            Console.Write("Enter the Amount of Money : ");
            bool isValid = int.TryParse(Console.ReadLine(), out money);

            if (isValid)
            {
                //all the bills that we have
                int[] bills = new int[] { 500, 100, 50, 10, 5 };

                //for storing each type of bill count
                int[] billsCount = new int[bills.Length];

                //calculate bill count for each bill and
                //store it in corresponding billsCount index
                for (int i = 0; i < bills.Length; i++)
                {
                    int noOfBills = money / bills[i];
                    money = money - (noOfBills * bills[i]);
                    billsCount[i] = noOfBills;
                }

                //if money isn't reduced to 0, its invalid
                if (money > 0)
                    Console.WriteLine("Invalid Amount");
                //if not print bills and its count
                else
                    for (int i = 0; i < bills.Length; i++)
                        if (billsCount[i] != 0)
                            Console.WriteLine("{0}*{1}", bills[i], billsCount[i]);
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }

            Console.ReadKey();
        }
    }
}
