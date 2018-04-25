using System;
using System.Collections.Generic;
using System.Linq;

namespace Applied_Arithmetics
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<int, int> add = num => num += 1;

			Func<int, int> substract = num => num -= 1;

			Func<int, int> multiply = num => num *= 2;



			IEnumerable<int> input = Console.ReadLine()
				.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				.Select(int.Parse)
				.ToList();


			Action<IEnumerable<int>> print = list => Console.WriteLine(string.Join(" ", list));

			while (true)
			{
				string command = Console.ReadLine();

				if (command == "end")
				{
					break;
				}

				if (command == "add")
				{
					input = ForEach(input, x => x + 1);
				}
				else if (command == "multiply")
				{
					input = ForEach(input, x => x * 2);
				}
				else if (command == "subtract")
				{
					input = ForEach(input, x => x - 1);

				}
				else if (command == "print")
				{
					print(input);
				}

			}

		}

		private static IEnumerable<int> ForEach(IEnumerable<int> input, Func<int, int> func)
		{
			return input.Select(n => func(n));
		}
	}
}
