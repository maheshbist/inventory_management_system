alter procedure st_getPurchaseInvoiceList
@month int,
@year int
as
select
pii.pi_id as 'ID',
su.sup_company+', '+format(pii.pi_date,'dd-MMM-yyyy') as 'Company'
from purchaseInvoice pii
inner join supplier su
on su.sup_id = pii.pi_suppID
where
month(pii.pi_date)=@month and year(pii.pi_date)=@year


create procedure st_getPurchaseINvoiceDetails
@pid bigint
as
select
pid.pid_proID as 'Product ID',
p.pro_name as 'Product',
pid.pid_proquan as 'Qunatity',
pid.pid_totprice as 'Total Price',
p.pro_price as 'Per Unit Price'
from purchaseInvoice pii
inner join purchaseInvoiceDetails pid
inner join products p on p.pro_id = pid.pid_proID
on pii.pi_id = pid.pid_purchaseID
where pii.pi_id = @pid