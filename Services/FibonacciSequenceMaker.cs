using System.Collections.Generic;
using Fibonacci.Interfaces;

namespace Fibonacci.Services
{
	public class FibonacciSequenceMaker : IFibonacciSequenceMaker
	{
		public List<int> MakingSequence { get; set; }

		static int previousNumber = 0;
		static int currentNumber = 1;
		static int[] FIRST_AND_SECOND_NUMBERS = new int[] { previousNumber, currentNumber };

		public FibonacciSequenceMaker(IParser parser)
		{
			MakingSequence = new List<int>();

			double minRangeValue = parser.MinRangeValue;
			double maxRangeValue = parser.MaxRangeValue;

			for (int i = 0; i < FIRST_AND_SECOND_NUMBERS.Length; i++)
			{
				if (FIRST_AND_SECOND_NUMBERS[i] >= minRangeValue && FIRST_AND_SECOND_NUMBERS[i] <= maxRangeValue)
				{
					MakingSequence.Add(FIRST_AND_SECOND_NUMBERS[i]);
				}
			}

			while (currentNumber >= 1 && currentNumber <= maxRangeValue)
			{
				int temp = previousNumber;
				previousNumber = currentNumber;
				currentNumber += temp;

				if (currentNumber >= minRangeValue && currentNumber <= maxRangeValue)
				{
					MakingSequence.Add(currentNumber);
				}
			}
		}
	}
}
