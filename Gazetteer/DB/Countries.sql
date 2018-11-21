CREATE TABLE Countries
(
	[CountryName] NVARCHAR(50) NOT NULL PRIMARY KEY, 
    [CountryArea] INT NOT NULL, 
    [CountryPopulation] INT NOT NULL, 
    [CountryCapital] NVARCHAR(50) NOT NULL, 
    [CountryGovernment] NVARCHAR(MAX) NOT NULL, 
    [CountryLeader] NVARCHAR(MAX) NOT NULL, 
    [CountryGDP] MONEY NOT NULL, 
    [ContinentName] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [FK_CountriesToContinents] FOREIGN KEY ([ContinentName]) REFERENCES [Continents]([ContinentName]) 
)
