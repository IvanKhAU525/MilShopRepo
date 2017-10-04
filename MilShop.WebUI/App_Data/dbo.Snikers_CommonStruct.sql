CREATE TABLE [dbo].[Snikers]
(
	[Id]		INT NOT NULL PRIMARY KEY,
	[ModelName] NVARCHAR(50),
	[Color]		INT,
	[Size]		INT,
	[Price]		INT,
	[Count]		INT, 
    CONSTRAINT [FK_Snikers_Colors] FOREIGN KEY ([Color]) REFERENCES [Colors]([Id]) ON DELETE SET NULL,
	CONSTRAINT [FK_Snikers_Sizes] FOREIGN KEY ([Size]) REFERENCES [Sizes]([Id]) ON DELETE SET NULL,
	CONSTRAINT [FK_Snikers_Prices] FOREIGN KEY ([Price]) REFERENCES [Prices]([Id]) ON DELETE SET NULL
)
