using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_Binary_Converter
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = int.Parse(Console.ReadLine());

			var stack = new Stack<int>();

			if (input == 0)
			{
				Console.WriteLine(0);
				return;
			}

			while (input > 0)
			{
				var reminder = input % 2;

				stack.Push(reminder);

				input /= 2;
			}

			while (stack.Count > 0)
			{
				Console.Write(stack.Pop());
			}

			Console.WriteLine();
		}
	}
}
