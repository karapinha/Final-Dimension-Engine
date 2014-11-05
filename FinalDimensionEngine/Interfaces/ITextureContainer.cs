using System;
using System.Collections.Generic;

namespace FinalDimensionEngine
{
	public interface ITextureContainer
	{
		void SetTextureInfo (List<string> ContentName);
		ITextureInfo GetTexture (string TextureName);
		void UnloadAll ();
	}
}

