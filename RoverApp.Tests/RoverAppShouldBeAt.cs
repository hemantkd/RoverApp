using NUnit.Framework;

namespace RoverApp.Tests
{
	[TestFixture]
    public class RoverAppShouldBeAt
    {
		[Test]
		[TestCase(0,0,'N', 2,2,'E', "FFRFF")]
		[TestCase(0,0,'N', 1,2,'W', "FRFLFL")]
		public void ExpectedLocation(int x, int y, char directionFacing, int expectedX, int expectedY, char expectedDirectionFacing, string commands)
		{
			// Arrange
			var location = new Location(x,y,directionFacing);
			var rover = new Rover(location);
			var expectedLocation = new Location(expectedX, expectedY, expectedDirectionFacing);

			// Act
			rover.Navigate(commands);

			// Assert
			Assert.AreEqual(expectedLocation.XCoordinate, rover.Location.XCoordinate);
			Assert.AreEqual(expectedLocation.YCoordinate, rover.Location.YCoordinate);
			Assert.AreEqual(expectedLocation.DirectionFacing, rover.Location.DirectionFacing);
		}
    }
}