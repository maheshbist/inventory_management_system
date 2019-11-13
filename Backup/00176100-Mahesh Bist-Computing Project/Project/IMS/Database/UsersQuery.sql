Create database IMSDB

use IMSDB

create table users
(
usr_id int not null identity primary key,
usr_name varchar(50) not null,
usr_username varchar(50) not null,
usr_password nvarchar(50) not null,
usr_phone varchar(50) not null,
usr_email varchar(50) not null,
usr_status tinyint not null default 1
)

create procedure st_insertUsers
@name varchar(50),
@username varchar(50),
@pwd nvarchar(50),
@phone varchar(50),
@email varchar(50)
as
insert into users (usr_name,usr_username,usr_password,usr_phone,usr_email) 
values (@name,@username,@pwd,@phone,@email)

create procedure st_updateUsers
@name varchar(50),
@username varchar(50),
@pwd nvarchar(50),
@phone varchar(50),
@email varchar(50),
@id int
as
update users
set
usr_name=@name,
usr_username=@username,
usr_password=@pwd,
usr_phone=@pwd,
usr_email=@email
where
usr_id = @id

create procedure st_deleteuser
@id int
as 
delete from users where usr_id = @id


create procedure st_getUsersData
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