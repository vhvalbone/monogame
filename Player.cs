using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogame
{
    public class Player
    {
        Vector2 posistion = new Vector2(400,240);
        Texture2D texture;
    
        public Player(Texture2D texture){
            this.texture=texture;
        }
    public void Update()
    {
        KeyboardState kState = Keyboard.GetState();
        if(kState.IsKeyDown(Keys.W)){
            posistion.Y-=1;
        }
        if(kState.IsKeyDown(Keys.S)){
            posistion.Y+=1;
        }
        if(kState.IsKeyDown(Keys.A)){
            posistion.X-=1;
        }
        if(kState.IsKeyDown(Keys.D)){
            posistion.X+=1;

        }
    }
    public void Draw(SpriteBatch spriteBatch)
    {
            Rectangle playerRectangle=new Rectangle((int)posistion.X,(int)posistion.Y, 100, 100);
        spriteBatch.Draw(texture, playerRectangle, Color.AliceBlue);
    }
}
}