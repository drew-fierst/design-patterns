using System;

namespace Visitor
{
	public class TurboEngine : AbstractEngine
	{

		public TurboEngine(int size) : base(size, true)
		{
			// turbocharged

			// Create two camshafts, 8 pistons and 8 spark plugs...
			camshafts = new Camshaft[]
				{
					new Camshaft(),
					new Camshaft()
				};
			pistons = new Piston[]
				{
					new Piston(),
					new Piston(),
					new Piston(),
					new Piston(),
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
					new SparkPlug(),
					new SparkPlug(),
					new SparkPlug(),
					new SparkPlug(),
					new SparkPlug()
				};
		}

	}
}
