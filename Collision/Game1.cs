using System.Collections.Generic;
using System.Net.NetworkInformation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Collision;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    private List<Box> boxes = new List<Box>();
    Texture2D pixel;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
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
        pixel = Content.Load<Texture2D>("pixel");
        BoxLeft box1 = new BoxLeft(pixel, new Vector2(100,200),2.0f);
        BoxRight box2 = new BoxRight(pixel, new Vector2(100,250));
        BoxLeft box3 = new BoxLeft(pixel, new Vector2(100,300), 0.5f);

        boxes.Add(box1);
        boxes.Add(box2);
        boxes.Add(box3);
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();
        foreach(Box box in boxes){
            box.Update();
        }
        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);
        _spriteBatch.Begin();
        foreach(Box box in boxes){
            box.Draw(_spriteBatch);
        }
        _spriteBatch.End();
        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
