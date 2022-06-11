using System;

namespace MyChallenge
{
	class Challenge
	{
		public static void Main(string[] args)
		{
			int a = 0;
            while (a < 7) {
                int b = 0;
                while (b < 5) {
                    int c = 0;
                    while (c < 4) {
                        Console.WriteLine("({0},{1},{2})", a,b,c);
                        c++;
                    }
                    b++;
                }
            a++;

            }
		}
	}
}