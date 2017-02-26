using NUnit.Framework;

namespace RoverApp.Tests
{
	[TestFixture]
    public class RoverAppShould
    {
		[Test]
		public void MoveForward_If_Command_Is_F()
		{
			// Arrange
			var rover = new Rover
			{
				XCoordinate = 0,
				YCoordinate = 0,
				DirectionFacing = 'N'
			};

			// Act
			rover.MoveForward();

			// Assert
			Assert.AreEqual(1, rover.YCoordinate);
		}
    }
}