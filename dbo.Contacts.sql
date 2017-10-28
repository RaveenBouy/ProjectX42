CREATE TABLE [dbo].[Contacts] (
    [ID]    INT NOT NULL IDENTITY,
    [FName] VARCHAR (50) NULL,
    [LName] VARCHAR (50) NULL,
    [Email] VARCHAR (50) NULL, 
    CONSTRAINT [PK_Contacts] PRIMARY KEY ([ID]) 
);

