# Gummi Bear Kingdom

#### Gummi Bear Kingdom, A Web Application for a Candy Store called Gummi Bear Kingdom. 08/04/2017

#### By Andrew Dalton

## Description

	This Web Application is designed for the user to see information about a Candy Store called Gummi Bear Kingdom. They can View a list of their products, view information about an individual product, add a new products, update an existing product, or delete an existing product.

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
  | User can view information about Gummi Bear Kingdom | application Start | "Welcome to our Kingdom..." |
  | User can View a list of all the Products available | click "View Products" | "Gummi Bears, Chocolate, Candy Bars |
  | User can View the information of an individual Product | click "Gummi Bears" | "Gummi Bears", "$3.99/lb.", "Brazil" |
  | User can Add a Product | click "Add Product", enter product info | "Gummi Bears", "$3.99/lb.", "Brazil" |
  | User can Update a Product | click "Update Product", enter new product info | "Gummi Bears", "$2.99/lb.", "Honduras" |
  | User can Delete a Product | click "Delete Product" | This product has been deleted. |

3. Integration
  * HomeController.cs - for routing and file integration.
  * Product.cs - Our Product Object Model
  * GummiBearKingdomContext.cs - for Database Configuration
  * 20170804200356_Initial.cs - for Database Migration
  * Index.cshtml - our home page
  * List.cshtml - a page for listing our products
  * Details.cshtml - a page for viewing the details of a given product
  * Add.cshtml - a page for adding a new product
  * Edit.cshtml - a page for editing an existing product
  * Delete.cshtml - a page for deleting an existing product
  
## Setup/Installation Requirements

* Open your console or powershell command line.
* In your command line, navigate to the desktop or your desired folder destination.
* Copy the project's github address (https://github.com/drewlinn/GummiBearKingdom.git)
* Write in your console the command "git clone" and paste the project address afterward and press enter.
* Open the project using Visual Studio.
* Right click on the project in the Solution Explorer Pane and click "Build".
* Use your console to navigate to the "GummiBearKingdom/src/GummiBearKingdom".
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