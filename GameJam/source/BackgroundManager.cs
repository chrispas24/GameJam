using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;

namespace GameJam.source
{
    public class BackgroundManager
    {
        public static void StartBuildings()
        {
            for(int i = 1; i <= 4; i++)
            {
                Building.buildings.Add(new Building("daytime_building0" + i, new Vector2(0 * i, 50), 1, 0));
            }
        }

        public static void Update(GameTime gameTime)
        {
            foreach(Building building in Building.buildings)
            {
                building.Update(gameTime);
            }
        }

        public static void Draw()
        {
            foreach (Building building in Building.buildings)
            {
                building.Draw();
            }
        }
    }
}
