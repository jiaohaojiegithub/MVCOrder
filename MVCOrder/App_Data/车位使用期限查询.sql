--18.��λʹ�����޲�ѯ��								
--���	ʹ������	ͣ�����	��λ��	����	���	��Ч��	�û�����	��ϵ�绰
create procedure ��λʹ�����޲�ѯ
as
begin
select ROW_NUMBER() over(order by a.��Ч��) ���,a.*
from (
select 
(case when c.validdt is not null and DATEDIFF(day,GETDATE(),c.validdt)>0 then CONVERT(varchar(100),DATEDIFF(day,GETDATE(),c.validdt))+'��'  else '�ѹ���' end) ʹ������,
(case when a.park_stall is not null then a.park_stall  else '' end) ��λ��,
'' ����,
'' ���,
(case when c.validdt is not null then  CONVERT(varchar(100),c.validdt,121)  else '' end) ��Ч��,
(case when b.cust_name is not null then b.cust_name  else '' end) �û�����,
(case when b.mobile is not null then b.mobile else (CASe when b.phone_no is not null then b.phone_no else '' end ) end) ��ϵ�绰
from park_card_make a left join customer b on a.cust_no=b.cust_no
left join card_make c on a.cust_no=c.cust_no 
) a
end

--select * from park_stall
--select * from park_card_make
--select * from card_make
--select * from customer