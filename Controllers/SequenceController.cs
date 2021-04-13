using Fibonacci.Interfaces;
using Fibonacci.Services;
using Fibonacci.View;


namespace Fibonacci.Controllers
{
	public class SequenceController
	{
		public SequenceController(string[] inputArgs)
		{
			Parser parser = new Parser(inputArgs);
			IFibonacciSequenceMaker maker = new FibonacciSequenceMaker(parser.minRangeValue, parser.maxRangeValue);
			IFibonacciSequence sequence = new Models.FibonacciSequence { Sequence = maker.MakingSequence };
			new SequenceViewer(sequence);
		}
	}
}
