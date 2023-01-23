public class Monster: GameObject
{
    public Monster()
    {
        color = Color.BLUE;
        rect.x = 128;
    }
    public override void Update()
    {
        rect.y++;
    }
}
