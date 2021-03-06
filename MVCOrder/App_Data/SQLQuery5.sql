USE [hzcy2017]
GO
/****** Object:  StoredProcedure [dbo].[停车注销记录报表]    Script Date: 2018-03-27 16:22:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[停车注销记录报表]
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
