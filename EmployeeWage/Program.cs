using System;

namespace EmployeeWage
{
	class Program1
	{
		static void Main(string[] args)
		{
			Console.WriteLine("welcome to employee Program");
			int isPresent = 1;
			Random random = new Random();
			int empCheck = random.Next(0, 2);
			if (empCheck == isPresent)
				Console.WriteLine("Employee is Present");
			else
				Console.WriteLine("Employee is Absent");
		}
	}
}
