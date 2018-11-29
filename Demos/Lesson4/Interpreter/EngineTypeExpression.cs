using System;

namespace Interpreter
{
	public class EngineTypeExpression : IBuilderExpression
	{
		private bool turbo;

		public EngineTypeExpression(bool turbo) 
		{
			this.turbo = turbo;
		}

		public IBuilderExpression NextExpression { get; set; }

		public IVehicle Interpret(IVehicle vehicle)
		{
			IEngine engine;
			if (turbo)
			{
				engine = new TurboEngine(2000);
			}
			else
			{
				engine = new StandardEngine(1500);
			}
			vehicle.InstallEngine(engine);

			if (NextExpression != null)
			{
				vehicle = NextExpression.Interpret(vehicle);
			}

			return vehicle;
		}

	}
}