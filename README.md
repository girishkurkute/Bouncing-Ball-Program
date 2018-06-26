# Bouncing-Ball-Program
Developed Bouncing Ball Program using Windows Forms and Visual Basic


The Bouncing Ball Program
1.	Creates a graphics window 
2.	Has 1 or more buttons to:
a.	Start the operations below
b.	Stop the operations below
c.	Set the speed of the ball 
d.	Set the initial angle of the ball from its rest position
3.	Draws a blue ball (approximately 1/4 inch in diameter) that moves inside the graphics window at a pre-selected velocity and bounces off its borders. The ball moves when the “start” button is clicked.
4.	Allows user to change speed of ball while it is moving.
5.	Allows user to change direction (using an angle (in degrees) based on the standard x-y coordinate system – 0 degrees is to the right along the x-axis, 180 degrees is to the left on the x-axis)
6.	Allows user to stop the ball (which stays where it is) and change the initial angle (and speed if desired) before restarting it.
7.	Responds to form’s Resize event to reset ball’s position to the corresponding position in the new window (if the window is enlarged on the right, the ball moves to a position that is where it was relative to the right border, etc.)
8.	Responds to the Timer Tick event to redraw the ball in its new position
9.	After each timer tick and after window is resized
a.	 Checks for collisions with sides of window and adjusts ball’s path
10.	Class level variables (accessible to all class methods):
a.	xC, yC: current coordinates of ball’s center
b.	xDelta, yDelta: x,y components of velocity
c.	iXSize, iYSize: dimensions of window’s client area
11.	Contains a function named DrawBall( ) (Here is where the  hard work gets done)
a.	Uses the Form’s CreateGraphics() method to get a Graphics object
b.	Draws blue ball in new position.
c.	Allows for change of angle and speed

