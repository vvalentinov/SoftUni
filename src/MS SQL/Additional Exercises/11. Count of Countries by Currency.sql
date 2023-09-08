SELECT crr.CurrencyCode,
	   crr.[Description] AS [Currency],
	   COUNT(C.CountryCode) AS [NumberOfCountries]
FROM Currencies crr
LEFT JOIN Countries c ON crr.CurrencyCode = c.CurrencyCode
GROUP BY crr.CurrencyCode, crr.[Description]
ORDER BY COUNT(C.CountryCode) DESC, crr.[Description]