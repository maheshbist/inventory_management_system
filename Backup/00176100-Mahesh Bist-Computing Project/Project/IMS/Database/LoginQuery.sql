create procedure st_getUserDetails
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