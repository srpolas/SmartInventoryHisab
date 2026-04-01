# SmartInventoryHisab - Inventory Management System

A robust, N-tier architecture Inventory Management System built with **.NET 8** and **Entity Framework Core**. This project demonstrates clean coding practices, the **Repository Pattern**, and a data-driven dashboard for warehouse health monitoring.

## 🚀 Key Features

### 📦 Inventory & Stock Management
- **Automated Stock Tracking**: Purchases automatically increment stock, and Sales automatically decrement it.
- **Stock Audit Logging**: Every inventory movement is logged in a `StockTransactions` table for a complete history.
- **Low Stock Alerts**: Real-time identification of items requiring re-order (Stock < 5).

### 🖥️ Dynamic Dashboard
- **Live Statistics**: Monitor Total SKUs, Low Stock Items, Aged Inventory (>6 months), and Recent Unit Sales at a glance.
- **Activity Feeds**: High-level visibility into "Latest Additions" and "Recent Sales" directly on the home page.

### 🖼️ Product Photography
- **Image Support**: Integrated product photo uploads with automatic placeholder assignment for missing images.
- **Premium UI**: Modern, card-based interface using **Bootstrap 5** and **Bootstrap Icons**.

### 🏗️ Architecture
- **N-Tier Separation**:
    - **Model**: Domain entities (`Product`, `Purchase`, `Sale`, `StockTransaction`).
    - **DAL (Data Access Layer)**: `GenericRepository` & `UnitOfWork` for clean data access.
    - **BLL (Business Logic Layer)**: Service-oriented business rules for stock validation and recording.
    - **Web**: ASP.NET Core MVC (Controllers & Views).

## 🛠️ Technology Stack

- **Framework**: .NET 8.0
- **Database**: Microsoft SQL Server
- **ORM**: Entity Framework Core (Migrations & Seeding)
- **UI**: ASP.NET Core MVC, Bootstrap 5, Bootstrap Icons
- **Patterns**: Repository Pattern, Unit of Work, Dependency Injection

## ⚙️ Setup & Installation

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (Express or Developer)

### 1. Database Configuration
Open `SmartInventoryHisab.Web/appsettings.json` and update the `DefaultConnection` string with your SQL Server credentials:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=SmartInventoryHisabDb;User Id=SA;Password=YOUR_PASSWORD;TrustServerCertificate=True;MultipleActiveResultSets=true"
}
```

### 2. Apply Migrations
Run the following commands in the project root to create the database and seed initial data:

```bash
dotnet ef database update --project SmartInventoryHisab.DAL/SmartInventoryHisab.DAL.csproj --startup-project SmartInventoryHisab.Web/SmartInventoryHisab.Web.csproj --context SmartInventoryDbContext
```

### 3. Run the Application
Start the web project:

```bash
dotnet run --project SmartInventoryHisab.Web/SmartInventoryHisab.Web.csproj
```

The application will be available at `http://localhost:5012` (or the port specified in console).

## 👨‍💻 Author
**MD. SHAHINUR RAHMAN POLAS**  
*Full Stack .NET Developer*

---
*Developed as part of Module 35 - Assignment 2.*
