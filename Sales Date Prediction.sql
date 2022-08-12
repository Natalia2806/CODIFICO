
	SELECT companyname, 
		   MAX(orderdate) AS LastOrderDate, 
		   DATEADD(DAY,DATEDIFF(DAY,MIN(orderdate),MAX(orderdate))/COUNT(orderdate), MAX(orderdate)) AS NextPredictedOrder
		   
	FROM [Sales].[Orders] AS orders
	INNER JOIN [Sales].[Customers] AS customers ON customers.custid = orders.custid

	GROUP BY companyname