using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_by_Age
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> persons = new Dictionary<string, int>();

			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				string[] input = Console.ReadLine()
					.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
					.ToArray();

				string name = input[0];

				int age = int.Parse(input[1]);

				persons[name] = age;
			}

			string condition = Console.ReadLine();

			int conditionAge = int.Parse(Console.ReadLine());

			string format = Console.ReadLine();

			var filter = GetFilter(condition, conditionAge);
			var printer = Print(format);

			foreach (var person in persons)
			{
				if (filter(person.Value))
				{
					printer(person);
				}
			}


		}

		static Func<int, bool> GetFilter(string condition, int age)
		{
			if (condition == "younger")
			{
				return x => x < age;
			}
			else
			{
				return x => x >= age;
			}
		}

		static Action<KeyValuePair<string, int>> Print(string format)
		{
			switch (format)
			{
				case "name":
					return x => Console.WriteLine(x.Key);
				case "age":
					return x => Console.WriteLine(x.Value);
				case "name age":
					return x => Console.WriteLine($"{x.Key} - {x.Value}");
				default:
					throw new NotImplementedException();
			}
		}
	}
}
