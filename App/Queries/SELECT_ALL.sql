SELECT
    items.id,
    items.name,
    items.model,
    makers.name as maker,
    types.name as type,
    items.weight,
    items.release,
    items.price,
    items.selldate
FROM items
INNER JOIN makers ON makers.id = items.maker
INNER JOIN types ON types.id = items.type