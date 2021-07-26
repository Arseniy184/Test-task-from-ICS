CREATE TABLE [dbo].[Workers] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL ,
    [Name]          NVARCHAR (50) NOT NULL,
    [Surname]       NVARCHAR (50) NOT NULL,
    [Position]      NVARCHAR (50) NOT NULL,
    [Year_of_birth] DATE          NOT NULL,
    [Salary]        MONEY         NOT NULL,
    CONSTRAINT [PK_Workers] PRIMARY KEY CLUSTERED ([Id] ASC)
);

