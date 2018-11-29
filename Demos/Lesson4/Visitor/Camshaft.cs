using System;

namespace Visitor
{
	public class Camshaft : IVisitable
	{
		public virtual void AcceptEngineVisitor(IEngineVisitor visitor)
		{
			visitor.Visit(this);
		}

		//other properties, methods


	}
}
