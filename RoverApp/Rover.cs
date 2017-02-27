namespace RoverApp
{
    public class Rover
    {
	    public int XCoordinate { get; set; }
	    public int YCoordinate { get; set; }
	    public char DirectionFacing { get; set; }

	    public void ExecuteCommand(string commands)
	    {
		    foreach (char command in commands)
		    {
			    if (command == 'F')
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
				    YCoordinate++;
					break;

				case 'E':
				    XCoordinate++;
					break;
		    }
	    }
    }
}