using System;

namespace Visitor
{
	public class SparkPlug : IVisitable
	{
		public virtual void AcceptEngineVisitor(IEngineVisitor visitor)
		{
			visitor.Visit(this);
		}

		//other properties, methods


	}
}
