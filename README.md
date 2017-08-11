# Son of Cod

#### Son of Cod, A Web Application for a Seafood Company called Son of Cod. 08/11/2017

#### By Andrew Dalton

## Description

This Web Application is designed to display information about the Son of Cod Seafood Company and list all of the users who have signed up to receive the Son of Cod newsletter. The user can sign up for the newsletter and view the list of newsletter recipients.

## Planning

1. Configuration/dependencies

	For our Development Environment and Backend Functionality:
	* Microsoft.NETCore.App
	* Microsoft.AspNetCore.Diagnostics Version 1.0.0,
	* Microsoft.AspNetCore.Server.IISIntegration Version 1.0.0,
	* Microsoft.AspNetCore.Server.Kestrel Version 1.0.1,
	* Microsoft.Extensions.Logging.Console Version 1.0.0,
	* Microsoft.AspNetCore.Mvc Version 1.0.0,
	* Microsoft.EntityFrameworkCore Version 1.0.0,
	* Microsoft.EntityFrameworkCore.SqlServer Version 1.0.0,
	* Microsoft.Extensions.Configuration.FileExtensions Version 1.0.0,
	* Microsoft.Extensions.Configuration.Json Version 1.0.0
	
	For our Production Environment and Frontend Interface:
	* jQuery - as a dependency for bootstrap
	* npm - for installing bootstrap
	* gulp - for compiling bootstrap styles
	* Bootstrap - for basic styles

  2. Specifications

  | Behavior | Input | Output |
  | :--------| :---- | :------|
  | User can register for the website by entering their email address and password (twice) | "Username@Email.com", "Password123!", "Password123!" | "You are now registered for this site and can login" |
  | User can login to the website by entering their username and password | "Username@Email.com", "Password123!" | "You are now logged in as Username" |
  | A registered user can view a list of registered users | click "View Mailing List" | List of Registered Users |
  | *Stretch Goal* A registered user can make posts on the website about the company. | "Some info about Son of Cod...", "08/11/2017" | 


3. Integration

  * HomeController.cs - for routing and file integration.
  * User.cs - Our Object Model
  * SonOfCodContext.cs - for Database Configuration
  * 20170804200356_Initial.cs - for Database Migration
  * Index.cshtml - our home page
  * List.cshtml - a page for listing our users
  * Details.cshtml - a page for viewing the details of a given user
  * Add.cshtml - a page for adding a new User
  * Edit.cshtml - a page for editing an existing User
  * Delete.cshtml - a page for deleting an existing User
  
## Setup/Installation Requirements

* Open your console or powershell command line.
* In your command line, navigate to the desktop or your desired folder destination.
* Copy the project's github address (https://github.com/drewlinn/SonOfCod.git)
* Write in your console the command "git clone" and paste the project address afterward and press enter.
* Open the project using Visual Studio.
* Right click on the project in the Solution Explorer Pane and click "Build".
* Use your console to navigate to the "SonOfCod/src/SonOfCod".
* In the Command Line, type the command "dotnet ef database update".
* Once this process is complete, in Visual Studio, click on the button in the tool bar with the green PLAY SYMBOL that says "IIS EXPRESS" next to it.
* Your default web browser should open and navigate to the designated localhost automatically.
* The application should be displayed in your browser with full functionality.


## Known Bugs

Buttons in nav bar do not yet work.

## Support and contact details

If you notice any bugs in my program or any other issues with my code, please email me at expandrew@gmail.com

## Technologies Used

HTML
CSS
C#
Visual Studio 2015

### License

This software is licensed under the MIT license.

Copyright (c) 2016 **_{Andrew Dalton, Epicodus}_**