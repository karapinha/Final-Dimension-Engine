using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FinalDimensionEngine
{
	public interface IGameObject:IDrawable,IUpdateable,IGameComponent
	{
		Vector2 DrawingPosition{ get; set; }
		string TextureName { get; set; }
		Rectangle GetRectangle ();
		Point Size { get; set; }
		ITextureContainer TextureContainer { get; set;}
	}
}

