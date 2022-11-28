# Hot Desc
#### Web application that allows you to book a workplace in an office with the required equipment
## Configuration
* Change database ConnectingString in [appsettings.json](https://github.com/MParchan/Hot-Desc/blob/main/Hot%20Desc/appsettings.json)
````json
"ConnectionStrings": {
    "HotDescConnection": "Server=(localdb)\\mssqllocaldb;Database=HotDescDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
````
* In Package Manager Console run `update-database` command
* Run the program to load sample data to the database
## Database (MS SQL Server)
![Database-image](https://user-images.githubusercontent.com/85680066/204361209-032990f8-b897-4437-b002-8655f0557979.png)
## Architecture
#### Controllers:
* HotDescController - is responsible for the entire workplace booking process
* ReservationsController - is responsible for displaying current bookings
* EmployeesController - is responsible for creating employees

#### Project structure:

![architectureHotDesc](https://user-images.githubusercontent.com/85680066/204364535-6d7b89d1-8ad5-459d-95c6-bc49a0e7fd4c.png)
