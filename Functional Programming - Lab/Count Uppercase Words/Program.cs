using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Uppercase_Words
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

			Func<string, bool> func = word => char.IsUpper(word.First());

			foreach (var word in input)
			{
				if (func(word))
				{
					Console.WriteLine(word);
				}
			}
		}
	}
}
