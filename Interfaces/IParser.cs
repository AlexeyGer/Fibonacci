using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Interfaces
{
	public interface IParser
	{
		double MinRangeValue { get; set; }
		double MaxRangeValue { get; set; }
		void Parse(string[] inputArgs, IValidator validator);
	}
}
