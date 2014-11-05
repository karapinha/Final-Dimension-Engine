using System;
using Microsoft.Xna.Framework;

namespace FinalDimensionEngine
{
	public class GameObjectAnimated:GameObject					
	{
		int AnimationIndex = 0;
		public bool Loop = false;
		public Point AnimationSize;
		int TotalAnimationFrames = 30;

		public Animation(Game game,IGameKernel Kernal) : base(game,Kernal)
		{
		
		}

		public override void Draw (Microsoft.Xna.Framework.GameTime gameTime)
		{
			base.Draw (gameTime);
		}

		public override void Update (Microsoft.Xna.Framework.GameTime gameTime)
		{
			base.Update (gameTime);
		}

		public override Microsoft.Xna.Framework.Rectangle GetRectangle ()
		{
			return new Rectangle (AnimationSize.X*AnimationIndex,AnimationSize.Y, AnimationSize.X, AnimationSize.Y);
		}

	}
}

