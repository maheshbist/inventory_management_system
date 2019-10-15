create procedure st_getCategoriesDataLIKE
@data varchar(50)
as
select
u.usr_id as 'ID',
u.usr_name as 'Name',

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