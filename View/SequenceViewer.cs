using System;
using Fibonacci.Interfaces;

namespace Fibonacci.View
{
	public class SequenceViewer : ISequenceViewer
	{
		public SequenceViewer (IFibonacciSequence sequence)
		{
			View(sequence);
		}

		public void View(IFibonacciSequence sequence)
		{
			foreach (int integer in sequence)
			{
				Console.Write(integer + ", ");
			}
		}
	}
}
