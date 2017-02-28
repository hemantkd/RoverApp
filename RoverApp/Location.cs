namespace RoverApp
{
	public class Location
	{
		public Location(int x, int y, char directionFacing)
		{
			XCoordinate = x;
			YCoordinate = y;
			DirectionFacing = directionFacing;
		}

		public int XCoordinate { get; set; }
		public int YCoordinate { get; set; }
	    public char DirectionFacing { get; private set; }
	}
}