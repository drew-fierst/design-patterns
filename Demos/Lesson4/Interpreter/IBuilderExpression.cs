using System;

namespace Interpreter
{
	public interface IBuilderExpression
	{
		IBuilderExpression NextExpression { get; set; }
		IVehicle Interpret(IVehicle vehicle);
	}
}