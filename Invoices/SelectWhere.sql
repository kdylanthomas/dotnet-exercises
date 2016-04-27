-- This query is for practice with INSERT INTO, SELECT, and WHERE

--INSERT INTO Customer
--(IdCustomer, FirstName, LastName, StreetAddress, City, StateProvince, PostalCode, PhoneNumber)
--VALUES
--(987, 'Dylan', 'Thomas', '3100 Vanderbilt Place', 'Nashville', 'TN', 37212, '423-532-9414');

--SELECT
  --co.IdCustomer,
  --co.FirstName, 
  --co.LastName
--from Customer co
--where co.IdCustomer = 987;


--INSERT INTO product
--(IdProduct, Name, [Description], Price, IdProductType) -- description in brackets to distinguish from reserved word
--values
--(4, 'Confetti', 'Throw a surprise party', 4.99, 1)


--INSERT INTO productType
--(IdProductType, Name, [Description])
--VALUES
--(4, 'Electronics', 'technology for your life');


--INSERT INTO paymentOption
--(IdPaymentOption, IdCustomer, Name, AccountNumber)
--VALUES
--(501, 987, 'MasterCard', 900);

--SELECT * FROM OrderProducts

--INSERT INTO CustomerOrder 
--(IdCustomerOrder, IdProduct, OrderNumber, DateCreated, IdCustomer, PaymentType, Shipping, IdPaymentOption)
--VALUES
--(2, 4, 234, '2016-04-27', 987, 'Debit', 'UPS', 501);


--INSERT INTO OrderProducts
--(IdOrderProducts, IdProduct, IdCustomerOrder)
--VALUES
--(112, 4, 2);

--SELECT * FROM CustomerOrder
--SELECT * FROM OrderProducts

--SELECT 
--co.DateCreated,
--co.OrderNumber,
--co.IdCustomer,
--p.Name AS ProductName,
--c.FirstName + ' ' + c.LastName AS CustomerName
--FROM customerOrder co
--INNER JOIN Product p ON p.IdProduct = co.IdProduct
--INNER JOIN Customer c ON c.IdCustomer = co.IdCustomer
--WHERE co.IdCustomer = 987;

--SELECT 
--co.*
--FROM CustomerOrder co
--WHERE co.PaymentType = 'Credit'
--OR co.Shipping = 'UPS';

--SELECT 
--p.*
--FROM Product p
--WHERE p.price > 12.00;


-- !! use OUTER JOIN to find fields with no values, e.g. customers who have placed no orders

SELECT
 co.OrderNumber,
 c.FirstName
FROM CustomerOrder co
RIGHT OUTER JOIN Customer c on co.IdCustomer = c.IdCustomer
WHERE co.OrderNumber is NULL