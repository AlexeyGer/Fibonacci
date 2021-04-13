using System;

namespace Fibonacci.Sources
{
	public static class Message
	{
		public static void Instruction()
		{
			Console.WriteLine($"To create new sequence containing Fibonacci numbers " +
				$"\n\nPlease enter limiters of sequence as arguments of command line." +
				$"\nThe limiters must be positive integer or float numbers.");
		}
	}
}
