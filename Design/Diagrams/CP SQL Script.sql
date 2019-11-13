USE [master]
GO
/****** Object:  Database [IMSDB]    Script Date: 11/1/2019 11:07:09 AM ******/
CREATE DATABASE [IMSDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IMSDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MAHESHSQL\MSSQL\DATA\IMSDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'IMSDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MAHESHSQL\MSSQL\DATA\IMSDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [IMSDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IMSDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IMSDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IMSDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IMSDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IMSDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IMSDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [IMSDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [IMSDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IMSDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IMSDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IMSDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IMSDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IMSDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IMSDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IMSDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IMSDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [IMSDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IMSDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IMSDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IMSDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IMSDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IMSDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IMSDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IMSDB] SET RECOVERY FULL 
GO
ALTER DATABASE [IMSDB] SET  MULTI_USER 
GO
ALTER DATABASE [IMSDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IMSDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IMSDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IMSDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [IMSDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'IMSDB', N'ON'
GO
ALTER DATABASE [IMSDB] SET QUERY_STORE = OFF
GO
USE [IMSDB]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[cat_id] [int] IDENTITY(1,1) NOT NULL,
	[cat_name] [varchar](50) NOT NULL,
	[cat_isActive] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[pro_id] [int] IDENTITY(1,1) NOT NULL,
	[pro_name] [varchar](50) NOT NULL,
	[pro_barcode] [nvarchar](100) NOT NULL,
	[pro_price] [money] NOT NULL,
	[pro_expiry] [date] NULL,
	[pro_catID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[pro_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [barcodeUnique] UNIQUE NONCLUSTERED 
(
	[pro_barcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [uniqueProduct] UNIQUE NONCLUSTERED 
(
	[pro_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchaseInvoice]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchaseInvoice](
	[pi_id] [bigint] IDENTITY(1,1) NOT NULL,
	[pi_date] [date] NOT NULL,
	[pi_doneBy] [int] NOT NULL,
	[pi_suppID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[pi_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[purchaseInvoiceDetails]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[purchaseInvoiceDetails](
	[pid_id] [bigint] IDENTITY(1,1) NOT NULL,
	[pid_purchaseID] [bigint] NOT NULL,
	[pid_proID] [int] NOT NULL,
	[pid_proquan] [int] NOT NULL,
	[pid_totprice] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[pid_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stock]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock](
	[st_proID] [int] NOT NULL,
	[st_quan] [int] NOT NULL,
UNIQUE NONCLUSTERED 
(
	[st_proID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[supplier]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[supplier](
	[sup_id] [int] IDENTITY(1,1) NOT NULL,
	[sup_company] [varchar](100) NOT NULL,
	[sup_contactPerson] [varchar](50) NOT NULL,
	[sup_phone1] [varchar](15) NOT NULL,
	[sup_phone2] [varchar](15) NULL,
	[sup_address] [varchar](100) NOT NULL,
	[sup_ntn] [varchar](25) NULL,
	[sup_status] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[sup_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[sup_company] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[trackDeletedItemPI]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trackDeletedItemPI](
	[pi_id] [bigint] NOT NULL,
	[usr_id] [int] NOT NULL,
	[pro_id] [int] NOT NULL,
	[pro_quan] [int] NOT NULL,
	[del_date] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[usr_id] [int] IDENTITY(1,1) NOT NULL,
	[usr_name] [varchar](50) NOT NULL,
	[usr_username] [varchar](50) NOT NULL,
	[usr_password] [nvarchar](50) NOT NULL,
	[usr_phone] [varchar](50) NOT NULL,
	[usr_email] [varchar](50) NOT NULL,
	[usr_status] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[usr_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[users] ADD  DEFAULT ((1)) FOR [usr_status]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK__products__pro_ca__6A30C649] FOREIGN KEY([pro_catID])
REFERENCES [dbo].[categories] ([cat_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK__products__pro_ca__6A30C649]
GO
ALTER TABLE [dbo].[purchaseInvoiceDetails]  WITH CHECK ADD FOREIGN KEY([pid_purchaseID])
REFERENCES [dbo].[purchaseInvoice] ([pi_id])
GO
ALTER TABLE [dbo].[trackDeletedItemPI]  WITH CHECK ADD FOREIGN KEY([pro_id])
REFERENCES [dbo].[products] ([pro_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
/****** Object:  StoredProcedure [dbo].[s_productDelete]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[s_productDelete]
@proID int
as
delete from products where pro_id = @proID
GO
/****** Object:  StoredProcedure [dbo].[st_deleteCategory]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_deleteCategory]
@id int
as
delete from categories where cat_id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_deleteProductFromPID]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_deleteProductFromPID]
 @mPID bigint
 as
 delete from purchaseInvoiceDetails
 where pid_id =@mPID
GO
/****** Object:  StoredProcedure [dbo].[st_deleteSupplier]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_deleteSupplier]
@suppID int
as
delete from supplier where sup_id = @suppID
GO
/****** Object:  StoredProcedure [dbo].[st_deleteuser]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_deleteuser]
@id int
as 
delete from users where usr_id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_getALLStock]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getALLStock]
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
GO
/****** Object:  StoredProcedure [dbo].[st_getCategoriesDate]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getCategoriesDate]
as
select
c.cat_id as 'ID',
c.cat_name as 'Category',
case when (c.cat_isActive = 1) then 'Yes' else 'No' end as 'Status'
from categories c
order by c.cat_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getCategoriesList]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getCategoriesList]
as
select c.cat_id as 'ID',
c.cat_name as 'Category'
from categories c
order by c.cat_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getLastPurchaseID]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getLastPurchaseID]
 as select top 1 pii.pi_id from purchaseInvoice pii order by pii.pi_id desc
GO
/****** Object:  StoredProcedure [dbo].[st_getProductByBarcode]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getProductByBarcode]
@barcode nvarchar(100)
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
ROUND(p.pro_price,2) as 'Price',
p.pro_barcode as 'Barcode'
from products p where p.pro_barcode = @barcode

GO
/****** Object:  StoredProcedure [dbo].[st_getProductData]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getProductData]
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
format(p.pro_expiry,'dd-MMM-yyyy') as 'Expiry',
p.pro_price as 'price',
p.pro_barcode as 'Barcode',
c.cat_name as 'Category',
c.cat_id as 'Category ID'
from products p
inner join categories c
on c.cat_id = p.pro_catID
GO
/****** Object:  StoredProcedure [dbo].[st_getProductQuantity]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getProductQuantity]
@proID int
as
select s.st_quan as 'Quantity' from stock s where s.st_proID = @proID
GO
/****** Object:  StoredProcedure [dbo].[st_getProductsData]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getProductsData]
as
select
p.pro_id as 'Product ID',
p.pro_name as 'Product',
format(p.pro_expiry,'dd-MMM-yyyy') as 'Expiry',
p.pro_price as 'price',
p.pro_barcode as 'Barcode',
c.cat_name as 'Category',
c.cat_id as 'Category ID'
from products p
inner join categories c
on c.cat_id = p.pro_catID
GO
/****** Object:  StoredProcedure [dbo].[st_getPurchaseINvoiceDetails]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getPurchaseINvoiceDetails]
@pid bigint
as
select
pid.pid_id as 'mPID',
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
GO
/****** Object:  StoredProcedure [dbo].[st_getPurchaseInvoiceList]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getPurchaseInvoiceList]
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
GO
/****** Object:  StoredProcedure [dbo].[st_getSupplierData]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getSupplierData]
as
select
s.sup_id as 'ID',
s.sup_company as 'Company',
s.sup_contactPerson as 'Contact Person',
s.sup_phone1 as 'Phone1',
s.sup_phone2 as 'Phone2',
s.sup_ntn as 'NTN #',
s.sup_address as 'Address',
case when (s.sup_status = 1) then 'Active' else 'In-active' end as 'Status'
from supplier s order by s.sup_company asc

GO
/****** Object:  StoredProcedure [dbo].[st_getSupplierList]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getSupplierList]
as
select s.sup_id as 'ID',s.sup_company as 'Company' from supplier s where s.sup_status = 1 order by s.sup_company asc
GO
/****** Object:  StoredProcedure [dbo].[st_getUserDetails]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_getUserDetails]
@user varchar(50),
@pass nvarchar(50)
as
select
u.usr_id as 'ID',
u.usr_name as 'Name',
u.usr_username as 'Username',
u.usr_password as 'Password' from users u
where
u.usr_name = @user
and
u.usr_password = @pass
GO
/****** Object:  StoredProcedure [dbo].[st_getUsersData]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getUsersData]
as
select
u.usr_id as 'ID',
u.usr_name as 'Name',
u.usr_username as 'Username',
u.usr_password as 'Password',
u.usr_phone as 'Phone',
u.usr_email as 'Email',
case when (usr_status = 1) then 'Active' else 'In-active' end as 'Status'
from users u
order by u.usr_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_getUsersDataLike]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_getUsersDataLike]
@data varchar(50)
as
select
u.usr_id as 'ID',
u.usr_name as 'Name',
u.usr_username as 'Username',
u.usr_password as 'Password',
u.usr_phone as 'Phone',
u.usr_email as 'Email',
case when (usr_status = 1) then 'Active' else 'In-active' end as 'Status'
from users u
where u.usr_name like '%'+@data+'%'
or
u.usr_username like '%'+@data+'%'
or
u.usr_phone like '%'+@data+'%'
or
u.usr_email like '%'+@data+'%'
 
order by u.usr_name asc
GO
/****** Object:  StoredProcedure [dbo].[st_insertCategory]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertCategory]
@name varchar(50),
@isActive tinyint
as
insert into categories values (@name,@isActive)
GO
/****** Object:  StoredProcedure [dbo].[st_insertDeletedItemPI]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertDeletedItemPI]
@pi bigint,
@usrID int,
@proID int,
@quan int,
@date date
as
insert into trackDeletedItemPI values(@pi,@usrID,@proID,@quan,@date)
GO
/****** Object:  StoredProcedure [dbo].[st_insertPurchaseINvoice]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE procedure [dbo].[st_insertPurchaseINvoice]
 @date date,
 @doneBy int,
 @suppID int 
 as
 Insert into purchaseInvoice values (@date, @doneBy, @suppID)
GO
/****** Object:  StoredProcedure [dbo].[st_insertPurchaseInvoiceDetails]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertPurchaseInvoiceDetails]
 @purchaseID bigint,
 @proID int,
 @quan int,
 @totPrice money
 as 
 insert into purchaseInvoiceDetails values (@purchaseID,@proID,@quan,@totPrice)
GO
/****** Object:  StoredProcedure [dbo].[st_insertStock]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_insertStock]
@proID int,
@quan int
as
insert into stock values (@proID,@quan)
GO
/****** Object:  StoredProcedure [dbo].[st_insertSupplier]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_insertSupplier]
@company varchar(100),
@conPerson varchar(50),
@phone1 varchar(15),
@phone2 varchar(15),
@address nvarchar(100),
@ntn varchar (25),
@status tinyint
as
insert into supplier values (@company,@conPerson,@phone1,@phone2,@address,@ntn,@status)
GO
/****** Object:  StoredProcedure [dbo].[st_insertUsers]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_insertUsers]
@name varchar(50),
@username varchar(50),
@pwd nvarchar(50),
@phone varchar(50),
@email varchar(50),
@status tinyint
as
insert into users 
values (@name,@username,@pwd,@phone,@email,@status)
GO
/****** Object:  StoredProcedure [dbo].[st_productInsert]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_productInsert]
@name varchar(50),
@barcode nvarchar(100),
@price money,
@expiry date,
@catID int
as
insert into products values (@name,@barcode,@price,@expiry,@catID)
GO
/****** Object:  StoredProcedure [dbo].[st_productUpdate]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_productUpdate]
@name varchar(50),
@barcode nvarchar(100),
@price money,
@expiry date,
@catID int,
@proID int
as
update products
set
pro_name = @name,
pro_expiry = @expiry,
pro_price = @price,
pro_catID = @catID,
pro_barcode = @barcode
where
pro_id = @proID
GO
/****** Object:  StoredProcedure [dbo].[st_updateCategory]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_updateCategory]
@name varchar(50),
@isActive tinyint,
@id int
as
update categories
set
cat_name = @name,
cat_isActive = @isActive
where cat_id = @id
GO
/****** Object:  StoredProcedure [dbo].[st_updateStock]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_updateStock]
@proID int,
@quan int
as
update stock
set st_quan = @quan
where
st_proID = @proID
GO
/****** Object:  StoredProcedure [dbo].[st_updateSupplier]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[st_updateSupplier]
@company varchar(100),
@conPerson varchar(50),
@phone1 varchar(15),
@phone2 varchar(15),
@address nvarchar(100),
@ntn varchar (25),
@status tinyint,
@suppID int
as
update supplier
set
sup_company = @company,
sup_contactPerson = @conPerson,
sup_phone1 = @phone1,
sup_phone2 = @phone2,
sup_address = @address,
sup_ntn = @ntn,
sup_status = @status
where
sup_id = @suppID
GO
/****** Object:  StoredProcedure [dbo].[st_updateUsers]    Script Date: 11/1/2019 11:07:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[st_updateUsers]
@name varchar(50),
@username varchar(50),
@pwd nvarchar(50),
@phone varchar(50),
@email varchar(50),
@status tinyint,
@id int
as
update users
set
usr_name=@name,
usr_username=@username,
usr_password=@pwd,
usr_phone=@pwd,
usr_email=@email,
usr_status = @status
where
usr_id = @id
GO
USE [master]
GO
ALTER DATABASE [IMSDB] SET  READ_WRITE 
GO
