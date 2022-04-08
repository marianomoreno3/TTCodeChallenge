
CREATE TABLE #Customer (
    [FirstName] VARCHAR(255) NULL,
    [LastName] VARCHAR(255) NULL,
    [Age] INTEGER NULL,
    [Occupation] VARCHAR(255) NULL,
    [MaritalStatus] VARCHAR(255) NULL,
    [PersonID] INTEGER NULL
);
GO

INSERT INTO #Customer (FirstName,LastName,Age,Occupation,MaritalStatus,PersonID)
VALUES
  ('Haviva','Dickerson',84,'Dr.','Married',6),
  ('Dexter','Burgess',73,'Mrs.','Common-Law',10),
  ('Rajah','Galloway',22,'Ms.','Common-Law',2),
  ('Nita','Mcleod',65,'Dr.','Divorced',5),
  ('Fuller','Spears',69,'Dr.','Divorced',1);



CREATE TABLE #Orders (
    [OrderID] INTEGER NULL,
    [PersonID] INTEGER NULL,
    [DateCreated] VARCHAR(255) NULL,
    [MethodofPurchase] VARCHAR(255) NULL
);
GO

INSERT INTO #Orders (OrderID,PersonID,DateCreated,MethodOfPurchase)
VALUES
  (1,4,'20212217','Debit Card'),
  (2,5,'20232211','Cash'),
  (3,6,'20232806','Cash'),
  (4,1,'20205926','Transfer'),
  (5,7,'20210609','Credit card');

  

CREATE TABLE #OrderDetails (
    OrderID INTEGER NULL,
    OrderDetailID INTEGER NULL,
    ProductNumber VARCHAR(255) NULL,
    ProductID VARCHAR(255) NULL,
    ProductOrigin VARCHAR(255) NULL
);
GO

INSERT INTO #OrderDetails (OrderID, OrderDetailID, ProductNumber, ProductID, ProductOrigin)
VALUES
  (2,1,'4545462144', 'AZ234234Q', 'MEXICO'),
  (2,2,'7879879765', 'QA465465T', 'USA'),
  (2,3,'2122247878', 'WR456465G', 'ITALY'),
  (2,4,'2122247876', '1112222333', 'ITALY'),
  (3,5,'7879879765', 'QA465465T', 'USA'),
  (3,6,'2122247334', 'WR456464G', 'ITALY'),
  (3,7,'2122247878', '1112222333', 'ARGENTINA')


 select 
	FirstName + ' ' + LastName as 'Full name', 
	Age, 
	ord.OrderID, 
	DateCreated, 
	MethodOfPurchase as 'Purchase Method', 
	ProductNumber, 
	ProductOrigin
 from #Customer cus
  inner join #Orders ord on cus.PersonID = ord.PersonID
  inner join #OrderDetails odd on ord.OrderID = odd.OrderID
  where odd.ProductID = '1112222333'


drop table #OrderDetails
drop table #Orders
drop table #Customer