SELECT * FROM Items;

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