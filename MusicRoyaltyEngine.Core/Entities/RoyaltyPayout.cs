namespace MusicRoyaltyEngine.Core.Entities;

public class RoyaltyPayout
{
    public Guid Id {get; private set;}
    public Guid ArtistId {get; private set;}
    public decimal Amount {get; private set;}
    public DateTime CalculatedAt {get; private set;}

    private RoyaltyPayout(){}

    public RoyaltyPayout(Guid artistId, decimal amount)
    {
        if(artistId == Guid.Empty)
        throw new ArgumentException("ArtistId cannot be empty", nameof(artistId));

        if(amount <0)
        throw new ArgumentOutOfRangeException(nameof(amount), "The royalty amount cannot be negative");

        Id = Guid.NewGuid();
        ArtistId = artistId;
        Amount = amount;
        CalculatedAt = DateTime.UtcNow;
    }
}