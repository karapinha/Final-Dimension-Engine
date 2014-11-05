using System;
using Ninject.Modules;
using Ninject;

namespace FinalDimensionEngine
{
	public class TypeMappings: NinjectModule
	{
		public override void Load ()
		{
			Kernel.Bind<ITextureInfo> ().To<TextureInfo>();
		}
	}
}

