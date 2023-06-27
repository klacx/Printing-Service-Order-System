CREATE TABLE [dbo].[userProfile] (
    [username]   NVARCHAR (50) NOT NULL,
    [password]   NCHAR (12)    NOT NULL,
    [permission] NCHAR (10)    NOT NULL,
    [DoB]        DATE          NULL,
    [firstName]  NCHAR (10)    NULL,
    [lastName]   NCHAR (10)    NULL,
    [phone]      INT           NULL,
    [intake]     NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([username] ASC)
);