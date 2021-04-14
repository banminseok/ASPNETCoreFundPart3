CREATE TABLE [dbo].[Users] (
    [Id]      INT           IDENTITY (1, 1) Primary Key NOT NULL,
    [UserID]   NVARCHAR (25) NOT NULL,
    [UserName]   NVARCHAR (50) NULL,
    [Password] NVARCHAR (20) NOT NULL
);