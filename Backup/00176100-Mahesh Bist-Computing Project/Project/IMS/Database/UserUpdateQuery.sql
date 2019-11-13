USE [IMSDB]
GO
/****** Object:  StoredProcedure [dbo].[st_updateUsers]    Script Date: 9/16/2019 12:18:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[st_updateUsers]
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