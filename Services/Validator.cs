using System;
using Fibonacci.Interfaces;

namespace Fibonacci.Services
{
	public class Validator : IValidator
	{
        // Validate first and second input args. Can be changed to validate all args.
        public bool FormatValidation(string[] inputArgs, out string[] validArgs)
        {
            validArgs = new string[2];

            for (int i = 0; i < 2; i++)
            {
                if (Double.TryParse(inputArgs[i], out _))
                {
                    validArgs[i] = inputArgs[i];
                }
                else
                {
                    throw new Exception();
                }
            }
            return true;
        }

        // Validate only positive input args. Can be changed to working with negative part of Fibonacci sequence.
        public bool PositiveValidation(double[] parsedArgs, out double[] validPositiveArgs)
        {
            validPositiveArgs = new double[2];

            for (int i = 0; i < parsedArgs.Length; i++)
            {
                if (parsedArgs[i] >= 0)
                {
                    validPositiveArgs[i] = parsedArgs[i];
                }
                else
                {
                    throw new Exception();
                }
            }
            return true;
        }
    }
}
