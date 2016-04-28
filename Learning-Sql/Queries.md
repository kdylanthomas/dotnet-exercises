**[1] Provide a query showing Customers (just their full names, customer ID and country) who are not in the US.**
```SQL
SELECT
 FirstName|| " " ||LastName AS FullName,
 CustomerId,
 Country
FROM Customer
WHERE Country != 'USA';
```

**[2] Provide a query only showing the Customers from Brazil.**
```SQL
SELECT * FROM Customer
WHERE Country = 'Brazil';
```

**[3] Provide a query showing the Invoices of customers who are from Brazil. The resultant table should show the customer's full name, Invoice ID, Date of the invoice and billing country.**
```SQL
SELECT
 c.FirstName|| " " ||c.LastName AS FullName,
 i.InvoiceId,
 i.InvoiceDate,
 i.BillingCountry
FROM Customer c
INNER JOIN Invoice i ON i.CustomerId = c.CustomerId
WHERE c.Country = 'Brazil';
```

**[4] Provide a query showing only the Employees who are Sales Agents.**
```SQL
SELECT * FROM Employee
WHERE Title = 'Sales Support Agent';
```

**[5] Provide a query showing a unique list of billing countries from the Invoice table.**
```SQL 
SELECT DISTINCT BillingCountry FROM Invoice;
```

**[6] Provide a query that shows the invoices associated with each sales agent. The resultant table should include the Sales Agent's full name.**
```SQL
SELECT
 i.invoiceId,
 e.FirstName|| " "||e.LastName as EmployeeName
FROM Invoice i
INNER JOIN Customer c ON c.CustomerId = i.CustomerId
INNER JOIN Employee e ON e.EmployeeId = c.SupportRepId;
```

[7]
<!-- Provide a query that shows the Invoice Total, Customer name, Country and Sale Agent name for all invoices and customers. -->
SELECT
 i.Total,
 i.BillingCountry,
 c.FirstName||" "||c.LastName AS CustomerName,
 e.FirstName||" "||e.LastName AS SaleAgentName
FROM Invoice i
INNER JOIN Customer c ON c.CustomerId = i.CustomerId
INNER JOIN Employee e ON e.EmployeeId = c.SupportRepId;

[8]
<!-- How many Invoices were there in 2009 and 2011? What are the respective total sales for each of those years?(include both the answers and the queries used to find the answers) -->
SELECT <!-- total # of invoices: 166 -->
 COUNT(InvoiceId) AS TotalInvoices,
 InvoiceDate
FROM Invoice
WHERE InvoiceDate BETWEEN date('2009-01-01') AND date('2009-12-31')
OR InvoiceDate BETWEEN date('2011-01-01') AND date('2011-12-31');


SELECT <!-- total sales: $919.04 -->
 InvoiceId,
 InvoiceDate,
 SUM(Total) AS SumOfSales
FROM Invoice
WHERE InvoiceDate BETWEEN date('2009-01-01') AND date('2009-12-31')
OR InvoiceDate BETWEEN date('2011-01-01') AND date('2011-12-31');

[9]
<!-- Looking at the InvoiceLine table, provide a query that COUNTs the number of line items for Invoice ID 37. -->
SELECT COUNT(InvoiceId)
FROM InvoiceLine
WHERE InvoiceId = 37;

[10]
<!-- Looking at the InvoiceLine table, provide a query that COUNTs the number of line items for each Invoice. HINT: GROUP BY -->
SELECT InvoiceId, COUNT(InvoiceLineId)
FROM InvoiceLine
GROUP BY InvoiceId;

[11]
<!-- Provide a query that includes the track name with each invoice line item. -->
SELECT
 il.InvoiceLineId,
 t.Name
FROM InvoiceLine il
INNER JOIN Track t ON t.TrackId = il.TrackId;

[12]
<!-- Provide a query that includes the purchased track name AND artist name with each invoice line item. -->
SELECT
 il.InvoiceLineId,
 t.Name,
 ar.Name
FROM InvoiceLine il
INNER JOIN Track t ON t.TrackId = il.TrackId
INNER JOIN Album a ON a.AlbumId = t.AlbumId
INNER JOIN Artist ar ON ar.ArtistId = a.ArtistId;

[13]
<!-- Provide a query that shows the # of invoices per country. HINT: GROUP BY -->
SELECT
 COUNT(InvoiceId),
 BillingCountry
FROM Invoice
GROUP BY BillingCountry;

[14]
<!-- Provide a query that shows the total number of tracks in each playlist. The Playlist name should be include on the resultant table. -->
SELECT
 COUNT(pt.TrackId),
 pt.PlaylistId,
 p.Name
FROM PlaylistTrack pt
INNER JOIN Playlist p ON p.PlaylistId = pt.PlaylistId
GROUP BY p.PlaylistId;

