create procedure ͣ��ע����¼����
as
begin
select ROW_NUMBER() over(order by a.����ʱ�� asc) ���, a.* from (
select (case when b.cust_name is not null then b.cust_name else '' end) �û�����,
(case when c.carno is not null then c.carno else '' end) ����,
a.cust_no �û����,
(case when c.park_stall is not null then c.park_stall else '' end) ��λ��,
'' �����,
e.card_tname �˿���ʽ,
a.foregift Ѻ��,
a.balance ���,
a.retmoney �˻����,
a.operator ����Ա,
a.createdt ����ʱ��,
(case when d.deptName is not null then d.deptName else '' end)  ����
from card_quit a left join customer b on a.card_no=b.idcard
left join kq_dept d on d.deptNo=b.deptNo
left join park_card_make c on a.card_no=c.card_no 
left join card_type e on e.card_tid=a.retmode
) a
end
go
--���	�û�����	����	�û����	��λ��	�����	�˿���ʽ	Ѻ��	���	�˻����	����Ա	����ʱ��	����
--select top 1 * from customer
--select * from card_quit
----select top 1 * from park_card_make
--select * from park_stall
