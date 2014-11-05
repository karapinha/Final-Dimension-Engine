using System;
using Microsoft.Xna.Framework.Graphics;

namespace FinalDimensionEngine
{
	public interface ITextureInfo
	{
		string Name {get;set;}
		Texture2D Texture {get;set;}
	}
}

