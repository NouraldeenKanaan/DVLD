# DVLD - Driver and Vehicle Licensing Department System

## Overview

Driving & Vehicle License Department Application. DVLD is a Desktop Application developed from scratch, using **.NET Framework Windows Forms**, **ADO.NET**, and **Microsoft SQL Server** as part of Programming Advices Course 19. It manages driver and vehicle licensing processes, including user authentication, person records, test types, test appointments, licenses, and local driving license applications.

## Project Structure

The solution is organized into three projects:

- **DVLD**: Contains the user interface, implemented using Windows Forms for interacting with the application.
- **DVLD_Business**: Implements the business logic, serving as an intermediary between the presentation and data access layers.
- **DVLD_DataAccess**: Manages database operations using ADO.NET, with classes for handling users, people, tests, test appointments, and licenses.