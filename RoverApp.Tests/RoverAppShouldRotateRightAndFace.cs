using NUnit.Framework;

namespace RoverApp.Tests
{
	[TestFixture]
    public class RoverAppShouldRotateRightAndFace
    {
		[Test]
		public void East_If_Command_Is_R_And_DirectionFacing_Is_North()
		{
			// Arrange
			var location = new Location(1,1,'N');
			var rover = new Rover(location);
			var expectedLocation = new Location(1,1,'E');

			// Act
			rover.Navigate("R");

			// Assert
			Assert.AreEqual(expectedLocation.XCoordinate, rover.Location.XCoordinate);
			Assert.AreEqual(expectedLocation.YCoordinate, rover.Location.YCoordinate);
			Assert.AreEqual(expectedLocation.DirectionFacing, rover.Location.DirectionFacing);
		}

		[Test]
		public void South_If_Command_Is_R_And_DirectionFacing_Is_East()
		{
			// Arrange
			var location = new Location(1,1,'E');
			var rover = new Rover(location);
			var expectedLocation = new Location(1,1,'S');

			// Act
			rover.Navigate("R");

			// Assert
			Assert.AreEqual(expectedLocation.XCoordinate, rover.Location.XCoordinate);
			Assert.AreEqual(expectedLocation.YCoordinate, rover.Location.YCoordinate);
			Assert.AreEqual(expectedLocation.DirectionFacing, rover.Location.DirectionFacing);
		}

		[Test]
		public void West_If_Command_Is_R_And_DirectionFacing_Is_South()
		{
			// Arrange
			var location = new Location(1,1,'S');
			var rover = new Rover(location);
			var expectedLocation = new Location(1,1,'W');

			// Act
			rover.Navigate("R");

			// Assert
			Assert.AreEqual(expectedLocation.XCoordinate, rover.Location.XCoordinate);
			Assert.AreEqual(expectedLocation.YCoordinate, rover.Location.YCoordinate);
			Assert.AreEqual(expectedLocation.DirectionFacing, rover.Location.DirectionFacing);
		}

		[Test]
		public void North_If_Command_Is_R_And_DirectionFacing_Is_West()
		{
			// Arrange
			var location = new Location(1,1,'W');
			var rover = new Rover(location);
			var expectedLocation = new Location(1,1,'N');

			// Act
			rover.Navigate("R");

			// Assert
			Assert.AreEqual(expectedLocation.XCoordinate, rover.Location.XCoordinate);
			Assert.AreEqual(expectedLocation.YCoordinate, rover.Location.YCoordinate);
			Assert.AreEqual(expectedLocation.DirectionFacing, rover.Location.DirectionFacing);
		}
    }
}