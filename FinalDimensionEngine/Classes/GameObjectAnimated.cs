using System;
using Microsoft.Xna.Framework;

namespace FinalDimensionEngine
{
	public class GameObjectAnimated:GameObject,IAnimation
	{
		#region IAnimation implementation

		public int LoopTimes { get; set; }
		public int AnimationIndex { get; set; }
		public bool Loop { get; set; }
		public Point AnimationSize{ get; set; }
		public int TotalAnimationFrames{ get; set; }

		#endregion

		public GameObjectAnimated(Game game,ITextureContainer TextureContainer) : base(game,TextureContainer)
		{
			
		}

		public override Rectangle GetRectangle ()
		{
			return new Rectangle (AnimationSize.X*AnimationIndex,AnimationSize.Y, AnimationSize.X, AnimationSize.Y);
		}

	}
}

