<h1 align="center"><strong>

# _Pierre's Sweet and Savory Treats_ 
</strong></h1>


#### A practice in Authentication with Identity within C# & .Net through an application that is based out on Pierre's Bakery._ , 2020 ver 1.0_

#### By _Sean Downs_

## Description

_A practice in Authentication with Identity within C# & .Net through an application that is based out on Pierre's Bakery._

## Setup/Installation Requirements

* to clone this content, copy the url provided by the `clone or download` button in GitHub
* in command line use the command 'git clone (GitHub url)'
* open the program in a code editor
* you will need [.NET] (https://dotnet.microsoft.com/download/dotnet-core/2.2) installed to run this program 
* then install dotnet script REPL by typing `dotnet tool installl -g dotnet-script` in the command line
* type dotnet build in the command line to compile the code
* create a `.gitignore` file and store the bin and obj folders in .gitignore
* type `dotnet watch run` in the command line to run the program
* run `dotnet add package Microsoft.EntityFrameworkCore -v 2.2.0`  &
`dotnet add package Pomelo.EntityFrameworkCore.MySql -v 2.2.0`
in the terminal
* add a file called `appsetting.json` in the PierresBakeryTreatFlavor directory.
* in `appsetting.json` add ![appsetting.json](Assets/setup.png)
* fill in your `server`, `port`,`database`,`uid`, and `pwd`
* Make suere to have your `MySQLWorkbench` open
* run 
`dotnet ef migrations add Initial`
then `dotnet ef database update`
* if everything looks correct you should see this as the home page: 
<!-- ![Home-page](Assets/HomePage.png) -->

__

## Specs

| Behavior    |
| :---------- |
| Create User for site using Identity |
| Create a treat with Name, Description |
| Create a flavor with Name and Description |
| Edit Treat or Flavor and be able to link them together |
|


## Known Bugs

_No known bugs_

## Support and contact details

_Sean Downs <spdowns@protonmail.com>_

## Technologies Used

_The Technologies used in the making of this software was Chrome browser, Visual Studio editor, and Mac, C#, .Net, Authentication with Identity_

### License

Copyright (c) 2020 **_Sean Downs_**

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

<!-- Insert gif at the end to catch the eye -->
</h1>