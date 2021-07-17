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
            BlackBarTrans.TransIn();
        }

        public virtual void Update(GameTime gameTime)
        {
            BlackBarTrans.Update(gameTime);
        }

        public virtual void Draw()
        {
            BlackBarTrans.Draw();
        }
    }
}
