 create table purchaseInvoice
 (
 pi_id bigint not null identity primary key,
 pi_date date not null,
 pi_doneBy int not null,
 pi_suppID int not null
 )

 create procedure st_insertPurchaseINvoice
 @date date,
 @doneBy int,
 @suppID int
 as
 Insert into purchaseInvoice values (@date, @doneBy, @suppID)

 create procedure st_getLastPurchaseID
 as 
 select top 1 pii.pi_id from purchaseInvoice pii order by pii.pi_id desc


 create table purchaseInvoiceDetails
 (
 pid_id bigint not null identity primary key,
 pid_purchaseID bigint not null foreign key references purchaseInvoice(pi_id),
 pid_proID int not null,
 pid_proquan int not null,
 pid_totprice money not null
 )

 create procedure st_insertPurchaseInvoiceDetails
 @purchaseID bigint,
 @proID int,
 @quan int,
 @totPrice money
 as 
 insert into purchaseInvoiceDetails values (@purchaseID,@proID,@quan,@totPrice)


 create procedure st_deleteProductFromPID
 @mPID bigint
 as
 delete from purchaseInvoiceDetails
 where pid_id =@mPID