UPDATE Countries
SET CountryName = 'Burma'
WHERE CountryName = 'Myanmar'

INSERT INTO Monasteries ([Name], [CountryCode])
(
select 'Hanga Abbey',
		CountryCode
from Countries
where CountryName = 'Tanzania'
)

INSERT INTO Monasteries ([Name], [CountryCode])
(
select 'Myin-Tin-Daik',
		CountryCode
from Countries
where CountryName = 'Myanmar'
)

SELECT c.ContinentName,
	   ct.CountryName,
	   COUNT(m.Id) as [MonasteriesCount]
FROM Countries ct
LEFT JOIN Continents c ON ct.ContinentCode = c.ContinentCode
LEFT JOIN Monasteries m ON m.CountryCode = ct.CountryCode
WHERE ct.IsDeleted = 0
GROUP BY ct.CountryName,c.ContinentName
ORDER BY COUNT(m.Id) DESC, ct.CountryName