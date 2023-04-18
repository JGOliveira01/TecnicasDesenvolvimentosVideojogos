using IPCA.Monogame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace SegundoProjeto
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        //private KeyboardManager _keyboardManager;
        private Player _player;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            //_keyboardManager = new KeyboardManager();
            //_keyboardManager = new KeyboardManager(this);
            new KeyboardManager(this); //Singleton
            KeyboardManager.Register(Keys.Escape, KeysState.GoingDown, Exit);
            // Register Recebe:
            //  - A tecla a "analisar"
            //  - O estado a considerar para essa tecla
            //  - Funcao a ser executada quando essa tecla atinge o estado indicado

            //Components.Add(_keyboardManager);
            _player = new Player();

            Console.WriteLine("#######  HELLO!!!! #######");
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            //if (KeyboardManager.IsGoingDown(Keys.Escape))
            //    Exit();

            // TODO: Add your update logic here
            //_keyboardManager.Update(gameTime);
            //if (_keyboardManager.IsGoingDown(Keys.Space))
            //{
            //    Console.WriteLine("Space is Going Down");
            //}
            //if (_keyboardManager.IsKeyDown(Keys.Space))
            //{
            //    Console.WriteLine("Space is Down");
            //}
            //if (_keyboardManager.IsGoingUp(Keys.Space))
            //{
            //    Console.WriteLine("Space is Going Up");
            //}
            //if (_keyboardManager.IsKeyUp(Keys.Space))
            //{
            //    Console.WriteLine("Space is Up");
            //}
            //_player.Update(_keyboardManager);
            //_player.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}