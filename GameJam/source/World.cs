using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using Apos.Input;
using Track = Apos.Input.Track;
using System.Collections;
using System.Collections.Generic;

namespace GameJam.source
{
    public class World
    {
        FlyingHero hero;
        CrewGirl girl;
        Texture2D background;
        public World()
        {

        }

        public virtual void LoadContent()
        {
            background = Globals.content.Load<Texture2D>("daytime_background");
            

            Ufo.ufos.Add(new Ufo("ufo", new Vector2(460, 50), 2, 0, 9));
            Ufo.ufos.Add(new Ufo("ufo", new Vector2(500, 80), 2, 0, 9));
            Ufo.ufos.Add(new Ufo("ufo", new Vector2(450, 150), 2, 0, 9));
            Ufo.ufos.Add(new Ufo("ufo", new Vector2(480, 170), 2, 0, 9));
            Ufo.ufos.Add(new Ufo("ufo", new Vector2(460, 100), 2, 0, 9));
            hero = new FlyingHero("dynamatt-Sheet", new Vector2(100, 100), 2, 0, 4);
            girl = new CrewGirl("HollyIdle", new Vector2(100, 10), 1, 0, hero);
            BlackBarTrans.TransIn();
        }

        public virtual void Update(GameTime gameTime)
        {
            hero.RopeX = girl.position.X + 6;
            girl.Update(gameTime);
            hero.Update(gameTime);
            BlackBarTrans.Update(gameTime);
            FlyingEnemy.Update(gameTime);
            BackgroundManager.Update(gameTime);
        }

        public virtual void Draw()
        {
            Globals.spriteBatch.Draw(background, new Rectangle(0, 0, 426, 240), Color.White);
            BackgroundManager.Draw();
            FlyingEnemy.Draw();
            BlackBarTrans.Draw();
            girl.Draw();
            hero.Draw();
        }
    }
}
