using System;

namespace EmployeeWage
{
	class Program1
	{
        static void Main(string[] args)
		{
			Console.WriteLine("welcome to employee Program");
			const int EmpWagePerHr = 20, Num_Of_Working_Days = 20, Max_Working_Hrs = 100;
			const int Is_FullTime = 1, Is_PartTime = 2;
			int EmpHrs = 0, EmpWage = 0, TotalWages = 0, TotalHrs = 0, WorkingDays = 0;
			while (TotalHrs <= Max_Working_Hrs && WorkingDays < Num_Of_Working_Days)
			{
				Console.WriteLine("Day :" + WorkingDays);
				WorkingDays++;
				Random random = new Random();
				int empCheck = random.Next(1, 3);
				switch (empCheck)
				{
					case Is_FullTime:
						EmpHrs = 8;
						Console.WriteLine("Employee is Full Time");
						break;
					case Is_PartTime:
						EmpHrs = 4;
						Console.WriteLine("Employee is Part Time");
						break;
					default:
						EmpHrs = 0;
						Console.WriteLine("Default Value");
						break;
				}
				EmpWage = EmpHrs * EmpWagePerHr;
				Console.WriteLine("Employee Wage :" + EmpWage);
				TotalHrs = TotalHrs + EmpHrs;
				TotalWages = TotalWages + EmpWage;

			}
			Console.WriteLine("Total Monthly Emp Wages = " + TotalWages);
		}
	}
}

