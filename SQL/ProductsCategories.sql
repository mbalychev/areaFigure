SELECT
    p.ProductName,
    COALESCE(c.CategoryName, 'Нет категории') AS CategoryName
FROM
    Products p
    LEFT JOIN ProductCategoriesLinks links ON p.ProductID = link.ProductID
    LEFT JOIN Categories c ON links.CategoryID = c.CategoryID;