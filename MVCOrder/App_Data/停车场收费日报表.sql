--05ͣ�����շ��ձ���
--ʱ��	˽�ҳ�λ ����ͣ��	ʱ��ͣ�� ����ͣ�� �Ż�ͣ�������ͣ����	Ա��ͣ��	����ͣ��	
create procedure ͣ�����շ��ձ���
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
 С�ƽ��  
from
(
select a.* from (
select * from (
select CONVERT(varchar(100),a.out_time,103) ʱ��,
(case when a.money2 is not null then a.money2 else 0 end) ʵ�ս��,
(case when c.card_tname is not null then c.card_tname else '����' end) ����
from out_park a left join park_card_make b on a.card_no=b.card_no
left join card_type c on b.card_type=c.card_tid 
where DATEPART(YEAR,a.out_time)=DATEPART(YEAR,@time) and  DATEPART(MONTH,a.out_time)=DATEPART(MONTH,@time)--���շ�
 and DATEPART(DAY,a.out_time)=DATEPART(DAY,@time)--���շ�
) a
pivot
(
sum(a.ʵ�ս��) for a.���� in (�ڿ�,��Ȩ��,����Ա��,��ʱ��,ʱ�ο�,��ѿ�,���⿨,�����,��ֵ��,һ��ͨ,����)
) b
)a 
) a order by a.ʱ��
end

--select * from card_type
--declare @time datetime
--set @time=N'2017-08-21 07:36:48.000'
--select SUM(money2) ��� from out_park where DATEPART(YEAR,out_time)=DATEPART(YEAR,@time) and DATEPART(MONTH,out_time)=DATEPART(MONTH,@time) and DATEPART(DAY,out_time)=DATEPART(DAY,@time)