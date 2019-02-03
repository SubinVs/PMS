
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/03/2019 14:55:16
-- Generated from EDMX file: F:\Project\PMS\PMS.Entity\PMSModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PMS];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AdvanceControl_Outlet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_AdvanceControl] DROP CONSTRAINT [FK_AdvanceControl_Outlet];
GO
IF OBJECT_ID(N'[dbo].[FK_CheckIn_Agent]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_CheckIn] DROP CONSTRAINT [FK_CheckIn_Agent];
GO
IF OBJECT_ID(N'[dbo].[FK_CheckIn_Company]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_CheckIn] DROP CONSTRAINT [FK_CheckIn_Company];
GO
IF OBJECT_ID(N'[dbo].[FK_CheckIn_Guest]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_CheckIn] DROP CONSTRAINT [FK_CheckIn_Guest];
GO
IF OBJECT_ID(N'[dbo].[FK_CheckIn_Plan]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_CheckIn] DROP CONSTRAINT [FK_CheckIn_Plan];
GO
IF OBJECT_ID(N'[dbo].[FK_CheckIn_Purpose]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_CheckIn] DROP CONSTRAINT [FK_CheckIn_Purpose];
GO
IF OBJECT_ID(N'[dbo].[FK_CheckIn_Room]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_CheckIn] DROP CONSTRAINT [FK_CheckIn_Room];
GO
IF OBJECT_ID(N'[dbo].[FK_City_State]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_City] DROP CONSTRAINT [FK_City_State];
GO
IF OBJECT_ID(N'[dbo].[FK_Guest_City]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_Guest] DROP CONSTRAINT [FK_Guest_City];
GO
IF OBJECT_ID(N'[dbo].[FK_Guest_Country]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_Guest] DROP CONSTRAINT [FK_Guest_Country];
GO
IF OBJECT_ID(N'[dbo].[FK_Guest_Prefix]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_Guest] DROP CONSTRAINT [FK_Guest_Prefix];
GO
IF OBJECT_ID(N'[dbo].[FK_Guest_State]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_Guest] DROP CONSTRAINT [FK_Guest_State];
GO
IF OBJECT_ID(N'[dbo].[FK_Outlet_Control]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_Outlet] DROP CONSTRAINT [FK_Outlet_Control];
GO
IF OBJECT_ID(N'[dbo].[FK_Room_Floor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_Room] DROP CONSTRAINT [FK_Room_Floor];
GO
IF OBJECT_ID(N'[dbo].[FK_Room_RoomType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_Room] DROP CONSTRAINT [FK_Room_RoomType];
GO
IF OBJECT_ID(N'[dbo].[FK_Room_Status]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_Room] DROP CONSTRAINT [FK_Room_Status];
GO
IF OBJECT_ID(N'[dbo].[FK_State_Country]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_State] DROP CONSTRAINT [FK_State_Country];
GO
IF OBJECT_ID(N'[dbo].[FK_TaxControl_Outlet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HMS_TaxControl] DROP CONSTRAINT [FK_TaxControl_Outlet];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[HMS_AdvanceControl]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_AdvanceControl];
GO
IF OBJECT_ID(N'[dbo].[HMS_Agent]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_Agent];
GO
IF OBJECT_ID(N'[dbo].[HMS_CheckIn]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_CheckIn];
GO
IF OBJECT_ID(N'[dbo].[HMS_City]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_City];
GO
IF OBJECT_ID(N'[dbo].[HMS_Company]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_Company];
GO
IF OBJECT_ID(N'[dbo].[HMS_Control]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_Control];
GO
IF OBJECT_ID(N'[dbo].[HMS_Country]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_Country];
GO
IF OBJECT_ID(N'[dbo].[HMS_Floor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_Floor];
GO
IF OBJECT_ID(N'[dbo].[HMS_Guest]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_Guest];
GO
IF OBJECT_ID(N'[dbo].[HMS_Outlet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_Outlet];
GO
IF OBJECT_ID(N'[dbo].[HMS_Plan]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_Plan];
GO
IF OBJECT_ID(N'[dbo].[HMS_Purpose]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_Purpose];
GO
IF OBJECT_ID(N'[dbo].[HMS_Rate]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_Rate];
GO
IF OBJECT_ID(N'[dbo].[HMS_Room]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_Room];
GO
IF OBJECT_ID(N'[dbo].[HMS_RoomType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_RoomType];
GO
IF OBJECT_ID(N'[dbo].[HMS_State]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_State];
GO
IF OBJECT_ID(N'[dbo].[HMS_TaxControl]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HMS_TaxControl];
GO
IF OBJECT_ID(N'[dbo].[Prefix]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Prefix];
GO
IF OBJECT_ID(N'[dbo].[Status]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Status];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'HMS_AdvanceControl'
CREATE TABLE [dbo].[HMS_AdvanceControl] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OutletId] int  NOT NULL,
    [RecieptNo] int  NOT NULL,
    [PrintAdvance] bit  NOT NULL,
    [NoofCopies] int  NOT NULL,
    [SendSms] bit  NOT NULL,
    [SmsToMd] bit  NOT NULL,
    [SmsToGuest] bit  NOT NULL,
    [SendEmail] bit  NOT NULL,
    [EmailToMd] bit  NOT NULL,
    [EmailToGuest] bit  NOT NULL
);
GO

-- Creating table 'HMS_Agent'
CREATE TABLE [dbo].[HMS_Agent] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AgentName] varchar(15)  NOT NULL,
    [Active] bit  NOT NULL
);
GO

-- Creating table 'HMS_CheckIn'
CREATE TABLE [dbo].[HMS_CheckIn] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GuestId] int  NOT NULL,
    [RoomId] int  NOT NULL,
    [CheckInDate] datetime  NOT NULL,
    [CheckOutDate] datetime  NOT NULL,
    [GRCNo] varchar(10)  NOT NULL,
    [PurposeId] int  NOT NULL,
    [PlanId] int  NOT NULL,
    [CompanyId] int  NOT NULL,
    [AgentId] int  NOT NULL,
    [Comments] varchar(200)  NULL,
    [UserId] int  NOT NULL
);
GO

-- Creating table 'HMS_City'
CREATE TABLE [dbo].[HMS_City] (
    [id] int  NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [state_id] int  NOT NULL
);
GO

-- Creating table 'HMS_Company'
CREATE TABLE [dbo].[HMS_Company] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CompanyName] varchar(15)  NOT NULL,
    [Active] bit  NOT NULL
);
GO

-- Creating table 'HMS_Control'
CREATE TABLE [dbo].[HMS_Control] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(50)  NOT NULL,
    [Address] varchar(150)  NOT NULL,
    [PhoneNo] varchar(15)  NULL,
    [AlternatePhoneNo] varchar(15)  NULL,
    [MobileNo] varchar(15)  NULL,
    [AlternateMobileNo] varchar(15)  NULL,
    [MailId] varchar(50)  NULL,
    [AlternateMailId] varchar(50)  NULL
);
GO

-- Creating table 'HMS_Country'
CREATE TABLE [dbo].[HMS_Country] (
    [id] int IDENTITY(1,1) NOT NULL,
    [sortname] varchar(max)  NOT NULL,
    [name] varchar(max)  NOT NULL,
    [phonecode] int  NOT NULL
);
GO

-- Creating table 'HMS_Floor'
CREATE TABLE [dbo].[HMS_Floor] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FloorName] varchar(50)  NOT NULL,
    [Active] bit  NOT NULL
);
GO

-- Creating table 'HMS_Guest'
CREATE TABLE [dbo].[HMS_Guest] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PrefixId] int  NOT NULL,
    [GuestName] varchar(20)  NOT NULL,
    [Address] varchar(200)  NULL,
    [CountryId] int  NOT NULL,
    [StateId] int  NOT NULL,
    [CityId] int  NOT NULL,
    [Pincode] int  NOT NULL,
    [MobileNo] varchar(15)  NOT NULL,
    [EmailId] varchar(50)  NULL,
    [ImagePath] varchar(100)  NULL,
    [DocumentPath] varchar(100)  NULL,
    [Active] bit  NULL
);
GO

-- Creating table 'HMS_Outlet'
CREATE TABLE [dbo].[HMS_Outlet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OutletName] varchar(20)  NOT NULL,
    [GRCNo] int  NOT NULL,
    [ControlId] int  NOT NULL,
    [Address] varchar(150)  NOT NULL,
    [AlternateAddress] varchar(150)  NULL,
    [MobileNo] varchar(15)  NOT NULL,
    [AlternateMobileNo] varchar(15)  NULL,
    [PhoneNo] varchar(15)  NOT NULL,
    [AlternatePhoneNo] varchar(15)  NULL,
    [EmailId] varchar(50)  NOT NULL,
    [AlternateEmailId] varchar(50)  NULL,
    [GraceHours] int  NOT NULL,
    [Active] bit  NOT NULL
);
GO

-- Creating table 'HMS_Plan'
CREATE TABLE [dbo].[HMS_Plan] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PlanType] varchar(10)  NOT NULL
);
GO

-- Creating table 'HMS_Purpose'
CREATE TABLE [dbo].[HMS_Purpose] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PurposeType] varchar(10)  NOT NULL
);
GO

-- Creating table 'HMS_Rate'
CREATE TABLE [dbo].[HMS_Rate] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AgentId] int  NOT NULL,
    [PlanId] int  NOT NULL,
    [RoomTypeId] int  NOT NULL,
    [Occupancy] int  NOT NULL,
    [Amount] int  NOT NULL,
    [ExtraPersonCharge] int  NOT NULL,
    [AgentName] varchar(50)  NOT NULL,
    [PlanName] varchar(50)  NOT NULL,
    [RoomType] varchar(50)  NOT NULL
);
GO

-- Creating table 'HMS_Room'
CREATE TABLE [dbo].[HMS_Room] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RoomNo] varchar(5)  NOT NULL,
    [FloorId] int  NOT NULL,
    [RoomTypeId] int  NOT NULL,
    [StatusId] int  NOT NULL,
    [Active] bit  NOT NULL
);
GO

-- Creating table 'HMS_RoomType'
CREATE TABLE [dbo].[HMS_RoomType] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [RoomTypeName] varchar(50)  NULL,
    [Occupancy] int  NOT NULL,
    [Active] bit  NOT NULL
);
GO

-- Creating table 'HMS_State'
CREATE TABLE [dbo].[HMS_State] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [country_id] int  NOT NULL
);
GO

-- Creating table 'HMS_TaxControl'
CREATE TABLE [dbo].[HMS_TaxControl] (
    [Id] int  NOT NULL,
    [OutletId] int  NOT NULL,
    [TaxName] varchar(50)  NOT NULL,
    [TaxNo] varchar(20)  NOT NULL,
    [FromSlabAmount] int  NOT NULL,
    [ToSlabAmount] int  NOT NULL,
    [Percentage] int  NOT NULL,
    [Active] bit  NOT NULL
);
GO

-- Creating table 'Prefixes'
CREATE TABLE [dbo].[Prefixes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PrefixName] varchar(7)  NOT NULL
);
GO

-- Creating table 'Status'
CREATE TABLE [dbo].[Status] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StatusName] varchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'HMS_AdvanceControl'
ALTER TABLE [dbo].[HMS_AdvanceControl]
ADD CONSTRAINT [PK_HMS_AdvanceControl]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HMS_Agent'
ALTER TABLE [dbo].[HMS_Agent]
ADD CONSTRAINT [PK_HMS_Agent]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HMS_CheckIn'
ALTER TABLE [dbo].[HMS_CheckIn]
ADD CONSTRAINT [PK_HMS_CheckIn]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'HMS_City'
ALTER TABLE [dbo].[HMS_City]
ADD CONSTRAINT [PK_HMS_City]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'HMS_Company'
ALTER TABLE [dbo].[HMS_Company]
ADD CONSTRAINT [PK_HMS_Company]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HMS_Control'
ALTER TABLE [dbo].[HMS_Control]
ADD CONSTRAINT [PK_HMS_Control]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'HMS_Country'
ALTER TABLE [dbo].[HMS_Country]
ADD CONSTRAINT [PK_HMS_Country]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'HMS_Floor'
ALTER TABLE [dbo].[HMS_Floor]
ADD CONSTRAINT [PK_HMS_Floor]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HMS_Guest'
ALTER TABLE [dbo].[HMS_Guest]
ADD CONSTRAINT [PK_HMS_Guest]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HMS_Outlet'
ALTER TABLE [dbo].[HMS_Outlet]
ADD CONSTRAINT [PK_HMS_Outlet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HMS_Plan'
ALTER TABLE [dbo].[HMS_Plan]
ADD CONSTRAINT [PK_HMS_Plan]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HMS_Purpose'
ALTER TABLE [dbo].[HMS_Purpose]
ADD CONSTRAINT [PK_HMS_Purpose]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HMS_Rate'
ALTER TABLE [dbo].[HMS_Rate]
ADD CONSTRAINT [PK_HMS_Rate]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HMS_Room'
ALTER TABLE [dbo].[HMS_Room]
ADD CONSTRAINT [PK_HMS_Room]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HMS_RoomType'
ALTER TABLE [dbo].[HMS_RoomType]
ADD CONSTRAINT [PK_HMS_RoomType]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table 'HMS_State'
ALTER TABLE [dbo].[HMS_State]
ADD CONSTRAINT [PK_HMS_State]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table 'HMS_TaxControl'
ALTER TABLE [dbo].[HMS_TaxControl]
ADD CONSTRAINT [PK_HMS_TaxControl]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Prefixes'
ALTER TABLE [dbo].[Prefixes]
ADD CONSTRAINT [PK_Prefixes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Status'
ALTER TABLE [dbo].[Status]
ADD CONSTRAINT [PK_Status]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [OutletId] in table 'HMS_AdvanceControl'
ALTER TABLE [dbo].[HMS_AdvanceControl]
ADD CONSTRAINT [FK_AdvanceControl_Outlet]
    FOREIGN KEY ([OutletId])
    REFERENCES [dbo].[HMS_Outlet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AdvanceControl_Outlet'
CREATE INDEX [IX_FK_AdvanceControl_Outlet]
ON [dbo].[HMS_AdvanceControl]
    ([OutletId]);
GO

-- Creating foreign key on [AgentId] in table 'HMS_CheckIn'
ALTER TABLE [dbo].[HMS_CheckIn]
ADD CONSTRAINT [FK_CheckIn_Agent]
    FOREIGN KEY ([AgentId])
    REFERENCES [dbo].[HMS_Agent]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CheckIn_Agent'
CREATE INDEX [IX_FK_CheckIn_Agent]
ON [dbo].[HMS_CheckIn]
    ([AgentId]);
GO

-- Creating foreign key on [CompanyId] in table 'HMS_CheckIn'
ALTER TABLE [dbo].[HMS_CheckIn]
ADD CONSTRAINT [FK_CheckIn_Company]
    FOREIGN KEY ([CompanyId])
    REFERENCES [dbo].[HMS_Company]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CheckIn_Company'
CREATE INDEX [IX_FK_CheckIn_Company]
ON [dbo].[HMS_CheckIn]
    ([CompanyId]);
GO

-- Creating foreign key on [GuestId] in table 'HMS_CheckIn'
ALTER TABLE [dbo].[HMS_CheckIn]
ADD CONSTRAINT [FK_CheckIn_Guest]
    FOREIGN KEY ([GuestId])
    REFERENCES [dbo].[HMS_Guest]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CheckIn_Guest'
CREATE INDEX [IX_FK_CheckIn_Guest]
ON [dbo].[HMS_CheckIn]
    ([GuestId]);
GO

-- Creating foreign key on [PlanId] in table 'HMS_CheckIn'
ALTER TABLE [dbo].[HMS_CheckIn]
ADD CONSTRAINT [FK_CheckIn_Plan]
    FOREIGN KEY ([PlanId])
    REFERENCES [dbo].[HMS_Plan]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CheckIn_Plan'
CREATE INDEX [IX_FK_CheckIn_Plan]
ON [dbo].[HMS_CheckIn]
    ([PlanId]);
GO

-- Creating foreign key on [PurposeId] in table 'HMS_CheckIn'
ALTER TABLE [dbo].[HMS_CheckIn]
ADD CONSTRAINT [FK_CheckIn_Purpose]
    FOREIGN KEY ([PurposeId])
    REFERENCES [dbo].[HMS_Purpose]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CheckIn_Purpose'
CREATE INDEX [IX_FK_CheckIn_Purpose]
ON [dbo].[HMS_CheckIn]
    ([PurposeId]);
GO

-- Creating foreign key on [RoomId] in table 'HMS_CheckIn'
ALTER TABLE [dbo].[HMS_CheckIn]
ADD CONSTRAINT [FK_CheckIn_Room]
    FOREIGN KEY ([RoomId])
    REFERENCES [dbo].[HMS_Room]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CheckIn_Room'
CREATE INDEX [IX_FK_CheckIn_Room]
ON [dbo].[HMS_CheckIn]
    ([RoomId]);
GO

-- Creating foreign key on [state_id] in table 'HMS_City'
ALTER TABLE [dbo].[HMS_City]
ADD CONSTRAINT [FK_City_State]
    FOREIGN KEY ([state_id])
    REFERENCES [dbo].[HMS_State]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_City_State'
CREATE INDEX [IX_FK_City_State]
ON [dbo].[HMS_City]
    ([state_id]);
GO

-- Creating foreign key on [CityId] in table 'HMS_Guest'
ALTER TABLE [dbo].[HMS_Guest]
ADD CONSTRAINT [FK_Guest_City]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[HMS_City]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Guest_City'
CREATE INDEX [IX_FK_Guest_City]
ON [dbo].[HMS_Guest]
    ([CityId]);
GO

-- Creating foreign key on [ControlId] in table 'HMS_Outlet'
ALTER TABLE [dbo].[HMS_Outlet]
ADD CONSTRAINT [FK_Outlet_Control]
    FOREIGN KEY ([ControlId])
    REFERENCES [dbo].[HMS_Control]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Outlet_Control'
CREATE INDEX [IX_FK_Outlet_Control]
ON [dbo].[HMS_Outlet]
    ([ControlId]);
GO

-- Creating foreign key on [CountryId] in table 'HMS_Guest'
ALTER TABLE [dbo].[HMS_Guest]
ADD CONSTRAINT [FK_Guest_Country]
    FOREIGN KEY ([CountryId])
    REFERENCES [dbo].[HMS_Country]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Guest_Country'
CREATE INDEX [IX_FK_Guest_Country]
ON [dbo].[HMS_Guest]
    ([CountryId]);
GO

-- Creating foreign key on [country_id] in table 'HMS_State'
ALTER TABLE [dbo].[HMS_State]
ADD CONSTRAINT [FK_State_Country]
    FOREIGN KEY ([country_id])
    REFERENCES [dbo].[HMS_Country]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_State_Country'
CREATE INDEX [IX_FK_State_Country]
ON [dbo].[HMS_State]
    ([country_id]);
GO

-- Creating foreign key on [FloorId] in table 'HMS_Room'
ALTER TABLE [dbo].[HMS_Room]
ADD CONSTRAINT [FK_Room_Floor]
    FOREIGN KEY ([FloorId])
    REFERENCES [dbo].[HMS_Floor]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Room_Floor'
CREATE INDEX [IX_FK_Room_Floor]
ON [dbo].[HMS_Room]
    ([FloorId]);
GO

-- Creating foreign key on [PrefixId] in table 'HMS_Guest'
ALTER TABLE [dbo].[HMS_Guest]
ADD CONSTRAINT [FK_Guest_Prefix]
    FOREIGN KEY ([PrefixId])
    REFERENCES [dbo].[Prefixes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Guest_Prefix'
CREATE INDEX [IX_FK_Guest_Prefix]
ON [dbo].[HMS_Guest]
    ([PrefixId]);
GO

-- Creating foreign key on [StateId] in table 'HMS_Guest'
ALTER TABLE [dbo].[HMS_Guest]
ADD CONSTRAINT [FK_Guest_State]
    FOREIGN KEY ([StateId])
    REFERENCES [dbo].[HMS_State]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Guest_State'
CREATE INDEX [IX_FK_Guest_State]
ON [dbo].[HMS_Guest]
    ([StateId]);
GO

-- Creating foreign key on [OutletId] in table 'HMS_TaxControl'
ALTER TABLE [dbo].[HMS_TaxControl]
ADD CONSTRAINT [FK_TaxControl_Outlet]
    FOREIGN KEY ([OutletId])
    REFERENCES [dbo].[HMS_Outlet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TaxControl_Outlet'
CREATE INDEX [IX_FK_TaxControl_Outlet]
ON [dbo].[HMS_TaxControl]
    ([OutletId]);
GO

-- Creating foreign key on [RoomTypeId] in table 'HMS_Room'
ALTER TABLE [dbo].[HMS_Room]
ADD CONSTRAINT [FK_Room_RoomType]
    FOREIGN KEY ([RoomTypeId])
    REFERENCES [dbo].[HMS_RoomType]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Room_RoomType'
CREATE INDEX [IX_FK_Room_RoomType]
ON [dbo].[HMS_Room]
    ([RoomTypeId]);
GO

-- Creating foreign key on [StatusId] in table 'HMS_Room'
ALTER TABLE [dbo].[HMS_Room]
ADD CONSTRAINT [FK_Room_Status]
    FOREIGN KEY ([StatusId])
    REFERENCES [dbo].[Status]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Room_Status'
CREATE INDEX [IX_FK_Room_Status]
ON [dbo].[HMS_Room]
    ([StatusId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------