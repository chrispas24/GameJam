﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using GameJam;

namespace GameJam.source
{
    public class Sprite
    {
        public Vector2 position;
        public float rotation;
        public int scale;
        public Texture2D texture;

        public Sprite(string path, Vector2 pos, int dim, float rot)
        {
            position = pos;
            scale = dim;
            rotation = rot;
            texture = Globals.content.Load<Texture2D>(path);
        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw()
        {
            Globals.spriteBatch.Draw(texture, new Rectangle((int)(position.X), (int)position.Y, (int)texture.Width * scale, (int)texture.Height * scale), null, Color.White, rotation, new Vector2(texture.Bounds.Width / 2, texture.Bounds.Height / 1.5f), new SpriteEffects(), 0);
        }
    }
}