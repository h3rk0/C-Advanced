using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			var inputArr = Console.ReadLine().Split(' ');

			var stack = new Stack<string>();

			for (int i = inputArr.Length - 1; i >= 0; i--)
			{
				stack.Push(inputArr[i]);
			}


			var result = int.Parse(stack.Pop());

			while (stack.Count > 1)
			{
				var symbol = stack.Pop();

				if (symbol == "+")
				{
					result += int.Parse(stack.Pop());
				}
				else
				{
					result -= int.Parse(stack.Pop());
				}
			}

			Console.WriteLine(result);
		}
	}
}
