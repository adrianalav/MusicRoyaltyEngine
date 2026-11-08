namespace MusicRoyaltyEngine.Core.Tests.Entities;

using System;
using MusicRoyaltyEngine.Core.Entities;
using Xunit;

public class RoyaltyPayoutTests
{
    [Fact]
    public void Constructor_WithValidArguments_ShouldCreatePayoutSuccessfully()
    {
        // Arrange
        var artistId = Guid.NewGuid();
        decimal validAmount = 1500.75m;

        // Act
        var payout = new RoyaltyPayout(artistId, validAmount);

        // Assert
        Assert.NotEqual(Guid.Empty, payout.Id);
        Assert.Equal(artistId, payout.ArtistId);
        Assert.Equal(validAmount, payout.Amount);
        Assert.True(payout.CalculatedAt <= DateTime.UtcNow);
    }

    [Fact]
    public void Constructor_WithEmptyArtistId_ShouldThrowArgumentException()
    {
        // Arrange
        var emptyArtistId = Guid.Empty;
        decimal validAmount = 500.00m;

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => new RoyaltyPayout(emptyArtistId, validAmount));
        
        Assert.Contains("ArtistId", exception.Message);
    }

    [Fact]
    public void Constructor_WithNegativeAmount_ShouldThrowArgumentOutOfRangeException()
    {
        // Arrange
        var artistId = Guid.NewGuid();
        decimal negativeAmount = -50.00m;

        // Act & Assert
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() => new RoyaltyPayout(artistId, negativeAmount));
        
        Assert.Contains("royalty amount", exception.Message);
    }
}