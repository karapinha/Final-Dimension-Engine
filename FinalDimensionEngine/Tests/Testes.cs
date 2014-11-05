using System;
using NUnit.Framework;
using Moq;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace FinalDimensionEngine
{
	[TestFixture]
	public class Testes
	{

		[Test]
		public void TextureContainerContent()
		{
			Mock<IServiceProvider> sp = new Mock<IServiceProvider> ();
			Mock<ContentManager> cm = new Mock<ContentManager> (sp.Object);

			TextureContainer TC = new TextureContainer (cm.Object);

			List<string> TextureNames = new List<string> () {
				"Teste1",
				"Teste2",
				"Teste1"
			};
			TC.SetTextureInfo (TextureNames);

			Assert.DoesNotThrow(()=> TC.GetTexture("Teste1"));
		}

		[Test]
		public void AnimationGetRectangle()
		{
			Mock<IServiceProvider> sp = new Mock<IServiceProvider> ();
			ITextureContainer TextureContainer = Mock.Of<ITextureContainer> ();
			GameObjectAnimated AnimTest = new GameObjectAnimated (new Game(),TextureContainer);
			AnimTest.AnimationSize = new Point (32, 32);

			Assert.Equals(AnimTest.GetRectangle(),new Rectangle(0,0,32,32));
			Assert.AreNotEqual(AnimTest.GetRectangle(),new Rectangle(32,0,32,32));
		}
	}
}

