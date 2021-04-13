using System;
using Fibonacci.Interfaces;

namespace Fibonacci.View
{
	public class SequenceViewer
	{
		public SequenceViewer(IFibonacciSequence sequence)
		{
			foreach (int integer in sequence)
			{
				Console.Write(integer + ", ");
			}
		}
	}
}
