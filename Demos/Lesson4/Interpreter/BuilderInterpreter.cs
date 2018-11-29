using System;
using System.Collections.Generic;

namespace Interpreter
{
	public class BuilderInterpreter
	{
		private IBuilderExpression command;

		public bool TryParse(string expr)
		{
			expr = expr.ToLower();
			command = null;
			IBuilderExpression currCommand;

			//get the vehicle type to be created
			IBuilderExpression vehicleTypeExpr = ParseVehicleExpression(expr);
			if (vehicleTypeExpr == null)
			{
				//must specify what kind of vehicle to create, at a minimum
				return false;
			}
			command = vehicleTypeExpr;
			currCommand = vehicleTypeExpr;

			//now, parse out color
			IBuilderExpression colorExpr = ParseColorExpression(expr);
			if (colorExpr != null)
			{
				currCommand.NextExpression = colorExpr;
				currCommand = colorExpr;
			}

			//next, parse out engine
			IBuilderExpression engineExpr = ParseEngineExpression(expr);
			currCommand.NextExpression = engineExpr;
			currCommand = engineExpr;



			return true;
		}

		public IVehicle Interpret()
		{
			if (command != null)
			{
				return command.Interpret(null);
			}
			return null;
		}

		private string[] vehicleCommands = new string[] { "coupe", "sedan", "sport", "pickup", "boxvan" };
		private IBuilderExpression ParseVehicleExpression(string expr)
		{
			foreach (var oneCommand in vehicleCommands)
			{
				if (expr.Contains(oneCommand))
				{
					expr.Replace(oneCommand, "");
					return new VehicleExpression(oneCommand);
				}
			}
			return null;
		}

		private string[] colorCommands = new string[] { "red", "black", "white", "blue", "green", "silver", "yellow" };
		private IBuilderExpression ParseColorExpression(string expr)
		{
			foreach (var oneCommand in colorCommands)
			{
				if (expr.Contains(oneCommand))
				{
					expr.Replace(oneCommand, "");
					return new PaintColorExpression(oneCommand);
				}
			}
			return null;
		}

		private IBuilderExpression ParseEngineExpression(string expr)
		{
			if (expr.Contains("turbo"))
			{
				expr.Replace("turbo", "");
				return new EngineTypeExpression(true);
			}
			else
			{
				return new EngineTypeExpression(false);
			}

		}
	}
}