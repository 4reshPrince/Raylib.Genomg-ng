
public class Player: GameObject
{
    // hp; stamina, position, bild, speed, hitbox, currentItem


   

    public Player()
    {
        color = Color.GREEN;
    }

    public override void Update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            rect.x++;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            rect.x--;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
        {
            rect.y--;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            rect.y++;
        }
    }


}
