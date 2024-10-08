# Hotel Management System

## Project Overview

This repository contains a hotel management system divided into different components:

1. **CustomerWebApp**: A customer-facing web application for booking and interacting with hotel services.
2. **FrontDeskApp**: An application used by front desk staff for managing bookings, check-ins, and check-outs.
3. **HotelDataLibrary**: A shared library for managing hotel data, including database migrations and data models.
4. **ServiceCrewApp**: An application for the service crew to handle room service and maintenance requests.

## Features

### CustomerWebApp
- **Technologies**: ASP.NET Core, Entity Framework, Razor Pages
- **Key Features**:
  - User registration and login.
  - Booking and reservation system.
  - Room and service browsing.
  - Customer feedback section.

### FrontDeskApp
- **Technologies**: UWP (Universal Windows Platform)
- **Key Features**:
  - Front desk management for guest check-in and check-out.
  - Room availability tracking.
  - Payment handling.

### HotelDataLibrary
- **Technologies**: .NET Standard Library, Entity Framework
- **Key Features**:
  - Centralized data models and database handling.
  - Database migration scripts.
  - Shared between CustomerWebApp, FrontDeskApp, and ServiceCrewApp.

### ServiceCrewApp
- **Technologies**: UWP (Universal Windows Platform)
- **Key Features**:
  - Task management for service crew.
  - Room service tracking and status updates.
  - Maintenance requests.

## Getting Started

### Prerequisites
- .NET 5.0 or higher
- Visual Studio 2019 or higher
- SQL Server (for database)

### Setting Up the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/your-repo/hotel-management-system.git
   ```
   
2. Open the solution file `HotelProject.sln` in Visual Studio.

3. Restore NuGet packages:
   ```bash
   dotnet restore
   ```

4. Set up the database:
   - Navigate to the `CustomerWebApp` or `HotelDataLibrary` and update the connection string in `appsettings.json` or `Startup.cs`.
   - Run the following command to apply migrations:
     ```bash
     dotnet ef database update
     ```

5. Run each application (CustomerWebApp, FrontDeskApp, ServiceCrewApp) by setting the appropriate startup project in Visual Studio.

## Usage

- **CustomerWebApp**: Accessible via web browser once launched.
- **FrontDeskApp**: A desktop application that can be installed and used by front desk staff.
- **ServiceCrewApp**: A task management application for service crew members.
