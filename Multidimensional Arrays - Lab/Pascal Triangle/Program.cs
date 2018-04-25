using System;

namespace Pascal_Triangle
{
	class Program
	{
		static void Main(string[] args)
		{
			var height = long.Parse(Console.ReadLine());

			long[][] triangle = new long[height][];

			for (long currentHeight = 0; currentHeight < height; currentHeight++)
			{

				triangle[currentHeight] = new long[currentHeight + 1];

				triangle[currentHeight][0] = 1;

				triangle[currentHeight][currentHeight] = 1;

				if (currentHeight >= 2)
				{
					for (long widthCounter = 1; widthCounter < currentHeight; widthCounter++)
					{
						triangle[currentHeight][widthCounter] =
							triangle[currentHeight - 1][widthCounter - 1] +
							triangle[currentHeight - 1][widthCounter];
					}
				}

			}

			for (long i = 0; i < triangle.Length; i++)
			{

				for (long j = 0; j < triangle[i].Length; j++)
				{
					Console.Write(triangle[i][j] + " ");

				}

				Console.WriteLine();
			}


		}
	}
}
