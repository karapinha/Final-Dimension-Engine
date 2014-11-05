using System;
using Microsoft.Xna.Framework.Graphics;

namespace FinalDimensionEngine
{
	public class TextureInfo : ITextureInfo
	{
		public string Name {get;set;}
		public Texture2D Texture {get;set;}

		public TextureInfo(string Name,Texture2D Texture = null)
		{
			this.Name = Name;
			this.Texture = Texture;
		}
	}
}

