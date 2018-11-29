using System.Collections.Generic;

namespace Flyweight
{
	public class EngineFlyweightFactory
	{
		private static EngineFlyweightFactory instance;

		public static EngineFlyweightFactory GetInstance()
		{
			if (instance == null) instance = new EngineFlyweightFactory();
			return instance;
		}


		private IDictionary<int?, IEngine> standardEnginePool;
		private IDictionary<int?, IEngine> turboEnginePool;

		private EngineFlyweightFactory()
		{
			standardEnginePool = new Dictionary<int?, IEngine>();
			turboEnginePool = new Dictionary<int?, IEngine>();
		}

		public virtual IEngine GetStandardEngine(int size)
		{
			IEngine e = null;
			bool found = standardEnginePool.TryGetValue(size, out e);
			if (!found)
			{
				e = new StandardEngine(size);
				standardEnginePool[size] = e;
			}
			return e;
		}

		public virtual IEngine GetTurboEngine(int size)
		{
			IEngine e = null;
			bool found = turboEnginePool.TryGetValue(size, out e);
			if (!found)
			{
				e = new TurboEngine(size);
				turboEnginePool[size] = e;
			}
			return e;
		}
	}
}
