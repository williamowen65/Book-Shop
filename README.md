# Book Shop

![alt text](<Book Registration (Windows Forms + SQL Server)-1.gif>)

This is a simple Windows Forms app which integrates with a local SQL Server backend.

The project brings a few concepts together. CRUD database interactions, Class library logic, Front-end development via Windows Form Designer.
  
Each has it's own fun challenges but it's been fun to see it come together. 

[The instructions](./CPW-115_Final.pdf) share the C# class structure for this project. I followed this and organized the project in to MVC folder structure to keep it all organized.

--- 

> Note about testing locally

When testing this app there is an assumption that the SQL server is already setup and the program isn't responsible for creating/initializing the database for the bookstore. The SQL Server script is including if you wish to test out the project in whole. 

Here are the steps for doing that:

1. Open up SQL Server Management Studio (or other SQL Connection software)
2. Connect to your SQL instance
3. Open the [SQL Script]() in the program and run it.  
4. Observe the new database. 
5. Then run the Book Shop app







