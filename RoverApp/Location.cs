namespace RoverApp
{
	public class Location
	{
		public Location(int x, int y)
		{
			XCoordinate = x;
			YCoordinate = y;
		}

		public int XCoordinate { get; set; }
		public int YCoordinate { get; set; }
	}
}