using System;

namespace EmployeeWage
{
	class Program1
	{
        static void Main(string[] args)
		{
			Console.WriteLine("welcome to employee Program");
			const int EmpWagePerHr = 20, Num_Of_Working_Days = 20;
			const int Is_FullTime = 1, Is_PartTime = 2;
			int EmpHrs=0, EmpWage = 0, TotalWages = 0;
			for (int day = 0; day <= Num_Of_Working_Days; day++)
			{
				Random random = new Random();
				int empCheck = random.Next(1, 3);
				Console.WriteLine("day :" + day);
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
				TotalWages = TotalWages + EmpWage;
			}
			Console.WriteLine("Total Monthly Emp Wages = " + TotalWages);
		}
	}
}

