**LocationApp**

This project consists of two parts: a backend built with ASP.NET Core API and frontend built with React Native (bare workflow). The application allows users to submit their full name and current location to the backend and retrieve all records stored in the database.

**Backend Setup**

```
git clone https://github.com/HassanHamdanDev/locationapp.git
```

***Open the project in Visual Studio:***

Launch Visual Studio.
Open the solution file LocationApp.sln .

***Set up the database:***

Make The LocationApp.Infrastructure.EntityFramework the Startup Project

Open the Package Manager Console (PMC) in Visual Studio and run:

```
Update-Database
```

***Run the backend:***

Make The LocationApp.API the Startup Project
Press F5 to start the backend server.


**Frontend Setup**

***Steps to Run***

***Navigate to the frontend folder:***
```
cd /Clients/Frontend/LocationAppMobile
```
***Install dependencies:***
```
npm install
```
***Run the app:***

For Android:
```
npx react-native run-android
```
For iOS (macOS only):
```
npx react-native run-ios
```

**API Endpoints**

***1. POST /api/places/createRecord***

Description: Adds a new record with the user's full name and location.
Request Body:

```
{
  "name": "John Doe",
  "latitude": "12.34",
  "longitude": "56.78"
}
```

***2. GET /api/places/records***

Description: Retrieves all records stored in the database.
Response Example:

```
[
  {
    "id": 1,
  "name": "John Doe",
  "latitude": "12.34",
  "longitude": "56.78"
    "createdOn": "2024-12-18T10:00:00"
  }
]
```


