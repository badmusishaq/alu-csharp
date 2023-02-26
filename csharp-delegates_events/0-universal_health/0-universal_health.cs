/// <summary>
/// Represents a player with a name, maximum health, and current health.
/// </summary>
public class Player
{
    // Player's name
    private string name {get; set;}
    // Player's max hp.
    private float maxHp {get; set;}
    // Player's hp
    private float hp {get; set;}

    /// <summary>
    /// Creates a new instance of the Player class with the specified name and maximum health.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHp">The maximum health of the player.</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
    }
    /// <summary>
    /// Prints the name and current health of the player.
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}