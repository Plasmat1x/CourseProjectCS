USE CourseProjectCStest;

CREATE TABLE Makers(
    [Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [Name] NVARCHAR(50),
);

CREATE TABLE Types(
    [Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [Name] NVARCHAR(50),
);

CREATE TABLE Countries(
    [Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [Name] NVARCHAR(50),
);

CREATE TABLE Items(
    [Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [Name] NVARCHAR(50),
    [Model] NVARCHAR(50),
    [Maker] INT FOREIGN KEY REFERENCES Makers(Id),
    [Type] INT FOREIGN KEY REFERENCES Types(Id),
    [Weight] INT,
    [Release] DATE,
);

CREATE TABLE Sellings(
    [ItemId] INT FOREIGN KEY REFERENCES Items(Id) NOT NULL,
    [Date] DATE,
);

CREATE TABLE ItemCountry(
    [Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
    [ItemId] INT FOREIGN KEY REFERENCES Items(Id) NOT NULL,
    [CountryId] INT FOREIGN KEY REFERENCES Countries(Id) NOT NULL,
);

CREATE TABLE Fails(
    [ItemCountryId] INT FOREIGN KEY REFERENCES ItemCountry(Id),
    [Quantity] INT,
);

CREATE TABLE Quantities(
    [ItemCountryId] INT FOREIGN KEY REFERENCES ItemCountry(Id),
    [Quantity] INT,
)