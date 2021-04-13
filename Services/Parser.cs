using System;

namespace Fibonacci.Services
{
	public class Parser
	{
		public double minRangeValue;
		public double maxRangeValue;

		public Parser(string[] inputArgs)
		{
			double[] parsedArgs = new double[2];

			if (Validator.FormatValidation(inputArgs, out string[] validArgs))
			{
				for (int i = 0; i < validArgs.Length; i++)
				{
					parsedArgs[i] = Double.Parse(validArgs[i]);
				}
			}

			if (Validator.PositiveValidation(parsedArgs, out double[] validPositiveArgs))
			{
				if (validPositiveArgs[0] < validPositiveArgs[1])
				{
					minRangeValue = validPositiveArgs[0];
					maxRangeValue = validPositiveArgs[1];
				}
				else
				{
					minRangeValue = validPositiveArgs[1];
					maxRangeValue = validPositiveArgs[0];
				}
			}
		}
	}
}
