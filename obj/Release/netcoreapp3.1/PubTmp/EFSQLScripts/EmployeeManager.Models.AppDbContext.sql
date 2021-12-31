IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211214090147_InitialCreate')
BEGIN
    CREATE TABLE [Countries] (
        [CountryID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        CONSTRAINT [PK_Countries] PRIMARY KEY ([CountryID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211214090147_InitialCreate')
BEGIN
    CREATE TABLE [Employees] (
        [EmployeeID] int NOT NULL IDENTITY,
        [FirstName] nvarchar(10) NOT NULL,
        [LastName] nvarchar(20) NOT NULL,
        [Title] nvarchar(30) NOT NULL,
        [BirthDate] datetime2 NOT NULL,
        [HireDate] datetime2 NOT NULL,
        [Country] nvarchar(15) NULL,
        [Notes] nvarchar(500) NULL,
        CONSTRAINT [PK_Employees] PRIMARY KEY ([EmployeeID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211214090147_InitialCreate')
BEGIN
    CREATE TABLE [Users] (
        [UserID] int NOT NULL IDENTITY,
        [UserName] nvarchar(20) NOT NULL,
        [Password] nvarchar(20) NOT NULL,
        [Email] nvarchar(max) NOT NULL,
        [FullName] nvarchar(max) NOT NULL,
        [BirthDate] datetime2 NOT NULL,
        [Role] nvarchar(50) NOT NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([UserID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211214090147_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211214090147_InitialCreate', N'3.1.21');
END;

GO

