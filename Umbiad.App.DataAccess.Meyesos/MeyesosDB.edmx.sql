
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/28/2016 20:13:15
-- Generated from EDMX file: F:\KoaloDeveloperFiles\Projeler\Umbiad_Meyesos\Umbiad.App.DataAccess.Meyesos\MeyesosDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MEYESOS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Table_User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Table_User];
GO
IF OBJECT_ID(N'[dbo].[Table_Message]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Table_Message];
GO
IF OBJECT_ID(N'[dbo].[Table_FollowInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Table_FollowInfo];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Table_User'
CREATE TABLE [dbo].[Table_User] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Status] smallint  NOT NULL,
    [UserName] nvarchar(50)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [PersonalMessage] nvarchar(max)  NULL,
    [BirthDate] int  NOT NULL
);
GO

-- Creating table 'Table_Message'
CREATE TABLE [dbo].[Table_Message] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Status] smallint  NOT NULL,
    [UserId] bigint  NOT NULL,
    [EntryDate] int  NOT NULL,
    [EntryTime] int  NOT NULL,
    [Message] nvarchar(max)  NOT NULL,
    [Location] geography  NULL,
    [MediaType] nvarchar(max)  NULL,
    [Media] nvarchar(max)  NULL
);
GO

-- Creating table 'Table_FollowInfo'
CREATE TABLE [dbo].[Table_FollowInfo] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [UserId] bigint  NOT NULL,
    [OpponentUserId] bigint  NOT NULL,
    [IsActive] bit  NOT NULL,
    [StartDate] int  NOT NULL,
    [StartTime] int  NOT NULL,
    [EndDate] int  NOT NULL,
    [EndTime] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Table_User'
ALTER TABLE [dbo].[Table_User]
ADD CONSTRAINT [PK_Table_User]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Table_Message'
ALTER TABLE [dbo].[Table_Message]
ADD CONSTRAINT [PK_Table_Message]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Table_FollowInfo'
ALTER TABLE [dbo].[Table_FollowInfo]
ADD CONSTRAINT [PK_Table_FollowInfo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------