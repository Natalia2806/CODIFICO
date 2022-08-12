
	DECLARE @Freight TABLE( shipperid INT, TotalFreight MONEY )

	INSERT INTO @Freight
	SELECT shipperid, SUM(freight) FROM Sales.Orders  group by [shipperid]

	SELECT companyname AS CompanyName, freght.TotalFreight, 
		SUM(details.[unitprice] * details.[qty]) AS TotalCostShipped, 
		SUM(details.[qty]) AS TotalItemShipped 

	FROM Sales.OrderDetails details

	INNER JOIN  Sales.Orders AS orders ON details.orderid = orders.orderid
	INNER JOIN Sales.Shippers AS shippers ON shippers.shipperid = orders.shipperid
	INNER JOIN @Freight AS freght ON freght.shipperid = orders.shipperid

	GROUP BY companyname, freght.TotalFreight
	ORDER BY companyname ASC