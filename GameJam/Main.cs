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
        RenderTarget2D renderTarget;
        public Main()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.PreferredBackBufferHeight = 1080;
            _graphics.IsFullScreen = false;
            _graphics.ApplyChanges();

            renderTarget = new RenderTarget2D(
                GraphicsDevice,
                426,
                240,
                false,
                GraphicsDevice.PresentationParameters.BackBufferFormat,
                DepthFormat.Depth24);

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

        protected void DrawSceneToTexture(RenderTarget2D renderTarget)
        {
            // Set the render target
            GraphicsDevice.SetRenderTarget(renderTarget);

            GraphicsDevice.DepthStencilState = new DepthStencilState() { DepthBufferEnable = true };

            // Draw the scene
            GraphicsDevice.Clear(Color.LightSkyBlue);

            Globals.spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend,
                        SamplerState.PointClamp);
            testWorld.Draw();
            Globals.spriteBatch.End();
            // Drop the render target
            GraphicsDevice.SetRenderTarget(null);
        }

        protected override void Draw(GameTime gameTime)
        {
            DrawSceneToTexture(renderTarget);
            GraphicsDevice.Clear(Color.Black);

            Globals.spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend,
                        SamplerState.PointClamp);

            Globals.spriteBatch.Draw(renderTarget, new Rectangle(0, 0, 1920, 1080), Color.White);
            

            Globals.spriteBatch.End();




            base.Draw(gameTime);
        }
    }
}
