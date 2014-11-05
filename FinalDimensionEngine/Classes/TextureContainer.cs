using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace FinalDimensionEngine
{
	public class TextureContainer:ITextureContainer
	{

		List<ITextureInfo> Textures = new List<ITextureInfo>();

		ContentManager contentManager = null;

		public TextureContainer (ContentManager contentManager)
		{
			this.contentManager = contentManager;
		}

		public void SetTextureInfo(List<string> ContentName)
		{
			ContentName.ForEach
			(cn => 
				{
					if(Textures.Where(t => t.Name == cn).Count() == 0)
						Textures.Add(new TextureInfo(cn));
				});
		}

		public void UnloadAll()
		{
			Textures.Clear();
		}

		public ITextureInfo GetTexture (string TextureName)
		{
			ITextureInfo TI = Textures.Where (t => t.Name == TextureName).SingleOrDefault();

			if (TI.Texture == null)
				TI.Texture = contentManager.Load<Texture2D> (TI.Name);

			return TI;
		}
	}
}

