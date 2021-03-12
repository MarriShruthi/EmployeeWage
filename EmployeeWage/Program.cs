using System;

namespace EmployeeWage
{
	class Program1
	{
		static void Main(string[] args)
		{
			Console.WriteLine("welcome to employee Program");
			int isPartTime = 1;
			int EmpWagePerHr = 20;
			Random random = new Random();
			int empCheck = random.Next(0, 2);
			if (empCheck == isPartTime)
				Console.WriteLine("Employee is Part Time");
				int EmpHrs = 8;
				int EmpWage =(EmpHrs * EmpWagePerHr);
				Console.WriteLine("Emp Wage = "+EmpWage);
		}
	}
}

