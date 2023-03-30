
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/29/2023 17:04:56
-- Generated from EDMX file: C:\Users\...\source\repos\DorganASPNetFramework\DorganASPNetFramework\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dorgandb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TestBEntityTestCEntity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TestCEntities] DROP CONSTRAINT [FK_TestBEntityTestCEntity];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EquipmentTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EquipmentTypes];
GO
IF OBJECT_ID(N'[dbo].[PartTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PartTypes];
GO
IF OBJECT_ID(N'[dbo].[Suppliers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Suppliers];
GO
IF OBJECT_ID(N'[dbo].[TestEntities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TestEntities];
GO
IF OBJECT_ID(N'[dbo].[TestBEntities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TestBEntities];
GO
IF OBJECT_ID(N'[dbo].[TestCEntities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TestCEntities];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'EquipmentTypes'
CREATE TABLE [dbo].[EquipmentTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PartTypes'
CREATE TABLE [dbo].[PartTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Suppliers'
CREATE TABLE [dbo].[Suppliers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Address1] nvarchar(max)  NOT NULL,
    [Address2] nvarchar(max)  NULL,
    [City] nvarchar(max)  NOT NULL,
    [State] nvarchar(max)  NOT NULL,
    [ZIP] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TestEntities'
CREATE TABLE [dbo].[TestEntities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TestBEntities'
CREATE TABLE [dbo].[TestBEntities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TestCEntities'
CREATE TABLE [dbo].[TestCEntities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TestBEntityId] int  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'EquipmentTypes'
ALTER TABLE [dbo].[EquipmentTypes]
ADD CONSTRAINT [PK_EquipmentTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PartTypes'
ALTER TABLE [dbo].[PartTypes]
ADD CONSTRAINT [PK_PartTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Suppliers'
ALTER TABLE [dbo].[Suppliers]
ADD CONSTRAINT [PK_Suppliers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TestEntities'
ALTER TABLE [dbo].[TestEntities]
ADD CONSTRAINT [PK_TestEntities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TestBEntities'
ALTER TABLE [dbo].[TestBEntities]
ADD CONSTRAINT [PK_TestBEntities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TestCEntities'
ALTER TABLE [dbo].[TestCEntities]
ADD CONSTRAINT [PK_TestCEntities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TestBEntityId] in table 'TestCEntities'
ALTER TABLE [dbo].[TestCEntities]
ADD CONSTRAINT [FK_TestBEntityTestCEntity]
    FOREIGN KEY ([TestBEntityId])
    REFERENCES [dbo].[TestBEntities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TestBEntityTestCEntity'
CREATE INDEX [IX_FK_TestBEntityTestCEntity]
ON [dbo].[TestCEntities]
    ([TestBEntityId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------