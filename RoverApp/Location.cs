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

		public int XCoordinate { get; private set; }
		public int YCoordinate { get; private set; }
	    public char DirectionFacing { get; private set; }

		public void MoveForward()
		{
			switch (DirectionFacing)
		    {
				case 'N':
				    YCoordinate++;
					break;

				case 'E':
				    XCoordinate++;
					break;

				case 'S':
				    YCoordinate--;
					break;

				case 'W':
				    XCoordinate--;
					break;
		    }
		}

		public void MoveBackward()
		{
			switch (DirectionFacing)
		    {
				case 'N':
				    YCoordinate--;
					break;

				case 'E':
				    XCoordinate--;
					break;

				case 'S':
				    YCoordinate++;
					break;

				case 'W':
				    XCoordinate++;
					break;
		    }
		}

		public void RotateRight()
		{
			switch (DirectionFacing)
		    {
				case 'N':
				    DirectionFacing = 'E';
					break;

				case 'E':
				    DirectionFacing = 'S';
					break;

				case 'S':
				    DirectionFacing = 'W';
					break;

				case 'W':
				    DirectionFacing = 'N';
					break;
		    }
		}

		public void RotateLeft()
		{
			switch (DirectionFacing)
		    {
				case 'N':
				    DirectionFacing = 'W';
					break;

				case 'W':
				    DirectionFacing = 'S';
					break;

				case 'S':
				    DirectionFacing = 'E';
					break;

				case 'E':
				    DirectionFacing = 'N';
					break;
		    }
		}
	}
}