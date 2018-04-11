USE [hzcy2017]
GO

/****** Object:  StoredProcedure [dbo].[ParkingCard]    Script Date: 2018-03-26 17:29:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[ParkingCard]
as
select ROW_NUMBER() over(PARTITION  by a.�û��� ORDER BY a.�û���) as �������,a.*
from (
select a.cust_name as �û���, c.park_stall as ��λ��,
		'' as ���,
		a.cust_no �û����,
		'' as �����,
		b.validdt as ��Ч����,
		(case when b.status= 0 then '����' else 'ʧЧ' end) as ״̬,
		c.carno as ����,
		d.car_tname as ����,
		e.color_tname as ��ɫ,
		f.card_tname as �����,
		b.operator as ����Ա,
		b.createdt as ����ʱ��,
		g.deptName as ����
from dbo.customer a inner join dbo.card_make b on a.cust_no=b.cust_no
	 inner join dbo.park_card_make c on b.cust_no=c.cust_no 
	 left join dbo.car_type d on d.car_tid=c.car_type
	 left join dbo.color_type e on e.color_tid=c.car_color
	 left join dbo.card_type f on f.card_tid=c.card_type
	 left join dbo.kq_dept g on g.deptNo=a.deptNo
	 
) a  order by a.�û��� desc
GO


--01ͣ�����б���