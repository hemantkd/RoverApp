namespace RoverApp
{
    public class Rover
    {
	    public Rover(Location location)
	    {
		    Location = location;
	    }

		public Location Location { get; private set; }

	    public void Navigate(string commands)
	    {
		    foreach (char command in commands)
		    {
			    if (char.ToUpper(command).Equals('F'))
			    {
				    MoveForward();
			    }

			    if (char.ToUpper(command).Equals('B'))
			    {
				    MoveBackward();
			    }
		    }
	    }

	    private void MoveForward()
	    {
		    switch (Location.DirectionFacing)
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

	    private void MoveBackward()
	    {
		    switch (Location.DirectionFacing)
		    {
				case 'N':
				    Location.YCoordinate--;
					break;

				case 'E':
				    Location.XCoordinate--;
					break;

				case 'S':
				    Location.YCoordinate++;
					break;

				case 'W':
				    Location.XCoordinate++;
					break;
		    }
	    }
    }
}