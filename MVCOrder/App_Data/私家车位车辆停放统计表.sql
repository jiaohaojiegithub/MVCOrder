--14.私家车位车辆停放统计表
--序号	车位号	停车类别	用户姓名	用户编号	车牌号	是否缴费	缴费日期	停车有效期		
create procedure 私家车位车辆停放统计表
as
begin
select ROW_NUMBER() over(order by a.用户编号) 序号,a.*
from(
select 
(case when a.park_stall is not null then a.park_stall  else '' end) 车位号,
(case when b.cust_name is not null then b.cust_name  else '' end) 用户姓名,
(case when c.card_tname is not null then c.card_tname  else '' end) 停车类别,
(case when b.cust_nick is not null then b.cust_nick  else '' end) 用户编号,
(case when a.card_no is not null then a.carno  else '' end) 车牌号,
(case when d.balance >0 then '已缴费'  else '未缴费' end) 是否缴费,
(case when d.createdt is not null then CONVERT(varchar(100),d.createdt,121)  else '' end) 缴费日期,
(case when d.validdt is not null then CONVERT(varchar(100),d.validdt,121)  else '' end) 停车有效期
from park_card_make a left join customer b on a.cust_no=b.cust_no
left join card_type c on a.card_type=c.card_tid 
left join card_make d on d.cust_no=a.cust_no
) a --where a.停车类别='期卡' --私家车
end

--select * from card_type
--select * from park_card_make
--select * from customer
