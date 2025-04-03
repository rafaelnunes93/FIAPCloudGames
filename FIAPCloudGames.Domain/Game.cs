namespace FIAPCloudGames.Domain.Entities;

public class Game
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public string Category { get; private set; }
    public string Developer { get; private set; }

    private Game() { }

    public Game(string name, string description, decimal price, string category, string developer)
    {
        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        Price = price;
        Category = category;
        Developer = developer;
    }
}
