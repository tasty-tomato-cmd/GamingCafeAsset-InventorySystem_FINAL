# 🎮 Gaming Cafe Asset & Inventory System

A desktop-based asset and inventory management system for gaming cafes, built with **C# Windows Forms** and **Microsoft SQL Server**. The system manages devices, bookings, food items, user accounts, payments, and game libraries from a single unified interface.

---

## 📋 Table of Contents

- [Features](#features)
- [Tech Stack](#tech-stack)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Database Setup](#database-setup)
- [Project Structure](#project-structure)
- [Database Design](#database-design)
  - [ER Diagram](#er-diagram)
  - [Normalisation](#normalisation)
  - [Final Tables](#final-tables)
- [Contribution](#contribution)

---

## ✨ Features

- 🔐 **User Authentication** — Role-based login (Admin / Staff) with active/inactive account control
- 🖥️ **Device Management** — Track gaming devices by category, location, hourly rate, and status
- 🎮 **Games Library** — Catalog games by platform and genre, linked to specific devices
- 📅 **Booking System** — Create and manage customer bookings with start/end times and device assignment
- 🍔 **Food & Beverage Inventory** — Manage food items with pricing, stock quantity, and categories
- 💳 **Payment Processing** — Record payments per booking with method, status, and timestamps
- 👥 **User Management** — Full CRUD for staff and admin accounts with contact and type info

---

## 🛠 Tech Stack

| Layer | Technology |
|---|---|
| Language | C# (.NET Windows Forms) |
| IDE | Visual Studio 2022+ |
| Database | Microsoft SQL Server (Express) |
| ORM / Data Access | ADO.NET (`SqlClient`, `SqlDataAdapter`) |
| Project Format | `.slnx` / `.csproj` |

---

## ✅ Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET Desktop Development** workload
- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or full SQL Server)
- [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms)

---

## 🚀 Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/tasty-tomato-cmd/GamingCafeAsset-InventorySystem.git
   cd GamingCafeAsset-InventorySystem
   ```

2. **Set up the database** — See [Database Setup](#database-setup) below.

3. **Update the connection string** in `DBAccessHelper.cs`:
   ```csharp
   new SqlConnection(
     "Data Source=YOUR_SERVER_NAME\\SQLEXPRESS;" +
     "Initial Catalog=GamingCafeDB;" +
     "Integrated Security=True;" +
     "TrustServerCertificate=True"
   );
   ```
   Replace `YOUR_SERVER_NAME` with your machine's SQL Server instance name.

4. **Open the solution** — Open `GamingCafeAsset&InventorySystem.slnx` in Visual Studio.

5. **Build and run** — Press `F5` or click **Run**.

---

## 🗄️ Database Setup

1. Open **SSMS** and connect to your SQL Server instance.
2. Create a new database named `GamingCafeDB`.
3. Run the table creation scripts from the [Final Tables](#final-tables) section below, in order.
4. Optionally seed initial data for `UserType`, `DeviceCategory`, `FoodCategory`, and `Games`.

---

## 📁 Project Structure

```
GamingCafeAsset-InventorySystem_FINAL-master/
├── GamingCafeAsset&InventorySystem.slnx       # Solution file
└── GamingCafeAsset&InventorySystem/
    ├── Program.cs                             # Application entry point
    ├── App.config                             # App configuration
    ├── DBAccessHelper.cs                      # SQL connection & query helpers
    ├── DataDeletionHelper.cs                  # Soft/hard delete utilities
    ├── LoggedInUser.cs                        # Session state for logged-in user
    ├── PhoneEmailValidation.cs                # Input validation helpers
    ├── LoginForm.cs / .Designer.cs            # Login screen
    ├── HomeForm.cs / .Designer.cs             # Main dashboard
    ├── AddBookingForm.cs / .Designer.cs       # Create/edit bookings
    ├── AddDeviceForm.cs / .Designer.cs        # Create/edit devices
    ├── AddFoodItemFrom.cs / .Designer.cs      # Create/edit food items
    ├── AddGamesForm.cs / .Designer.cs         # Create/edit games
    ├── AddPaymentForm.cs / .Designer.cs       # Record payments
    ├── AddUserForm.cs / .Designer.cs          # Create new users
    ├── UpdateUserForm.cs / .Designer.cs       # Edit existing users
    └── Properties/                            # Assembly info & resources
```

---

## 🗃️ Database Design

### ER Diagram

The entity-relationship diagram below shows all entities, their attributes, and relationships across the system.

> See `ERMainDiagram_drawio.png` in the repository root.

**Entities & Relationships:**

- `UserType` (1) ──── (M) `Users` — each user belongs to one user type (e.g. Admin, Staff)
- `DeviceCategory` (1) ──── (M) `DeviceCategoryMap` (M) ──── (1) `Device` — devices are mapped to one or more categories
- `Device` (M) ──── (M) `Games` via `DeviceGames` — each device can have multiple games installed
- `Users` (M) ──── (M) `Booking` — users can have multiple bookings; bookings involve one device and one user
- `Device` (1) ──── (M) `Booking` — each booking is assigned to one device
- `Booking` (1) ──── (M) `Payment` — a booking can have multiple payment records
- `Booking` (1) ──── (M) `FoodItem` — food items are associated with a booking
- `FoodItem` (M) ──── (M) `FoodCategory` via `FoodItemCategory` — food items belong to one or more categories

---

### Normalisation

The raw unnormalised data that could exist in this domain (e.g. a flat booking record) is progressively normalised through three normal forms before arriving at the final table schema.

---

#### 🔴 Unnormalised Form (UNF)

A single flat record capturing all booking-related information, with repeating groups for food items and games:

| BookingID | CustomerName | CustomerPhone | DeviceName | CategoryName | HourlyRate | GameName | Platform | FoodName | Price | Qty | PaymentAmount | PaymentMethod |
|---|---|---|---|---|---|---|---|---|---|---|---|---|
| 1 | John Doe | 017XXXXXXXX | PC-01, PS5-03 | PC, Console | 50, 80 | FIFA 25, Valorant | PS5, PC | Burger, Coke | 120, 40 | 2, 3 | 500 | Cash |

**Problems:** Repeating groups for devices, games, and food items. Multiple values in single cells. No single unique key.

---

#### 🟡 First Normal Form (1NF)

**Rule:** Eliminate repeating groups. Each cell must contain a single atomic value. Each row must be uniquely identifiable.

Split repeating device, game, and food data into separate rows. Introduce composite keys where needed.

**Booking (1NF)**

| BookingID | UserID | CustomerName | CustomerPhone | DeviceID | StartTime | EndTime | TotalHours | BookingDate | BookingStatus | Notes |
|---|---|---|---|---|---|---|---|---|---|---|
| 1 | 3 | John Doe | 017XXXXXXXX | 2 | 10:00 | 12:00 | 2 | 2024-01-15 | Confirmed | — |

**Device (1NF)**

| DeviceID | DeviceName | HourlyRate | Status | LocationNumber | CategoryID |
|---|---|---|---|---|---|
| 2 | PC-01 | 50.00 | Available | A1 | 1 |

**FoodItem (1NF)** — one row per food item per booking

| FoodID | FoodName | Price | Quantity | BookingID | CategoryID |
|---|---|---|---|---|---|
| 1 | Burger | 120.00 | 2 | 1 | 2 |
| 2 | Coke | 40.00 | 3 | 1 | 2 |

**Problems remaining:** Partial dependencies exist — `CustomerName` and `CustomerPhone` depend only on `UserID`, not the full booking key. `DeviceName` and `HourlyRate` depend only on `DeviceID`. `CategoryName` depends only on `CategoryID`.

---

#### 🟠 Second Normal Form (2NF)

**Rule:** Must be in 1NF. Remove all **partial dependencies** — non-key attributes must depend on the *whole* primary key.

Separate user details from bookings. Separate device details from bookings. Separate category details from device and food.

**Users (2NF)** — user attributes moved out of Booking

| UserID | Username | Password | FirstName | LastName | Email | PhoneNumber | Address | DateOfBirth | CreatedAt | IsActive | UserTypeID |
|---|---|---|---|---|---|---|---|---|---|---|---|
| 3 | johndoe | \*\*\*\*\*\* | John | Doe | john@email.com | 017XXXXXXXX | Dhaka | 1995-05-10 | 2024-01-01 | 1 | 2 |

**Device (2NF)** — category name removed; referenced via FK

| DeviceID | DeviceName | HourlyRate | Status | LocationNumber |
|---|---|---|---|---|
| 2 | PC-01 | 50.00 | Available | A1 |

**DeviceCategory (2NF)**

| CategoryID | CategoryName |
|---|---|
| 1 | PC |
| 2 | Console |

**FoodCategory (2NF)**

| CategoryID | CategoryName |
|---|---|
| 1 | Snacks |
| 2 | Beverages |

**Problems remaining:** Transitive dependencies — e.g. `UserTypeName` depends on `UserTypeID`, not directly on `UserID`.

---

#### 🟢 Third Normal Form (3NF)

**Rule:** Must be in 2NF. Remove all **transitive dependencies** — non-key attributes must depend *only* on the primary key, not on other non-key attributes.

Extract `UserType` into its own table. Extract `Games` details. Use junction tables for many-to-many relationships.

**UserType (3NF)**

| UserTypeID | UserTypeName |
|---|---|
| 1 | Admin |
| 2 | Staff |

**Games (3NF)**

| GameID | GameName | GamePlatform | Genre |
|---|---|---|---|
| 1 | FIFA 25 | PS5 | Sports |
| 2 | Valorant | PC | FPS |

**DeviceGames — Junction Table (3NF)**

| DeviceID | GameID |
|---|---|
| 2 | 2 |
| 3 | 1 |

**DeviceCategoryMap — Junction Table (3NF)**

| DeviceID | CategoryID |
|---|---|
| 2 | 1 |
| 3 | 2 |

**FoodItemCategory — Junction Table (3NF)**

| FoodID | CategoryID |
|---|---|
| 1 | 1 |
| 2 | 2 |

The schema is now in **3NF**: all non-key attributes depend solely on the primary key of their respective table, with no partial or transitive dependencies remaining.

---

### Final Tables

The following are the final normalised table definitions as implemented in `GamingCafeDB`:

---

#### `UserType`
Lookup table for user roles.

| Column | Type | Constraints |
|---|---|---|
| UserTypeID | INT | PK, IDENTITY |
| UserTypeName | NVARCHAR(50) | NOT NULL |

```sql
SELECT TOP (1000) [UserTypeID], [UserTypeName]
FROM [GamingCafeDB].[dbo].[UserType]
```

---

#### `Users`
All staff and admin accounts.

| Column | Type | Constraints |
|---|---|---|
| UserID | INT | PK, IDENTITY |
| Username | NVARCHAR(100) | NOT NULL, UNIQUE |
| Password | NVARCHAR(255) | NOT NULL |
| FirstName | NVARCHAR(100) | NOT NULL |
| LastName | NVARCHAR(100) | NOT NULL |
| UserTypeID | INT | FK → UserType(UserTypeID) |
| Email | NVARCHAR(255) | |
| PhoneNumber | NVARCHAR(20) | |
| Address | NVARCHAR(255) | |
| CreatedAt | DATETIME | DEFAULT GETDATE() |
| IsActive | BIT | DEFAULT 1 |
| DateOfBirth | DATE | |

```sql
SELECT TOP (1000) [UserID], [Username], [Password], [FirstName], [LastName],
  [UserTypeID], [Email], [PhoneNumber], [Address], [CreatedAt], [IsActive], [DateOfBirth]
FROM [GamingCafeDB].[dbo].[Users]
```

---

#### `DeviceCategory`
Categories for gaming devices (e.g. PC, Console, VR).

| Column | Type | Constraints |
|---|---|---|
| CategoryID | INT | PK, IDENTITY |
| CategoryName | NVARCHAR(100) | NOT NULL |

```sql
SELECT TOP (1000) [CategoryID], [CategoryName]
FROM [GamingCafeDB].[dbo].[DeviceCategory]
```

---

#### `Device`
Physical gaming devices available for booking.

| Column | Type | Constraints |
|---|---|---|
| DeviceID | INT | PK, IDENTITY |
| DeviceName | NVARCHAR(100) | NOT NULL |
| HourlyRate | DECIMAL(10,2) | NOT NULL |
| Status | NVARCHAR(50) | NOT NULL |
| LocationNumber | NVARCHAR(20) | |

```sql
SELECT TOP (1000) [DeviceID], [DeviceName], [HourlyRate], [Status], [LocationNumber]
FROM [GamingCafeDB].[dbo].[Device]
```

---

#### `DeviceCategoryMap`
Junction table — maps devices to their categories (M:M).

| Column | Type | Constraints |
|---|---|---|
| DeviceID | INT | PK, FK → Device(DeviceID) |
| CategoryID | INT | PK, FK → DeviceCategory(CategoryID) |

```sql
SELECT TOP (1000) [DeviceID], [CategoryID]
FROM [GamingCafeDB].[dbo].[DeviceCategoryMap]
```

---

#### `Games`
Game titles available in the cafe.

| Column | Type | Constraints |
|---|---|---|
| GameID | INT | PK, IDENTITY |
| GameName | NVARCHAR(150) | NOT NULL |
| GamePlatform | NVARCHAR(100) | |
| Genre | NVARCHAR(100) | |

```sql
SELECT TOP (1000) [GameID], [GameName], [GamePlatform], [Genre]
FROM [GamingCafeDB].[dbo].[Games]
```

---

#### `DeviceGames`
Junction table — maps which games are installed on which devices (M:M).

| Column | Type | Constraints |
|---|---|---|
| DeviceID | INT | PK, FK → Device(DeviceID) |
| GameID | INT | PK, FK → Games(GameID) |

```sql
SELECT TOP (1000) [DeviceID], [GameID]
FROM [GamingCafeDB].[dbo].[DeviceGames]
```

---

#### `Booking`
Customer session bookings linking users and devices.

| Column | Type | Constraints |
|---|---|---|
| BookingID | INT | PK, IDENTITY |
| UserID | INT | FK → Users(UserID) |
| StartTime | DATETIME | NOT NULL |
| EndTime | DATETIME | NOT NULL |
| TotalHours | DECIMAL(5,2) | |
| BookingDate | DATE | DEFAULT GETDATE() |
| BookingStatus | NVARCHAR(50) | NOT NULL |
| Notes | NVARCHAR(500) | |
| CustomerName | NVARCHAR(150) | |
| CustomerPhone | NVARCHAR(20) | |
| DeviceID | INT | FK → Device(DeviceID) |

```sql
SELECT TOP (1000) [BookingID], [UserID], [StartTime], [EndTime], [TotalHours],
  [BookingDate], [BookingStatus], [Notes], [CustomerName], [CustomerPhone], [DeviceID]
FROM [GamingCafeDB].[dbo].[Booking]
```

---

#### `FoodCategory`
Categories for food and beverage items.

| Column | Type | Constraints |
|---|---|---|
| CategoryID | INT | PK, IDENTITY |
| CategoryName | NVARCHAR(100) | NOT NULL |

```sql
SELECT TOP (1000) [CategoryID], [CategoryName]
FROM [GamingCafeDB].[dbo].[FoodCategory]
```

---

#### `FoodItem`
Food and beverage items orderable during a booking.

| Column | Type | Constraints |
|---|---|---|
| FoodID | INT | PK, IDENTITY |
| FoodName | NVARCHAR(150) | NOT NULL |
| Price | DECIMAL(10,2) | NOT NULL |
| Quantity | INT | NOT NULL |
| BookingID | INT | FK → Booking(BookingID) |

```sql
SELECT TOP (1000) [FoodID], [FoodName], [Price], [Quantity], [BookingID]
FROM [GamingCafeDB].[dbo].[FoodItem]
```

---

#### `FoodItemCategory`
Junction table — maps food items to their categories (M:M).

| Column | Type | Constraints |
|---|---|---|
| FoodID | INT | PK, FK → FoodItem(FoodID) |
| CategoryID | INT | PK, FK → FoodCategory(CategoryID) |

```sql
SELECT TOP (1000) [FoodID], [CategoryID]
FROM [GamingCafeDB].[dbo].[FoodItemCategory]
```

---

#### `Payment`
Payment records linked to bookings.

| Column | Type | Constraints |
|---|---|---|
| PaymentID | INT | PK, IDENTITY |
| BookingID | INT | FK → Booking(BookingID) |
| PaymentAmount | DECIMAL(10,2) | NOT NULL |
| PaymentMethod | NVARCHAR(50) | |
| PaymentDate | DATE | |
| PaymentStatus | NVARCHAR(50) | NOT NULL |
| CreatedAt | DATETIME | DEFAULT GETDATE() |

```sql
SELECT TOP (1000) [PaymentID], [BookingID], [PaymentAmount], [PaymentMethod],
  [PaymentDate], [PaymentStatus], [CreatedAt]
FROM [GamingCafeDB].[dbo].[Payment]
```

---

## 🤝 Contribution

1. ARYAN AFSAR AMEYA
2. MOHAMMAD MAHIR ABSAR SAZIN

---

*Built as part of a database systems project for gaming cafe management.*
