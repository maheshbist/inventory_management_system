USE [IMSDB]
GO
/****** Object:  StoredProcedure [dbo].[st_insertUsers]    Script Date: 9/15/2019 10:34:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[st_insertUsers]
@name varchar(50),
@username varchar(50),
@pwd nvarchar(50),
@phone varchar(50),
@email varchar(50),
@status tinyint
as
insert into users 
values (@name,@username,@pwd,@phone,@email,@status)