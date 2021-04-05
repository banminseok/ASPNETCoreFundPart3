USE [CompanyApp]
GO

drop table Companies
go
CREATE TABLE [dbo].[Companies] (
    [Id]   BIGINT  Primary key Identity(1,1),
    [Name] NVARCHAR (255) NOT NULL
);


