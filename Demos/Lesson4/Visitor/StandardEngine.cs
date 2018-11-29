using System;

namespace Visitor
{
	public class StandardEngine : AbstractEngine
	{

		public StandardEngine(int size) : base(size, false)
		{
			// not turbocharged

			// Create a camshaft, 4 pistons and 4 spark plugs...
			camshafts = new Camshaft[]
				{
					new Camshaft()
				};
			pistons = new Piston[]
				{
					new Piston(),
					new Piston(),
					new Piston(),
					new Piston()
				};
			sparkPlugs = new SparkPlug[]
				{
					new SparkPlug(),
					new SparkPlug(),
					new SparkPlug(),
					new SparkPlug()
				};
		}

	}
}
