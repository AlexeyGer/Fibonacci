using System;
using Fibonacci.Interfaces;

namespace Fibonacci.Services
{
	public class Parser : IParser
	{
		public double MinRangeValue { get; set; }
		public double MaxRangeValue { get; set; }

		public Parser(string[] inputArgs, IValidator validator)
		{
			Parse(inputArgs, validator);
		}

		public void Parse(string[] inputArgs, IValidator validator)
		{
			double[] parsedArgs = new double[2];

			if (validator.FormatValidation(inputArgs, out string[] validArgs))
			{
				for (int i = 0; i < validArgs.Length; i++)
				{
					parsedArgs[i] = Double.Parse(validArgs[i]);
				}
			}

			if (validator.PositiveValidation(parsedArgs, out double[] validPositiveArgs))
			{
				if (validPositiveArgs[0] != validPositiveArgs[1])
				{
					MinRangeValue = Math.Min(validPositiveArgs[0], validPositiveArgs[1]);
					MaxRangeValue = Math.Max(validPositiveArgs[0], validPositiveArgs[1]);
				}
				else
				{
					MinRangeValue = MaxRangeValue = validPositiveArgs[0];
				}
			}
		}
	}
}
