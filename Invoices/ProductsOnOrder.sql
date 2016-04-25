-- goal: get the names of products that are on an order
SELECT
 co.DateCreated,
 co.OrderNumber,
 p.Name,
 pt.Name as ProductTypeName,
 c.FirstName + ' ' + c.LastName AS CustomerName,
 po.Name as Payment
FROM CustomerOrder co
INNER JOIN OrderProducts op ON op.IdCustomerOrder = co.IdCustomerOrder 
INNER JOIN Product p ON p.IdProduct = op.IdProduct
INNER JOIN ProductType pt ON pt.IdProductType = p.IdProductType
INNER JOIN Customer c ON c.IdCustomer = co.IdCustomer 
INNER JOIN PaymentOption po ON po.IdPaymentOption = co.IdPaymentOption