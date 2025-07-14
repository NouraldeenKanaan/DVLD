# DVLD System

## Overview
The **DVLD System** is a C# .NET application for managing driver and vehicle licensing. It uses a layered architecture with three projects:
- **DVLD_Presentation**: User interface (Windows Forms/WPF).
- **DVLD_Business**: Business logic and rules.
- **DVLD_DataAccess**: Database operations (ADO.NET/Entity Framework).

## Features
- Manage driver licenses and vehicle registrations.
- Scalable, modular design.
- User-friendly interface.

## Prerequisites
- Visual Studio 2022+
- .NET Framework (e.g., 4.8)
- SQL Server (optional, for database)

## Setup
1. Clone the repo: `git clone https://github.com/yourusername/DVLD.git`
2. Open `DVLD.sln` in Visual Studio.
3. Restore NuGet packages: `dotnet restore`
4. Configure database connection in `DVLD_DataAccess` (e.g., `app.config`).
5. Build and run (`F5`), with `DVLD_Presentation` as the startup project.

## Usage
- Launch the app via `DVLD_Presentation`.
- Use the UI to issue/renew licenses, manage vehicles, or view data.

## Contributing
1. Fork and create a branch: `git checkout -b feature/your-feature`
2. Commit changes: `git commit -m "Your changes"`
3. Push: `git push origin feature/your-feature`
4. Submit a pull request.

## License
[MIT License](LICENSE)