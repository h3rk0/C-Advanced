﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			var input = Console.ReadLine();

			var stack = new Stack<char>();

			for (int i = 0; i < input.Length; i++)
			{
				stack.Push(input[i]);
			}

			for (int i = 0; i < input.Length; i++)
			{
				Console.Write(stack.Pop());
			}

			Console.WriteLine();
		}
	}
}
