using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace GameJam.source
{
    public class World
    {

        public World()
        {

        }

        public virtual void LoadContent()
        {
            for(int i = 1; i <= 20; i++)
                Entity.entities.Add(new Entity("1", new Vector2(60 * i, 100), 2, 0));
        }

        public virtual void Update(GameTime gameTime)
        {
            foreach(Entity entity in Entity.entities)
            {
                entity.Update(gameTime);
            }
        }

        public virtual void Draw()
        {
            foreach (Entity entity in Entity.entities)
            {
                entity.Draw();
            }
        }
    }
}
