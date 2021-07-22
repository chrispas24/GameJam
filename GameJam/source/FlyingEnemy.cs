using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Tweening;
using RPG;
using System;
using System.Collections.Generic;
using Apos.Input;
using Track = Apos.Input.Track;

namespace GameJam.source
{
    public class FlyingEnemy
    {

        public static void StartEnemies()
        {

        }

        public static void Update(GameTime gameTime)
        {

            foreach(Ufo ufo in Ufo.ufos)
            {
                ufo.Update(gameTime);
            }

        }

        public static void Draw()
        {
            foreach (Ufo ufo in Ufo.ufos)
            {
                ufo.Draw();
            }
        }
    }
}
