using System;

namespace Mediator
{
	public interface IEngineManager
	{
		void RegisterIgnition(Ignition ignition);
		void RegisterGearbox(Gearbox gearbox);
		void RegisterAccelerator(Accelerator accelerator);
		void RegisterBrake(Brake brake);

		void IgnitionTurnedOn();
		void IgnitionTurnedOff();
		void GearboxEnabled();
		void GearboxDisabled();
		void GearChanged();
		void AcceleratorEnabled();
		void AcceleratorDisabled();
		void AcceleratorPressed();
		void BrakeEnabled();
		void BrakeDisabled();
		void BrakePressed();
		void BrakeReleased();
	}
}