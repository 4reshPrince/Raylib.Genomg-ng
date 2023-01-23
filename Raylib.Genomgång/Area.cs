public class Area
{
    private Jordan jordan;
    private Monster monster;

    public Area()
    {
        jordan = new Jordan();
        monster = new Monster();
    }

    public void Update()
    {
        jordan.Update();
        monster.Update();
    }
    public void Draw()
    {
        jordan.Draw();
        monster.Draw();
    }
}
