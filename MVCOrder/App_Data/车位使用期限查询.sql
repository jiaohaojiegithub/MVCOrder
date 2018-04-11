--18.车位使用期限查询表								
--序号	使用期限	停车类别	车位号	房号	层别	有效期	用户姓名	联系电话
create procedure 车位使用期限查询
as
begin
select ROW_NUMBER() over(order by a.有效期) 序号,a.*
from (
select 
(case when c.validdt is not null and DATEDIFF(day,GETDATE(),c.validdt)>0 then CONVERT(varchar(100),DATEDIFF(day,GETDATE(),c.validdt))+'天'  else '已过期' end) 使用期限,
(case when a.park_stall is not null then a.park_stall  else '' end) 车位号,
'' 房号,
'' 层别,
(case when c.validdt is not null then  CONVERT(varchar(100),c.validdt,121)  else '' end) 有效期,
(case when b.cust_name is not null then b.cust_name  else '' end) 用户姓名,
(case when b.mobile is not null then b.mobile else (CASe when b.phone_no is not null then b.phone_no else '' end ) end) 联系电话
from park_card_make a left join customer b on a.cust_no=b.cust_no
left join card_make c on a.cust_no=c.cust_no 
) a
end

--select * from park_stall
--select * from park_card_make
--select * from card_make
--select * from customer