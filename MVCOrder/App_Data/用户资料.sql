create procedure 用户资料
as
begin
select ROW_NUMBER() over(order by c.有效期 asc) 序号,c.*
from(
select
(case when b.park_stall is not null then b.park_stall else '' end) 车位号,
'' 层别,
(case when d.card_tname is not null then d.card_tname else '' end) 停车类别,
'' 房间号,
(case when a.cust_name is not null then a.cust_name else '' end)  用户姓名, 
(case when a.sex =0 then '男' else '女' end) 性别,
(case when a.cust_nick is not null then a.cust_nick else '' end) 用户编号,
(case when c.validdt is not null then c.validdt else GETDATE() end) 有效期,
(case when b.carno is not null then b.carno else '' end) 车牌号,
(case when a.mobile is not null then a.mobile else (CASe when a.phone_no is not null then a.phone_no else '' end ) end) 联系电话,
'' 身份证号,
(case when a.remark is not null then a.remark else '' end) 备注
from customer a left join park_card_make b on a.cust_no=b.cust_no
left join card_make c on a.cust_no=c.cust_no
left join card_type d on d.card_tid=b.card_type) c

end
go
--select * from customer
--序号+A2:N2	车位号	层别	停车类别	房间号	用户姓名	性别	用户编号	有效期	车牌号	联系电话	联系地址	身份证号	备注
--select GETDATE()