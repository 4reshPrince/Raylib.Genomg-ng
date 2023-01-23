public class Area
{
    private Player player;
    private Monster monster;

    public Area()
    {
        player = new Player();
        monster = new Monster();
    }

    public void Update()
    {
        player.Update();
        monster.Update();
    }
    public void Draw()
    {
        player.Draw();
        monster.Draw();
    }
}
