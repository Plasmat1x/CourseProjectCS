
# Запросы T-SQL

```sql

-- most high price
SELECT Types.Name, Items.Price FROM Items
INNER JOIN Types ON Types.Id = Items.Type_Id
INNER JOIN Makers ON Makers.Id = Items.Maker_Id
WHERE (SELECT MAX(Price) FROM Items) = Items.Price;

-- most lowest price
SELECT Types.Name, Items.Price FROM Items
INNER JOIN Types ON Types.Id = Items.Type_Id
INNER JOIN Makers ON Makers.Id = Items.Maker_Id
WHERE (SELECT MIN(Price) FROM Items) = Items.Price;

--avg price at all per type
SELECT Types.Name, AVG(Price) as avgPrice FROM Items
INNER JOIN Types ON Types.Id = Items.Type_Id
INNER JOIN Makers ON Makers.Id = Items.Maker_Id
GROUP BY Types.Name;

--avg price at all electronic
SELECT AVG(Price) as avgPrice FROM Items;

-- Get sellings at period
GO
CREATE PROCEDURE GetSellsAtPeriod @d1 DATETIME, @d2 DATETIME
AS
SELECT * FROM Sellings WHERE @d1 <= Sellings.Date and @d2 >= Sellings.Date;

-- Get most popular item

SELECT Items.Id, Items.Name, 
    (SELECT COUNT(*) 
    FROM Sellings 
    INNER JOIN Items ON Items.Id = Sellings.ItemId  
    WHERE Items.Id = Sellings.ItemId) as cnt 
FROM Items 
JOIN Sellings ON Items.Id = Sellings.ItemId 
GROUP BY Items.Id 
ORDER BY COUNT(Items.Id) DESC; -- LIMIT 1;

-- Get cheape item below entered price
GO
CREATE PROCEDURE GetCheapestAtVal @val1 DECIMAL @maker INT
AS
SELECT (SELECT COUNT(*) FROM Items WHERE Items.Price < @val ) as Count
FROM Items
GROUP BY Items.Name;

--get count fails by maker and cuntry
GO
CREATE PROCEDURE GetFailAtMakerACounty @maker INT, @country INT
AS
SELECT Makers.Name, Countries.Name, COUNT(*)
FROM ItemCountries
INNER JOIN Items ON Items.Id = ItemCountries.ItemId
INNER JOIN Makers ON Makers.Id = Items.Maker_Id
INNER JOIN Countries ON Countries.Id = ItemCountries.CountryId
INNER JOIN Fails ON ItemCountries.FailId = Fails.Id
WHERE Items.Maker_Id = @maker AND CountryId = @country;

```