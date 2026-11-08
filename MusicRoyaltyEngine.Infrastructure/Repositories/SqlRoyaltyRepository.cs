using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicRoyaltyEngine.Core.Entities;
using MusicRoyaltyEngine.Core.Interfaces;
using MusicRoyaltyEngine.Infrastructure.Persistence;

namespace MusicRoyaltyEngine.Infrastructure.Repositories;

public class SqlRoyaltyRepository : IRoyaltyRepository
{
    private readonly RoyaltyDbContext _context;

    public SqlRoyaltyRepository(RoyaltyDbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public async Task<RoyaltyPayout?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Royalties
            .AsNoTracking()
            .FirstOrDefaultAsync(r => r.Id == id, cancellationToken);
    }

    public async Task<RoyaltyAgreement?> GetByArtistIdAsync(Guid artistId, CancellationToken cancellationToken = default)
    {
        return await _context.RoyaltyAgreements
            .AsNoTracking()
            .FirstOrDefaultAsync(r => r.ArtistId == artistId, cancellationToken);
    }

    public async Task AddAgreementAsync(RoyaltyAgreement agreement, CancellationToken cancellationToken = default)
    {
        await _context.RoyaltyAgreements.AddAsync(agreement, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }

    public async Task SavePayoutAsync(RoyaltyPayout royaltyPayout, CancellationToken cancellationToken = default)
    {
        await _context.Royalties.AddAsync(royaltyPayout, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
    }
}