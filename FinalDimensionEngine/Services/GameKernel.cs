using System;
using Ninject;
using Ninject.Modules;

namespace FinalDimensionEngine
{

	public class GameKernel: StandardKernel,IGameKernel
	{
		public GameKernel (params INinjectModule[] modules) : base(modules)
		{
			Bind<IGameKernel>().ToConstant<GameKernel> (this);
		}
	}
}

