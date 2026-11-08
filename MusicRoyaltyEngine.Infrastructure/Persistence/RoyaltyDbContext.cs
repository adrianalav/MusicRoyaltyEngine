using Microsoft.EntityFrameworkCore;
using MusicRoyaltyEngine.Core.Entities;

namespace MusicRoyaltyEngine.Infrastructure.Persistence;

public class RoyaltyDbContext : DbContext
{
    public RoyaltyDbContext(DbContextOptions<RoyaltyDbContext> options) : base(options)
    {
    }

    public DbSet<RoyaltyPayout> Royalties => Set<RoyaltyPayout>();
    public DbSet<RoyaltyAgreement> RoyaltyAgreements => Set<RoyaltyAgreement>();
}