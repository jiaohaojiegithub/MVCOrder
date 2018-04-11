create procedure 停车延期报表
as
begin
 select ROW_NUMBER() over(order by a.车牌 asc) 序号, a.* from (
 select
 a.cust_name 用户姓名,
e.cust_no 用户编号,
'' 房间号,
e.prevdate 原有效日期,
e.currdate 现有效日期,
e.money 付款金额,
e.operator 操作员,
b.deptName 部门,
c.carno 车牌
from card_delay e left join customer a on e.card_no=a.idcard
 left join kq_dept b on a.deptNo=b.deptNo
 left join park_card_make c on c.card_no=e.card_no 
 ) a 
 end
 go
--停车延期报表
--select * from customer
--序号	用户姓名	用户编号	房间号	原有效日期	现有效日期	付款金额	操作员	操作时间	部门	车牌
--备注：用户编号指同一业主同一车位登记的车辆编号，001代表第一部车，002代表第二部车										
--select * from park_card_make
select * from card_delay