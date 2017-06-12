# Console Maze Game

This was a little activity I made for myself after learning some of the basics of how to write code in Csharp. My objective was to use some
OOP concepts as well as the applicable syntax which I had learned for things like iterative loops, variable decleration etc. While the game is simple,
and currently doesnt actually even have a win condition, I found it a great way to engage the new information I had just learned. Furthermore,
I was able to be creative in my approach to how the program achieves its goal (allowing the player to move a character through a maze on the console) 
with what metrics to evaluate not just how to envoke that in the code. 

For example colLision detection in the game and painting are implented in an interesting fashion (or at least one i was proud to have thought of). The "maze model" is actually just stored as a string in the code, because each line of the maze string is the same number of characters when its printed as its intended to look on the console (86 characters), the program can store player position as two variables for vertical and lateral offset from a hard coded start position on the console (1,1), and all of the positions surrounding the p on the console can be easily found in the maze string by mapping the 2 console dimensions onto the one dimensional string index using adding 86 for every 1 positions moved in the Y direction.

## Getting Started

To run the project just clone, open in your ide of choice and run.

### Prerequisites

an IDE

## Acknowledgments

* I made this game while attending 1150 academy an indianapolis area code bootcamp
* big thanks to my teachers there who taught me the C# basics and more!
