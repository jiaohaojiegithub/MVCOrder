--14.˽�ҳ�λ����ͣ��ͳ�Ʊ�
--���	��λ��	ͣ�����	�û�����	�û����	���ƺ�	�Ƿ�ɷ�	�ɷ�����	ͣ����Ч��		
create procedure ˽�ҳ�λ����ͣ��ͳ�Ʊ�
as
begin
select ROW_NUMBER() over(order by a.�û����) ���,a.*
from(
select 
(case when a.park_stall is not null then a.park_stall  else '' end) ��λ��,
(case when b.cust_name is not null then b.cust_name  else '' end) �û�����,
(case when c.card_tname is not null then c.card_tname  else '' end) ͣ�����,
(case when b.cust_nick is not null then b.cust_nick  else '' end) �û����,
(case when a.card_no is not null then a.carno  else '' end) ���ƺ�,
(case when d.balance >0 then '�ѽɷ�'  else 'δ�ɷ�' end) �Ƿ�ɷ�,
(case when d.createdt is not null then CONVERT(varchar(100),d.createdt,121)  else '' end) �ɷ�����,
(case when d.validdt is not null then CONVERT(varchar(100),d.validdt,121)  else '' end) ͣ����Ч��
from park_card_make a left join customer b on a.cust_no=b.cust_no
left join card_type c on a.card_type=c.card_tid 
left join card_make d on d.cust_no=a.cust_no
) a --where a.ͣ�����='�ڿ�' --˽�ҳ�
end

--select * from card_type
--select * from park_card_make
--select * from customer
