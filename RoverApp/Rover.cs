namespace RoverApp
{
    public class Rover
    {
	    public Rover(Location location, char directionFacing)
	    {
		    Location = location;
		    DirectionFacing = directionFacing;
	    }

		public Location Location { get; private set; }
	    public char DirectionFacing { get; private set; }

	    public void Navigate(string commands)
	    {
		    foreach (char command in commands)
		    {
			    if (char.ToUpper(command).Equals('F'))
			    {
				    MoveForward();
			    }
		    }
	    }

	    private void MoveForward()
	    {
		    switch (DirectionFacing)
		    {
				case 'N':
				    Location.YCoordinate++;
					break;

				case 'E':
				    Location.XCoordinate++;
					break;

				case 'S':
				    Location.YCoordinate--;
					break;

				case 'W':
				    Location.XCoordinate--;
					break;
		    }
	    }
    }
}