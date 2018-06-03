# Code Fellow 401 .NET Calculator Prework

This is a Calculator designed using the .NET core SDK and is a Console Application. It can perform simple math equations such as addition, subtraction, multiplication and division. It is also capable of performing powers and finding remainders.

Away from traditional calculators, this application has a more "text adventure" interaction. You can choose your operation after inputting your two variables.

### How to Run
* Have the latest version of Visual Studio and .NET SDK
* After downloading, open up the .sln and proceed to run

### Current Known Issues
* Currently, the user-input is not designed to handled empty string inputs as it automatically converts the input to a operable variable (i.e. "3" becomes 3). 
* Similarly, the application will not understand if the user was to input the text equivalent "three" and will also break.

### Overall Thoughts
the project itself probably took a combined 1-2 hours with most of the time spent on figuring out a twist to design the calculator in a non-calculator way.

The biggest struggle was utilizing Console.Write and .WriteLine to create a semi-formatted experience within the console window. There are unique interactions when finding the difference between a .Write and .WriteLine.
 I've managed to learn more about the interactions of the console window and for logging future bugs and interactions I feel will be smoother for future debugging and monitoring.

Biggest resource used for this project was the Microsoft Documentation and as always the community of Stackoverflow.