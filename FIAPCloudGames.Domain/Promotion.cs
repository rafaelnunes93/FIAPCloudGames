namespace FIAPCloudGames.Domain.Entities;

public class Promotion
{
    public Guid Id { get; private set; }
    public Guid GameId { get; private set; }
    public decimal DiscountPercentage { get; private set; }
    public DateTime StartDate { get; private set; }
    public DateTime EndDate { get; private set; }

    private Promotion() { }

    public Promotion(Guid gameId, decimal discountPercentage, DateTime startDate, DateTime endDate)
    {
        Id = Guid.NewGuid();
        GameId = gameId;
        DiscountPercentage = discountPercentage;
        StartDate = startDate;
        EndDate = endDate;
    }
}
