using System;

namespace Visitor
{
	public abstract class AbstractEngine : IEngine, IVisitable
	{
		private int size;
		private bool turbo;

		protected Camshaft[] camshafts;
		protected Piston[] pistons;
		protected SparkPlug[] sparkPlugs;

		public AbstractEngine(int size, bool turbo)
		{
			this.size = size;
			this.turbo = turbo;
		}

		public virtual int Size
		{
			get
			{
				return size;
			}
		}

		public virtual bool Turbo
		{
			get
			{
				return turbo;
			}
		}

		public virtual void AcceptEngineVisitor(IEngineVisitor visitor)
		{
			// Visit each component first...
			foreach (Camshaft oneCamshaft in camshafts) 
			{
				oneCamshaft.AcceptEngineVisitor(visitor);
			}
			foreach (Piston onePiston in pistons)
			{
				onePiston.AcceptEngineVisitor(visitor);
			}
			foreach (SparkPlug eachSparkPlug in sparkPlugs)
			{
				eachSparkPlug.AcceptEngineVisitor(visitor);
			}

			// Now visit the receiver...
			visitor.Visit(this);
		}

		public override string ToString()
		{
			return this.GetType().Name + " (" + size + ")";
		}

	}
}
