using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = 1;
			while (number < 300)
			{
				number++;
				if (300 % number == 0)
				{
					Console.WriteLine(number);
				}
			}
		}
	}
}
