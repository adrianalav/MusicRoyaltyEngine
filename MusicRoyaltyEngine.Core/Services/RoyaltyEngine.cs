namespace MusicRoyaltyEngine.Core.Services;

public class RoyaltyEngine
{
    
    public decimal CalculatePayout(long totalStreams, decimal royaltyRate)
    {
        decimal payoutAmount = totalStreams * royaltyRate; 
        return payoutAmount;
    }
}