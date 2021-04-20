using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fibonacci.Interfaces;

namespace Fibonacci.Models
{
	public class FibonacciSequence : IFibonacciSequence
	{
		public List<int> Sequence { get; set; }

		public FibonacciSequence (IFibonacciSequenceMaker maker)
		{
			Sequence = maker.MakingSequence;
		}

		public IEnumerator<int> GetEnumerator()
		{
			for (int i = 0; i < Sequence.Count; i++)
			{
				yield return Sequence[i];
			}
		}
	}
}
