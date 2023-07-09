# name-sorter

## Project Description:
This program takes the path of a file containing a list of names and then sorts them alphabectically by the last names first, then any given names. It then prints this sorted list to the console and saves the sorted names to a file called 'sorted-names-list.txt' into the current working directory .

The names present in the unsorted list provided are be converted to Name objects and stored as a list of Name objects when loaded. The algorithm to sort these names takes this list of Name objects, orders the contents by the LastName proerty, then by the GivenNames property, and then convert the list to a list of strings. This list of string is then printed to the console and saved to the 'sorted-names-list.txt' file.

If no file path is provided as an argument, a message will be printed to the console stating the requirement for a path argument and end the program. If the file provided is unable to be read or is in an invalid format an InvalidNamesFileException will be thrown and the program exits.

All class and methods documentation for the project can be found here: "name-sorter\HelpDocumentation\index.html". The documentation covers all public classes, methods, and properties of both the name-sorter project and the name-sorter.tests project that can be found in the code.

## Installation Instructions:
1. Download the zip folder of the github repository for the program.

2. Ensure you have the required .Net Core SDK installed on you device. To do this, open the 'name-sorter.sln' file in the base "name-sorter" directory in a program like Visual Studio. It will then link you to the required software if it is not installed.

3. Create a copy of the names list file you want to sort in the base "name-sorter" directory.

4. Using the Windows Command Prompt, navigate to where you have stored the "name-sorter" directory, where the .exe file is located. You can do this using the *cd* command followed by the directory you want to navigate to,
e.g. *cd "C:\Users\youUserName\name-sorter"*.

5. When in the correct directory to run the program enter: *name-sorter ./name-of-file.txt*
You should see the sorted names printed to the window and the 'sorted-names-list.txt' file appear in the "name-sorter" directory where you saved your unsorted list.


## Usage Tutorial:
1. I have a file called 'unsorted-names-list.txt' with the contents:
>Janet Parsons
>Vaughn Lewis
>Adonis Julius Archer
>Shelby Nathan Yoder
>Marin Alvarez
>London Lindsey
>Beau Tristan Bentley
>Leo Gardner
>Hunter Uriah Mathew Clarke
>Mikayla Lopez
>Frankie Conner Ritter
I have saved this file in my "name-sorter" base directory.

2. Next, I open the Windows Command Prompt and navigate to base directory using *cd "C:\Users\myuser\Visual Studio\name-sorter"*

3. I then run the program using *name-sorter ./unsorted-names-list.txt* and get the following outputted to the console:
>Marin Alvarez
>Adonis Julius Archer
>Beau Tristan Bentley
>Hunter Uriah Mathew Clarke
>Leo Gardner
>Vaughn Lewis
>London Lindsey
>Mikayla Lopez
>Janet Parsons
>Frankie Conner Ritter
>Shelby Nathan Yoder
There is also now a file called 'sorted-names-list.txt' in my base directory.