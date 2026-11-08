using System;
using Xunit;
using MusicRoyaltyEngine.Core.Entities;

namespace MusicRoyaltyEngine.Core.Tests.Entities;

public class RoyaltyAgreementTests
{
    [Fact]
    public void Constructor_WithValidParameters_ShouldCreateRoyaltyAgreement()
    {
        // Arrange
        var validArtistId = Guid.NewGuid();
        var validRoyaltyRate = 0.15m;

        // Act
        var agreement = new RoyaltyAgreement(validArtistId, validRoyaltyRate);

        // Assert
        Assert.NotEqual(Guid.Empty, agreement.Id);
        Assert.Equal(validArtistId, agreement.ArtistId);
        Assert.Equal(validRoyaltyRate, agreement.RoyaltyRate);
        Assert.True(agreement.CreatedAt <= DateTime.UtcNow);
    }

    [Fact]
    public void Constructor_WithNegativeRoyaltyRate_ShouldThrowArgumentException()
    {
        // Arrange
        var validArtistId = Guid.NewGuid();
        var invalidRoyaltyRate = -0.05m;

        // Act & Assert
        var ex = Assert.Throws<ArgumentException>(() =>
            new RoyaltyAgreement(validArtistId, invalidRoyaltyRate)
        );

        Assert.NotNull(ex);
    }

    [Fact]
    public void Constructor_WithEmptyArtistId_ShouldThrowArgumentException()
    {
        // Arrange
        var emptyArtistId = Guid.Empty;
        var validRoyaltyRate = 0.20m;

        // Act & Assert
        var ex = Assert.Throws<ArgumentException>(() =>
            new RoyaltyAgreement(emptyArtistId, validRoyaltyRate)
        );

        Assert.NotNull(ex);
    }
}