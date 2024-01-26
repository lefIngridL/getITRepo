--SELECT TOP (1000) [ID]
--,[Color]
--FROM [TextObjects].[dbo].[Color]

SELECT t.[Index], t.Text, c1.Color ForeColor, c2.Color BackColor
FROM TextObject_link t
JOIN Color c1 ON t.ForeColor = c1.ID
JOIN Color c2 ON t.BackColor = c2.ID

INSERT INTO TextObject VALUES (7, 'RHO', 4, 5)