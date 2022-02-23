## CS 8395: Project 2 - AR Book Cover

# Project Details:

In this project, I use Unity Version 2020.3.27f1 (Personal) and the Unity Vuforia SDK Version 10.5.5 to create an AR Book Cover for my Database Management Systems textbook. This project was implemented using a 2015 Macbook Pro and the laptop's web camera.

To implement the project correctly, I used the Vuforia developer portal to upload front and back image covers of the Murach's MySQL 3rd Edition textbook. After that, I created two instances of Vuforia ImageTarget in the Unity environment and edited their properties to reflect the database images I uploaded in the Vuforia portal. Next, I added a virtual scene of a pen, pencil, eraser, and notebook around the text on the front cover. Finally, I created a Vuforia VirtualButton in the back cover ImageTarget instance that toggles between a book description and a review of the book itself.

# Project Repository:

`FrontCover.jpg` - image of the front cover of Murach's MySQL 3rd Edition textbook used for Vuforia image target

`BackCover.jpg` - image of the back cover of Murach's MySQL 3rd Edition textbook used for Vuforia image target

`VBTN.cs` - C# script that enabled the AR button toggle logic on the MySQL textbook

# Code Explanation:

`VBTN.cs` uses the `OnButtonReleased()` and `OnButtonPressed()` methods to visualize or devisualize text on the back cover image target.

# How to Run the Demo:

The Unity Project folder is located on my Vanderbilt Box account (linked in my Brightspace submission). Simply download the project directory to your local machine. In Unity, click open project and select my AR Book Cover project. Finally, run the project and test (if you have the MySQL textbook).

# Limitations:

There are no notable limitation, but adjusting the VirtualButton instance sensitivity can lead to difficulty toggling the book description and review of the book which are attached to the back cover image target. In my project, I used Medium sensitivity so toggling was easily detected by a hand touch to the bottom-right of the back cover of the textbook.

Also, the 100MB limit on GitHub required me to upload the Unity project to Box instead.
