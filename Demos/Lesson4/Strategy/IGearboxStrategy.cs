using System;

namespace Strategy
{
	public interface IGearboxStrategy
	{
		void EnsureCorrectGear(IEngine engine, int speed);
	}
}
