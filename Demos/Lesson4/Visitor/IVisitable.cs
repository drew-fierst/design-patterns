using System;

namespace Visitor
{

	public interface IVisitable
	{
		void AcceptEngineVisitor(IEngineVisitor visitor);
	}

}
