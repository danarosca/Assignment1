
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/24/2018 16:23:24
-- Generated from EDMX file: F:\An3Sem2\SD\Dana\Electrica\WindowsFormsApp2\WindowsFormsApp2\ElectricaModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Electrica];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Bills]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bills];
GO
IF OBJECT_ID(N'[dbo].[ClientNumbers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientNumbers];
GO
IF OBJECT_ID(N'[dbo].[Clients]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clients];
GO
IF OBJECT_ID(N'[dbo].[Complaints]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Complaints];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Bills'
CREATE TABLE [dbo].[Bills] (
    [id] int IDENTITY(1,1) NOT NULL,
    [total] int  NOT NULL,
    [paid] bit  NOT NULL,
    [clientId] int  NOT NULL
);
GO

-- Creating table 'ClientNumbers'
CREATE TABLE [dbo].[ClientNumbers] (
    [id] int IDENTITY(1,1) NOT NULL,
    [clientNr] nchar(30)  NOT NULL
);
GO

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nchar(20)  NOT NULL,
    [IDN] nchar(30)  NOT NULL,
    [PNC] nchar(20)  NOT NULL,
    [address] nchar(30)  NOT NULL,
    [userId] int  NOT NULL
);
GO

-- Creating table 'Complaints'
CREATE TABLE [dbo].[Complaints] (
    [id] int IDENTITY(1,1) NOT NULL,
    [status] nchar(30)  NOT NULL,
    [serviceQ] int  NOT NULL,
    [quickR] int  NOT NULL,
    [customerQ] int  NOT NULL,
    [shortDescription] nvarchar(max)  NOT NULL,
    [longDescription] nvarchar(max)  NOT NULL,
    [clientId] int  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [id] int IDENTITY(1,1) NOT NULL,
    [rights] nvarchar(max)  NOT NULL,
    [registrationNr] nvarchar(max)  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Bills'
ALTER TABLE [dbo].[Bills]
ADD CONSTRAINT [PK_Bills]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'ClientNumbers'
ALTER TABLE [dbo].[ClientNumbers]
ADD CONSTRAINT [PK_ClientNumbers]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Complaints'
ALTER TABLE [dbo].[Complaints]
ADD CONSTRAINT [PK_Complaints]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------