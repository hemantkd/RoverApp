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
			var rover = new Rover
			{
				XCoordinate = 0,
				YCoordinate = 0,
				DirectionFacing = 'N'
			};

			// Act
			rover.ExecuteCommand("F");

			// Assert
			Assert.AreEqual(1, rover.YCoordinate);
		}

		[Test]
		public void Add_XCoordinate_By_One_If_Command_Is_F_And_DirectionFacing_Is_E()
		{
			// Arrange
			var rover = new Rover
			{
				XCoordinate = 0,
				YCoordinate = 0,
				DirectionFacing = 'E'
			};

			// Act
			rover.ExecuteCommand("F");

			// Assert
			Assert.AreEqual(1, rover.XCoordinate);
		}
    }
}