# SESRIC Cafeteria Menu System

This project is a simple cafeteria menu backend application. I created it to practise C#, ASP.NET Core Web API, SQL, Entity Framework Core and SQLite.

The application stores cafeteria menu information in a SQLite database. Each menu item has a date, soup, main course, side dish and extra item.

The API supports basic CRUD operations. It can show all menu items, show one menu item by its Id, add a new menu item, update an existing menu item and delete a menu item.

I used C#, .NET, ASP.NET Core Web API, Entity Framework Core and SQLite while developing this project.

The API uses the following routes. GET /api/menuitems returns all menu items. GET /api/menuitems/{id} returns one menu item by its Id. POST /api/menuitems adds a new menu item. PUT /api/menuitems/{id} updates an existing menu item. DELETE /api/menuitems/{id} deletes a menu item.

To run the project, first open the cafeteria-menu-system/api folder in the terminal. Then run dotnet ef database update to create or update the database. After that, run dotnet run to start the application. The API normally runs on http://localhost:5064.

The learning-exercises folder contains the C# exercises I completed before starting the main project. The database folder contains the SQL table, sample data and SQL queries. The api folder contains the ASP.NET Core Web API project.

While working on this project, I learned how to create models and controllers, create API routes, use GET, POST, PUT and DELETE methods, connect an API to a database, use Entity Framework Core migrations and save data with SQLite.
