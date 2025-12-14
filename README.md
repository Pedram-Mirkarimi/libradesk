# Library Management System

**Library** is a desktop Library Management System implemented as a Windows Forms (WinForms) application in **C#** targeting **.NET Framework 4.7.2**.  
It provides basic library management features such as user management, book records, borrowing/return operations, and reporting (uses Stimulsoft Reports).

---

## Key Features

- User management (add/edit/delete users)
- Book catalog and management
- Borrowing and returning books (loan records)
- Backup / restore utilities (icons and placeholders present)
- Reporting using **Stimulsoft.Report**
- Local SQL Server database integration (configurable connection string)

---

## Prerequisites

- Microsoft Windows (developed for Windows Desktop)
- Visual Studio 2017/2019/2022 (recommended) with **.NET desktop development** workload
- .NET Framework **4.7.2** (installed on target machine)
- Local SQL Server / SQL Server Express instance for the application database
- (Optional) Stimulsoft Reports runtime if you will use the built-in reporting features

---

## Project Structure (important files & folders)

```
Library/
├── Library.sln
├── Library/                        # Visual Studio project
│   ├── Properties/
│   ├── Resources/
│   ├── Forms/                      # WinForms (*.cs + *.Designer.cs)
│   ├── DataSets/                   # Typed DataSets (LibraryDBDataSet)
│   ├── Icon/                       # UI icons
│   ├── Reports/                    # Stimulsoft report templates (if present)
│   └── App.config                  # Contains connection string
```

---

## Setup & Run (developer instructions)

1. **Clone or copy the repository** to your development machine.

2. **Open the solution**  
   - Launch Visual Studio and open `Library/Library.sln`.

3. **Restore/Install third-party components (if necessary)**  
   - If the solution references Stimulsoft.Report assemblies that are not present on your system, install the appropriate Stimulsoft runtime or add the assembly references in Visual Studio.
   - Ensure NuGet packages (if any) are restored by right-clicking the solution and selecting "Restore NuGet Packages".

4. **Database**  
   - The default connection string is located in `Library/App.config`:
     ```
     Data Source=.;Initial Catalog=libraryDB;Integrated Security=True
     ```
   - This expects a local SQL Server instance and a database named `libraryDB`. You have two options:
     - Attach / restore an existing database named `libraryDB` to your SQL Server instance.
     - Create a new database `libraryDB` and run the application's SQL scripts or allow the app to create tables (if implemented).
	
	### SQL Script
	
	```sql
	-- 1. Create the Database
	-- This command creates the main database for the project.
	CREATE DATABASE libraryDB;
	
	-- 2. Switch to the new database context
	-- This ensures that the subsequent tables are created inside 'libraryDB'.
	USE libraryDB;
	
	-- 3. Create the necessary tables
	-- Table to store information about the books.
	CREATE TABLE Book (
	    id int IDENTITY(1,1) PRIMARY KEY,
	    name nvarchar(50) NOT NULL,
	    writer nvarchar(50) NOT NULL,
	    genre nvarchar(50) NOT NULL
	);
	CREATE TABLE Users (
	    id int IDENTITY(1,1) PRIMARY KEY,
	    fname nvarchar(50) NOT NULL,
	    lName nvarchar(50) NOT NULL,
	    phoneNumber nvarchar(50) NOT NULL
	);
	CREATE TABLE Depository (
	    id int IDENTITY(1,1) PRIMARY KEY,
	    bookId int NOT NULL,
	    borrowerId int NOT NULL,
	    date nvarchar(50) NOT NULL,
		maxDate nvarchar(50) NOT NULL
	);
	CREATE TABLE Genre (
	    id int IDENTITY(1,1) PRIMARY KEY,
	    genre nvarchar(50) NOT NULL
	);
	
	```
	
	After running this script, the database schema will be ready for the application to use.
	
	5. **Build & Run**  
	   - Build the solution (`Build > Build Solution`).
	   - Run the application (`Debug > Start Debugging` or press F5).

---

## Notes & Recommendations

- The project targets **.NET Framework 4.7.2**. If you need to run on a newer runtime, consider retargeting the project in Visual Studio.
- Sensitive settings (passwords, connection strings) currently live in `App.config` and in user settings — for production use, consider securing these values or using integrated Windows authentication carefully.
- There are references to Stimulsoft.Report in the project file. If you don't have Stimulsoft libraries, you can:
  - Acquire the Stimulsoft runtime and add references.
  - Replace reporting functionality with an alternative (e.g., Microsoft RDLC, FastReport) if licensing is an issue.
- Visual Studio `.vs/` folder and build artifacts should be added to `.gitignore` before committing.

---

## Suggested Improvements

- Include SQL schema / seed data or automated migration scripts (e.g., using EF Code First or SQL scripts) so other developers can easily provision `libraryDB`.
- Replace any hard-coded credentials with secure configuration options.
- Add a brief developer guide listing the main forms and core classes (e.g., which forms handle users/books/loans).
- Add unit tests or integration tests where applicable.

---
