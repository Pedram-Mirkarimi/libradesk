<h1 align="center">📚 LibraDesk — Library Management System</h1>

<p align="center">
  A <b>Windows Forms (WinForms)</b> desktop application built with <b>C#</b> targeting <b>.NET Framework 4.7.2</b>, featuring
  <b>SQL Server</b> persistence and optional <b>Stimulsoft Reports</b> integration.
</p>

<p align="center">
  <img alt=".NET Framework" src="https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4" />
  <img alt="Platform" src="https://img.shields.io/badge/Platform-Windows-0078D6" />
  <img alt="UI" src="https://img.shields.io/badge/UI-WinForms-0A84FF" />
  <img alt="Language" src="https://img.shields.io/badge/Language-C%23-239120" />
  <img alt="Database" src="https://img.shields.io/badge/Database-SQL%20Server-CC2927" />
  <img alt="Reports" src="https://img.shields.io/badge/Reports-Stimulsoft-6f42c1" />
</p>

<p align="center">
  <a href="#-features">Features</a> •
  <a href="#-tech-stack">Tech Stack</a> •
  <a href="#-project-structure">Structure</a> •
  <a href="#-setup--run">Setup</a> •
  <a href="#-database-setup">Database</a> •
  <a href="#-roadmap">Roadmap</a>
</p>

---

## ✨ Overview

**LibraDesk** is a desktop app designed to handle core library operations such as:
- managing users and books
- tracking borrow/return transactions (loan records)
- generating reports (via Stimulsoft, if available)

It uses a local **SQL Server** database (`libraryDB`) and a configurable connection string inside `App.config`.

---

## ✅ Features

| Area | What you can do |
|---|---|
| 👤 Users | Add / edit / delete library users |
| 📖 Books | Manage the book catalog (records, metadata) |
| 🔁 Loans | Borrow and return books (loan/depository records) |
| 🧾 Reports | Reporting via **Stimulsoft.Report** (optional) |
| 🧰 Utilities | Backup / restore utilities (icons/placeholders present) |
| 🗄️ DB | Local **SQL Server** integration (configurable) |

---

## 🧰 Tech Stack

| Category | Technology | Notes |
|---|---|---|
| Language | C# | 100% C# |
| UI | WinForms | Desktop UI |
| Target Framework | .NET Framework 4.7.2 | Visual Studio Desktop workload |
| Database | SQL Server / SQL Server Express | Database name: `libraryDB` |
| Reporting (Optional) | Stimulsoft.Report | Requires assemblies/runtime |

---

## 📁 Project Structure

```text
Library-Management-System/
├─ Icon/                   # UI icons/assets
├─ Library/                # Visual Studio project folder
├─ Library.sln             # Solution
├─ README.md
└─ gitignore
````

> Inside the `Library/` project you’ll typically find WinForms, resources, typed datasets (e.g., `LibraryDBDataSet`), and `App.config`.

---

## 🚀 Setup & Run

### 1) Prerequisites

* ✅ **Windows**
* ✅ **Visual Studio 2017/2019/2022** with **.NET desktop development** workload
* ✅ **.NET Framework 4.7.2**
* ✅ **SQL Server** or **SQL Server Express**
* ➕ *(Optional)* **Stimulsoft Reports** runtime/assemblies (if you use reports)

### 2) Clone the repository

```bash
git clone https://github.com/Pedram-Mirkarimi/Library-Management-System.git
cd Library-Management-System
```

### 3) Open the solution

Open `Library.sln` in Visual Studio.

### 4) Restore dependencies

* If the project uses NuGet packages: Right-click the solution → **Restore NuGet Packages**
* If **Stimulsoft.Report** references are missing:

  * Install Stimulsoft runtime or add the required assembly references, **or**
  * Temporarily remove/replace reporting features.

### 5) Configure the connection string

Open:

* `Library/App.config`

Find/update the connection string (example):

```xml
Data Source=.;Initial Catalog=libraryDB;Integrated Security=True
```

* `Data Source=.` means your local SQL Server instance
* `Initial Catalog=libraryDB` is the database name

### 6) Build & run

* **Build**: `Build > Build Solution`
* **Run**: press **F5**

---

## 🗃️ Database Setup

The app expects a SQL Server database called **`libraryDB`**.

### Create DB + Tables

Run this script in SQL Server Management Studio (SSMS):

```sql
-- 1) Create DB
CREATE DATABASE libraryDB;
GO

-- 2) Use DB
USE libraryDB;
GO

-- 3) Tables
CREATE TABLE Book (
    id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(50) NOT NULL,
    writer NVARCHAR(50) NOT NULL,
    genre NVARCHAR(50) NOT NULL
);

CREATE TABLE Users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    fname NVARCHAR(50) NOT NULL,
    lName NVARCHAR(50) NOT NULL,
    phoneNumber NVARCHAR(50) NOT NULL
);

CREATE TABLE Depository (
    id INT IDENTITY(1,1) PRIMARY KEY,
    bookId INT NOT NULL,
    borrowerId INT NOT NULL,
    date NVARCHAR(50) NOT NULL,
    maxDate NVARCHAR(50) NOT NULL
);

CREATE TABLE Genre (
    id INT IDENTITY(1,1) PRIMARY KEY,
    genre NVARCHAR(50) NOT NULL
);
```

> Tip: You can improve this schema by adding foreign keys (e.g., `Depository.bookId → Book.id`) and using proper date types (`DATE/DATETIME`) instead of `NVARCHAR`.

---

## 🧯 Troubleshooting

### “Cannot find Stimulsoft assemblies”

* Install Stimulsoft runtime (licensed), or
* Remove/replace Stimulsoft reporting with an alternative (e.g., RDLC/FastReport)

### “Cannot open database ‘libraryDB’…”

* Confirm SQL Server service is running
* Confirm the DB exists
* Confirm your connection string in `App.config` matches your instance name

  * Example instance names:

    * `Data Source=.;...`
    * `Data Source=localhost;...`
    * `Data Source=.\SQLEXPRESS;...`

---

## 🛣️ Roadmap

* [ ] Add SQL seed data (demo users/books)
* [ ] Add migrations or an automated DB setup step
* [ ] Replace `NVARCHAR` dates with real `DATE/DATETIME`
* [ ] Add foreign keys + indexes for performance & integrity
* [ ] Add tests (where applicable)
* [ ] Improve `.gitignore` to exclude build artifacts (`bin/`, `obj/`, `.vs/`)

---

## 🤝 Contributing

1. Fork the repo
2. Create a branch: `git checkout -b feature/your-feature`
3. Commit changes: `git commit -m "Add: your feature"`
4. Push: `git push origin feature/your-feature`
5. Open a Pull Request

---

## 👤 Author

**Pedram Mirkarimi**
GitHub: [https://github.com/Pedram-Mirkarimi](https://github.com/Pedram-Mirkarimi)
