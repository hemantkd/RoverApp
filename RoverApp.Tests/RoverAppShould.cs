using NUnit.Framework;

namespace RoverApp.Tests
{
	[TestFixture]
    public class RoverAppShould
    {
		[Test]
		public void Add_YCoordinate_By_One_If_Command_Is_F_And_DirectionFacing_Is_N()
		{
			// Arrange
			var location = new Location(0,0);
			var rover = new Rover(location, directionFacing: 'N');

			// Act
			rover.Navigate("F");

			// Assert
			Assert.AreEqual(1, rover.Location.YCoordinate);
		}

		[Test]
		public void Add_XCoordinate_By_One_If_Command_Is_F_And_DirectionFacing_Is_E()
		{
			// Arrange
			var location = new Location(0,1);
			var rover = new Rover(location, directionFacing: 'E');

			// Act
			rover.Navigate("F");

			// Assert
			Assert.AreEqual(1, rover.Location.XCoordinate);
		}

		[Test]
		public void Subtract_YCoordinate_By_One_If_Command_Is_F_And_DirectionFacing_Is_S()
		{
			// Arrange
			var location = new Location(1,1);
			var rover = new Rover(location, directionFacing: 'S');

			// Act
			rover.Navigate("F");

			// Assert
			Assert.AreEqual(0, rover.Location.YCoordinate);
		}

		[Test]
		public void Subtract_XCoordinate_By_One_If_Command_Is_F_And_DirectionFacing_Is_W()
		{
			// Arrange
			var location = new Location(1,0);
			var rover = new Rover(location, directionFacing: 'W');

			// Act
			rover.Navigate("F");

			// Assert
			Assert.AreEqual(0, rover.Location.XCoordinate);
		}
    }
}