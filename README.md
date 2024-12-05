1. Install XAMPP Version 8.2.12 from https://www.apachefriends.org/download.html

    Click through the initial warning about UAC which pops up. This warning does not affect functionality of the system.
    All default options in the installer are ok.

  
2. Open up XAMPP Control Panel 

3. Start the Apache Module with the “Start” action
  Port number should be 80 and 443 by default
  
4. Start the MySQL Module with the “Start” action
  Port number should be 3306 by default
  
5. Open a browser and navigate to localhost/phpMyAdmin

6. From the landing page, click the “databases” tab on the top left of the screen

7. Create a new database called “inventorydatabase” by entering “inventorydatabase” into the database name input box and clicking create.

8. Create the required tables with dummy data by clicking the “Import” tab

9. In the first box at the top of the Import tab, click “choose” file and locate the “inventorydatabase.sql” file (this should be included in the project zip folder)
Once selected, scroll to the bottom of the page and click import.

10. The database should now be set up with the correct tables.

11. Now open the ISDS454 IMS-Forms.sln open the project file with Visual Studio
12. Run the program with the green play button.
13. Sign in to the Inventory managment system using these credentials:

    Employee ID: admin
  
    Password: password
