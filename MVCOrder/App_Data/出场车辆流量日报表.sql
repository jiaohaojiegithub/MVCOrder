--ʱ��	˽�ҳ�	���⳵	ʱ�⳵	���⳵	�Żݳ�	Ա����	������	С��	
--09�������������ձ���									
create procedure �������������ձ���
@time datetime
as
begin
--declare @time datetime
--set @time=N'2017-08-30 07:36:48.000'
select 
a.ʱ�� ����,
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
select a.* from (
select * from (
select CONVERT(varchar(100),a.out_time,103) ʱ��,
(case when c.card_tname is not null then c.card_tname else '����' end) ����
from out_park a left join park_card_make b on a.card_no=b.card_no
left join card_type c on b.card_type=c.card_tid 
where DATEPART(YEAR,a.out_time)=DATEPART(YEAR,@time) and  DATEPART(MONTH,a.out_time)=DATEPART(MONTH,@time)
) a
pivot
(
count(a.����) for a.���� in (�ڿ�,��Ȩ��,����Ա��,��ʱ��,ʱ�ο�,��ѿ�,���⿨,�����,��ֵ��,һ��ͨ,����)
) b
)a 
) a order by a.ʱ��
end

--select * from out_park