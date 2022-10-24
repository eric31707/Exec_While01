using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{			
			int limit = 0;
			int sum = 1;
			while (sum + limit < 105)
			{
				limit += 1;
				sum+=limit;
			}
			Console.WriteLine(limit);
		}
	}
}
