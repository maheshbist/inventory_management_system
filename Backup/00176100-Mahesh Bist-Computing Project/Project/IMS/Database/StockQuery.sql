create table stock
(
st_proID int not null unique,
st_quan int not null
)

create procedure st_insertStock
@proID int,
@quan int
as
insert into stock values (@proID,@quan)


create procedure st_updateStock
@proID int,
@quan int
as
update stock
set st_quan = @quan
where
st_proID = @proID


create procedure st_getProductQuantity
@proID int
as
select s.st_quan as 'Quantity' from stock s where s.st_proID = @proID


DELETE FROM purchaseInvoiceDetails
DBCC CHECKINENT ('purchaseInvoiceDetails', RESEED, 0)


DELETE FROM purchaseInvoice
DBCC CHECKINENT ('purchaseInvoice', RESEED, 0)


create table trackDeletedItemPI
(
pi_id bigint not null,
usr_id int not null,
pro_id int not null foreign key references products(pro_id)
on delete cascade on update cascade,
pro_quan int not null
)

alter procedure st_insertDeletedItemPI
@pi bigint,
@usrID int,
@proID int,
@quan int,
@date date
as
insert into trackDeletedItemPI values(@pi,@usrID,@proID,@quan,@date)


alter table trackDeletedItemPI
add del_date date not null


alter procedure st_getALLStock
as
select 
p.pro_id as 'Product ID',
p.pro_name as 'Product',
p.pro_barcode as 'Barcode',
format(p.pro_expiry,'dd-MMM-yyyy') as 'Expiry Date',
p.pro_price as 'Price',
c.cat_name as 'Category',
s.st_quan as 'Available Stock',
case when (s.st_quan < 50) then 'LOW' else case when (s.st_quan <100 and s.st_quan>50) then 'Average' else case when (s.st_quan >=100) then 
'Good' end end end as 'Status',
p.pro_price * s.st_quan as 'Total Amount'
from stock s
inner join products p
on p.pro_id = s.st_proID
inner join categories c
on c.cat_id = p.pro_catID

