using System;
using Fibonacci.Sources;
using Fibonacci.Controllers; 

namespace Fibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				new SequenceController(args);
			}
			catch (Exception e)
			{
				Message.Instruction();
				//Console.WriteLine("\n" + e); //Enable to see system messages
			}
			Console.ReadKey();
		}
	}
}
