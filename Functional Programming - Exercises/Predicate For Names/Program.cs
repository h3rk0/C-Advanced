using System;
using System.Linq;

namespace Predicate_For_Names
{
	class Program
	{
		static void Main(string[] args)
		{
			int lenght = int.Parse(Console.ReadLine());

			string[] names = Console.ReadLine().Split(' ').ToArray();

			Func<string, bool> predicate = name => name.Length <= lenght;

			foreach (var name in names)
			{
				if (predicate(name))
				{
					Console.WriteLine(name);
				}
			}
		}
	}
}
