using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Apos.Input;
using Track = Apos.Input.Track;
using MonoGame.Extended.Tweening;
using MonoGame.Extended.Graphics;


namespace GameJam.source
{
    class Entity : Sprite
    {
        public static List<Entity> entities = new List<Entity>();
        public Vector2 physPosition;
        public Rectangle body;
        public Entity(string path, Vector2 position, int _dim, float rot) : base(path, position, _dim, rot)
        {
            physPosition = new Vector2(position.X + texture.Width / 2, position.Y + texture.Height / 2);
            body = new Rectangle((int)position.X, (int)position.Y, texture.Width * scale, texture.Height * scale);
        }

        public override void Update(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            foreach(Entity entity in entities)
            {
                if(Helpers.CollisionCheck(body, entity.body) && entity != this)
                {
                    Console.WriteLine("It's a hit!");
                }
            }
        }

        public override void Draw()
        {
            base.Draw();
            foreach (Entity entity in entities) if (Helpers.CollisionCheck(body, entity.body) && entity != this) Globals.spriteBatch.Draw(pixel, body, Color.Black);

        }
    }
}
