using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharReplacement
{
	class Program
	{
		static void Main(string[] args)
		{
			string r = ReplaceSpaces("I hope this webinar isn't boring.");
			Console.WriteLine(r);
			Console.ReadLine();
		}

		public static string ReplaceSpaces(string s)
		{
			return s.Replace(" ", "%20");
		}
	}
}
