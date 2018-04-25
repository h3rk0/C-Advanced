using System;
using System.Linq;

namespace Action_Point
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine()
				.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			Action<string> print = word => Console.WriteLine(word);

			foreach (var word in input)
			{
				print(word);
			}
		}
	}
}
