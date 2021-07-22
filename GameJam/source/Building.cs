using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameJam.source
{
    class Building : Entity
    {
        public static List<Building> buildings = new List<Building>();
        public Building(string path, Vector2 pos, int dim, float rot) : base(path, pos, dim, rot)
        {

        }

        public override void Update(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= 40 * dt;
        }

        public override void Draw()
        {
            base.Draw();
        }
    }
}
