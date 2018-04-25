using System;
using System.Linq;

namespace Knights_of_Honor
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine()
				.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				.ToArray();

			Action<string> printSir = word => Console.WriteLine($"Sir {word}");

			foreach (var word in input)
			{
				printSir(word);
			}
		}
	}
}
