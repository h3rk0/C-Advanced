using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Text_Editor
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var text = string.Empty;
			var undo = new Stack<string>();
			var erase = new Stack<string>();
			var append = new Stack<string>();
			for (int i = 0; i < n; i++)
			{


				try
				{
					var inputArr = Console.ReadLine().Split(' ').ToArray();
					var command = int.Parse(inputArr[0]);
					if (command == 1)
					{
						//append
						var textToAppend = inputArr[1];
						text = text + textToAppend;
						undo.Push("append");
						append.Push(textToAppend);

					}
					if (command == 2)
					{
						//erase
						var count = int.Parse(inputArr[1]);
						//var textArr = text.ToCharArray();

						var textArr = text.ToCharArray();
						var index = textArr.Length - count; // vazmojno e da e -1 nakraq
						text = text.Remove(index, count);
						var str = string.Empty;
						for (int j = index; j < textArr.Length; j++)
						{
							str = str + textArr[j];
						}
						undo.Push("erase");
						erase.Push(str);
					}
					if (command == 3)
					{
						//cw symbol at index
						var index = int.Parse(inputArr[1]);
						var textArr = text.ToCharArray();
						Console.WriteLine(textArr[index - 1]);
					}
					if (command == 4)
					{
						var lastCommand = undo.Peek();
						undo.Pop();
						if (lastCommand == "erase")
						{
							var undoCom = erase.Pop();
							text = text + undoCom;
						}
						else if (lastCommand == "append")
						{
							var textArr = text.ToCharArray();
							var undoCom = append.Pop();
							var lenght = undoCom.Length;
							var index = textArr.Length - lenght; // vazmojno e da e -1 nakraq
							text = text.Replace(undoCom, string.Empty);

						}
					}
				}
				catch
				{

				}
			}
		}
	}
}
