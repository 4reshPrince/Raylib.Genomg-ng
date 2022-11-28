
public class Link: GameObject
{
    // hp; stamina, position, bild, speed, hitbox, currentItem

    public Link()
    {
        color = Color.GREEN;
    }

    public override void Update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            rect.x++;
        }
    }

}