[15]
<!-- Provide a query that shows all the Tracks, but displays no IDs. The resultant table should include the Album name, Media type and Genre. -->
SELECT
 t.Name AS TrackName,
 a.Title AS AlbumTitle,
 mt.Name AS MediaType,
 g.Name AS Genre
FROM Track t
INNER JOIN Album a ON a.AlbumId = t.AlbumId
INNER JOIN MediaType mt ON t.MediaTypeId = t.MediaTypeId
INNER JOIN Genre g ON g.GenreId = t.GenreId;

[16]
<!-- Provide a query that shows all Invoices but includes the # of invoice line items. -->
SELECT
 COUNT(il.InvoiceLineId),
 i.*
FROM InvoiceLine il
INNER JOIN Invoice i ON i.InvoiceId = il.InvoiceId
GROUP BY il.InvoiceId;

[17]
<!-- Provide a query that shows total sales made by each sales agent. -->
SELECT
 SUM(i.Total),
 e.FirstName||" "||e.LastName AS SalesAgentName
FROM Employee e
INNER JOIN Customer c ON c.SupportRepId = e.EmployeeId
INNER JOIN Invoice i ON i.CustomerId = c.CustomerId
GROUP BY e.EmployeeId;

[18]
<!-- Which sales agent made the most in sales in 2009? HINT: MAX -->
SELECT
 SUM(i.Total) AS TotalSales,
 e.FirstName||" "||e.LastName AS SalesAgentName,
 i.InvoiceDate
FROM Employee e
INNER JOIN Customer c ON c.SupportRepId = e.EmployeeId
INNER JOIN Invoice i ON i.CustomerId = c.CustomerId
WHERE i.InvoiceDate BETWEEN date('2009-01-01') AND date('2009-12-31')
GROUP BY e.EmployeeId
ORDER BY TotalSales
DESC LIMIT 1;

[19]
<!-- Which sales agent made the most in sales over all? -->
SELECT
 SUM(i.Total) AS TotalSales,
 e.FirstName||" "||e.LastName AS SalesAgentName
FROM Employee e
INNER JOIN Customer c ON c.SupportRepId = e.EmployeeId
INNER JOIN Invoice i ON i.CustomerId = c.CustomerId
GROUP BY e.EmployeeId
ORDER BY TotalSales
DESC LIMIT 1;

[20]
<!-- Provide a query that shows the # of customers assigned to each sales agent. -->
SELECT
 COUNT(CustomerId),
 SupportRepId
FROM Customer
GROUP BY SupportRepId;

[21]
<!-- Provide a query that shows the total sales per country. Which country's customers spent the most? -->
SELECT
 BillingCountry,
 SUM(Total) AS TotalSales
FROM Invoice
GROUP BY BillingCountry
ORDER BY TotalSales
DESC LIMIT 1;

[22]
<!-- Provide a query that shows the most purchased track of 2013. -->
SELECT
 t.Name,
 COUNT(t.Name) AS Total
FROM InvoiceLine il
INNER JOIN Track t ON t.TrackId = il.TrackId
INNER JOIN Invoice i ON i.InvoiceId = il.InvoiceId
WHERE i.InvoiceDate BETWEEN date('2013-01-01') AND date('2013-12-31')
GROUP BY t.Name
ORDER BY Total
DESC LIMIT 1;

[23]
<!-- Provide a query that shows the top 5 most purchased tracks over all. -->
SELECT
 t.Name,
 COUNT(t.Name) AS Total
FROM InvoiceLine il
INNER JOIN Track t ON t.TrackId = il.TrackId
INNER JOIN Invoice i ON i.InvoiceId = il.InvoiceId
GROUP BY t.Name
ORDER BY Total
DESC LIMIT 5;

[24]
<!-- Provide a query that shows the top 3 best selling artists. -->
SELECT
 ar.Name,
 COUNT(t.Name) AS Total
FROM InvoiceLine il
INNER JOIN Track t ON t.TrackId = il.TrackId
INNER JOIN Invoice i ON i.InvoiceId = il.InvoiceId
INNER JOIN Album a ON a.AlbumId = t.AlbumId
INNER JOIN Artist ar ON ar.ArtistId = a.AlbumId
GROUP BY t.Name
ORDER BY Total
DESC LIMIT 3;

[25]
<!-- Provide a query that shows the most purchased Media Type. -->
SELECT
 mt.Name AS MediaTypeName,
 COUNT(mt.Name) AS Total
FROM InvoiceLine il
INNER JOIN Track t ON t.TrackId = il.TrackId
INNER JOIN Invoice i ON i.InvoiceId = il.InvoiceId
INNER JOIN Album a ON a.AlbumId = t.AlbumId
INNER JOIN Artist ar ON ar.ArtistId = a.AlbumId
INNER JOIN MediaType mt ON mt.MediaTypeId = t.MediaTypeId
GROUP BY mt.Name
ORDER BY Total
DESC LIMIT 1;

