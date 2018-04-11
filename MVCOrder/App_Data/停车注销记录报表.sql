create procedure 停车注销记录报表
as
begin
select ROW_NUMBER() over(order by a.操作时间 asc) 序号, a.* from (
select (case when b.cust_name is not null then b.cust_name else '' end) 用户姓名,
(case when c.carno is not null then c.carno else '' end) 车牌,
a.cust_no 用户编号,
(case when c.park_stall is not null then c.park_stall else '' end) 车位号,
'' 房间号,
e.card_tname 退卡方式,
a.foregift 押金,
a.balance 余额,
a.retmoney 退还金额,
a.operator 操作员,
a.createdt 操作时间,
(case when d.deptName is not null then d.deptName else '' end)  部门
from card_quit a left join customer b on a.card_no=b.idcard
left join kq_dept d on d.deptNo=b.deptNo
left join park_card_make c on a.card_no=c.card_no 
left join card_type e on e.card_tid=a.retmode
) a
end
go
--序号	用户姓名	车牌	用户编号	车位号	房间号	退卡方式	押金	余额	退还金额	操作员	操作时间	部门
--select top 1 * from customer
--select * from card_quit
----select top 1 * from park_card_make
--select * from park_stall
