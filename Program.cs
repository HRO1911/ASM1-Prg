// See https://aka.ms/new-console-template for more information
Console.WriteLine("Program to calculate electricity and water bills");

// Declare the function to handle the program

void TinhTienHoaDonNuoc()
{
    Console.WriteLine("Enter the customer's full name : ");
    string customer = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Please select customer type");
    Console.WriteLine("Enter number 1 if you are a home customer type, then press enter");
    Console.WriteLine("Enter number 2 if you are a public service administrative agency customer type, then press enter");
    Console.WriteLine("Enter number 3 if you are a production unit customer type, then press enter");
    Console.WriteLine("Enter the number 4 if you specify the Business Services customer type, then press enter");
    int typeCustomer = Convert.ToInt32(Console.ReadLine());
    if (typeCustomer == 1)
    {
        // Family customers
        // Ask for the number of family members
        Console.WriteLine("Enter the number of members in the family");
        int numberMember = Convert.ToInt32(Console.ReadLine());
        if (numberMember >= 1)
        {
            Console.WriteLine("Enter the number of the previous month");
            int waterNumberLastMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter this month's water index");
            int waterNumberCurrentMonth = Convert.ToInt32(Console.ReadLine());
            if (waterNumberCurrentMonth >= waterNumberLastMonth)
            {
                int waterNumber = waterNumberCurrentMonth - waterNumberLastMonth;
                double waterNumberPeople = waterNumber / numberMember;
                double money = 0;
                if (waterNumberPeople > 0 && waterNumber <= 10)
                {
                    money = waterNumber * 5973 * 1.1;
                }
                else if (waterNumberPeople > 10 && waterNumberPeople <= 20)
                {
                    money = waterNumber * 7051 * 1.1;
                }
                else if (waterNumberPeople > 20 && waterNumberPeople <= 30)
                {
                    money = waterNumber * 8699 * 1.1;
                }
                else
                {
                    money = waterNumber * 15929 * 1.1;
                }
                Console.WriteLine("Your family's water bill is : {0}", money);
            }
            else
            {
                Console.WriteLine("The amount of water in the previous month is not greater than that of the current month");
            }
        }
        else
        {
            Console.WriteLine("You are not a household customer");
        }
    }
    else if (typeCustomer == 2)
    {
        // Customers have public administration
        Console.WriteLine("Please enter last month's water meter reading");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the current month's water meter reading");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 9955 * 1.1;
            Console.WriteLine("Water fees of public administrative agencies are {0}", m);
        }
        else
        {
            Console.WriteLine("The previous month's water meter reading is not greater than the current month's");
        }
       
    }
    else if (typeCustomer == 3)
    {
        // Product produced by customer unit
        Console.WriteLine("Please enter last month's water meter reading");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the current month's water meter reading");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 11615 * 1.1;
            Console.WriteLine("The production unit's water bill is {0}", m);
        }
        else
        {
            Console.WriteLine("The previous month's water meter reading is not greater than the current month's");
        }
    }
    else if (typeCustomer == 4)
    {
        // Business customers
        Console.WriteLine("Please enter last month's water meter reading");
        int waterLastMonth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the current month's water meter reading");
        int waterCurrentMonth = Convert.ToInt32(Console.ReadLine());
        if (waterCurrentMonth >= waterLastMonth)
        {
            double m = (waterCurrentMonth - waterLastMonth) * 22068 * 1.1;
            Console.WriteLine("Water charges for business services are {0}", m);
        }
        else
        {
            Console.WriteLine("The previous month's water meter reading is not greater than the current month's");
        }

    }
    else
    {
        Console.WriteLine("Please enter the correct customer category");
    }
}
// run the program
TinhTienHoaDonNuoc();