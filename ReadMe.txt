// Author: Matthew Alexander Prinsloo
// Student Number: ST10081850
// Subject code: PROG7312
//----------------------------------------------------------------------------//
//Introduction

The version of the DDS_Trainer app that you have at your disposal is still under
development. The replacing books activity and the identifying areas activity
are the only activities functioning as per the requirements of the 
PROG7312 POE Part 2 rubric. The gamification feature implemented is an 
arcade-style leaderboard that stores its values via text files. 

//----------------------------------------------------------------------------//
//Installation

If you have not already done so, please unzip the folder that this Readme is
stored in.

On doing so please open the unzipped folder so that you are back in the
directory that holds this readme.

Optionally you can install a font style that enhances the experience of the app.
Again this is completely optional but if you wish to, follow these instructions:
1 - In the file explorer click the path heading and paste this in:
			\DDS_Trainer\bin\Debug
if done correctly you should be in the debug folder.

2 - locate and double click the file that says: 
			retro_computer_personal_use.ttf
3 - Click the Install button located at the top left.

If it is not in that directory it will be attached as 
retro_computer_personal_use.ttf in the main directory of this folder

//----------------------------------------------------------------------------//
//Running
Follow these steps to run the application:

1 - In the file explorer click the path heading and paste this in:
			\DDS_Trainer\bin\Debug
if done correctly you should be in the debug folder.

2 - locate and double click the file that says: 
			DDS_Trainer.exe
3 - The application should launch and you will be greeted with the Main Menu.

If the exe is not available please run the .sln in the main directory of this
folder

//----------------------------------------------------------------------------//
//Main Menu

The main menu will open in full screen, the art style is akin to a retro
computer desktop. The app was developed on a 1920x1080p monitor.

Three app icons will be on the left side
1 - Replacing-Books.exe
2 - Identifying-Areas.exe
3 - Finding-Call-Numbers.exe

Clicking on one of these three icons will open the corresponding activity. 
See the titles relating to these activities for more information.

The leaderboard is shown as a black rectangle window in the bottom right of the 
desktop. White arrows (left  and right arrows) appear within the window that
users can click to navigate to between other game leaderboards. On startup the
replacing books leaderboard is shown. The leaderboard shows the top 10 
players of the application game being displayed.

The red power button located in the bottom left among the task bar is used to
exit the app. Please see "Closing the app" to find out more.
//----------------------------------------------------------------------------//
//Replacing Books Game

Clicking the icon will open a window onto the "desktop".
Clicking the stop watch will begin the game and start a 2 minute countdown.

You will be presented with randomly generating books with call numbers that 
will be required to be placed in ascending order from left to right. By placing
the last book, the app will check if the books are in the correct order and
allocate the appropriate points. Points can only be accumilated over 2 minutes.

User must drag the books into the correct order, books can be dragged out of 
position if the need to reorder arises.

At the end of the 2 minutes the user will have the stopwatch displayed again, 
users are free to play as many times as they would like.

Clicking the red x at the top right of this "window" will ask the user if they
would like to close this window:

Clicking the blue back button will return them to the main menu desktop.
Clicking the grey no button will cancel the return procedure.

When a high score is achieved a window will appear to congradulate the user and
promts them to enter 3 initials to mark their spot on the leaderboard. Clicking 
the save button will save the initials and close the High score form.The 
leaderboard will then switch its view to the Replacing Books leaderboard.

The stopwatch will then be displayed again.
//----------------------------------------------------------------------------//
//Identifying Areas

Clicking the icon will open a window onto the "desktop".
Clicking the stop watch will begin the game and start a 2 minute countdown.

Once the timer has begun and the game has started, you will be presented with 4 
random questions on the left. On the right side of the window you will see 7
options to select from; 4 correct and 3 incorrect. The options will be the
counterpart to the questions asked for instance:
Call number questions = Description options;
Description questions = Call number options.
The answers will be placed randomly on the right side. The questions will
rotate between asking call numbers and descriptions as questions
(questions can either only be call numbers or only descriptions).

The 4 questions will be highlighted in a color, users must click on the question
to select the highlighter color. Users can know what color they have selected by
looking at the markers lid on the window (marker image placed on book). Users
must then match the columns, the question column with the answer column.

Matching columns is done by clicking on the suspected answer label in the answer
column once a question color has been selected (see marker image).

Once all 4 question colors have been assigned to a answer within the answer 
column the application will check if it is correct.  If incorrect no points will
be allocated until the correct answers are assigned. If correct the user will 
have 100 points added to their score. Furthermore, the columns will be 
regenerated with new questions and answers to match. The timer will continue 
to tick down.

At the end of the 2 minutes the user will have the stopwatch displayed again, 
users are free to play as many times as they would like.

Clicking the red x at the top right of this "window" will ask the user if they
would like to close this window:

Clicking the blue back button will return them to the main menu desktop.
Clicking the grey no button will cancel the return procedure.

When a high score is achieved a window will appear to congradulate the user and
promts them to enter 3 initials to mark their spot on the leaderboard. Clicking 
the save button will save the initials and close the High score form. The 
leaderboard will then switch its view to the Identifying Areas leaderboard.

The stopwatch will then be displayed again.
//----------------------------------------------------------------------------//
//Closing the app
When clicking The red power button located in the bottom left of the main menu/
desktop:
A window will be displayed on the games "desktop" asking users if they would
like to exit the application.

Clicking the red exit button will close the app.
Clicking the grey no button will cancel the exit procedure.

//============================================================================//