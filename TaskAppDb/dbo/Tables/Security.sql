CREATE TABLE [dbo].[Security]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [SID] INT NOT NULL, 
    [username] NVARCHAR(50) NOT NULL, 
    [password] NVARCHAR(50) NOT NULL
	)
