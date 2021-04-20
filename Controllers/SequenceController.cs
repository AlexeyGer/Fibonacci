using Fibonacci.Interfaces;
using Fibonacci.Services;
using Fibonacci.View;

namespace Fibonacci.Controllers
{
	public class SequenceController
	{

		public IValidator validator;
		public IParser parser;
		public IFibonacciSequenceMaker maker;
		public IFibonacciSequence sequence;
		public ISequenceViewer viewer;

		public SequenceController(string[] inputArgs)
		{
			Initialize(inputArgs);
		}

		public void Initialize(string[] inputArgs)
		{
			validator = new Validator();
			parser = new Parser(inputArgs, validator);
			maker = new FibonacciSequenceMaker(parser);
			sequence = new Models.FibonacciSequence(maker);
			viewer = new SequenceViewer(sequence);
		}
	}
}
