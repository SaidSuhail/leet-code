# Write your MySQL query statement below
SELECT S.product_id, S.year AS first_year, S.quantity, S.price FROM Sales S
JOIN (
    SELECT product_id, MIN(year) AS first_year
    FROM Sales
    GROUP BY product_id
) AS FirstSales
ON S.product_id = FirstSales.product_id AND S.year = FirstSales.first_year;
