using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using GameJam.source;
using Apos.Input;
using Track = Apos.Input.Track;
using MonoGame.Extended.Tweening;
namespace GameJam
{
    public class Main : Game
    {
        private GraphicsDeviceManager _graphics;
        World testWorld;
        public Main()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            _graphics.ApplyChanges();


            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            Globals.content = this.Content;
            Globals.spriteBatch = new SpriteBatch(GraphicsDevice);
            InputHelper.Setup(this);
            testWorld = new World();
            testWorld.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            InputHelper.UpdateSetup();

            var dt = (float)gameTime.ElapsedGameTime.TotalSeconds;

            Globals.tweener.Update(dt);
            testWorld.Update(gameTime);
            base.Update(gameTime);

            InputHelper.UpdateCleanup();
        }


        protected override void Draw(GameTime gameTime)
        {

            GraphicsDevice.Clear(Color.AntiqueWhite);

            Globals.spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend,
                        SamplerState.PointClamp);
            testWorld.Draw();

            

            Globals.spriteBatch.End();




            base.Draw(gameTime);
        }
    }
}
