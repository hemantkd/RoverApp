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
		    foreach (char command in commands.ToUpperInvariant())
		    {
			    if (command.Equals('F'))
			    {
				    MoveForward();
			    }

			    if (command.Equals('B'))
			    {
				    MoveBackward();
			    }

			    if (command.Equals('R'))
			    {
				    TurnRight();
			    }

			    if (command.Equals('L'))
			    {
				    TurnLeft();
			    }
		    }
	    }

	    private void MoveForward()
	    {
		    Location.MoveForward();
	    }

	    private void MoveBackward()
	    {
		    Location.MoveBackward();
	    }

	    private void TurnRight()
	    {
		    Location.RotateRight();
	    }

	    private void TurnLeft()
	    {
		    Location.RotateLeft();
	    }
   }
}