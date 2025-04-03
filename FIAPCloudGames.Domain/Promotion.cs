using FIAPCloudGames.Domain.Entities;

public class Promotion
{
    public Guid Id { get; set; }
    public Decimal Discount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Game Game { get; set; } // Adicionando a propriedade Game

    public Promotion(decimal discount, DateTime startDate, DateTime endDate, Game game)
    {
        Discount = discount;
        StartDate = startDate;
        EndDate = endDate;
        Game = game;
    }
}
