
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/25/2016 03:37:39
-- Generated from EDMX file: C:\Users\Администратoр\Desktop\ServiceStation\ServiceStation\Model\DbServiceStationModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ServiceStation];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CarApplication]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Application] DROP CONSTRAINT [FK_CarApplication];
GO
IF OBJECT_ID(N'[dbo].[FK_EApllicationEOptionsCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OptionCustomer] DROP CONSTRAINT [FK_EApllicationEOptionsCustomer];
GO
IF OBJECT_ID(N'[dbo].[FK_EApplicationEReasonsCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReasonCustomer] DROP CONSTRAINT [FK_EApplicationEReasonsCustomer];
GO
IF OBJECT_ID(N'[dbo].[FK_EEmployeeEApllication]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Application] DROP CONSTRAINT [FK_EEmployeeEApllication];
GO
IF OBJECT_ID(N'[dbo].[FK_EPowerOfAttorneyEApllication]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Application] DROP CONSTRAINT [FK_EPowerOfAttorneyEApllication];
GO
IF OBJECT_ID(N'[dbo].[FK_TypeRepairModelApplicationModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Application] DROP CONSTRAINT [FK_TypeRepairModelApplicationModel];
GO
IF OBJECT_ID(N'[dbo].[FK_ContractorCar]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Car] DROP CONSTRAINT [FK_ContractorCar];
GO
IF OBJECT_ID(N'[dbo].[FK_EModelEVehicles]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Car] DROP CONSTRAINT [FK_EModelEVehicles];
GO
IF OBJECT_ID(N'[dbo].[FK_EContactNameEPowerOfAttorney]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PowerOfAttorney] DROP CONSTRAINT [FK_EContactNameEPowerOfAttorney];
GO
IF OBJECT_ID(N'[dbo].[FK_EContractingPartiesEContactName]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContactPerson] DROP CONSTRAINT [FK_EContractingPartiesEContactName];
GO
IF OBJECT_ID(N'[dbo].[FK_EViewContractingPartiesEContractingParties]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Contractor] DROP CONSTRAINT [FK_EViewContractingPartiesEContractingParties];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeModelUserModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_EmployeeModelUserModel];
GO
IF OBJECT_ID(N'[dbo].[FK_EPostEEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employee] DROP CONSTRAINT [FK_EPostEEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_EMarkEModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Model] DROP CONSTRAINT [FK_EMarkEModel];
GO
IF OBJECT_ID(N'[dbo].[FK_NomenclatureModelMaterialModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Material] DROP CONSTRAINT [FK_NomenclatureModelMaterialModel];
GO
IF OBJECT_ID(N'[dbo].[FK_ReasonCustomerModelMaterialModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Material] DROP CONSTRAINT [FK_ReasonCustomerModelMaterialModel];
GO
IF OBJECT_ID(N'[dbo].[FK_NomenclatureModelWorkModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Work] DROP CONSTRAINT [FK_NomenclatureModelWorkModel];
GO
IF OBJECT_ID(N'[dbo].[FK_TypeNomenclatureModelNomenclatureModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Nomenclature] DROP CONSTRAINT [FK_TypeNomenclatureModelNomenclatureModel];
GO
IF OBJECT_ID(N'[dbo].[FK_UnitModelNomenclatureModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Nomenclature] DROP CONSTRAINT [FK_UnitModelNomenclatureModel];
GO
IF OBJECT_ID(N'[dbo].[FK_EOptionsEOptionsCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OptionCustomer] DROP CONSTRAINT [FK_EOptionsEOptionsCustomer];
GO
IF OBJECT_ID(N'[dbo].[FK_ReasonModelReasonCustomerModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ReasonCustomer] DROP CONSTRAINT [FK_ReasonModelReasonCustomerModel];
GO
IF OBJECT_ID(N'[dbo].[FK_TypeManifestationModelReasonModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reason] DROP CONSTRAINT [FK_TypeManifestationModelReasonModel];
GO
IF OBJECT_ID(N'[dbo].[FK_ReasonCustomerModelWorkModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Work] DROP CONSTRAINT [FK_ReasonCustomerModelWorkModel];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkingHourModelWorkModel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Work] DROP CONSTRAINT [FK_WorkingHourModelWorkModel];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Application]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Application];
GO
IF OBJECT_ID(N'[dbo].[Car]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Car];
GO
IF OBJECT_ID(N'[dbo].[ContactPerson]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContactPerson];
GO
IF OBJECT_ID(N'[dbo].[Contractor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Contractor];
GO
IF OBJECT_ID(N'[dbo].[Employee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employee];
GO
IF OBJECT_ID(N'[dbo].[Mark]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Mark];
GO
IF OBJECT_ID(N'[dbo].[Material]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Material];
GO
IF OBJECT_ID(N'[dbo].[Model]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Model];
GO
IF OBJECT_ID(N'[dbo].[Nomenclature]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Nomenclature];
GO
IF OBJECT_ID(N'[dbo].[Option]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Option];
GO
IF OBJECT_ID(N'[dbo].[OptionCustomer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OptionCustomer];
GO
IF OBJECT_ID(N'[dbo].[Post]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Post];
GO
IF OBJECT_ID(N'[dbo].[PowerOfAttorney]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PowerOfAttorney];
GO
IF OBJECT_ID(N'[dbo].[Reason]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reason];
GO
IF OBJECT_ID(N'[dbo].[ReasonCustomer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ReasonCustomer];
GO
IF OBJECT_ID(N'[dbo].[TypeManifestation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeManifestation];
GO
IF OBJECT_ID(N'[dbo].[TypeNomenclature]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeNomenclature];
GO
IF OBJECT_ID(N'[dbo].[TypeRepair]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeRepair];
GO
IF OBJECT_ID(N'[dbo].[Unit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Unit];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO
IF OBJECT_ID(N'[dbo].[ViewСontractor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ViewСontractor];
GO
IF OBJECT_ID(N'[dbo].[Work]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Work];
GO
IF OBJECT_ID(N'[dbo].[WorkingHour]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkingHour];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Application'
CREATE TABLE [dbo].[Application] (
    [Number] int  NOT NULL,
    [Date] datetime  NOT NULL,
    [FirstControlTime] datetime  NULL,
    [SecondControlTime] datetime  NULL,
    [Type] nvarchar(15)  NOT NULL,
    [Readiness] datetime  NULL,
    [Extradition] datetime  NULL,
    [Revealed] nvarchar(max)  NULL,
    [Recommendations] nvarchar(max)  NULL,
    [ID_powerOfAttorney] uniqueidentifier  NULL,
    [ID_car] uniqueidentifier  NOT NULL,
    [ID_employee] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Car'
CREATE TABLE [dbo].[Car] (
    [ID] uniqueidentifier  NOT NULL,
    [VIN] nchar(17)  NOT NULL,
    [ID_model] uniqueidentifier  NOT NULL,
    [Mileage] decimal(12,0)  NOT NULL,
    [LicensePlate] nvarchar(15)  NULL,
    [NumberEngine] nvarchar(20)  NULL,
    [NumberChassis] nvarchar(20)  NULL,
    [NumberBody] nvarchar(20)  NULL,
    [Year] datetime  NOT NULL,
    [Price] decimal(12,2)  NOT NULL,
    [Color] nvarchar(50)  NULL,
    [ID_contractor] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ContactPerson'
CREATE TABLE [dbo].[ContactPerson] (
    [ID] uniqueidentifier  NOT NULL,
    [FFP] nvarchar(250)  NULL,
    [Phone] nvarchar(11)  NULL,
    [Email] nvarchar(40)  NULL,
    [Address] nvarchar(100)  NULL,
    [Additionally] nvarchar(max)  NULL,
    [ID_сontractor] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Contractor'
CREATE TABLE [dbo].[Contractor] (
    [ID] uniqueidentifier  NOT NULL,
    [View] nvarchar(20)  NOT NULL,
    [ShortName] nvarchar(150)  NOT NULL,
    [FullName] nvarchar(300)  NULL,
    [INN] nchar(12)  NULL,
    [KPP] nchar(9)  NULL,
    [OKPO] nchar(10)  NULL,
    [Phone] nvarchar(11)  NULL,
    [Email] nvarchar(40)  NULL,
    [Address] nvarchar(100)  NULL,
    [Additionally] nvarchar(max)  NULL
);
GO

-- Creating table 'Employee'
CREATE TABLE [dbo].[Employee] (
    [ID] uniqueidentifier  NOT NULL,
    [FFP] nvarchar(250)  NOT NULL,
    [ID_post] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Mark'
CREATE TABLE [dbo].[Mark] (
    [ID] uniqueidentifier  NOT NULL,
    [ShortName] nvarchar(100)  NOT NULL,
    [FullName] nvarchar(200)  NULL
);
GO

-- Creating table 'Material'
CREATE TABLE [dbo].[Material] (
    [ID] uniqueidentifier  NOT NULL,
    [Number_nomenclature] int  NOT NULL,
    [Amount] int  NOT NULL,
    [Price] decimal(10,2)  NOT NULL,
    [ID_reasonCustomer] uniqueidentifier  NOT NULL,
    [Customer] bit  NOT NULL
);
GO

-- Creating table 'Model'
CREATE TABLE [dbo].[Model] (
    [ID] uniqueidentifier  NOT NULL,
    [ID_mark] uniqueidentifier  NOT NULL,
    [Name] nvarchar(150)  NOT NULL
);
GO

-- Creating table 'Nomenclature'
CREATE TABLE [dbo].[Nomenclature] (
    [Number] int  NOT NULL,
    [ShortName] nvarchar(150)  NOT NULL,
    [FullName] nvarchar(300)  NULL,
    [Type] nvarchar(6)  NOT NULL,
    [Price] decimal(10,2)  NOT NULL,
    [Code_unit] int  NOT NULL,
    [VendorCode] nvarchar(20)  NULL,
    [Descriprion] nvarchar(max)  NULL
);
GO

-- Creating table 'Option'
CREATE TABLE [dbo].[Option] (
    [ID] uniqueidentifier  NOT NULL,
    [ShortName] nvarchar(150)  NOT NULL,
    [FullName] nvarchar(300)  NULL
);
GO

-- Creating table 'OptionCustomer'
CREATE TABLE [dbo].[OptionCustomer] (
    [ID] uniqueidentifier  NOT NULL,
    [Number] int  NOT NULL,
    [ID_option] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Post'
CREATE TABLE [dbo].[Post] (
    [ID] uniqueidentifier  NOT NULL,
    [Name] nvarchar(200)  NOT NULL
);
GO

-- Creating table 'PowerOfAttorney'
CREATE TABLE [dbo].[PowerOfAttorney] (
    [ID] uniqueidentifier  NOT NULL,
    [Number] nvarchar(10)  NOT NULL,
    [Date] datetime  NOT NULL,
    [ID_contactPerson] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Reason'
CREATE TABLE [dbo].[Reason] (
    [ID] uniqueidentifier  NOT NULL,
    [ShortName] nvarchar(100)  NOT NULL,
    [FullName] nvarchar(200)  NULL,
    [Additionally] nvarchar(max)  NULL,
    [Type] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'ReasonCustomer'
CREATE TABLE [dbo].[ReasonCustomer] (
    [ID] uniqueidentifier  NOT NULL,
    [ID_reason] uniqueidentifier  NOT NULL,
    [Number] int  NOT NULL
);
GO

-- Creating table 'TypeManifestation'
CREATE TABLE [dbo].[TypeManifestation] (
    [Type] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'TypeNomenclature'
CREATE TABLE [dbo].[TypeNomenclature] (
    [Type] nvarchar(6)  NOT NULL
);
GO

-- Creating table 'TypeRepair'
CREATE TABLE [dbo].[TypeRepair] (
    [Type] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'Unit'
CREATE TABLE [dbo].[Unit] (
    [Code] int  NOT NULL,
    [Name] nvarchar(40)  NOT NULL,
    [ShortName] nvarchar(40)  NOT NULL
);
GO

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [ID] uniqueidentifier  NOT NULL,
    [Name] nvarchar(20)  NOT NULL,
    [Password] nchar(64)  NOT NULL,
    [Administrator] bit  NOT NULL,
    [ID_employee] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'ViewСontractor'
CREATE TABLE [dbo].[ViewСontractor] (
    [View] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Work'
CREATE TABLE [dbo].[Work] (
    [ID] uniqueidentifier  NOT NULL,
    [Number_nomenclature] int  NOT NULL,
    [ID_workingHour] uniqueidentifier  NOT NULL,
    [Amount] int  NOT NULL,
    [NormOfTime] decimal(5,2)  NOT NULL,
    [ID_reasonCustomer] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'WorkingHour'
CREATE TABLE [dbo].[WorkingHour] (
    [ID] uniqueidentifier  NOT NULL,
    [Name] nvarchar(100)  NOT NULL,
    [Price] decimal(5,2)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Number] in table 'Application'
ALTER TABLE [dbo].[Application]
ADD CONSTRAINT [PK_Application]
    PRIMARY KEY CLUSTERED ([Number] ASC);
GO

-- Creating primary key on [ID] in table 'Car'
ALTER TABLE [dbo].[Car]
ADD CONSTRAINT [PK_Car]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ContactPerson'
ALTER TABLE [dbo].[ContactPerson]
ADD CONSTRAINT [PK_ContactPerson]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Contractor'
ALTER TABLE [dbo].[Contractor]
ADD CONSTRAINT [PK_Contractor]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Employee'
ALTER TABLE [dbo].[Employee]
ADD CONSTRAINT [PK_Employee]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Mark'
ALTER TABLE [dbo].[Mark]
ADD CONSTRAINT [PK_Mark]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Material'
ALTER TABLE [dbo].[Material]
ADD CONSTRAINT [PK_Material]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Model'
ALTER TABLE [dbo].[Model]
ADD CONSTRAINT [PK_Model]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Number] in table 'Nomenclature'
ALTER TABLE [dbo].[Nomenclature]
ADD CONSTRAINT [PK_Nomenclature]
    PRIMARY KEY CLUSTERED ([Number] ASC);
GO

-- Creating primary key on [ID] in table 'Option'
ALTER TABLE [dbo].[Option]
ADD CONSTRAINT [PK_Option]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'OptionCustomer'
ALTER TABLE [dbo].[OptionCustomer]
ADD CONSTRAINT [PK_OptionCustomer]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Post'
ALTER TABLE [dbo].[Post]
ADD CONSTRAINT [PK_Post]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'PowerOfAttorney'
ALTER TABLE [dbo].[PowerOfAttorney]
ADD CONSTRAINT [PK_PowerOfAttorney]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Reason'
ALTER TABLE [dbo].[Reason]
ADD CONSTRAINT [PK_Reason]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ReasonCustomer'
ALTER TABLE [dbo].[ReasonCustomer]
ADD CONSTRAINT [PK_ReasonCustomer]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [Type] in table 'TypeManifestation'
ALTER TABLE [dbo].[TypeManifestation]
ADD CONSTRAINT [PK_TypeManifestation]
    PRIMARY KEY CLUSTERED ([Type] ASC);
GO

-- Creating primary key on [Type] in table 'TypeNomenclature'
ALTER TABLE [dbo].[TypeNomenclature]
ADD CONSTRAINT [PK_TypeNomenclature]
    PRIMARY KEY CLUSTERED ([Type] ASC);
GO

-- Creating primary key on [Type] in table 'TypeRepair'
ALTER TABLE [dbo].[TypeRepair]
ADD CONSTRAINT [PK_TypeRepair]
    PRIMARY KEY CLUSTERED ([Type] ASC);
GO

-- Creating primary key on [Code] in table 'Unit'
ALTER TABLE [dbo].[Unit]
ADD CONSTRAINT [PK_Unit]
    PRIMARY KEY CLUSTERED ([Code] ASC);
GO

-- Creating primary key on [ID] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [View] in table 'ViewСontractor'
ALTER TABLE [dbo].[ViewСontractor]
ADD CONSTRAINT [PK_ViewСontractor]
    PRIMARY KEY CLUSTERED ([View] ASC);
GO

-- Creating primary key on [ID] in table 'Work'
ALTER TABLE [dbo].[Work]
ADD CONSTRAINT [PK_Work]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'WorkingHour'
ALTER TABLE [dbo].[WorkingHour]
ADD CONSTRAINT [PK_WorkingHour]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ID_car] in table 'Application'
ALTER TABLE [dbo].[Application]
ADD CONSTRAINT [FK_CarApplication]
    FOREIGN KEY ([ID_car])
    REFERENCES [dbo].[Car]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CarApplication'
CREATE INDEX [IX_FK_CarApplication]
ON [dbo].[Application]
    ([ID_car]);
GO

-- Creating foreign key on [Number] in table 'OptionCustomer'
ALTER TABLE [dbo].[OptionCustomer]
ADD CONSTRAINT [FK_EApllicationEOptionsCustomer]
    FOREIGN KEY ([Number])
    REFERENCES [dbo].[Application]
        ([Number])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EApllicationEOptionsCustomer'
CREATE INDEX [IX_FK_EApllicationEOptionsCustomer]
ON [dbo].[OptionCustomer]
    ([Number]);
GO

-- Creating foreign key on [Number] in table 'ReasonCustomer'
ALTER TABLE [dbo].[ReasonCustomer]
ADD CONSTRAINT [FK_EApplicationEReasonsCustomer]
    FOREIGN KEY ([Number])
    REFERENCES [dbo].[Application]
        ([Number])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EApplicationEReasonsCustomer'
CREATE INDEX [IX_FK_EApplicationEReasonsCustomer]
ON [dbo].[ReasonCustomer]
    ([Number]);
GO

-- Creating foreign key on [ID_employee] in table 'Application'
ALTER TABLE [dbo].[Application]
ADD CONSTRAINT [FK_EEmployeeEApllication]
    FOREIGN KEY ([ID_employee])
    REFERENCES [dbo].[Employee]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EEmployeeEApllication'
CREATE INDEX [IX_FK_EEmployeeEApllication]
ON [dbo].[Application]
    ([ID_employee]);
GO

-- Creating foreign key on [ID_powerOfAttorney] in table 'Application'
ALTER TABLE [dbo].[Application]
ADD CONSTRAINT [FK_EPowerOfAttorneyEApllication]
    FOREIGN KEY ([ID_powerOfAttorney])
    REFERENCES [dbo].[PowerOfAttorney]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EPowerOfAttorneyEApllication'
CREATE INDEX [IX_FK_EPowerOfAttorneyEApllication]
ON [dbo].[Application]
    ([ID_powerOfAttorney]);
GO

-- Creating foreign key on [Type] in table 'Application'
ALTER TABLE [dbo].[Application]
ADD CONSTRAINT [FK_TypeRepairModelApplicationModel]
    FOREIGN KEY ([Type])
    REFERENCES [dbo].[TypeRepair]
        ([Type])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TypeRepairModelApplicationModel'
CREATE INDEX [IX_FK_TypeRepairModelApplicationModel]
ON [dbo].[Application]
    ([Type]);
GO

-- Creating foreign key on [ID_contractor] in table 'Car'
ALTER TABLE [dbo].[Car]
ADD CONSTRAINT [FK_ContractorCar]
    FOREIGN KEY ([ID_contractor])
    REFERENCES [dbo].[Contractor]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ContractorCar'
CREATE INDEX [IX_FK_ContractorCar]
ON [dbo].[Car]
    ([ID_contractor]);
GO

-- Creating foreign key on [ID_model] in table 'Car'
ALTER TABLE [dbo].[Car]
ADD CONSTRAINT [FK_EModelEVehicles]
    FOREIGN KEY ([ID_model])
    REFERENCES [dbo].[Model]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EModelEVehicles'
CREATE INDEX [IX_FK_EModelEVehicles]
ON [dbo].[Car]
    ([ID_model]);
GO

-- Creating foreign key on [ID_contactPerson] in table 'PowerOfAttorney'
ALTER TABLE [dbo].[PowerOfAttorney]
ADD CONSTRAINT [FK_EContactNameEPowerOfAttorney]
    FOREIGN KEY ([ID_contactPerson])
    REFERENCES [dbo].[ContactPerson]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EContactNameEPowerOfAttorney'
CREATE INDEX [IX_FK_EContactNameEPowerOfAttorney]
ON [dbo].[PowerOfAttorney]
    ([ID_contactPerson]);
GO

-- Creating foreign key on [ID_сontractor] in table 'ContactPerson'
ALTER TABLE [dbo].[ContactPerson]
ADD CONSTRAINT [FK_EContractingPartiesEContactName]
    FOREIGN KEY ([ID_сontractor])
    REFERENCES [dbo].[Contractor]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EContractingPartiesEContactName'
CREATE INDEX [IX_FK_EContractingPartiesEContactName]
ON [dbo].[ContactPerson]
    ([ID_сontractor]);
GO

-- Creating foreign key on [View] in table 'Contractor'
ALTER TABLE [dbo].[Contractor]
ADD CONSTRAINT [FK_EViewContractingPartiesEContractingParties]
    FOREIGN KEY ([View])
    REFERENCES [dbo].[ViewСontractor]
        ([View])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EViewContractingPartiesEContractingParties'
CREATE INDEX [IX_FK_EViewContractingPartiesEContractingParties]
ON [dbo].[Contractor]
    ([View]);
GO

-- Creating foreign key on [ID_employee] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [FK_EmployeeModelUserModel]
    FOREIGN KEY ([ID_employee])
    REFERENCES [dbo].[Employee]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeModelUserModel'
CREATE INDEX [IX_FK_EmployeeModelUserModel]
ON [dbo].[User]
    ([ID_employee]);
GO

-- Creating foreign key on [ID_post] in table 'Employee'
ALTER TABLE [dbo].[Employee]
ADD CONSTRAINT [FK_EPostEEmployee]
    FOREIGN KEY ([ID_post])
    REFERENCES [dbo].[Post]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EPostEEmployee'
CREATE INDEX [IX_FK_EPostEEmployee]
ON [dbo].[Employee]
    ([ID_post]);
GO

-- Creating foreign key on [ID_mark] in table 'Model'
ALTER TABLE [dbo].[Model]
ADD CONSTRAINT [FK_EMarkEModel]
    FOREIGN KEY ([ID_mark])
    REFERENCES [dbo].[Mark]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EMarkEModel'
CREATE INDEX [IX_FK_EMarkEModel]
ON [dbo].[Model]
    ([ID_mark]);
GO

-- Creating foreign key on [Number_nomenclature] in table 'Material'
ALTER TABLE [dbo].[Material]
ADD CONSTRAINT [FK_NomenclatureModelMaterialModel]
    FOREIGN KEY ([Number_nomenclature])
    REFERENCES [dbo].[Nomenclature]
        ([Number])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NomenclatureModelMaterialModel'
CREATE INDEX [IX_FK_NomenclatureModelMaterialModel]
ON [dbo].[Material]
    ([Number_nomenclature]);
GO

-- Creating foreign key on [ID_reasonCustomer] in table 'Material'
ALTER TABLE [dbo].[Material]
ADD CONSTRAINT [FK_ReasonCustomerModelMaterialModel]
    FOREIGN KEY ([ID_reasonCustomer])
    REFERENCES [dbo].[ReasonCustomer]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReasonCustomerModelMaterialModel'
CREATE INDEX [IX_FK_ReasonCustomerModelMaterialModel]
ON [dbo].[Material]
    ([ID_reasonCustomer]);
GO

-- Creating foreign key on [Number_nomenclature] in table 'Work'
ALTER TABLE [dbo].[Work]
ADD CONSTRAINT [FK_NomenclatureModelWorkModel]
    FOREIGN KEY ([Number_nomenclature])
    REFERENCES [dbo].[Nomenclature]
        ([Number])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NomenclatureModelWorkModel'
CREATE INDEX [IX_FK_NomenclatureModelWorkModel]
ON [dbo].[Work]
    ([Number_nomenclature]);
GO

-- Creating foreign key on [Type] in table 'Nomenclature'
ALTER TABLE [dbo].[Nomenclature]
ADD CONSTRAINT [FK_TypeNomenclatureModelNomenclatureModel]
    FOREIGN KEY ([Type])
    REFERENCES [dbo].[TypeNomenclature]
        ([Type])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TypeNomenclatureModelNomenclatureModel'
CREATE INDEX [IX_FK_TypeNomenclatureModelNomenclatureModel]
ON [dbo].[Nomenclature]
    ([Type]);
GO

-- Creating foreign key on [Code_unit] in table 'Nomenclature'
ALTER TABLE [dbo].[Nomenclature]
ADD CONSTRAINT [FK_UnitModelNomenclatureModel]
    FOREIGN KEY ([Code_unit])
    REFERENCES [dbo].[Unit]
        ([Code])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UnitModelNomenclatureModel'
CREATE INDEX [IX_FK_UnitModelNomenclatureModel]
ON [dbo].[Nomenclature]
    ([Code_unit]);
GO

-- Creating foreign key on [ID_option] in table 'OptionCustomer'
ALTER TABLE [dbo].[OptionCustomer]
ADD CONSTRAINT [FK_EOptionsEOptionsCustomer]
    FOREIGN KEY ([ID_option])
    REFERENCES [dbo].[Option]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EOptionsEOptionsCustomer'
CREATE INDEX [IX_FK_EOptionsEOptionsCustomer]
ON [dbo].[OptionCustomer]
    ([ID_option]);
GO

-- Creating foreign key on [ID_reason] in table 'ReasonCustomer'
ALTER TABLE [dbo].[ReasonCustomer]
ADD CONSTRAINT [FK_ReasonModelReasonCustomerModel]
    FOREIGN KEY ([ID_reason])
    REFERENCES [dbo].[Reason]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReasonModelReasonCustomerModel'
CREATE INDEX [IX_FK_ReasonModelReasonCustomerModel]
ON [dbo].[ReasonCustomer]
    ([ID_reason]);
GO

-- Creating foreign key on [Type] in table 'Reason'
ALTER TABLE [dbo].[Reason]
ADD CONSTRAINT [FK_TypeManifestationModelReasonModel]
    FOREIGN KEY ([Type])
    REFERENCES [dbo].[TypeManifestation]
        ([Type])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TypeManifestationModelReasonModel'
CREATE INDEX [IX_FK_TypeManifestationModelReasonModel]
ON [dbo].[Reason]
    ([Type]);
GO

-- Creating foreign key on [ID_reasonCustomer] in table 'Work'
ALTER TABLE [dbo].[Work]
ADD CONSTRAINT [FK_ReasonCustomerModelWorkModel]
    FOREIGN KEY ([ID_reasonCustomer])
    REFERENCES [dbo].[ReasonCustomer]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReasonCustomerModelWorkModel'
CREATE INDEX [IX_FK_ReasonCustomerModelWorkModel]
ON [dbo].[Work]
    ([ID_reasonCustomer]);
GO

-- Creating foreign key on [ID_workingHour] in table 'Work'
ALTER TABLE [dbo].[Work]
ADD CONSTRAINT [FK_WorkingHourModelWorkModel]
    FOREIGN KEY ([ID_workingHour])
    REFERENCES [dbo].[WorkingHour]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkingHourModelWorkModel'
CREATE INDEX [IX_FK_WorkingHourModelWorkModel]
ON [dbo].[Work]
    ([ID_workingHour]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------