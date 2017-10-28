CREATE TABLE [dbo].[Contacts] (
    [ID]    INT          IDENTITY (1, 1) NOT NULL,
    [FName] VARCHAR (50) NULL,
    [LName] VARCHAR (50) NULL,
    [Email] VARCHAR (50) NULL,
    CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED ([ID] ASC)
);

