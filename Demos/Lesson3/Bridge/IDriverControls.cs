using System;

namespace Bridge
{
	public interface IDriverControls
	{
		void IgnitionOn();
		void IgnitionOff();
		void Accelerate();
		void Brake();
	}
}
