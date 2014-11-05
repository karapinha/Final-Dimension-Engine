using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Ninject;

namespace FinalDimensionEngine
{
	public abstract class GameObject:DrawableGameComponent,IGameObject
	{


		#region IGameObject implementation

		public Point Size { get; set; }

		public virtual Rectangle GetRectangle ()
		{
			return new Rectangle (0,Size.Y, Size.X, Size.Y);
		}

		public Vector2 DrawingPosition { get; set; }

		public string TextureName { get; set;}

		public ITextureContainer TextureContainer{ get; set; }

		#endregion

		SpriteBatch spriteB;

		public GameObject(Game game,ITextureContainer TextureContainer) : base(game)
		{
			this.TextureContainer = TextureContainer;
		}

		public override void Initialize ()
		{
			spriteB = new SpriteBatch (this.GraphicsDevice);
			base.Initialize ();

		}

		public override void Update (GameTime gameTime)
		{
			base.Update (gameTime);
		}

		public override void Draw (GameTime gameTime)
		{
			spriteB.Begin ();
			spriteB.Draw(TextureContainer.GetTexture(TextureName).Texture,DrawingPosition,GetRectangle(), Color.White);
			spriteB.End ();
			base.Draw (gameTime);
		}
	}
}

