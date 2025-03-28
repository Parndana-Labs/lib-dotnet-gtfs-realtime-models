using ParndanaLabs.Lib.GtfsRealtimeModels.TransitRealtime;

namespace ParndanaLabs.Lib.GtfsRealtimeModelsTests;

public class GtfsRealtimeTests
{
    [Fact]
    public void Given_TransitRealtimeIsImported_Should_BeAbleToReferToProtobufModelBasics()
    {
        // Arrange
        var feedMessage = new FeedMessage();

        // Act
        var record = Record.Exception(() => feedMessage.Entity.Select(e => e));
        
        // Assert
        Assert.Null(record);
    }
}