using System;

namespace Loop
{
	class NestedForLoop
	{
		public static void Main(string[] args)
		{
			int a = 0, b = 0;
			for (int i = 1; i < 10 ;  i++ )
			{
				a++;
				for (int j = 1; j < 5; j++)
				{
					b++;
				}
			}
			Console.WriteLine("{0},{1}", a, b);
		}
	}
}