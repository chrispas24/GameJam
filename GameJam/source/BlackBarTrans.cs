using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;

namespace GameJam.source
{
    public class BlackBarTrans
    {
        public static void TransIn()
        {
            BlackBar.blackBars.Add(new BlackBar("debugRect", new Vector2(0, -30), 30, 0, true));
            BlackBar.blackBars.Add(new BlackBar("debugRect", new Vector2(0, 240), 30, 0, false));
        }

        public static void Update(GameTime gameTime)
        {
            foreach (BlackBar bb in BlackBar.blackBars)
                bb.Update(gameTime);
        }

        public static void Draw()
        {
            foreach (BlackBar bb in BlackBar.blackBars)
                bb.Draw();
        }
    }
}
