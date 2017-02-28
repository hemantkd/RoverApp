using NUnit.Framework;

namespace RoverApp.Tests
{
	[TestFixture]
    public class RoverAppShouldMoveForwardByOneGrid
    {
		[Test]
		public void If_Command_Is_F_And_DirectionFacing_Is_N()
		{
			// Arrange
			var location = new Location(0,0,'N');
			var rover = new Rover(location);

			// Act
			rover.Navigate("F");

			// Assert
			Assert.AreEqual(1, rover.Location.YCoordinate);
			Assert.AreEqual(location.DirectionFacing, rover.Location.DirectionFacing);
		}

		[Test]
		public void If_Command_Is_F_And_DirectionFacing_Is_E()
		{
			// Arrange
			var location = new Location(0,1,'E');
			var rover = new Rover(location);

			// Act
			rover.Navigate("F");

			// Assert
			Assert.AreEqual(1, rover.Location.XCoordinate);
			Assert.AreEqual(location.DirectionFacing, rover.Location.DirectionFacing);
		}

		[Test]
		public void If_Command_Is_F_And_DirectionFacing_Is_S()
		{
			// Arrange
			var location = new Location(1,1,'S');
			var rover = new Rover(location);

			// Act
			rover.Navigate("F");

			// Assert
			Assert.AreEqual(0, rover.Location.YCoordinate);
			Assert.AreEqual(location.DirectionFacing, rover.Location.DirectionFacing);
		}

		[Test]
		public void If_Command_Is_F_And_DirectionFacing_Is_W()
		{
			// Arrange
			var location = new Location(1,0,'W');
			var rover = new Rover(location);

			// Act
			rover.Navigate("F");

			// Assert
			Assert.AreEqual(0, rover.Location.XCoordinate);
			Assert.AreEqual(location.DirectionFacing, rover.Location.DirectionFacing);
		}
    }
}