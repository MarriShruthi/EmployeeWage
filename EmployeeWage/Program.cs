using System;

namespace EmployeeWage
{
	class Program1
	{
        static void Main(string[] args)
		{
			Console.WriteLine("welcome to employee Program");
			const int EmpWagePerHr = 20;
			int EmpHrs;
			const int Is_FullTime = 1, Is_PartTime = 2;
			Random random = new Random();
			int empCheck = random.Next(1,3);
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
				default :
					EmpHrs = 0;
					Console.WriteLine("Default Value");
					break;
			}
			int EmpWage = EmpHrs * EmpWagePerHr;
			Console.WriteLine("Emp Wage =" + EmpWage);
		}
	}
}

