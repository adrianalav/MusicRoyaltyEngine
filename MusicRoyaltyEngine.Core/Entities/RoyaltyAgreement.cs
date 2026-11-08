namespace MusicRoyaltyEngine.Core.Entities;

public class RoyaltyAgreement {

    /* private set to protect the internal state of the entity. 
    This ensures that values cannot be arbitrarily modified from outside
    the class (e.g., in an API controller), preserving domain encapsulation. */


    public Guid Id {get; private set;}
    public Guid ArtistId {get; private set;}

    /// <summary>
    /// Gets the agreed finncial royaltu rate (e.g. 0,15m representing 15%).
    /// </summary>
    public decimal RoyaltyRate {get; private set;}
    /// <summary>
    /// Gets the precise UTC timestamp indicating when the contract was estabilished.
    /// </summary>
    public DateTime CreatedAt{get; private set;}

    private RoyaltyAgreement() {}

    public RoyaltyAgreement(Guid artistId, decimal royaltyRate)
    {
        if(artistId == Guid.Empty)
        {
            throw new ArgumentException("The artist identifier cannot be empty", nameof(ArtistId));
        }
        if(royaltyRate < 0)
        {
            throw new ArgumentException("The royalty rate cannot be less than zero", nameof(RoyaltyRate));
        }

        Id = Guid.NewGuid();
        ArtistId = artistId;
        RoyaltyRate = royaltyRate;
        CreatedAt = DateTime.UtcNow;


    }

}