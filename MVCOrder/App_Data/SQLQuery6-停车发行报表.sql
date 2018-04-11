USE [hzcy2017]
GO

/****** Object:  StoredProcedure [dbo].[ParkingCard]    Script Date: 2018-03-26 17:29:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ParkingCard]
as
select ROW_NUMBER() over(PARTITION  by a.用户名 ORDER BY a.用户名) as 车辆编号,a.*
from (
select a.cust_name as 用户名, c.park_stall as 车位号,
		'' as 层别,
		a.cust_no 用户编号,
		'' as 房间号,
		b.validdt as 有效日期,
		(case when b.status= 0 then '正常' else '失效' end) as 状态,
		c.carno as 车牌,
		d.car_tname as 车型,
		e.color_tname as 颜色,
		f.card_tname as 卡类别,
		b.operator as 操作员,
		b.createdt as 操作时间,
		g.deptName as 部门
from dbo.customer a inner join dbo.card_make b on a.cust_no=b.cust_no
	 inner join dbo.park_card_make c on b.cust_no=c.cust_no 
	 left join dbo.car_type d on d.car_tid=c.car_type
	 left join dbo.color_type e on e.color_tid=c.car_color
	 left join dbo.card_type f on f.card_tid=c.card_type
	 left join dbo.kq_dept g on g.deptNo=a.deptNo
	 
) a  order by a.用户名 desc
GO


--01停车发行报表