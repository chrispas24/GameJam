using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using Apos.Input;
using Track = Apos.Input.Track;
namespace GameJam.source
{
    public class World
    {

        public World()
        {

        }

        public virtual void LoadContent()
        {
            FlyingEnemy.StartEnemies();
            BlackBarTrans.TransIn();
        }

        public virtual void Update(GameTime gameTime)
        {
            if (KeyboardCondition.Pressed(Keys.Back)) Ufo.ufos.Clear();
            BlackBarTrans.Update(gameTime);
            FlyingEnemy.Update(gameTime);
        }

        public virtual void Draw()
        { 
            FlyingEnemy.Draw();
            BlackBarTrans.Draw();
        }
    }
}
