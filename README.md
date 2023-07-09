# name-sorter

## Project Description:
This program takes the path of a file containing a list of names and then sorts them alphabectically by the last names, then by any given names. It then prints this sorted list to the console and saves the sorted names to a file called *sorted-names-list.txt* in the current working directory (where the .exe file is located).

The names present in the unsorted list provided are converted to Names objects and stored as a list of Names objects when loaded. The algorithm to sort these names takes this list and orders the contents by the LastName property, then by the GivenNames property, and then converts the list to a list of strings. This new list of strings is then printed to the console and saved to the *sorted-names-list.txt* file.

If no file path is provided as an argument when executing the program, a message will be printed to the console stating the requirement for a path argument and end the program. If the file provided is unable to be read or is in an invalid format (e.g. missing given names) an InvalidNamesFileException will be thrown and the program will terminate.

All class and method documentation for the project can be found in the *HelpDocumentation* folder in the base directory. Use the *index.html* file to view it in your browser. This documentation covers all public classes, methods, and properties of both the name-sorter project and the name-sorter.tests unit tests project.

## Installation Instructions:
1. Download the zip folder of the github repository for the program and unzip to your preferred location.

2. Ensure you have the required .Net Core SDK installed on you device to run the program. You can find the required SDK here:
*https://aka.ms/dotnet-core-applaunch?missing_runtime=true&arch=x64&rid=win10-x64&apphost_version=6.0.18*
**Note: If you do attempt to execute the application through command line without the required software, you will be asked to install it and be provided the download link.**

3. Create a copy of the names list file you want to sort in the base directory (the directory that contains the .exe file).

4. Using your command line program, navigate to the programs base directory where the .exe file is located. You can do this using the *cd* command followed by the directory you want to navigate to, e.g. *cd "C:\Users\youUserName\name-sorter"*.

5. When in the correct directory enter this command to run the program: *name-sorter ./name-of-file.txt*
You should see the sorted names printed to the console and the *sorted-names-list.txt* file appear in the current directory.


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

I have saved this file in my *name-sorter* base directory.

2. Next, I open the Windows Command Prompt and navigate to base directory using *cd "C:\Users\myuser\Downloads\name-sorter"*

3. To check I have the correct SDK installed, I enter *name-sorter.exe* in the command prompt. This will either output a link to the required SDK or a message asking for the file path argument. If it does the latter, the required software is installed.

4. After installing the software, I then run the program using *name-sorter ./unsorted-names-list.txt* and get the following output to the console of the now sorted names:
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

There is now a file called 'sorted-names-list.txt' in my base directory. If I was to run the program again with a different set of names will sorted file will be replaced with those names.