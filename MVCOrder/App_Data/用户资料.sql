create procedure �û�����
as
begin
select ROW_NUMBER() over(order by c.��Ч�� asc) ���,c.*
from(
select
(case when b.park_stall is not null then b.park_stall else '' end) ��λ��,
'' ���,
(case when d.card_tname is not null then d.card_tname else '' end) ͣ�����,
'' �����,
(case when a.cust_name is not null then a.cust_name else '' end)  �û�����, 
(case when a.sex =0 then '��' else 'Ů' end) �Ա�,
(case when a.cust_nick is not null then a.cust_nick else '' end) �û����,
(case when c.validdt is not null then c.validdt else GETDATE() end) ��Ч��,
(case when b.carno is not null then b.carno else '' end) ���ƺ�,
(case when a.mobile is not null then a.mobile else (CASe when a.phone_no is not null then a.phone_no else '' end ) end) ��ϵ�绰,
'' ���֤��,
(case when a.remark is not null then a.remark else '' end) ��ע
from customer a left join park_card_make b on a.cust_no=b.cust_no
left join card_make c on a.cust_no=c.cust_no
left join card_type d on d.card_tid=b.card_type) c

end
go
--select * from customer
--���+A2:N2	��λ��	���	ͣ�����	�����	�û�����	�Ա�	�û����	��Ч��	���ƺ�	��ϵ�绰	��ϵ��ַ	���֤��	��ע
--select GETDATE()