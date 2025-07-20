public class Games
{
    public Genre genre;
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string studio;
    public string Studio
    {
        get { return studio; }
        set { studio = value; }
    }

    private int totalplaytime;
    private int playtime;
    public void Play(int playtime)
    {
        this.playtime = playtime;
        totalplaytime += this.playtime;
    }
    public string gamedetails()
    {
        return name + " " + genre + " Time played = " + totalplaytime + "min";
    }
}




public enum Genre
{
    Platformer,
    Puzzle,
    Roguelike,
    MMO
}