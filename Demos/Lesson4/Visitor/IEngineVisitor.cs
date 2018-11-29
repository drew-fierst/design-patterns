using System;

namespace Visitor
{
	public interface IEngineVisitor
	{
		void Visit(Camshaft camshaft);
		void Visit(IEngine engine);
		void Visit(Piston piston);
		void Visit(SparkPlug sparkPlug);
	}
}
