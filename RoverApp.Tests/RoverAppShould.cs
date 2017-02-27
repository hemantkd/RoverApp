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
			var directionFacing = 'N';
			var rover = new Rover(location, directionFacing);

			// Act
			rover.Navigate("F");

			// Assert
			Assert.AreEqual(1, rover.Location.YCoordinate);
			Assert.AreEqual(directionFacing, rover.DirectionFacing);
		}

		[Test]
		public void Add_XCoordinate_By_One_If_Command_Is_F_And_DirectionFacing_Is_E()
		{
			// Arrange
			var location = new Location(0,1);
			var directionFacing = 'E';
			var rover = new Rover(location, directionFacing);

			// Act
			rover.Navigate("F");

			// Assert
			Assert.AreEqual(1, rover.Location.XCoordinate);
			Assert.AreEqual(directionFacing, rover.DirectionFacing);
		}

		[Test]
		public void Subtract_YCoordinate_By_One_If_Command_Is_F_And_DirectionFacing_Is_S()
		{
			// Arrange
			var location = new Location(1,1);
			var directionFacing = 'S';
			var rover = new Rover(location, directionFacing);

			// Act
			rover.Navigate("F");

			// Assert
			Assert.AreEqual(0, rover.Location.YCoordinate);
			Assert.AreEqual(directionFacing, rover.DirectionFacing);
		}

		[Test]
		public void Subtract_XCoordinate_By_One_If_Command_Is_F_And_DirectionFacing_Is_W()
		{
			// Arrange
			var location = new Location(1,0);
			var directionFacing = 'W';
			var rover = new Rover(location, directionFacing);

			// Act
			rover.Navigate("F");

			// Assert
			Assert.AreEqual(0, rover.Location.XCoordinate);
			Assert.AreEqual(directionFacing, rover.DirectionFacing);
		}
    }
}