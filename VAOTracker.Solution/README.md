# Vendor & Order Tracker

#### By Richard Barbour II

#### C# ASP.NET Core MVC web application that tracks customers and their orders.


## Technologies Used

* C#
* .Net 7.0.400 SDK (incl. NuGet and MSTest)
* ASP.NET Core MVC


## Description

This web-based application tracks vendors and their associated orders. The user can navigate from the splash page using a link to reach a page that lists any current customers. If there are no customers currently in the "database", the user is notified by a message on the page and can follow a link to create a new vendor. Once vendors have been created, the user can create orders that are tied to that vendor using relevant links.   

The main vendor page displays a list of all vendors and each individual vendor page displays a list of all orders for that vendor. The indiviual orders serve as links to their own order detail page.  

The web app follows RESTful / CRUD conventions for naming files, route names and URL paths.

## Setup/Installation Requirements

1. Navigate to https://github.com/rbarcode/w9-vendor-and-order-tracker in an internet browser.
2. Click on the green “<> Code” on the far right-hand side of the page's main column.
3. On the “Local” tab of the mini-window that opens underneath the “<>Code” button, copy the HTTPS link in the gray bar to your clipboard.
4. In GitBash (or a terminal shell of your choice), navigate to the directory where you wish to download the project and enter the following prompt (replacing the italicized word with the appropriate link): git clone *url-of-the-repository-copied-in-the-previous-step*
5. Your chosen directory will now contain a folder titled w9-vendor-and-order-tracker.
6. Navigate into the subfolder called VAOTracker.Solution/VAOTracker.Tests within the folder you cloned down.
7. If you don't have the .Net Software Development Kit already installed on your computer, do so now. You may also wish to download the REPL (read-evaluate-print-loop) tool called dotnet-script. 
7. To run MSTest from the terminal, enter the following command from within the VAOTracker.Tests directory: dotnet test.
8. To build and run the web app on your local server, navigate to the VAOTracker directory. In the command line, enter the following command to compile and execute the application in a web browser: dotnet watch 
9. Optionally, you can run the following command to compile the console application without running it by entering the following command in the command line: dotnet build


## Known Bugs

No known bugs.

## License

MIT License

Copyright (c) 2023 Richard Barbour II

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.