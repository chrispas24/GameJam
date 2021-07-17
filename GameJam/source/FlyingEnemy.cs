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
        public static Action[] spawners =
            new Action[]
            {
                () => Ufo.ufos.Add(new Ufo("ufo", new Vector2(460, Helpers.random.Next(20, 180)), 1, 0, 0)),

            };
    

        public static void StartEnemies()
        {

            


        }

        public static void EnemyManage()
        {
            foreach(Ufo ufo in Ufo.ufos)
            {
                if(ufo.position.X < -29)
                {
                    ufo.position.X = 460;
                    ufo.MoveToEdge();
                }
            }
        }

        public static void Update(GameTime gameTime)
        {
            EnemyManage();
            foreach(Ufo ufo in Ufo.ufos)
            {
                ufo.Update(gameTime);
            }

            if (KeyboardCondition.Pressed(Keys.Space))
            {
                spawners[0]();
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
