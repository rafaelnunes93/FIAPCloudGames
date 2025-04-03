namespace FIAPCloudGames.Application.DTOs;

public class PromotionDTO
{
    public string GameName { get; set; } = string.Empty;
    public decimal DiscountPercentage { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime ExpiryDate { get; set; }
}
