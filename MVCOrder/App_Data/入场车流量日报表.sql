create procedure �볡�������ձ���
@time datetime 
as
begin
--declare @time datetime
--set @time=N'2017-08-30 07:36:48.000'
select 
a.ʱ��,
(case when a.�ڿ� is not null then a.�ڿ� else 0 end) ˽�ҳ�,
(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end) ���⳵,
(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end) ʱ�⳵,
(case when a.���⿨ is not null then a.���⿨ else 0 end) ���⳵,
(case when a.����� is not null then a.����� else 0 end) �Żݳ�,
(case when a.��ѿ� is not null then a.��ѿ� else 0 end) Ա����,
 (case when a.���� is not null then a.���� else 0 end) ������,
(case when a.��ѿ� is not null then a.��ѿ� else 0 end)+(case when a.����� is not null then a.����� else 0 end)+
(case when a.�ڿ� is not null then a.�ڿ� else 0 end)+
(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end)+
(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end)+
(case when a.���⿨ is not null then a.���⿨ else 0 end)+
(case when a.���� is not null then a.���� else 0 end)
 С��  
from
(
select a.* from(
select * from
(
select CONVERT(varchar(100),a.in_time,103) ʱ��,
(case when d.card_tname is not null then d.card_tname else '����' end) ����
from in_park a 
left join park_card_make c on a.card_no=c.card_no
left join card_type d on c.card_type=d.card_tid
where DATEPART(YEAR,a.in_time)=DATEPART(YEAR,@time) and  DATEPART(MONTH,a.in_time)=DATEPART(MONTH,@time) --and  DATEPART(DAY,a.in_time)=DATEPART(DAY,@time)
--order by a.in_time
) a
pivot
(
count(a.����) for a.���� in (�ڿ�,��Ȩ��,����Ա��,��ʱ��,ʱ�ο�,��ѿ�,���⿨,�����,��ֵ��,һ��ͨ,����)
) b)a
) a
end


--select DATEDIFF(HOUR,getdate(),'2017-08-30 07:36:48.000')

--ʱ��	˽�ҳ�	���⳵	ʱ�⳵	���⳵�����⳵��	�Żݳ����������	Ա����	С��	
-- declare @time datetime
--set @time=N'2017-08-30 07:36:48.000'
--select a.* from(
--select * from
--(
--select CONVERT(varchar(100),a.in_time,103) ʱ��,
--(case when d.card_tname is not null then d.card_tname else '����' end) ����
--from in_park a 
--left join park_card_make c on a.card_no=c.card_no
--left join card_type d on c.card_type=d.card_tid
--where DATEPART(YEAR,a.in_time)=DATEPART(YEAR,@time) and  DATEPART(MONTH,a.in_time)=DATEPART(MONTH,@time) --and  DATEPART(DAY,a.in_time)=DATEPART(DAY,@time)
----order by a.in_time
--) a
--pivot
--(
--count(a.����) for a.���� in (�ڿ�,��Ȩ��,����Ա��,��ʱ��,ʱ�ο�,��ѿ�,���⿨,�����,��ֵ��,һ��ͨ,����)
--) b)a
--select CONVERT(varchar(100),a.in_time,103) ʱ��,
--(case when d.card_tname is not null then d.card_tname else '����' end) ����
--from in_park a 
--left join park_card_make c on a.card_no=c.card_no
--left join card_type d on c.card_type=d.card_tid
--where DATEPART(YEAR,a.in_time)=DATEPART(YEAR,@time) and  DATEPART(MONTH,a.in_time)=DATEPART(MONTH,@time) --and  DATEPART(DAY,a.in_time)=DATEPART(DAY,@time)
--order by a.in_time