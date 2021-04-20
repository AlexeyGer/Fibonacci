using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Interfaces
{
	public interface IValidator
	{
		bool FormatValidation(string[] inputArgs, out string[] validArgs);
		bool PositiveValidation(double[] parsedArgs, out double[] validPositiveArgs);
	}
}
