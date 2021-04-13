using System.Collections.Generic;

namespace Fibonacci.Interfaces
{
	public interface IFibonacciSequence
	{
		List<int> Sequence { get; set; }
		IEnumerator<int> GetEnumerator();
	}
}
