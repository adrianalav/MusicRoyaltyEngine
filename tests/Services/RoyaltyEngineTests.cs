namespace MusicRoyaltyEngine.Core.Tests.Services;

public class RoyaltyEngineTests
{
    [Fact]
    public void CalculatePayout_ReturnsCorrectTotal_WhenGivenValidStreamsAndRate()
    {

        var engine = new RoyaltyEngine();

        long totalStreams = 1000;
        
        decimal royaltyRate = 0.05m;

        decimal expectedPayout = 50.00m;

        decimal actualPayout = engine.CalculatePayout(totalStreams, royaltyRate);

        Assert.Equal(expectedPayout, actualPayout);
    }
}