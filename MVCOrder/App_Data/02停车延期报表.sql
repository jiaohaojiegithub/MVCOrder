create procedure ͣ�����ڱ���
as
begin
 select ROW_NUMBER() over(order by a.���� asc) ���, a.* from (
 select
 a.cust_name �û�����,
e.cust_no �û����,
'' �����,
e.prevdate ԭ��Ч����,
e.currdate ����Ч����,
e.money ������,
e.operator ����Ա,
b.deptName ����,
c.carno ����
from card_delay e left join customer a on e.card_no=a.idcard
 left join kq_dept b on a.deptNo=b.deptNo
 left join park_card_make c on c.card_no=e.card_no 
 ) a 
 end
 go
--ͣ�����ڱ���
--select * from customer
--���	�û�����	�û����	�����	ԭ��Ч����	����Ч����	������	����Ա	����ʱ��	����	����
--��ע���û����ָͬһҵ��ͬһ��λ�Ǽǵĳ�����ţ�001�����һ������002����ڶ�����										
--select * from park_card_make
select * from card_delay