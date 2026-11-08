namespace MusicRoyaltyEngine.Core.Interfaces;

using MusicRoyaltyEngine.Core.Entities;

public interface IRoyaltyRepository
{
    
Task <RoyaltyAgreement?> GetByArtistIdAsync(Guid artistId, CancellationToken ct= default);

Task AddAgreementAsync(RoyaltyAgreement agreement, CancellationToken ct = default);

Task SavePayoutAsync(RoyaltyPayout royaltyPayout, CancellationToken ct = default);

}