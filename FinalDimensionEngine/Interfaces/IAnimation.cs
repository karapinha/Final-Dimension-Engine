using System;
using Microsoft.Xna.Framework;

namespace FinalDimensionEngine
{
	public interface IAnimation: IDrawable, IUpdateable,IGameComponent
	{
		int LoopTimes { get; set; }
		int AnimationIndex { get; set; }
		bool Loop { get; set; }
		Point AnimationSize{ get; set; }
		int TotalAnimationFrames{ get; set; }
	}
}

