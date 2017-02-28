using NUnit.Framework;

namespace RoverApp.Tests
{
	[TestFixture]
    public class RoverAppShouldMoveBackwardByOneGrid
    {
		[Test]
		public void If_Command_Is_B_And_DirectionFacing_Is_N()
		{
			// Arrange
			var location = new Location(1,1,'N');
			var rover = new Rover(location);
			var expectedLocation = new Location(1,0,'N');

			// Act
			rover.Navigate("B");

			// Assert
			Assert.AreEqual(expectedLocation.XCoordinate, rover.Location.XCoordinate);
			Assert.AreEqual(expectedLocation.YCoordinate, rover.Location.YCoordinate);
			Assert.AreEqual(expectedLocation.DirectionFacing, rover.Location.DirectionFacing);
		}

		[Test]
		public void If_Command_Is_B_And_DirectionFacing_Is_E()
		{
			// Arrange
			var location = new Location(1,0,'E');
			var rover = new Rover(location);
			var expectedLocation = new Location(0,0,'E');

			// Act
			rover.Navigate("B");

			// Assert
			Assert.AreEqual(expectedLocation.XCoordinate, rover.Location.XCoordinate);
			Assert.AreEqual(expectedLocation.YCoordinate, rover.Location.YCoordinate);
			Assert.AreEqual(expectedLocation.DirectionFacing, rover.Location.DirectionFacing);
		}

		[Test]
		public void If_Command_Is_B_And_DirectionFacing_Is_S()
		{
			// Arrange
			var location = new Location(1,0,'S');
			var rover = new Rover(location);
			var expectedLocation = new Location(1,1,'S');

			// Act
			rover.Navigate("B");

			// Assert
			Assert.AreEqual(expectedLocation.XCoordinate, rover.Location.XCoordinate);
			Assert.AreEqual(expectedLocation.YCoordinate, rover.Location.YCoordinate);
			Assert.AreEqual(expectedLocation.DirectionFacing, rover.Location.DirectionFacing);
		}

		[Test]
		public void If_Command_Is_B_And_DirectionFacing_Is_W()
		{
			// Arrange
			var location = new Location(0,0,'W');
			var rover = new Rover(location);
			var expectedLocation = new Location(1,0,'W');

			// Act
			rover.Navigate("B");

			// Assert
			Assert.AreEqual(expectedLocation.XCoordinate, rover.Location.XCoordinate);
			Assert.AreEqual(expectedLocation.YCoordinate, rover.Location.YCoordinate);
			Assert.AreEqual(expectedLocation.DirectionFacing, rover.Location.DirectionFacing);
		}
    }
}