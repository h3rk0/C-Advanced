using System;
using System.Linq;

namespace Add_VAT
{
	class Program
	{
		static void Main(string[] args)
		{
			double[] numbers = Console.ReadLine()
				.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(double.Parse)
				.ToArray();

			Action<double> action = number => Console.WriteLine($"{number * 1.2:f2}");

			foreach (var number in numbers)
			{
				action(number);
			}
		}
	}
}
