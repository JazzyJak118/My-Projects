using System;
using static System.Console;

class Program 
{
    public static void Main (string[] args)
    {
        int subs;
        WriteLine("How many Subcontractors would you like to enter? ");
        subs = Convert.ToInt32(ReadLine());

        Subcontractor[] contractors = new Subcontractor[subs];
        int x;

        for(x = 0; x < contractors.Length; ++x)
        {
            contractors[x] = new Subcontractor("", 0, DateTime.Now);
            WriteLine("Enter Contractor Name: ");
            contractors[x].ContractorName = ReadLine();
            WriteLine("Enter Contractor Number: ");
            contractors[x].ContractorNumber = Convert.ToInt32(ReadLine());
            WriteLine("Enter Contractor Start Date: ");
            contractors[x].ContractorStartDate = Convert.ToDateTime(ReadLine());
            WriteLine("Enter Contractor Shift day = 1 or night = 2 ");
            contractors[x].Shift = Convert.ToInt32(ReadLine());
            WriteLine("Enter Contractor pay rate: ");
            contractors[x].PayRate = Convert.ToDouble(ReadLine());
            WriteLine("Enter Contractor hours worked:");
            contractors[x].HoursWorked = Convert.ToInt32(ReadLine());

        }

        for(x = 0; x < contractors.Length; ++x)
        {
            WriteLine(contractors[x].ToString());
        }
    }
}

class Contractor 
{
    private string contractor_name;
    private int contractor_number;
    private DateTime contractor_start_date;

    public Contractor()
    {
        contractor_name = "";
        contractor_number = 0;
        contractor_start_date = DateTime.Parse("2024/03/20");
    }

    public Contractor(string cName, int cNumber, DateTime csDate)
    {
        contractor_name = cName; 
        contractor_number = cNumber;
        contractor_start_date = csDate;
    }

    public string ContractorName
    {
        get
        {
            return contractor_name;
        }

        set
        {
            contractor_name = value;
        }
    }

    public int ContractorNumber
    {
        get
        {
            return contractor_number;
        }

        set
        {
            contractor_number = value;
        }
    }

    public DateTime ContractorStartDate
    {
        get
        {
            return contractor_start_date;
        }

        set
        {
            contractor_start_date = value;
        }
    }
}

class Subcontractor : Contractor
{
    private int shift;
    private int hoursWorked;
    private double payRate;
    private double totalPay;

    public Subcontractor(string cName, int cNumber, DateTime csDate) : base(cName, cNumber, csDate)
    {
    }

    public int Shift
    {
        get
        {
            return shift;
        }
        set
        {
            shift = value;
        }
    }

    public double PayRate
    {
        get
        {
            return payRate;
        }
        set
        {
            payRate = value;
        }
    }

    public int HoursWorked
    {
        get
        {
            return hoursWorked;
        }
        set
        {
            hoursWorked = value;
            totalPay = hoursWorked * payRate;
            if(shift == 2)
            {
                totalPay = totalPay + (totalPay * .03);
            }
        }
    }

    public override string ToString()
    {
        return "Name: " + ContractorName + " Number: " + ContractorNumber + " Starting Date: " + ContractorStartDate + " Shift: " + Shift + " Pay Rate: $" + PayRate + " Total Pay: $" + totalPay;
    }
}
