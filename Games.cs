public class Games
{
    public Genre genre;

    private string name;
    //Gets the name of the game and sotres it in the private feild above.
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string studio;
    //Gets the name of the studi and sotres it in the private feild above.
    //not actual implimented
    public string Studio
    {
        get { return studio; }
        set { studio = value; }
    }

    private int totalplaytime;
    private int playtime;
    //Adds the time played for the game and stores it.
    public void Play(int playtime)
    {
        this.playtime = playtime;
        totalplaytime += this.playtime;
    }
    // Displays the details of the specified game.
    public string gamedetails()
    {
        return name + " " + genre + " Time played = " + totalplaytime + "min";
    }
}
//Diffrent posible game genres.
public enum Genre
{
    Platformer,
    Puzzle,
    Roguelike,
    MMO
}