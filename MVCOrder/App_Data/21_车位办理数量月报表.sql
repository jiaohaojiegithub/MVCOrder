--21.��λ���������±���							
							
--����	˽�ҳ�	���⳵	���⳵	�Żݳ�	Ա����	������	С��
--select 
--CONVERT(varchar(50),a.�·�)+'��' �·�,
--(case when a.�ڿ� is not null then a.�ڿ� else 0 end) ˽�ҳ�,
--(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end) ���⳵,
--(case when a.��ѿ� is not null then a.��ѿ� else 0 end) ���⳵,
--(case when a.����� is not null then a.����� else 0 end) �Żݳ�,
--(case when a.��Ȩ�� is not null then a.��Ȩ�� else 0 end) Ա����,
--(case when a.��ֵ�� is not null then a.��ֵ�� else 0 end)+(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end)+(case when a.���⿨ is not null then a.���⿨ else 0 end) ������,
--(case when a.��ֵ�� is not null then a.��ֵ�� else 0 end)+(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end)+(case when a.���⿨ is not null then a.���⿨ else 0 end)
--+(case when a.��Ȩ�� is not null then a.��Ȩ�� else 0 end)+ (case when a.����� is not null then a.����� else 0 end)+(case when a.��ѿ� is not null then a.��ѿ� else 0 end)
--+(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end)+(case when a.�ڿ� is not null then a.�ڿ� else 0 end) С��
-- from
--(
--select * from
--(
--select DATEPART(MONTH,b.createdt) �·�,c.card_tname ����,COUNT(c.card_tname) ����
----(case when b.createdt is not null then CONVERT(varchar(100),b.createdt,121) else '' end) ����,
--from park_card_make a 
--left join card_make b on a.cust_no=b.cust_no
--left join card_type c on c.card_tid=a.card_type
----where DATEPART(YEAR,b.createdt)=2017--����
--group by c.card_tname,DATEPART(MONTH,b.createdt)
--) a
--pivot(
--sum(a.����) for a.���� in (�ڿ�,��Ȩ��,����Ա��,��ʱ��,ʱ�ο�,��ѿ�,���⿨,�����,��ֵ��,һ��ͨ)
--) b
--) a
--===================����һ=============================================
create procedure ��λ���������±���
@���� datetime
as
begin
select 
CONVERT(varchar(50),a.�·�)+'��' �·�,
(case when a.�ڿ� is not null then a.�ڿ� else 0 end) ˽�ҳ�,
(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end) ���⳵,
(case when a.���⿨ is not null then a.���⿨ else 0 end) ���⳵,
(case when a.����� is not null then a.����� else 0 end) �Żݳ�,
(case when a.��ѿ� is not null then a.��ѿ� else 0 end) Ա����,
(case when a.��ֵ�� is not null then a.��ֵ�� else 0 end)+(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end)+(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end) ������,

(case when a.��ֵ�� is not null then a.��ֵ�� else 0 end)+(case when a.��ʱ�� is not null then a.��ʱ�� else 0 end)+(case when a.���⿨ is not null then a.���⿨ else 0 end)
+ (case when a.����� is not null then a.����� else 0 end)+(case when a.��ѿ� is not null then a.��ѿ� else 0 end)
+(case when a.ʱ�ο� is not null then a.ʱ�ο� else 0 end)+(case when a.�ڿ� is not null then a.�ڿ� else 0 end) С��
 from
(
select * from
(
select DATEPART(MONTH,b.createdt) �·�,c.card_tname ����,COUNT(c.card_tname) ����
--(case when b.createdt is not null then CONVERT(varchar(100),b.createdt,121) else '' end) ����,
from park_card_make a 
left join card_make b on a.cust_no=b.cust_no
left join card_type c on c.card_tid=a.card_type
where DATEPART(YEAR,b.createdt)=DATEPART(YEAR,@����)--����
group by c.card_tname,DATEPART(MONTH,b.createdt)
) a
pivot(
sum(a.����) for a.���� in (�ڿ�,��Ȩ��,����Ա��,��ʱ��,ʱ�ο�,��ѿ�,���⿨,�����,��ֵ��,һ��ͨ)
) b
) a
--=====================������====================================================
--select * from
--(
--select CONVERT(varchar(100),DATEPART(MONTH,b.createdt))+'��' �·�,c.card_tname ����,COUNT(c.card_tname) ����
----(case when b.createdt is not null then CONVERT(varchar(100),b.createdt,121) else '' end) ����,
--from park_card_make a 
--left join card_make b on a.cust_no=b.cust_no
--left join card_type c on c.card_tid=a.card_type
----where DATEPART(YEAR,b.createdt)=2017--����
--group by c.card_tname,DATEPART(MONTH,b.createdt)
--) a
--pivot(
--sum(a.����) for a.���� in (�ڿ�,��Ȩ��,����Ա��,��ʱ��,ʱ�ο�,��ѿ�,���⿨,�����,��ֵ��,һ��ͨ)
--) b
--=======================������===========================
--
--select CONVERT(varchar(100),DATEPART(MONTH,b.createdt))+'��' �·�,c.card_tname ����,COUNT(c.card_tname) ����
----(case when b.createdt is not null then CONVERT(varchar(100),b.createdt,121) else '' end) ����,
--from park_card_make a 
--left join card_make b on a.cust_no=b.cust_no
--left join card_type c on c.card_tid=a.card_type
----where DATEPART(YEAR,b.createdt)=2017--����
--group by c.card_tname,DATEPART(MONTH,b.createdt)
end


--select * from card_type

