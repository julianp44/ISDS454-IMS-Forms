Install XAMPP Version 8.2.12 from https://www.apachefriends.org/download.html
  Click through the initial warning about UAC which pops up. This warning does not affect functionality of the system.
  All default options in the installer are ok.
Open up XAMPP Control Panel 

Start the Apache Module with the “Start” action
  Port number should be 80 and 443 by default
  
Start the MySQL Module with the “Start” action
  Port number should be 3306 by default
  
Open a browser and navigate to localhost/phpMyAdmin

From the landing page, click the “databases” tab on the top left of the screen

Create a new database called “inventorydatabase” by entering “inventorydatabase” into the database name input box and clicking create.

Create the required tables with dummy data by clicking the “Import” tab

In the first box at the top of the Import tab, click “choose” file and locate the “inventorydatabase.sql” file (this should be included in the project zip folder)
Once selected, scroll to the bottom of the page and click import.

The database should now be set up with the correct tables.

Now open the project .sln file and run the program with the green play button.
  Employee ID: admin
  Password: password
